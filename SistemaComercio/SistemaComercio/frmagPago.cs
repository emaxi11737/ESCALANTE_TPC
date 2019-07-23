using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace SistemaComercio
{
    public partial class frmagPago : Form
    {
        private BindingList<Efectivo> listaEfectivo = new BindingList<Efectivo>();
        private BindingList<Cheque> listaCheques = new BindingList<Cheque>();
        private BindingList<Transferencia> listaTransferencias = new BindingList<Transferencia>();
        private BindingList<metodoPago> listametodoPago = new BindingList<metodoPago>();
        public int idPago { get; set; }
        public List<facturaVenta> listaFacturaslocal { get; set; }
        public decimal sumaTotal { get; set; }
        public decimal sumaFacturas { get; set; }

        public int id { get; set; }
        public frmagPago()
        {
            InitializeComponent();
            id = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listarFacturas ventana = new listarFacturas((Cliente)cboCliente.SelectedItem, 1);

            ventana.ShowDialog();
            if (ventana.factura != null)
            {
                listaFacturaslocal.Add(ventana.factura);
                refrescarGrilla();
                refrescarFacturas();

            }

        }

        private void refrescarGrilla()
        {
            dgvFacturas.DataSource = null;
            dgvFacturas.DataSource = listaFacturaslocal;
            dgvPagos.DataSource = null;
            dgvPagos.DataSource = listametodoPago;
            txtTotal.Text = sumaTotal.ToString();
            //dgvPagos.Columns[0].Visible = false;
            dgvPagos.Columns[3].Visible = false;
            refrescarCheques();

        }

        private void refrescarCheques()
        {
            sumaTotal = 0;
            foreach (metodoPago item in listametodoPago)
            {
                sumaTotal += item.importe;
            }
            txtTotal.Text = sumaTotal.ToString();

        }
        private void refrescarFacturas()
        {
            foreach (facturaVenta item in listaFacturaslocal)
            {
                sumaFacturas += item.importeNeto;
            }
            txtFactura.Text = sumaFacturas.ToString();
        }



        private void frmagPago_Load(object sender, EventArgs e)
        {

            clienteNegocio clientenegocio = new clienteNegocio();
            pagoNegocio pagonegocio = new pagoNegocio();
            listaFacturaslocal = new List<facturaVenta>();
            cboCliente.DataSource = clientenegocio.listarClientes();
            idPago = pagonegocio.idMax();
            sumaTotal = 0;


        }

        private void button10_Click(object sender, EventArgs e)
        {
            Efectivo efectivo = new Efectivo();
            agregarEfectivo ventana = new agregarEfectivo();
            ventana.ShowDialog();
            if (ventana.importe != 0)
            {
                efectivo.importe = ventana.importe;
                listaEfectivo.Add(efectivo);

                refrescarGrilla();

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Transferencia transferencia = new Transferencia();
            agregarTransferencias ventana = new agregarTransferencias();
            ventana.ShowDialog();
            if (ventana.transferencia.importe != 0)
            {
                transferencia.importe = ventana.transferencia.importe;
                transferencia.Banco = ventana.transferencia.Banco;
                transferencia.numeroTransferencia = ventana.transferencia.numeroTransferencia;
                listaTransferencias.Add(transferencia);

                refrescarGrilla();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            metodoPago pago = new metodoPago();
            agregarmPago ventana = new agregarmPago();
            ventana.ShowDialog();
            if (ventana.t != null)
            {
                ventana.t.id = id++;
                ventana.t.fechaPago = DateTime.Today;
                ventana.t.tipo = "Transferencia";
                listametodoPago.Add(ventana.t);
                listaTransferencias.Add(ventana.t);
            }
            if (ventana.ef != null)
            {
                ventana.ef.id = id++;
                ventana.ef.fechaPago = DateTime.Today;
                ventana.ef.tipo = "Efectivo";
                listametodoPago.Add(ventana.ef);
                listaEfectivo.Add(ventana.ef);
            }
            if (ventana.c != null)
            {
                ventana.c.id = id++;
                ventana.c.fechaPago = DateTime.Today;
                ventana.c.tipo = "Cheque";
                listametodoPago.Add(ventana.c);
                listaCheques.Add(ventana.c);
            }
            refrescarGrilla();
            refrescarCheques();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(listametodoPago.Count==0)
            {
                MessageBox.Show("Debe ingresar un pago");
                return;
            }
            if (listaFacturaslocal.Count == 0)
            {
                MessageBox.Show("Debe ingresar una factura");
                return;
            }
            if (cboCliente.Text.Trim() == "" )
            {
                MessageBox.Show("Debes completar todos los campos");
                return;
            }
            facturaventaNegocio facturanegocio = new facturaventaNegocio();
            pagoNegocio pagoNegocio = new pagoNegocio();
            if (sumaTotal == sumaFacturas & sumaTotal != 0)
            {

                pagoNegocio.agregarPago((Cliente)cboCliente.SelectedItem, dtpFecha.Value);
                foreach (facturaVenta item in listaFacturaslocal)
                {
                    facturanegocio.modificarFactura(item, "Pago");
                    pagoNegocio.agregarfacturaxpago(item, idPago);
                }

                if (listaEfectivo.Any())
                {
                    foreach (Efectivo item in listaEfectivo)
                    {
                        pagoNegocio.agregarEfectivo(item, (Cliente)cboCliente.SelectedItem, idPago);
                    }

                }
                if (listaCheques.Any())
                {
                    foreach (Cheque item in listaCheques)
                    {
                        pagoNegocio.agregarCheque(item, (Cliente)cboCliente.SelectedItem, idPago);
                    }

                }
                if (listaTransferencias.Any())
                {
                    foreach (Transferencia item in listaTransferencias)
                    {
                        pagoNegocio.agregarTransferencia(item, (Cliente)cboCliente.SelectedItem, idPago);
                    }

                }

                this.Close();
            }
            else
            {
                MessageBox.Show("No coinciden el monto del pago con el monto de las facturas", "ERROR");
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            metodoPago p = ((metodoPago)dgvPagos.CurrentRow.DataBoundItem);
            foreach (Transferencia item in listaTransferencias)
            {
                if (item.id == p.id)
                {
                    verTransferencia ventana = new verTransferencia(item);
                    ventana.ShowDialog();
                }
            }
            foreach (Cheque item in listaCheques)
            {
                if (item.id == p.id)
                {
                    verCheque ventana = new verCheque(item);
                    ventana.ShowDialog();
                }
            }
            foreach (Efectivo item in listaEfectivo)
            {
                if (item.id == p.id)
                {
                    verEfectivo ventana = new verEfectivo(item);
                    ventana.ShowDialog();
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgvFacturas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar al menos un certificado");
                return;
            }
            foreach (DataGridViewRow item in this.dgvFacturas.SelectedRows)
            {
                int numero = item.Index;
                sumaFacturas = sumaFacturas - listaFacturaslocal[numero].importeNeto;
                listaFacturaslocal.RemoveAt(numero);

                refrescarGrilla();
                refrescarFacturas();

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (dgvPagos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar al menos un pago");
                return;
            }
            foreach (DataGridViewRow item in this.dgvPagos.SelectedRows)
            {
                int numero = item.Index;
                long id = listametodoPago[numero].id;
                if(listametodoPago[numero].tipo=="Transferencia")
                {
                    eliminarlt(id);
                }
                if (listametodoPago[numero].tipo == "Efectivo")
                {
                    eliminarle(id);
                }
                if (listametodoPago[numero].tipo == "Cheque")
                {
                    eliminarlc(id);
                }
                listametodoPago.RemoveAt(numero);   

                refrescarGrilla();
                refrescarCheques();

            }
        }

        private void eliminarlc(long id)
        {
            foreach (Cheque item in listaCheques)
            {
                if (item.id == id)
                {
                    sumaTotal -= item.importe;
                    int i = listaCheques.IndexOf(item);
                    listaCheques.RemoveAt(i);
                    break;
                }
            }
        }

        private void eliminarle(long id)
        {
            foreach(Efectivo item in listaEfectivo)
            {
                if(item.id==id)
                {
                    sumaTotal -= item.importe;
                    int i = listaEfectivo.IndexOf(item);
                    listaEfectivo.RemoveAt(i);
                    break;
                }
            }
        }

        private void eliminarlt(long id)
        {
            foreach (Transferencia item in listaTransferencias)
            {
                if (item.id == id)
                {
                    sumaTotal -= item.importe;
                    int i = listaTransferencias.IndexOf(item);
                    listaTransferencias.RemoveAt(i);
                    break;
                }
            }
        }
    }
}
