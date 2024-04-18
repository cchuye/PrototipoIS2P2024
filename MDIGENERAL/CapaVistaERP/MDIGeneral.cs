using CapaVistaERP.Mantenimientos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVistaERP
{
    public partial class MDIGeneral : Form
    {
        public MDIGeneral()
        {
            InitializeComponent();
            //Control para habilitar opciones del menu
            // Button[] apps = { btn_precios, btn_generarBoleta };
            //Llamada metodo de libreria Controlador del modulo de Seguridad
            //cns.deshabilitarApps(apps);
            //Llamada metodo de libreria Controlador del modulo de Seguridad
            //cns.getAccesoApp(2001, apps[1]);
            //cns.getAccesoApp(2002, apps[2]);
            //cns.getAccesoApp(2003, apps[3]);
            //cns.getAccesoApp(2004, apps[4]);
            //cns.getAccesoApp(2005, apps[5]);
            escondersubmenus();
        }

        private void escondersubmenus()
        {
            panelTranportes.Visible = false;
            PanelAuditoria.Visible = false;
            panelayuda.Visible = false;
            panelseguridad.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelTranportes.Visible == true)
                panelTranportes.Visible = false;
            if (PanelAuditoria.Visible == true)
                PanelAuditoria.Visible = false;
            if (panelayuda.Visible == true)
                panelayuda.Visible = false;
            if (panelseguridad.Visible == true)
                panelseguridad.Visible = false;

        }
        //Método que valida si el submenu no es visible oculta el submenu
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                //hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        private void showSubMenuMantenimientos(Panel subMenuMant)
        {
            if (subMenuMant.Visible == false)
            {
                hideSubMenu();
                subMenuMant.Visible = true;
            }
            else
                subMenuMant.Visible = false;
        }

        private void Abrir(object abrirform)
        {
            if (this.panelMDI.Controls.Count > 0)
                this.panelMDI.Controls.RemoveAt(0);

            Form fh = abrirform as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.None;
            this.panelMDI.Controls.Add(fh);
            this.panelMDI.Tag = fh;
            fh.Show();
        }

        private void btnayuda_Click(object sender, EventArgs e)
        {
            //Help.ShowHelp(this, "umg.chm");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Abrir(new Mantenimientos.frm_Mant_Proveedor());
            hideSubMenu();
        }     

        private void btninicio_Click_1(object sender, EventArgs e)
        {

        }

        private void btnmanteniminetos_Click(object sender, EventArgs e)
        {
            showSubMenu(panelTranportes);
        }

        private void btnProcesos_Click_1(object sender, EventArgs e)
        {
            showSubMenu(PanelAuditoria);
        }

        private void btnReportes_Click_1(object sender, EventArgs e)
        {
            showSubMenu(panelseguridad);
        }

        private void btnSeguridad_Click_1(object sender, EventArgs e)
        {
            showSubMenu(panelayuda);
        }

        private void btnsalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnproveedor_Click(object sender, EventArgs e)
        {
            Abrir(new Mantenimientos.frm_Mant_Proveedor());
            hideSubMenu();
        }
    }
}
