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
        public frmEmpleados()
        {
            InitializeComponent();
        }

        private void frmEmpleados_Load(object sender, EventArgs e)
        {
            try
            {
                MostrarEmpleados();
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
            clsEmpleados MostrarEmpleados = new clsEmpleados();
            dataGridView1.DataSource = MostrarEmpleados.MostrarEmpleados();
            dataGridView1.RowsDefaultCellStyle.BackColor = Color.LightBlue;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
        }
    }
}
