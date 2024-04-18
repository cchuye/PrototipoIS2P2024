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
using Seguridad_Controlador;

//Comentado por George Mayén 25/02/2023
namespace MenuHCV
{
    public partial class Login : Form
    {

        //string tab = "usuario";
      //  string da1 = "usuario";
        //string da2 = "contra";
        Controlador cn = new Controlador();
        // prueba pr = new prueba();
        //prueba b = new prueba();

        public Login()
        {
            InitializeComponent();
        }

        


        //Método quye valida si el usuario y contraseña es correcta y se registra este valor en la bitacora
        public void login()
        {
            if (cn.validarLogin(TBusuario.Text, Controlador.SetHash(TBcontrasena.Text)))
            {
                Controlador.Username = Controlador.SetHash(TBusuario.Text);

                
                Menup b = new Menup();
                cn.setBtitacora("1", "Ingreso Login");
                b.Show();
                this.Hide();
            }else
            {
                MessageBox.Show("Contraseña o Usuario Incorrecta");
            }
        }


        //Método que llama al método login
        private void button1_Click(object sender, EventArgs e)
        {
            login();  
        }

        //Método checkbox: si se ha chequeado el estado del txtestado pasa a 1, de lo contrario pasa a 0
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                // TBcontraseña.PasswordChar = '*';
                TBcontrasena.PasswordChar = '\0';
            }
            else
                       if (TBcontrasena.Text != "")
            {
                // TBcontraseña.PasswordChar = '\0';
                TBcontrasena.PasswordChar = '*';
            }
        }
        //Método muestra el formulario de recuperación
        private void button2_Click(object sender, EventArgs e)
        {
            recuperacion b = new recuperacion();
            b.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            
        }
        //Método que se sale de la aplicación
        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
