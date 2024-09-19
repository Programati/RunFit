using CapaDeEntidades;
using CapaDeNegocios;
using Guna.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmListarCliente : Form
    {
        Inicio _inicio;
        
        public frmListarCliente(Inicio frminicio)
        {
            InitializeComponent();
            _inicio = frminicio;
            frminicio.PnlContenedorMenu.Enabled= false;
            
        }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {

            frmCliente CrearNuevoCliente = new frmCliente();

            CrearNuevoCliente.TopLevel = false;
            pnlContenedorCliente.Controls.Clear();
            pnlContenedorCliente.Controls.Add(CrearNuevoCliente);
            CrearNuevoCliente.FormBorderStyle = FormBorderStyle.None;
            CrearNuevoCliente.Dock = DockStyle.Fill;

            CrearNuevoCliente.Show();
            CrearNuevoCliente.FormClosing += frm_closing;
        }
        private void frm_closing(object sender, FormClosingEventArgs e)
        {
            frmListarCliente ListarNuevoCliente = new frmListarCliente(_inicio);

            ListarNuevoCliente.TopLevel = false;
            pnlContenedorCliente.Controls.Clear();
            pnlContenedorCliente.Controls.Add(ListarNuevoCliente);
            ListarNuevoCliente.FormBorderStyle = FormBorderStyle.None;
            ListarNuevoCliente.Dock = DockStyle.Fill;

            ListarNuevoCliente.Show();
        }

        private void txtBuscarCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            if (dgvListaClientes.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvListaClientes.Rows)
                {
                    if (row.Cells["Dni"].Value.ToString().Trim().Contains(txtBuscarCliente.Text.Trim()))
                        row.Visible = true;
                    else
                        row.Visible = false;
                }
            }
        }
        private void btnLimpiarCliente_Click(object sender, EventArgs e)
        {
            txtBuscarCliente.Clear();
            foreach (DataGridViewRow row in dgvListaClientes.Rows)
            {
                row.Visible = true;
            }
            txtBuscarCliente.Focus();
        }        
        private void frmListarCliente_Load(object sender, EventArgs e)
        {

           txtBuscarCliente.Focus();

            List<Domicilio> ListaDomicilio = new CN_Domicilio().ListarDomicilios();
            
            foreach (Domicilio item in ListaDomicilio)
            {
                dgvListaClientes.Rows.Add(new object[] { CapaPresentacion.Properties.Resources.editar, CapaPresentacion.Properties.Resources.Eliminar, item.oPersona.idPersona, item.oPersona.dni, item.oPersona.nombre, item.oPersona.apellido, item.oPersona.email, item.oPersona.telefono, item.oPersona.fechaNacimiento, item.oPersona.sexo, item.idDomicilio, item.calle, item.altura, item.casa, item.manzana, item.departamento, item.piso });
            }
        }

        private void dgvListaClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvListaClientes.Columns[e.ColumnIndex].Name == "Editar")
            {
                int n = e.RowIndex;
                if (n >= 0)
                {
                    
                    Domicilio DomicilioEditar = new Domicilio() { idDomicilio = Convert.ToInt32(dgvListaClientes.Rows[n].Cells["idDomicilio"].Value), calle = dgvListaClientes.Rows[n].Cells["Calle"].Value.ToString(), altura = dgvListaClientes.Rows[n].Cells["Altura"].Value.ToString(), casa = dgvListaClientes.Rows[n].Cells["Casa"].Value.ToString(), manzana = dgvListaClientes.Rows[n].Cells["Manzana"].Value.ToString(), departamento = dgvListaClientes.Rows[n].Cells["Departamento"].Value.ToString(), piso = dgvListaClientes.Rows[n].Cells["Piso"].Value.ToString(), oPersona = new Persona() { idPersona = Convert.ToInt32(dgvListaClientes.Rows[n].Cells["idPersona"].Value), dni = dgvListaClientes.Rows[n].Cells["Dni"].Value.ToString(), nombre = dgvListaClientes.Rows[n].Cells["Nombre"].Value.ToString(), apellido = dgvListaClientes.Rows[n].Cells["Apellido"].Value.ToString(), email = dgvListaClientes.Rows[n].Cells["Email"].Value.ToString(), telefono = dgvListaClientes.Rows[n].Cells["Telefono"].Value.ToString(), fechaNacimiento = dgvListaClientes.Rows[n].Cells["FechaNacimiento"].Value.ToString(), sexo = Convert.ToChar(dgvListaClientes.Rows[n].Cells["Sexo"].Value) } };

                    frmCliente CrearNuevoCliente = new frmCliente(DomicilioEditar);

                    CrearNuevoCliente.TopLevel = false;
                    pnlContenedorCliente.Controls.Clear();
                    pnlContenedorCliente.Controls.Add(CrearNuevoCliente);
                    CrearNuevoCliente.FormBorderStyle = FormBorderStyle.None;
                    CrearNuevoCliente.Dock = DockStyle.Fill;

                    CrearNuevoCliente.Show();
                    CrearNuevoCliente.FormClosing += frm_closing;
                }
            }
        }

        private void btnMenuClientes_Click(object sender, EventArgs e)
        {
            if (_inicio != null)
            {
                _inicio.PnlContenedorMenu.Enabled = true; // Reactivar el panel en Inicio
                _inicio.MostrarImagenFondo(); // Mostrar la imagen de fondo
            }
            this.Close(); // Cierra el formulario actual
            
        }
    }
}
