
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDeEntidades;
using Guna.UI.WinForms;

namespace CapaPresentacion
{
    public partial class Inicio : Form
    {
        private static Usuario UsuarioActual = null;
        private static GunaGradientButton menuActivo = null;
        private static Form formularioActivo = null;

        Color colorCeleste = Color.FromArgb(25, 162, 198);
        Color colorAzul = Color.FromArgb(6, 71, 109);
        Color colorVerde = Color.FromArgb(77, 163, 108);
        Color colorClaro = Color.FromArgb(227, 211, 154);
        Color colorRojo = Color.FromArgb(235, 57, 32);
        public Inicio(Usuario objUsuario)
        {
            UsuarioActual = objUsuario;
            InitializeComponent();
            IniciarSubMenuOculto();
        }

        private void IniciarSubMenuOculto()
        {
            subVentas.Visible = false;
            panelSubMantenedor.Visible = false;
        }
        protected void OcultarSubMenu()
        {
            if (subVentas.Visible == true)
            {
                subVentas.Visible = false;
            }
            if (panelSubMantenedor.Visible == true)
            {
                panelSubMantenedor.Visible = false;
            }
        }

        private void MostrarSubmenu(Panel Submenu)
        {
            if(Submenu.Visible == false)
            {
                OcultarSubMenu();
                Submenu.Visible = true;
            }
            else
            {
                Submenu.Visible = false;
            }
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            OcultarSubMenu();
            abrirFormulario(btnUsuario, new frmListarUsuario());
        }
        public void btnClientes_Click(object sender, EventArgs e)
        {
            OcultarSubMenu();
            abrirFormulario(btnClientes, new frmListarCliente());
        }
        private void btnVentas_Click_1(object sender, EventArgs e)
        {
            MostrarSubmenu(subVentas);
        }
        private void btnRegistrarVentas_Click(object sender, EventArgs e)
        {
            abrirFormulario(btnRegistrarVentas, new frmRegistrarVenta());
        }
        private void btnBuscarVentas_Click(object sender, EventArgs e)
        {
            abrirFormulario(btnBuscarVentas, new frmBuscarVenta());
        }
        private void btnProveedores_Click(object sender, EventArgs e)
        {
            OcultarSubMenu();
            abrirFormulario(btnProveedores, new frmListarProveedor());
        }
        private void btnReportes_Click(object sender, EventArgs e)
        {
            OcultarSubMenu();
            abrirFormulario(btnReportes, new frmReporte());
        }
        private void btnStock_Click(object sender, EventArgs e)
        {
            MostrarSubmenu(panelSubMantenedor);
        }
        private void btnCategoria_Click(object sender, EventArgs e)
        {
            abrirFormulario(btnCategoria, new frmCategoria());
        }
        private void btnProducto_Click(object sender, EventArgs e)
        {
            abrirFormulario(btnProducto, new frmListarProducto());
        }
        private void btnAcercaDe_Click(object sender, EventArgs e)
        {
            OcultarSubMenu();
            abrirFormulario(btnAcercaDe, new frmAcercaDe());
        }

        private void abrirFormulario(GunaGradientButton menu, Form formulario)
        {
            if (menuActivo != null) 
            {
                menuActivo.BaseColor1 = Color.Transparent;
                menuActivo.BaseColor2 = Color.Transparent;
                menuActivo.ForeColor = Color.White;
            } 
            menu.BaseColor1 = Color.White;
            menu.BaseColor2 = colorClaro;
            menu.ForeColor = colorAzul;
            menuActivo = menu;

            if (formularioActivo != null ) formularioActivo.Close();
            formularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            formulario.BackColor = Color.White;

            panelContenedorFormularios.Controls.Add(formulario);
            formulario.Show();

        }

        private void Inicio_Load(object sender, EventArgs e)
        {

            if (UsuarioActual.oRol.idRol == 2)
            {
                btnClientes.Visible = false;
                btnRegistrarVentas.Visible = false;
            }
            if (UsuarioActual.oRol.idRol == 3)
            {
                btnUsuario.Visible = false;
                btnProveedores.Visible = false;
                btnReportes.Visible = false;
                btnStock.Visible = false;
            }
        }

        private void btnMarca_Click(object sender, EventArgs e)
        {
            abrirFormulario(btnMarca, new frmMarca());
        }
    }   

}
