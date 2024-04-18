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
    public partial class Compras : Form
    {
        private Controlador controller;
        public Compras(string idord, string fechaS, string fechaE, string solicitante, string proveedor)
        {
            InitializeComponent();
            controller = new Controlador();
            llenarprod();
            controller.CargarOpcionesOrden(cmb_orden);
            txt_numorden.Text = idord;
            dateTimePickerEntrega.Text = fechaE;
            dateTimePickerPedido.Text = fechaS;
            txt_departamentos.Text = solicitante;
            txt_Idprov.Text = proveedor;
        }

        public void llenarprod()
        {
            cmb_productos.ValueMember = "numero";
            cmb_productos.DisplayMember = "nombre";

            string[] items = controller.itemsprod();

            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] != null)
                {
                    if (items[i] != "")
                    {
                        cmb_productos.Items.Add(items[i]);
                    }
                }

            }
            //Funciona para buscar en el combobox
            var dt2 = controller.enviarprod();
            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            foreach (DataRow row in dt2.Rows)
            {

                coleccion.Add(Convert.ToString(row["cod_producto"]) + "-" + Convert.ToString(row["nombre_prod"]));
                coleccion.Add(Convert.ToString(row["nombre_prod"]) + "-" + Convert.ToString(row["cod_producto"]));
            }
            cmb_productos.AutoCompleteCustomSource = coleccion;
            cmb_productos.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmb_productos.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void Compras_Load(object sender, EventArgs e)
        {
            string tabla = "tbl_compras";
            string campoid = "id_EncComp";
            txt_numcompra.Enabled = false;
            txt_numorden.Enabled = false;
            txt_Idprov.Enabled = false;
            btn_numorden.Enabled = false;
            txt_nombreprov.Enabled = false;
            txt_domicilio.Enabled = false;
            txt_telefonoprov.Enabled = false;
            txt_departamentos.Enabled = false;
            dateTimePickerEntrega.Enabled = false;
            dateTimePickerPedido.Enabled = false;
            dateTimePickerVencimiento.Enabled = false;
            txt_recibidopor.Enabled = false;
            int ultimoNumeroOrden = controller.ObtenerUltimoNumeroOrden(campoid, tabla);
            txt_numcompra.Text = ultimoNumeroOrden.ToString();
        }
        public void RecibirDatosDesdeBuscarOrdenes(string idord, string fechaS, string fechaE, string solicitante, string proveedor)
        {
            // Actualiza los textbox en del formulario con los datos recibidos
            txt_numorden.Text = idord;
            dateTimePickerEntrega.Text = fechaE;
            dateTimePickerPedido.Text = fechaS;
            txt_departamentos.Text = solicitante;
            txt_Idprov.Text = proveedor;
            ObtenerDatosProveedor(proveedor);
        }
        private void ObtenerDatosProveedor(string proveedorId)
        {
            string nombreProveedor = controller.ObtenerNombreProveedor(proveedorId);
            string domicilioProveedor = controller.ObtenerDomicilioProveedor(proveedorId);
            string telefonoProveedor = controller.ObtenerTelefonoProveedor(proveedorId);

            txt_Idprov.Text = proveedorId;
            txt_nombreprov.Text = nombreProveedor;
            txt_domicilio.Text = domicilioProveedor;
            txt_telefonoprov.Text = telefonoProveedor;
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            double precioU = 0;
            double cantidad = 0;
            double totalprod = 0;

            // Obtener el precio unitario desde el textbox
            if (double.TryParse(txt_preciou.Text, out precioU))
            {
                // Obtener la cantidad desde el textbox
                if (double.TryParse(txt_cantidad.Text, out cantidad))
                {
                    // Calcular el total del producto
                    totalprod = precioU * cantidad;

                    // Obtener el ID del producto seleccionado en el ComboBox
                    string productoSeleccionado = cmb_productos.SelectedItem.ToString();
                    string[] parts = productoSeleccionado.Split('-');
                    string idProducto = parts[0].Trim();
                    //Obtener el nombre del producto
                    string nomProducto = parts[1].Trim();
                    //Obtener la descripcion del producto
                    string descripcion = txt_descripcion.Text;
                    // Agregar una fila al DataGridView con los detalles
                    dgv_detalle.Rows.Add(cantidad, idProducto, nomProducto, descripcion, precioU, totalprod);
                    //Limpiar los textbox para poder ingresar uno nuevo
                    txt_cantidad.Text = "";
                    cmb_productos.Text = "";
                    txt_descripcion.Text = "";
                    txt_preciou.Text = "";
                    txt_totalfila.Text = "";
                }
                else
                {
                    MessageBox.Show("Ingrese una cantidad válida.");
                }
            }
            else
            {
                MessageBox.Show("Ingrese un precio unitario válido.");
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (dgv_detalle.SelectedRows.Count > 0)
            {
                // Mostrar un cuadro de diálogo de confirmación
                DialogResult result = MessageBox.Show("¿Está seguro que desea eliminar la fila seleccionada?", "Confirmación de eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // Obtiene la fila seleccionada del dgv_detalle (datagrid)
                    DataGridViewRow filaSeleccionada = dgv_detalle.SelectedRows[0];

                    // Elimina la fila seleccionada por el usuario
                    dgv_detalle.Rows.Remove(filaSeleccionada);
                }
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ninguna fila para eliminar.");
            }
        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            // Mostrar un cuadro de diálogo de confirmación
            DialogResult result = MessageBox.Show("¿Está seguro que desea confirmar la orden?", "Confirmación de orden", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                dgv_detalle.Enabled = false;
                txt_cantidad.Enabled = false;
                txt_descripcion.Enabled = false;
                cmb_productos.Enabled = false;
                txt_totalfila.Enabled = false;
                txt_preciou.Enabled = false;

                double subtotal = 0;
                double ivaPorcentaje = 0.12;

                foreach (DataGridViewRow fila in dgv_detalle.Rows)
                {
                    // Se asegura de que la fila no sea la fila de encabezado.
                    if (!fila.IsNewRow)
                    {
                        // Obtiene el valor de la última celda de la fila.
                        double valorCelda;
                        if (double.TryParse(fila.Cells[dgv_detalle.ColumnCount - 1].Value.ToString(), out valorCelda))
                        {
                            // Suma el valor al subtotal.
                            subtotal += valorCelda;
                        }
                    }
                }
                // Calcula el total con IVA.
                double totalIva = (subtotal * (1 + ivaPorcentaje)) - subtotal;
                double total = totalIva + subtotal;

                //Muestra los resultados en los textbox
                txt_subtotal.Text = subtotal.ToString();
                txt_iva.Text = totalIva.ToString();
                txt_total.Text = total.ToString();
            }
        }

        private void cmb_orden_SelectedIndexChanged(object sender, EventArgs e)
        {
            string seleccion = cmb_orden.SelectedItem.ToString();

            // Si se selecciona "Directa", deshabilitar botones para buscar proveedor
            if (seleccion == "Directa")
            {
                btn_numorden.Enabled = false;
                txt_numorden.Enabled = true;
                txt_Idprov.Enabled = true;
                txt_nombreprov.Enabled = true;
                txt_domicilio.Enabled = true;
                txt_telefonoprov.Enabled = true;
                txt_departamentos.Enabled = true;
                dateTimePickerEntrega.Enabled = true;
                dateTimePickerPedido.Enabled = true;
                dateTimePickerVencimiento.Enabled = true;
                txt_recibidopor.Enabled = true;
            }

            // Si se selecciona "Relacionada", deshabilitar TextBox para ingresar directamente
            if (seleccion == "Relacionada")
            {
                btn_numorden.Enabled = true;
                txt_numorden.Enabled = false;
                txt_Idprov.Enabled = false;
                txt_nombreprov.Enabled = false;
                txt_domicilio.Enabled = false;
                txt_telefonoprov.Enabled = false;
                txt_departamentos.Enabled = false;
                dateTimePickerEntrega.Enabled = false;
                dateTimePickerPedido.Enabled = false;
                dateTimePickerVencimiento.Enabled = true;
                txt_recibidopor.Enabled = true;
            }
        }

        private void cmb_productos_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtener el ID del producto que seleccionó el usuario
            string selectedValue = cmb_productos.SelectedItem.ToString();

            // Divide la cadena para tener ambos campos
            string[] parts = selectedValue.Split('-');
            string selectedProductId = parts[0].Trim();

            // Llamar a la capa controlador a su método ObtenerDescripción y ObtenerPrecioUnitario
            string descripcion = controller.ObtenerDescripcion(selectedProductId);
            decimal precioUnitario = controller.ObtenerPrecioUnitario(selectedProductId);

            // Llena los TextBox con la descripción y el precio unitario
            txt_descripcion.Text = descripcion;
            txt_preciou.Text = precioUnitario.ToString();

            //Pasa lo que está dentro de los text box a double para poder sacar el total de la fila
            double precioU = double.TryParse(txt_preciou.Text, out double precio) ? precio : 0.0;
            int cantidad = int.TryParse(txt_cantidad.Text, out int cant) ? cant : 0;
            double totalprod = precioU * cantidad;
            txt_totalfila.Text = totalprod.ToString();
        }

        private void btn_numorden_Click(object sender, EventArgs e)
        {
            BuscarOrdenCompra BuscarOrdenCompra = new BuscarOrdenCompra(this);
            BuscarOrdenCompra.Show();
        }
    }
}
