using System;
using System.Drawing;
using System.Windows.Forms;
using CapaDeEntidades;
using Guna.UI.WinForms;

namespace CapaPresentacion
{
    public partial class Inicio : Form
    {
        private static Usuario UsuarioActual = null;   //Declaracion de variables estaticas ,iniciadad en null
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
            lblUsuarioInicio.Text = UsuarioActual.nombreUsuario.ToString();
            lblRolInicio.Text=UsuarioActual.oRol.nombreRol.ToString().ToUpper();
        }

        private void IniciarSubMenuOculto()//Funcion que muestra el menu sin desplegar los botones
        {
            subVentas.Visible = false;
            panelSubMantenedor.Visible = false;
            
        }

        protected void OcultarSubMenu() //veifica si ciertos submenús están visibles y, si es así, los oculta
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

        private void MostrarSubmenu(Panel Submenu)//Funcion que muestra los submenu si esta oculto, y visceversa
        {
            if (Submenu.Visible == false)
            {
                OcultarSubMenu();
                Submenu.Visible = true;
            }
            else
            {
                Submenu.Visible = false;
            }
            
        }

        private void btnUsuario_Click(object sender, EventArgs e)//Funcion que muestra los clientes, oculta los submenus abiertos, y abre form usuario
        {
            OcultarSubMenu();
            frmListarUsuario frmUsuario= new frmListarUsuario(this);
            abrirFormulario(btnUsuario, frmUsuario);
        }

        public void btnClientes_Click(object sender, EventArgs e)
        {

            OcultarSubMenu();
            imagenFondo.Hide();
            frmListarCliente frmClientes = new frmListarCliente(this,UsuarioActual);
            abrirFormulario(btnClientes, frmClientes);
        }

        private void btnVentas_Click_1(object sender, EventArgs e)//Funcion que despliega el subMenu de ventas
        {
            MostrarSubmenu(subVentas);
        }

        private void btnRegistrarVentas_Click(object sender, EventArgs e)// Funcion que abre el formulario para registrar una venta, bloquea el panel de botones
        {
            // Crear el formulario y pasar la referencia de 'this'
            frmRegistrarVenta frmVenta = new frmRegistrarVenta(this);
            abrirFormulario(btnRegistrarVentas, frmVenta);
            pnlContenedorMenu.Enabled = false;
        }

        private void btnBuscarVentas_Click(object sender, EventArgs e)// Funcion que abre el formulario para buscar una venta
        {
            abrirFormulario(btnBuscarVentas, new frmBuscarVenta());
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            frmListarProveedor frmProv = new frmListarProveedor(this);
            OcultarSubMenu();
            abrirFormulario(btnProveedores, frmProv);
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            OcultarSubMenu();
            abrirFormulario(btnReportes, new frmReporte());
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            OcultarSubMenu();
            MostrarSubmenu(panelSubMantenedor);
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            abrirFormulario(btnCategoria, new frmCategoria());
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            imagenFondo.Hide();
            frmListarProducto frmPto = new frmListarProducto(this);
            abrirFormulario(btnRegistrarVentas, frmPto);
        }

        private void btnAcercaDe_Click(object sender, EventArgs e)
        {
            imagenFondo.Hide();
            OcultarSubMenu();
            abrirFormulario(btnAcercaDe, new frmAcercaDe());
        }

        private void abrirFormulario(GunaGradientButton menu, Form formulario)
        {
            imagenFondo.Hide();
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

           if (formularioActivo != null)
                formularioActivo.Close();
            
            formularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            formulario.BackColor = Color.White;

            panelContenedorFormularios.Controls.Add(formulario);
            formulario.Show();
        }

        private void Inicio_Load(object sender, EventArgs e)//Funcion que muestra el menu de acuerdo al rol del usuario que ingresa
        {
            if (UsuarioActual.oRol.idRol == 2)
            {
                btnClientes.Visible = true;
                btnUsuario.Visible = false;
                btnVentas.Visible = false;
                

            }
            if (UsuarioActual.oRol.idRol == 3)
            {
                btnUsuario.Visible = false;
                btnProveedores.Visible = false;
                btnReportes.Visible = false;
                btnStock.Visible = false;
                btnBackup.Visible = false;
            }
            if (UsuarioActual.oRol.idRol == 1)
            {
                btnClientes.Visible = false;
                btnStock.Visible = false;
                btnVentas.Visible = false;
                btnProveedores.Visible = false;
                
            }
        }

        private void btnMarca_Click(object sender, EventArgs e)
        {
            abrirFormulario(btnMarca, new frmMarca());
        }

        public Panel PnlContenedorMenu // Metodo para obtener acceso al control pnlContenedorMenu desde fuera de la clase en la que está definido.
        {
            get {
                return pnlContenedorMenu;
            }
        }
        public void MostrarImagenFondo()
        {
            imagenFondo.Show(); // Mostrar la imagen nuevamente
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            imagenFondo.Hide();
            OcultarSubMenu();
            abrirFormulario(btnBackup, new frmBackup(this));
        }
    }
}
