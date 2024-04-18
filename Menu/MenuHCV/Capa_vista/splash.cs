using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vista_Seguridad;
//Comentado por George Mayén 25/02/2023
namespace MenuHCV
{
    public partial class splash : Form
    {
        public splash()
        {
            InitializeComponent();
        }

        //Método quemuestra una barra con su porcentaje y cuando llega al máximo que es un 100% muestra el formulario de login
        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(5);
            label1.Text = progressBar1.Value.ToString() + "%";

            if (progressBar1.Value == progressBar1.Maximum)
            {
                timer1.Stop();
                this.Hide();
               Login b = new Login();
               b.ShowDialog();
            }
        }
    }
}
