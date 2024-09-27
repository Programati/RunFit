using System;
using System.Drawing;
using System.Windows.Forms;
using CapaDeEntidades;
using Guna.UI.WinForms;

namespace CapaPresentacion
{
    public partial class Inicio : Form
    {
        private static Usuario UsuarioActual = null; // Variable estática para almacenar el usuario actual
        private static GunaGradientButton menuActivo = null; // Variable estática para almacenar el botón activo del menú
        private static Form formularioActivo = null; // Variable estática para almacenar el formulario activo

        // Definición de colores que se utilizarán en la interfaz de usuario
        Color colorCeleste = Color.FromArgb(25, 162, 198); // Color personalizado celeste
        Color colorAzul = Color.FromArgb(6, 71, 109); // Color personalizado azul oscuro
        Color colorVerde = Color.FromArgb(77, 163, 108); // Color personalizado verde
        Color colorClaro = Color.FromArgb(227, 211, 154); // Color personalizado claro
        Color colorRojo = Color.FromArgb(235, 57, 32); // Color personalizado rojo

        // Constructor del formulario 'Inicio', recibe un objeto 'Usuario'
        public Inicio(Usuario objUsuario)
        {
            UsuarioActual = objUsuario; // Asigna el usuario actual a la variable estática
            InitializeComponent(); // Inicializa los componentes del formulario
            IniciarSubMenuOculto(); // Llama a la función para ocultar los submenús al iniciar
            lblUsuarioInicio.Text = UsuarioActual.nombreUsuario.ToString(); // Muestra el nombre del usuario en el label correspondiente
            lblRolInicio.Text = UsuarioActual.oRol.nombreRol.ToString().ToUpper(); // Muestra el rol del usuario en mayúsculas en el label correspondiente
        }

        // Función que oculta los submenús al iniciar el formulario
        private void IniciarSubMenuOculto()
        {
            subVentas.Visible = false; // Oculta el submenú de ventas
            panelSubMantenedor.Visible = false; // Oculta el panel de mantenimiento
        }

        // Función que oculta los submenús si están visibles
        protected void OcultarSubMenu()
        {
            if (subVentas.Visible == true) // Si el submenú de ventas está visible, lo oculta
            {
                subVentas.Visible = false;
            }
            if (panelSubMantenedor.Visible == true) // Si el panel de mantenimiento está visible, lo oculta
            {
                panelSubMantenedor.Visible = false;
            }
        }

        // Función que alterna la visibilidad de un submenú, lo muestra si está oculto y lo oculta si está visible
        private void MostrarSubmenu(Panel Submenu)
        {
            if (Submenu.Visible == false) // Si el submenú está oculto, lo muestra
            {
                OcultarSubMenu(); // Antes de mostrar el submenú, oculta los demás submenús
                Submenu.Visible = true; // Muestra el submenú
            }
            else // Si el submenú está visible, lo oculta
            {
                Submenu.Visible = false;
            }
        }


        // Función que muestra los clientes, oculta los submenús abiertos, y abre el formulario de usuarios
        private void btnUsuario_Click(object sender, EventArgs e)
        {
            OcultarSubMenu(); // Oculta todos los submenús abiertos
            frmListarUsuario frmUsuario = new frmListarUsuario(this); // Crea una nueva instancia del formulario de usuarios y le pasa la referencia del formulario actual
            abrirFormulario(btnUsuario, frmUsuario); // Llama a la función para abrir el formulario y activar el botón correspondiente
        }

        // Función que muestra la lista de clientes, oculta los submenús abiertos y oculta la imagen de fondo
        public void btnClientes_Click(object sender, EventArgs e)
        {
            OcultarSubMenu(); // Oculta todos los submenús abiertos
            imagenFondo.Hide(); // Oculta la imagen de fondo
            frmListarCliente frmClientes = new frmListarCliente(this, UsuarioActual); // Crea una nueva instancia del formulario de clientes y pasa la referencia del formulario y el usuario actual
            abrirFormulario(btnClientes, frmClientes); // Llama a la función para abrir el formulario y activar el botón correspondiente
        }

        // Función que despliega el submenú de ventas
        private void btnVentas_Click_1(object sender, EventArgs e)
        {
            MostrarSubmenu(subVentas); // Muestra u oculta el submenú de ventas dependiendo de su estado actual
        }

        // Función que abre el formulario para registrar una venta y bloquea el panel de botones
        private void btnRegistrarVentas_Click(object sender, EventArgs e)
        {
            frmRegistrarVenta frmVenta = new frmRegistrarVenta(this); // Crea una nueva instancia del formulario para registrar una venta y pasa la referencia del formulario actual
            abrirFormulario(btnRegistrarVentas, frmVenta); // Llama a la función para abrir el formulario y activar el botón correspondiente
            pnlContenedorMenu.Enabled = false; // Desactiva el panel de botones para evitar interacciones mientras el formulario de ventas está activo
        }

        // Función que abre el formulario para buscar una venta
        private void btnBuscarVentas_Click(object sender, EventArgs e)
        {
            abrirFormulario(btnBuscarVentas, new frmBuscarVenta(this)); // Crea una nueva instancia del formulario de búsqueda de ventas y lo abre
        }

