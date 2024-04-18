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
//Otto Adrian Lopez Ventura
namespace CapaVistaERP.Procesos
{
    public partial class frm_pedidos : Form

    {
        Controlador cn = new Controlador();
        public frm_pedidos()
        {
            InitializeComponent();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "dd/MM/yyyy";

            DateTime fechaSeleccionada = dateTimePicker1.Value;
            DateTime nuevaFecha = fechaSeleccionada.AddDays(15);
            dateTimePicker2.Value = nuevaFecha;
        }

        private void frm_pedidos_Load(object sender, EventArgs e)
        {

        }
        private void buscarVendedor(int idVendedor)
        {
            // Agrega un mensaje para verificar que se está llamando al método buscarVendedor
            MessageBox.Show("Buscando vendedor...");

            // Intenta obtener los datos del vendedor desde la base de datos
            DataTable dtVendedor = cn.BuscarVende("tbl_vendedor", "id_vendedor", idVendedor.ToString());

            // Verifica si se encontraron resultados
            if (dtVendedor.Rows.Count > 0)
            {
                // Muestra los datos del primer vendedor encontrado
                DataRow row = dtVendedor.Rows[0];
                MessageBox.Show($"Nombre del vendedor: {row["nombre_vend"]}, Apellido: {row["apellido_vend"]}, Teléfono: {row["telefono_vend"]}");

                // Asigna los datos a los cuadros de texto
                txt_nombre_vendedor.Text = row["nombre_vend"].ToString();
                txt_apellido_vendedor.Text = row["apellido_vend"].ToString();
                txt_telefono_vendedor.Text = row["telefono_vend"].ToString();
                txt_estado_vendedor.Text = row["estado_vend"].ToString();
            }
            else
            {
                // Muestra un mensaje si no se encontraron resultados
                MessageBox.Show("Vendedor no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btn_buscar_Click(object sender, EventArgs e)
        {
            int idVendedor;
            if (!int.TryParse(txt_id_vendedor.Text, out idVendedor))
            {
                MessageBox.Show("Ingrese un ID de vendedor válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Agrega un mensaje para verificar que se obtiene el ID del vendedor correctamente
            MessageBox.Show($"ID del vendedor: {idVendedor}");

            // Llama al método buscarVendedor
            buscarVendedor(idVendedor);
        }
    }
}

    

