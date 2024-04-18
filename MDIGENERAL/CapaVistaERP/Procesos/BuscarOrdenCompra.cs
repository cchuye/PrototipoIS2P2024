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
    public partial class BuscarOrdenCompra : Form
    {
        private Compras Compras;
        String tabla1 = "tbl_ordenescompra";
        Controlador cn = new Controlador();
        public BuscarOrdenCompra(Compras compra)
        {
            InitializeComponent();
            actualizardatagridview();
            Compras = compra;
        }
        public void actualizardatagridview()
        {
            DataTable dt = cn.llenarTablas(tabla1);
            dgv_orden.DataSource = dt;
        }

        private void btn_seleccionar_Click(object sender, EventArgs e)
        {
            if (dgv_orden.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dgv_orden.SelectedRows[0];
                string id = filaSeleccionada.Cells["id_OrdComp"].Value.ToString();
                string fechaS = filaSeleccionada.Cells["fechaSolicitid_OrdComp"].Value.ToString();
                string fechaE = filaSeleccionada.Cells["fechaEntrega_OrdComp"].Value.ToString();
                string solicitante = filaSeleccionada.Cells["deptoSolicitante_OrdComp"].Value.ToString();
                string proveedor = filaSeleccionada.Cells["tbl_proveedor_id_prov"].Value.ToString();
                Compras.RecibirDatosDesdeBuscarOrdenes(id, fechaS, fechaE, solicitante, proveedor);
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
                            int idOrdenEnFila = int.Parse(fila.Cells["id_OrdComp"].Value.ToString());

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
