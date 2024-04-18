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
using System.Data.Odbc;
namespace CapaVistaERP.Procesos
{
   
    public partial class Mov_bancario : Form
    {
        Controlador cn = new Controlador();
        string mov = "tbl_movimientosbancarios";
        public Mov_bancario()
        {
            InitializeComponent();
            actualizardatagridView();

            dgv_vistaTransacciones.Columns[0].HeaderText = "ID";
            dgv_vistaTransacciones.Columns[1].HeaderText = "Valor";
            dgv_vistaTransacciones.Columns[2].HeaderText = "Descripcion";
            dgv_vistaTransacciones.Columns[3].HeaderText = "Numero de cuenta";
            dgv_vistaTransacciones.Columns[4].HeaderText = "Transaccion";
            dgv_vistaTransacciones.Columns[5].HeaderText = "Valor";
            dgv_vistaTransacciones.Columns[6].HeaderText = "Estatus";
            dgv_vistaTransacciones.Columns[7].HeaderText = "Fecha de ingreso";
            dgv_vistaTransacciones.Columns[8].HeaderText = "Estatus conciliacion";
        }
        public void actualizardatagridView()
        {
            DataTable dt = cn.llenarTbl(mov);
            dgv_vistaTransacciones.DataSource = dt;

        }

        private void Mov_bancario_Load(object sender, EventArgs e)
        {
            string connectionString = "Dsn=HotelSConexion";
            OdbcConnection conn = new OdbcConnection("Dsn=HotelSConexion");
            using (OdbcConnection connection = new OdbcConnection(connectionString))
            {
                OdbcDataAdapter adapter = new OdbcDataAdapter("SELECT * FROM tbl_mantenimientos_tipo_movimiento", connection);
                DataSet dataSet = new DataSet();

                try
                {
                    connection.Open();
                    adapter.Fill(dataSet, "tbl_mantenimientos_tipo_movimiento");
                }
                catch (OdbcException ex)
                {
                    // Manejar la excepción
                    Console.WriteLine("Error al cargar datos: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }

            // Llama al controlador para obtener el saldo total y mostrarlo en el Label
            decimal saldoTotal = cn.ObtenerSaldoTotal();
            label6.Text = "Q. " + saldoTotal.ToString();

            // Obtener tipos de moneda y cargar en el ComboBox
            DataTable Cuentas = cn.ObtenerCuentas();
            if (Cuentas != null)
            {
                foreach (DataRow row in Cuentas.Rows)
                {
                    cb_nCuenta.Items.Add(row["manac_numero_de_cuenta"].ToString());
                }
            }
            DataTable tipoTrans = cn.ObtenerTipoDeTransacciones();
            if (tipoTrans != null)
            {
                foreach (DataRow row in tipoTrans.Rows)
                {
                    cb_tipoTrans.Items.Add(row["movtm_transacciones_existentes"].ToString());
                }
            }

            DataTable vtrnas = cn.valorTrans();
            if (vtrnas != null)
            {
                foreach (DataRow row in vtrnas.Rows)
                {
                    cb_tipoTrans.Items.Add(row["movtm_valor_transaccion"].ToString());
                }
            }
        }

        private void btn_rtrans_Click(object sender, EventArgs e)
        {
            string estado = "1";
            decimal saldoTotal = cn.ObtenerSaldoTotal();

            DialogResult result = MessageBox.Show("¿Desea realizar la transacción?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {


                // Convierte el valor de la transacción desde la base de datos
                decimal valorTransaccion = cn.ObtenerValorTransaccion(txt_ttransaccion.Text);

                // Convierte el valor del TextBox a decimal
                if (decimal.TryParse(txt_valorTransferencia.Text, out decimal valorTransferencia))
                {
                    // Suma o resta según el tipo de transacción
                    if (valorTransaccion == 1)
                    {
                        saldoTotal += valorTransferencia;
                    }
                    else if (valorTransaccion == 0)
                    {
                        saldoTotal -= valorTransferencia;
                    }

                    // Actualiza el Label
                    label6.Text = "Saldo total: " + saldoTotal.ToString();
                }
                else
                {
                    MessageBox.Show("El valor de la transferencia no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                // Llamar al Controlador para insertar el movimiento en la base de datos
                cn.InsertarMovimiento(txt_valorTransferencia.Text, txt_descripcionTransferencia.Text, txt_numeroCuenta.Text, txt_ttransaccion.Text, estado, txt_valorTrans.Text, txt_stCon.Text);

                // Actualizar el DataGridView con los datos actualizados
                actualizardatagridView();

                // Limpiar los TextBox y combobox
                cb_nCuenta.SelectedIndex = -1;
                cb_tipoTrans.SelectedIndex = -1;
                txt_ttransaccion.Clear();
                txt_estado.Clear();
                txt_numeroCuenta.Clear();
                txt_valorTransferencia.Clear();
                txt_descripcionTransferencia.Clear();

                // Mostrar un mensaje de éxito
                MessageBox.Show("Movimiento realizado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                label6.Text = "Q. " + saldoTotal.ToString();
            }
            else
            {
                // Limpiar los TextBox y combobox
                cb_nCuenta.SelectedIndex = -1;
                cb_tipoTrans.SelectedIndex = -1;
                txt_ttransaccion.Clear();
                txt_estado.Clear();
                txt_numeroCuenta.Clear();
                txt_valorTransferencia.Clear();
                txt_descripcionTransferencia.Clear();

                // Mostrar un mensaje informativo
                MessageBox.Show("No se realizó la transacción.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                label6.Text = "Q. " + saldoTotal.ToString();
            }
        }

        private void btn_cancelarTransaccion_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea guardar el archivo?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Limpiar los TextBox y combobox
                cb_nCuenta.SelectedIndex = -1;
                cb_tipoTrans.SelectedIndex = -1;
                txt_ttransaccion.Clear();
                txt_estado.Clear();
                txt_numeroCuenta.Clear();
                txt_valorTransferencia.Clear();
                txt_descripcionTransferencia.Clear();


                // Mostrar un mensaje de éxito
                MessageBox.Show("Transacción cancelada correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se canceló la transaccion.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cb_nCuenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_nCuenta.SelectedItem != null)
            {
                string tipoMonedaSeleccionada = cb_nCuenta.SelectedItem.ToString();
                txt_numeroCuenta.Text = tipoMonedaSeleccionada; // Muestra la selección en el TextBox txt_tipo_mon
            }
        }

        private void cb_tipoTrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_tipoTrans.SelectedItem != null)
            {
                string tipotransaccion = cb_tipoTrans.SelectedItem.ToString();
                txt_ttransaccion.Text = tipotransaccion;
                // Recupera el valor de la base de datos asociado al tipo de movimiento
                int valorTransaccion = cn.ObtenerValorTransaccion(tipotransaccion);

                // Asigna el valor al TextBox txt_valorTrans
                txt_valorTrans.Text = valorTransaccion.ToString();
            }
        }

        private void txt_stCon_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (string.IsNullOrEmpty(textBox.Text))
            {
                ((TextBox)sender).Text = "0";
            }
        }
    }
}
