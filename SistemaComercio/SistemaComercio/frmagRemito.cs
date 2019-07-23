using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Dominio;

namespace SistemaComercio
{
    
    public partial class frmagRemito : Form
    {

        public Detalle detalle { get; set; }
        private BindingList<Detalle> listaDetalles = new BindingList<Detalle>();

        
        private Remito remitoLocal = null;

        public frmagRemito()
        {
            
            InitializeComponent();
        }
        public frmagRemito(Remito remito)
        {
            InitializeComponent();

           
        }

        private void frmagRemito_Load(object sender, EventArgs e)
        {
            
            dgvDetalle.DataSource = listaDetalles;
            clienteNegocio clientenegocio = new clienteNegocio();
            cboCliente.DataSource = clientenegocio.listarClientes();
            
            if (remitoLocal != null)
            {
                txtnumeroRemito.Text = remitoLocal.numeroRemito;
                cboCliente.Text = remitoLocal.cliente.nombre;
                dtpRemito.Value = remitoLocal.fecha.Date;
            }
           cboCliente.DisplayMember = "Nombre";
           cboCliente.ValueMember = "Id";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(listaDetalles.Count==0)
            {
                MessageBox.Show("Debes ingresar al menos un producto");
                return;
            }
            if (txtnumeroRemito.Text.Trim() == "" || cboCliente.Text.Trim() == "")
            {
                MessageBox.Show("Debes completar todos los campos");
                return;
            }
            remitoNegocio negocio = new remitoNegocio();
            detalleNegocio negociodetalle = new detalleNegocio();
            tratamientoNegocio negociotratamiento = new tratamientoNegocio();
            try
            {
                if (remitoLocal == null)
                {
                    remitoLocal = new Remito();
                    remitoLocal.fecha = dtpRemito.Value;
                    remitoLocal.numeroRemito = txtnumeroRemito.Text;
                    remitoLocal.cliente = (Cliente)cboCliente.SelectedItem;
                    remitoLocal.estado = "No facturado";
                    remitoLocal.activo = true;
                  
                    
                }
                negocio.agregarRemito(remitoLocal);
                foreach (Detalle item in listaDetalles)
                {
                    if (item.numeroCertificado == null)
                    {
                        negociodetalle.agregarDetalles(item, txtnumeroRemito.Text);
                    }
                    
                    if(item.numeroCertificado!=null)
                    {
                        negociodetalle.agregarDetalles(item, txtnumeroRemito.Text,item.numeroCertificado);
                        negociotratamiento.modificarCertificado(item.numeroCertificado, item.cantidadVendida);
                    }
                    
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            listarProductos ventana = new listarProductos();
            ventana.ShowDialog();
            if(ventana.p!=null)
            {
                detalle = new Detalle();
                detalle.producto = new Producto();
                detalle.id = ventana.p.id;
                detalle.producto = ventana.p;
                detalle.precioUnitario = (decimal)detalle.producto.precioVenta;
                detalle.cantidadVendida = 1;
                detalle.precioParcial = detalle.cantidadVendida * detalle.precioUnitario;
                detalle.numeroCertificado = null;
                listaDetalles.Add(detalle);
            }
            
            
        }
        private void cargarGrilla(int id)
        {
            detalleNegocio negocio = new detalleNegocio();
            try
            {
             
  



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvDetalle.SelectedCells.Count == 0)
            {
                MessageBox.Show("Debe seleccionar al menos uno");
                return;
            }
            ingresarCantidad ventana = new ingresarCantidad(listaDetalles.ElementAt(dgvDetalle.CurrentCell.RowIndex).cantidadVendida);
            ventana.ShowDialog();
            listaDetalles.ElementAt(dgvDetalle.CurrentCell.RowIndex).cantidadVendida = ventana.cantidad;
            listaDetalles.ElementAt(dgvDetalle.CurrentCell.RowIndex).precioParcial = listaDetalles.ElementAt(dgvDetalle.CurrentCell.RowIndex).cantidadVendida * listaDetalles.ElementAt(dgvDetalle.CurrentCell.RowIndex).precioUnitario;
            refrescarGrilla();
            
        }
        private void refrescarGrilla()
        {
            dgvDetalle.DataSource = null;
            dgvDetalle.DataSource = listaDetalles;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgvDetalle.SelectedCells.Count == 0)
            {
                MessageBox.Show("Debe seleccionar al menos uno");
                return;
            }
            ingresarPrecio ventana = new ingresarPrecio(listaDetalles.ElementAt(dgvDetalle.CurrentCell.RowIndex).precioUnitario);
            ventana.ShowDialog();
            listaDetalles.ElementAt(dgvDetalle.CurrentCell.RowIndex).precioUnitario = ventana.precio;
            listaDetalles.ElementAt(dgvDetalle.CurrentCell.RowIndex).precioParcial = listaDetalles.ElementAt(dgvDetalle.CurrentCell.RowIndex).cantidadVendida * listaDetalles.ElementAt(dgvDetalle.CurrentCell.RowIndex).precioUnitario;
            refrescarGrilla();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dgvDetalle.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar al menos un producto");
                return;
            }

            foreach (DataGridViewRow item in this.dgvDetalle.SelectedRows)
            {
                dgvDetalle.Rows.RemoveAt(item.Index);

            }
        }

        private void dgvDetalle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (dgvDetalle.SelectedCells.Count == 0)
            {
                MessageBox.Show("Debe seleccionar al menos uno");
                return;
            }
            decimal cant = listaDetalles.ElementAt(dgvDetalle.CurrentCell.RowIndex).cantidadVendida;
            listarTratamientos ventana = new listarTratamientos(cant);
            ventana.ShowDialog();
            listaDetalles.ElementAt(dgvDetalle.CurrentCell.RowIndex).numeroCertificado = ventana.numeroCertificado;
            refrescarGrilla();
        }

        private void txtnumeroRemito_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))

            {
                e.Handled = true;

                return;


            }
        }
    }
}
