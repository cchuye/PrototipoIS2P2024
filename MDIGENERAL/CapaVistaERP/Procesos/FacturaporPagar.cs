using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControladorERP;

namespace CapaVistaERP.Procesos
{ 
    //Programado por: Carol Chuy
    public partial class FacturaporPagar : Form
    {
        private Controlador controller;
        public FacturaporPagar(string idcompra, string fechaV, string proveedorfact)
        {
            InitializeComponent();
            controller = new Controlador();
            controller.CargarOpcionesOrden(cmb_orden);
            txt_numcompra.Text = idcompra;
            dateTimePickerVencimiento.Text = fechaV;
            txt_Idprov.Text = proveedorfact;
        }
        private void FacturaporPagar_Load(object sender, EventArgs e)
        {
            string tabla = "tbl_facturaxpagar";
            string campoid = "NoFactura";
            txt_numcompra.Enabled = false;
            txt_numfactura.Enabled = false;
            txt_Idprov.Enabled = false;
            btn_numorden.Enabled = false;
            txt_nombreprov.Enabled = false;
            txt_domicilio.Enabled = false;
            txt_telefonoprov.Enabled = false;
            dateTimePickerVencimiento.Enabled = false;
            dateTimePickerAbono.Enabled = false;
            int ultimoNumeroOrden = controller.ObtenerUltimoNumeroOrden(campoid, tabla);
            txt_numfactura.Text = ultimoNumeroOrden.ToString();
        }
        public void RecibirDatosDesdeBuscarOrdenes(string idcompra, string fechaV, string proveedorfact)
        {
            // Actualiza los textbox en del formulario con los datos recibidos
            txt_numcompra.Text = idcompra;
            dateTimePickerVencimiento.Text = fechaV;
            txt_Idprov.Text = proveedorfact;
            ObtenerDatosProveedor(proveedorfact);
        }
        private void ObtenerDatosProveedor(string proveedorId)
        {
            string nombreProveedor = controller.ObtenerNombreProveedor(proveedorId);
            string domicilioProveedor = controller.ObtenerDomicilioProveedor(proveedorId);
            string telefonoProveedor = controller.ObtenerTelefonoProveedor(proveedorId);
            string nitProveedor = controller.ObtenerNitProveedor(proveedorId);

            txt_Idprov.Text = proveedorId;
            txt_nombreprov.Text = nombreProveedor;
            txt_domicilio.Text = domicilioProveedor;
            txt_telefonoprov.Text = telefonoProveedor;
            txt_nitprov.Text = nitProveedor;
        }

        private void cmb_orden_SelectedIndexChanged(object sender, EventArgs e)
        {
            string seleccion = cmb_orden.SelectedItem.ToString();

            // Si se selecciona "Directa", deshabilitar botones para buscar proveedor
            if (seleccion == "Directa")
            {
                btn_numorden.Enabled = false;
                txt_numcompra.Enabled = true;
                txt_Idprov.Enabled = true;
                txt_nombreprov.Enabled = true;
                txt_domicilio.Enabled = true;
                txt_telefonoprov.Enabled = true;
                txt_nitprov.Enabled = true;
                dateTimePickerVencimiento.Enabled = true;
                dateTimePickerAbono.Enabled = true;
            }

            // Si se selecciona "Relacionada", deshabilitar TextBox para ingresar directamente
            if (seleccion == "Relacionada")
            {
                btn_numorden.Enabled = true;
                txt_numcompra.Enabled = false;
                txt_Idprov.Enabled = false;
                txt_nombreprov.Enabled = false;
                txt_domicilio.Enabled = false;
                txt_telefonoprov.Enabled = false;
                txt_nitprov.Enabled = false;
                dateTimePickerVencimiento.Enabled = false;
                dateTimePickerAbono.Enabled = true;
            }
        }

        private void btn_numorden_Click(object sender, EventArgs e)
        {
            BuscarCompras BuscarCompras = new BuscarCompras(this);
            BuscarCompras.Show();
        }
    }
}
