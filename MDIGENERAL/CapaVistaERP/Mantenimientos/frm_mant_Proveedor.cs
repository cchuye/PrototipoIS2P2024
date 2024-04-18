using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CapaVistaERP.Mantenimientos
{
    public partial class frm_Mant_Proveedor : Form
    {
        public frm_Mant_Proveedor()
        {
            InitializeComponent();
            this.navegador1.config("proveedores", this, "8001");
            empezar();
        }
        public void empezar()
        {
            comboBox2.Items.Add("Activo");
            comboBox2.Items.Add("Inactivo");
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_estado.Text = comboBox2.SelectedItem.ToString();
        }
    }
}