        // Función que abre el formulario para listar proveedores
        private void btnProveedores_Click(object sender, EventArgs e)
        {
            frmListarProveedor frmProv = new frmListarProveedor(this); // Crea una nueva instancia del formulario de proveedores y pasa la referencia del formulario actual
            OcultarSubMenu(); 
            abrirFormulario(btnProveedores, frmProv); // Llama a la función para abrir el formulario y activar el botón correspondiente
        }

        // Función que abre el formulario de reportes
        private void btnReportes_Click(object sender, EventArgs e)
        {
            OcultarSubMenu(); 
            abrirFormulario(btnReportes, new frmReporte()); // Crea una nueva instancia del formulario de reportes y lo abre
        }

        // Función que oculta todos los submenús abiertos y despliega el submenú del mantenedor de stock
        private void btnStock_Click(object sender, EventArgs e)
        {
            OcultarSubMenu(); 
            MostrarSubmenu(panelSubMantenedor); // Muestra el submenú del panel mantenedor
        }

        // Función que oculta todos los submenús abiertos y abre el formulario de categoría
        private void btnCategoria_Click(object sender, EventArgs e)
        {
           
            abrirFormulario(btnCategoria, new frmCategoria(this)); // Abre el formulario de categoría
        }

        // Función que oculta todos los submenús abiertos y abre el formulario para listar productos
        private void btnProducto_Click(object sender, EventArgs e)
        {
           
            frmListarProducto frmPto = new frmListarProducto(this); // Crea una nueva instancia del formulario para listar productos
            abrirFormulario(btnRegistrarVentas, frmPto); // Abre el formulario de productos
        }

        // Función que oculta los submenús y abre el formulario de "Acerca de"
        private void btnAcercaDe_Click(object sender, EventArgs e)
        {
            imagenFondo.Hide(); // Oculta la imagen de fondo
            OcultarSubMenu(); 
            abrirFormulario(btnAcercaDe, new frmAcercaDe()); // Abre el formulario "Acerca de"
        }

        // Función que abre el formulario deseado y cambia el estilo del botón que lo invoca
        private void abrirFormulario(GunaGradientButton menu, Form formulario)
        {
            imagenFondo.Hide(); // Oculta la imagen de fondo

            // Si ya hay un menú activo, restablece sus colores a los originales
            if (menuActivo != null)
            {
                menuActivo.BaseColor1 = Color.Transparent;
                menuActivo.BaseColor2 = Color.Transparent;
                menuActivo.ForeColor = Color.White;
            }

            // Cambia los colores del menú seleccionado para que destaque
            menu.BaseColor1 = Color.White;
            menu.BaseColor2 = colorClaro;
            menu.ForeColor = colorAzul;
            menuActivo = menu; // Establece el nuevo menú activo

            // Si ya hay un formulario activo, lo cierra
            if (formularioActivo != null)
                formularioActivo.Close();

            formularioActivo = formulario; // Establece el nuevo formulario activo
            formulario.TopLevel = false; // El formulario no será de nivel superior
            formulario.FormBorderStyle = FormBorderStyle.None; // Elimina los bordes del formulario
            formulario.Dock = DockStyle.Fill; // Hace que el formulario ocupe todo el espacio disponible
            formulario.BackColor = Color.White; // Establece el color de fondo del formulario

            panelContenedorFormularios.Controls.Add(formulario); // Añade el formulario al panel contenedor
            formulario.Show(); // Muestra el formulario
        }

        // Función que configura la visibilidad de los botones del menú según el rol del usuario
        private void Inicio_Load(object sender, EventArgs e)
        {
            // Si el rol del usuario es 2, se muestra el botón de clientes y se ocultan otros
            if (UsuarioActual.oRol.idRol == 2)
            {
                btnClientes.Visible = true;
                btnUsuario.Visible = false;
                btnVentas.Visible = false;
                btnBackup.Visible = false;
            }

            // Si el rol del usuario es 3, se ocultan botones específicos
            if (UsuarioActual.oRol.idRol == 3)
            {
                btnUsuario.Visible = false;
                btnProveedores.Visible = false;
                btnStock.Visible = false;
                btnBackup.Visible = false;
            }

            // Si el rol del usuario es 1, se ocultan otros botones
            if (UsuarioActual.oRol.idRol == 1)
            {
                btnClientes.Visible = false;
                btnStock.Visible = false;
                btnVentas.Visible = false;
                btnProveedores.Visible = false;
            }
        }

        // Función que abre el formulario de marcas
        private void btnMarca_Click(object sender, EventArgs e)
        {
            abrirFormulario(btnMarca, new frmMarca(this)); // Abre el formulario de marcas
        }

        // Propiedad que permite acceder al control pnlContenedorMenu desde otras clases
        public Panel PnlContenedorMenu
        {
            get
            {
                return pnlContenedorMenu; // Devuelve el panel contenedor del menú
            }
        }

        // Función que muestra la imagen de fondo
        public void MostrarImagenFondo()
        {
            imagenFondo.Show(); // Muestra la imagen de fondo nuevamente
        }

        // Función que oculta los submenús abiertos y abre el formulario de respaldo (backup)
        private void btnBackup_Click(object sender, EventArgs e)
        {
            imagenFondo.Hide(); // Oculta la imagen de fondo
            OcultarSubMenu(); // Oculta todos los submenús visibles
            abrirFormulario(btnBackup, new frmBackup(this)); // Abre el formulario de respaldo
        }

    }
}

