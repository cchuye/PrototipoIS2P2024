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
    public partial class BuscarCompras : Form
    {
        private FacturaporPagar FacturaporPagar;
        String tabla1 = "tbl_compras";
        Controlador cn = new Controlador();
        public BuscarCompras(FacturaporPagar facturaporpagar)
        {
            InitializeComponent();
            actualizardatagridview();
            FacturaporPagar = facturaporpagar;
        }
        public void actualizardatagridview()
        {
            DataTable dt = cn.llenarTablasCondicion(tabla1);
            dgv_orden.DataSource = dt;
        }

        private void btn_seleccionar_Click(object sender, EventArgs e)
        {
            if (dgv_orden.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dgv_orden.SelectedRows[0];
                string idcompra = filaSeleccionada.Cells["id_EncComp"].Value.ToString();
                string fechaV = filaSeleccionada.Cells["fechaVencimientoPago_EncComp"].Value.ToString();
                string proveedorfact = filaSeleccionada.Cells["tbl_proveedor_id_prov"].Value.ToString();
                FacturaporPagar.RecibirDatosDesdeBuscarOrdenes(idcompra, fechaV, proveedorfact);
                this.Close();
            }
            else
            {
                MessageBox.Show("Seleccione una fila.", "Selección de Orden", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_buscarOrden_Click(object sender, EventArgs e)
        {
            if (dgv_orden != null && dgv_orden.Rows.Count > 0)
            {
                if (int.TryParse(txt_Orden.Text, out int idOrdenBuscar))
                {
                    bool encontrado = false;

                    foreach (DataGridViewRow fila in dgv_orden.Rows)
                    {
                        if (!fila.IsNewRow)
                        {
                            int idOrdenEnFila = int.Parse(fila.Cells["id_EncComp"].Value.ToString());

                            if (idOrdenEnFila == idOrdenBuscar)
                            {
                                fila.Selected = true;
                                dgv_orden.CurrentCell = fila.Cells[0];
                                encontrado = true;
                                break;
                            }
                        }
                    }

                    if (!encontrado)
                    {
                        MessageBox.Show("Orden de compra no encontrada.", "Búsqueda de Orden de Compra", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese un número de orden válido.", "Búsqueda de Orden de Compra", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
