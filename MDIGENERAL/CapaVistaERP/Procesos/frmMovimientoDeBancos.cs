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
{// carlos enrique guzman cabrera
    public partial class frmMovimientoDeBancos : Form
    {
        Controlador cn = new Controlador();
        public frmMovimientoDeBancos()
        {
            InitializeComponent();
            LlenarComboTipoMovimiento();
            LlenarComboCuentaBancaria();
        }

        public void LlenarComboTipoMovimiento()
        {
            List<string> concepto = cn.llenarCombo("id_conceptoMovimiento", "tbl_conceptomovimientodebancos");
            cb_movimiento.Items.Clear();
            cb_movimiento.Items.AddRange(concepto.ToArray());
        }

        public void LlenarComboCuentaBancaria()
        {
            List<string> concepto = cn.llenarCombo("id_cuentaBancaria", "tbl_cuentabancaria");
            cb_cuenta.Items.Clear();
            cb_cuenta.Items.AddRange(concepto.ToArray());
        }


        public void BuscarDetalleMovimientos()
        {
            string tabla = "tbl_conceptomovimientodebancos";

            string columna = "id_conceptoMovimiento";
            // string dato = cb_pasaporte.SelectedItem.ToString();
            string dato = (cb_movimiento.SelectedItem != null) ? cb_movimiento.SelectedItem.ToString() : string.Empty;

            DataTable dt = cn.Buscar(tabla, columna, dato);

            if (dt.Rows.Count > 0)
            {

                MessageBox.Show("Datos Encontrados");
                DataRow row = dt.Rows[0]; // Tomamos la primera fila (si hay resultados)

                // Llenamos los controles con los valores del resultado
                txt_concepto.Text = row["concepto_movimientoBanco"].ToString();
                txt_efecto.Text = row["efecto_movimientoBanco"].ToString();

            }
            else
            {

            }
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
                txt_noCuenta.Text = row["numero_cuenta"].ToString();
                txt_tipoCuenta.Text = row["tipo_cuenta"].ToString();
                txt_estadoCuenta.Text = row["estado_cuenta"].ToString();

            }
            else
            {

            }
        }

        public void GuardarDatos()
        {
            string tabla = "tbl_movimientodebancos";
            Dictionary<string, object> valores = new Dictionary<string, object>();

            valores.Add("tipo_movimientoBanco", int.Parse(cb_movimiento.SelectedItem.ToString()));
            valores.Add("fecha_movimientoBanco", dtp_fecha.Value);
            valores.Add("monto_movimientoBanco", int.Parse(txt_monto.Text));
            valores.Add("cuenta_movimientoBanco", int.Parse(cb_cuenta.SelectedItem.ToString()));


            cn.GuardarDatos(tabla, valores);

            //MessageBox.Show("Datos guardados");
        }

        public void ActualizarSaldoCuentaBancaria()
        {
            double monto = double.Parse(txt_monto.Text);
            bool esDeposito = (txt_efecto.Text == "+"); // Verificar si el texto es "+"
            int idCuenta = int.Parse(cb_cuenta.SelectedItem.ToString());
            bool resultado = cn.ActualizarSaldoCuentaBancaria(idCuenta, monto, esDeposito);

            //if (resultado)
            //{
                //MessageBox.Show("Saldo actualizado correctamente");
            //}
            //else
            //{
                //MessageBox.Show("Error al actualizar el saldo");
            //}
        }

        private void cb_movimiento_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuscarDetalleMovimientos();
        }

        private void cb_cuenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuscarDetalleCuentas();
        }

        private void btn_realizarMovimiento_Click(object sender, EventArgs e)
        {
            GuardarDatos();
            ActualizarSaldoCuentaBancaria();
            MessageBox.Show("Datos guadaddos y saldos actualizados exitosamente");
        }
    }
}
