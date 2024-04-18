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

//Programado por: Carol Chuy

namespace CapaVistaERP.Procesos
{
    public partial class OrdenesdeCompra : Form
    {
        private Controlador controller;
        public OrdenesdeCompra(string id, string nombre, string domicilio, string telefono)
        {
            InitializeComponent();
            controller = new Controlador();
            llenarprod();
            controller.CargarOpcionesOrden(cmb_orden);
            txt_idProv.Text = id;
            txt_nombreProv.Text = nombre;
            txt_domicilioProv.Text = domicilio;
            txt_telefonoProv.Text = telefono;
        }

        //Llena el combobox de productos
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

        //Condicionales para la selección del combo Orden
        private void cmb_orden_SelectedIndexChanged(object sender, EventArgs e)
        {
            string seleccion = cmb_orden.SelectedItem.ToString();

            // Si se selecciona "Directa", deshabilitar botones para buscar proveedor
            if (seleccion == "Directa")
            {
                btn_buscarProveedor.Enabled = false;
                txt_idProv.Enabled = true;
                btn_buscarProveedor.Enabled = false;
                txt_nombreProv.Enabled = true;
                txt_domicilioProv.Enabled = true;
                txt_telefonoProv.Enabled = true;
                txt_departamentos.Enabled = true;
                dateTimePickerEntrega.Enabled = true;
                dateTimePickerPedido.Enabled = true;
                txt_entregara.Enabled = true;
            }

            // Si se selecciona "Relacionada", deshabilitar TextBox para ingresar directamente
            if (seleccion == "Relacionada")
            {
                btn_buscarProveedor.Enabled = true;
                txt_idProv.Enabled = false;
                txt_nombreProv.Enabled = false;
                txt_telefonoProv.Enabled = false;
                txt_domicilioProv.Enabled = false;
                txt_departamentos.Enabled = true;
                dateTimePickerEntrega.Enabled = true;
                dateTimePickerPedido.Enabled = true;
                txt_entregara.Enabled = true;
            }
        }
        private void OrdenesdeCompra_Load(object sender, EventArgs e)
        {
            string tabla = "tbl_ordenescompra";
            string campoid = "id_OrdComp";
            txt_numeroorden.Enabled = false;
            txt_idProv.Enabled = false;
            btn_buscarProveedor.Enabled = false;
            txt_nombreProv.Enabled = false;
            txt_domicilioProv.Enabled = false;
            txt_telefonoProv.Enabled = false;
            txt_departamentos.Enabled = false;
            dateTimePickerEntrega.Enabled = false;
            dateTimePickerPedido.Enabled = false;
            txt_entregara.Enabled = false;
            int ultimoNumeroOrden = controller.ObtenerUltimoNumeroOrden(campoid, tabla);
            txt_numeroorden.Text = ultimoNumeroOrden.ToString();
        }

        private void btn_buscarProveedor_Click(object sender, EventArgs e)
        {
            //instrucciones para mostrar un formulario que esta dentro de la misma carpeta que este form
            BuscarProveedor BuscarProveedor = new BuscarProveedor(this);
            BuscarProveedor.Show();
        }

        public void RecibirDatosDesdeBuscarProveedor(string id, string nombre, string domicilio, string telefono)
        {
            // Actualiza los textbox en del formulario con los datos recibidos
            txt_idProv.Text = id;
            txt_nombreProv.Text = nombre;
            txt_domicilioProv.Text = domicilio;
            txt_telefonoProv.Text = telefono;
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
                    // Sirve para asegurarse de que la fila no sea la fila de encabezado.
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


    }
}
