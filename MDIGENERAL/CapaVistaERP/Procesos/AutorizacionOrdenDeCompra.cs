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
{//carlos enrique guzman cabrera
    public partial class AutorizacionOrdenDeCompra : Form
    {
        Controlador cn = new Controlador();
        public AutorizacionOrdenDeCompra()
        {
            InitializeComponent();
            LlenarComboCuentaBancaria();
        }

        public void LlenarComboCuentaBancaria()
        {
            List<string> concepto = cn.llenarCombo("id_cuentaBancaria", "tbl_cuentabancaria");
            cb_cuenta.Items.Clear();
            cb_cuenta.Items.AddRange(concepto.ToArray());
        }

        public void BuscarDetalleCuentas()
        {
            string tabla = "tbl_cuentabancaria";

            string columna = "id_cuentaBancaria";
            // string dato = cb_pasaporte.SelectedItem.ToString();
            string dato = (cb_cuenta.SelectedItem != null) ? cb_cuenta.SelectedItem.ToString() : string.Empty;

            DataTable dt = cn.Buscar(tabla, columna, dato);

            if (dt.Rows.Count > 0)
            {

                MessageBox.Show("Datos Encontrados");
                DataRow row = dt.Rows[0]; // Tomamos la primera fila (si hay resultados)

                // Llenamos los controles con los valores del resultado
                txt_nombreCuenta.Text = row["nombre_empresa"].ToString();
                txt_NoCuenta.Text = row["numero_cuenta"].ToString();
                txt_saldoDisponible.Text = row["saldoDisponible"].ToString();
            }
            else
            {

            }
        }

        private void AutorizacionOrdenDeCompra_Load(object sender, EventArgs e)
        {

        }

        private void cb_cuenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuscarDetalleCuentas();
        }
    }
}
