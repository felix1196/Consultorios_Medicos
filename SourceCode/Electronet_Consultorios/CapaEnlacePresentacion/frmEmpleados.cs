using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEnlaceNegocio;

namespace CapaEnlacePresentacion
{
    public partial class frmEmpleados : Form
    {
        clsEmpleados empleados = new clsEmpleados();

        public frmEmpleados()
        {
            InitializeComponent();
        }

        private void frmEmpleados_Load(object sender, EventArgs e)
        {
            try
            {
                MostrarEmpleados();
                ListarTipoEmpleados();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void MostrarEmpleados()
        {
            dataGridView1.DataSource = empleados.MostrarEmpleados();
            dataGridView1.RowsDefaultCellStyle.BackColor = Color.LightBlue;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
        }

        private void ListarTipoEmpleados()
        {
            DataTable listaEmpleados = new DataTable();

            listaEmpleados = empleados.MostrarTipoEmpleados();

            foreach(DataRow row in listaEmpleados.Rows)
            {
                cmbTipoEmpleado.Items.Add(row["Descripcion"].ToString());
            }

            cmbTipoEmpleado.Text = "Seleccione...";
        }

        private void btnAgregarEmpleado_Click(object sender, EventArgs e)
        {
            if (txtNombreEmpleado.Text.Length == 0 || txtContraseña.Text.Length == 0 || txtUsuario.Text.Length == 0)
            {
                MessageBox.Show("No se puede registrar empleado, existen campos vaciós.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    empleados.m_Nombre = txtNombreEmpleado.Text;
                    empleados.m_Telefono = txtTelefono.Text;
                    empleados.m_Correo = txtCorreo.Text;
                    empleados.m_FechaNacimiento = Convert.ToDateTime(dtFechaNacimiento.Text);
                    empleados.m_Usuario = txtUsuario.Text;
                    empleados.m_Contraseña = txtContraseña.Text;
                    empleados.m_TipoUsuario = cmbTipoEmpleado.Text;
                    MessageBox.Show(empleados.RegistrarEmpleado(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    MostrarEmpleados();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se puede registrar empleado por " + ex.ToString() + ", verifique los datos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
