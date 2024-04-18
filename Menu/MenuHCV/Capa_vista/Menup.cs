using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Seguridad_Controlador;
using Vista_Seguridad;
using Vista_PrototipoMenu;
using CapaVistaERP;
//Comentado por George Mayén 25/02/2023
namespace MenuHCV
{
    public partial class Menup : Form
    {
        Controlador cn = new Controlador();

        //Método que guarda en un arreglo de tipo botón los botones que se tienen en el formulario. Se les da permiso a los diferentes botones de acuerdo a la función que realice este
        public Menup()
        {
            InitializeComponent();

            Button[] apps = { btnseguridad, btnPrototipo};
            cn.deshabilitarApps(apps);

            cn.getAccesoApp(1000, apps[0]);  //Modulo Seguridad
           // cn.getAccesoApp(2000, apps[1]);  //Modulo Compras y Cxp
           // cn.getAccesoApp(3000, apps[2]);  //Modulo Ventas y Cxc
           // cn.getAccesoApp(4000, apps[3]);  //Modulo Inventarios
           // cn.getAccesoApp(5000, apps[4]);  //Modulo Bancos
           // cn.getAccesoApp(6000, apps[5]);  //Modulo Nominas
          //  cn.getAccesoApp(7000, apps[6]);  //Modulo Hoteleria
            cn.getAccesoApp(8000, apps[1]);  //Modulo Prototipo



        }
        //Método que ingresa un valor a la bitacora de acuerdo el módulo
        public void btnlogout_Click(object sender, EventArgs e)
        {
            MenuSeguridad b = new MenuSeguridad();
            b.Show();
            cn.setBtitacora("1000", "Ingreso Seguridad");
            this.Close();
        }

        public void btnVentas_Click(object sender, EventArgs e)
        {
            //Vista_PrototipoMenu.MenuVentasCxc form = new Vista_PrototipoMenu.MenuVentasCxc();
            //form.Show();
            //cn.setBtitacora("2000", "Ingreso Ventas");
        }
        //Método que ingresa un valor a la bitacora de acuerdo el módulo
        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            //Login b = new Login();
            //cn.setBtitacora("999", "Cerro Sesion");
            //b.Show();
           this.Close();
        }
        //Método que ingresa un valor a la bitacora de acuerdo el módulo
        private void btncompras_Click(object sender, EventArgs e)
        {
            //Vista_PrototipoMenu.MenuComprasCxp form = new Vista_PrototipoMenu.MenuComprasCxp();
            //form.Show();
            //cn.setBtitacora("3000", "Ingreso Compras");
        }
        //Método que ingresa un valor a la bitacora de acuerdo el módulo

        private void btnInventario_Click(object sender, EventArgs e)
        {
            //Vista_PrototipoMenu.MenuInventarios form = new Vista_PrototipoMenu.MenuInventarios();
            //form.Show();
            //cn.setBtitacora("4000", "Ingreso Inventarios");
            /*CapaVistaInventario.menu_inventario b = new CapaVistaInventario.menu_inventario();
            //b.Show();
            //cn.setBtitacora("4000", "Ingreso Inventario");*/
        }

        private void btnBancos_Click(object sender, EventArgs e)
        {
            //Vista_PrototipoMenu.MenuBancos form = new Vista_PrototipoMenu.MenuBancos();
            //form.Show();
            //cn.setBtitacora("5000", "Ingreso Ventas");
        }

        private void btnNominas_Click_1(object sender, EventArgs e)
        {
            //Vista_PrototipoMenu.MenuNominas form = new Vista_PrototipoMenu.MenuNominas();
            //form.Show();
            //cn.setBtitacora("6000", "Ingreso Ventas");
        }

        private void btnHoteleria_Click(object sender, EventArgs e)
        {
            //Vista_PrototipoMenu.MenuHoteleria form = new Vista_PrototipoMenu.MenuHoteleria();
            //form.Show();
            //cn.setBtitacora("7000", "Ingreso Ventas");
        }

        private void btnCxC_Click(object sender, EventArgs e)
        {

        }

        private void btnCxP_Click(object sender, EventArgs e)
        {

        }

        private void btnPrototipo_Click(object sender, EventArgs e)
        {
            CapaVistaERP.MDIGeneral form = new CapaVistaERP.MDIGeneral();
            form.Show();
            cn.setBtitacora("8000", "Ingreso Prototipo");
        }
        //Método que ingresa un valor a la bitacora de acuerdo el módulo

    }
}
