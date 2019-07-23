using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoDatos;
using Negocio;
using Dominio;

namespace SistemaComercio
{
    public partial class frmagfactVenta : Form
    {
        public int numero { get; set; }
        public string numeroRemito { get; set; }
        private BindingList<Remito> listaRemitos = new BindingList<Remito>();
        public List<Detalle> listaDetallesLocal = new List<Detalle>();
        public List<int> lista { get; set; }
        private facturaVenta facturaLocal=null;
        public frmagfactVenta()
        {
            InitializeComponent();
        }

        private void frmagfactVenta_Load(object sender, EventArgs e)
        {
            dgvRemito.DataSource = listaRemitos;
            clienteNegocio clientenegocio = new clienteNegocio();
            cboCliente.DataSource = clientenegocio.listarClientes();
        }

        private void btnagregarRemito_Click(object sender, EventArgs e)
        {
            detalleNegocio negocio = new detalleNegocio();
            listarRemito ventana = new listarRemito((Cliente)cboCliente.SelectedItem);
            ventana.ShowDialog();
            if(ventana.remito!=null)
            {
                listaRemitos.Add(ventana.remito);
                listaDetallesLocal.AddRange(negocio.listarDetalles(ventana.remito.numeroRemito));
                actualizarPrecios(listaDetallesLocal);
                
                
            }
            refrescarGrilla();
        }
        private void refrescarGrilla()
        {
            dgvRemito.DataSource = null;
            dgvRemito.DataSource = listaRemitos;
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = listaDetallesLocal;
        }
        private void actualizarPrecios(List<Detalle> lista)
        {
            decimal importeGravado = 0;
            foreach (Detalle item in lista)
            {
                importeGravado += item.precioParcial;
            }
            txtimporteGravado.Text = importeGravado.ToString();
            txtIVA21.Text = (importeGravado * 0.21M).ToString("F");
            txttotalFactura.Text = (importeGravado * 1.21M).ToString("F");
        }

        private void txtimportenoGravado_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(listaRemitos.Count==0)
            {
                MessageBox.Show("Debes ingresar al menos un remito");
                return;
            }
            facturaventaNegocio negocio = new facturaventaNegocio();
            remitoNegocio negocio2 = new remitoNegocio();
            try
            {
                if (facturaLocal == null)
                {
                    facturaLocal = new facturaVenta();
                    facturaLocal.fechaFactura = dtpFactura.Value;
                    facturaLocal.numeroFactura = txtnumeroFactura.Text;
                    facturaLocal.cliente = (Cliente)cboCliente.SelectedItem;
                    facturaLocal.importeBruto = decimal.Parse(txtimporteGravado.Text);
                    facturaLocal.importeIVA = decimal.Parse(txtIVA21.Text);
                    facturaLocal.importenoGravado = decimal.Parse(txtimportenoGravado.Text);
                    facturaLocal.importeNeto = decimal.Parse(txttotalFactura.Text);
                    facturaLocal.tipoComprobante = "Factura A";
                    facturaLocal.estado = "Impago";
                    facturaLocal.activo = true;
                    facturaLocal.condicionPago = int.Parse(cboCondicion.Text);

                }

                negocio.agregarFactura(facturaLocal);
                //foreach(Remito item in listaRemitos)
                //{
                negocio2.modificarRemitos(listaRemitos[0], facturaLocal.numeroFactura,"Facturado");
                //}
                


                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtnumeroFactura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))

            {
                e.Handled = true;

                return;


            }
        }

        private void txtimportenoGravado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))

            {
                e.Handled = true;

                return;


            }
        }

        private void comboBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))

            {
                e.Handled = true;

                return;


            }
        }

        private void btneliminarRemito_Click(object sender, EventArgs e)
        {
            if (dgvRemito.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar al menos un remito");
                return;
            }
            foreach (DataGridViewRow item in this.dgvRemito.SelectedRows)
            {
                 numero = item.Index;
                numeroRemito = listaRemitos[numero].numeroRemito;
                listaRemitos.RemoveAt(numero);
               
                
            }
            lista = new List<int>();
            foreach (Detalle item in listaDetallesLocal)
            {
                
                if (Equals(item.numeroRemito,numeroRemito))
                {
                    int i=listaDetallesLocal.IndexOf(item);
                    
                    lista.Add(i);
                    
                }
                
            }

            listaDetallesLocal.RemoveRange(lista[0],lista.Count);
               
            
            refrescarGrilla();
        }
    }
}
