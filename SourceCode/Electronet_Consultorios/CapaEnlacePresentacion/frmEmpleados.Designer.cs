namespace CapaEnlacePresentacion
{
    partial class frmEmpleados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            label1 = new Label();
            txtNombreEmpleado = new TextBox();
            groupBox1 = new GroupBox();
            btnAgregarEmpleado = new Button();
            btnActualizar = new Button();
            btnAgrearTipoEmpleado = new Button();
            btnSalir = new Button();
            cmbTipoEmpleado = new ComboBox();
            label7 = new Label();
            txtContraseña = new TextBox();
            label6 = new Label();
            txtUsuario = new TextBox();
            label5 = new Label();
            dtFechaNacimiento = new DateTimePicker();
            label4 = new Label();
            txtCorreo = new TextBox();
            label3 = new Label();
            txtTelefono = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 237);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1013, 293);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 25);
            label1.Name = "label1";
            label1.Size = new Size(129, 15);
            label1.TabIndex = 1;
            label1.Text = "Nombre del Empleado:";
            // 
            // txtNombreEmpleado
            // 
            txtNombreEmpleado.Location = new Point(164, 22);
            txtNombreEmpleado.Name = "txtNombreEmpleado";
            txtNombreEmpleado.Size = new Size(491, 23);
            txtNombreEmpleado.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(btnAgregarEmpleado);
            groupBox1.Controls.Add(btnActualizar);
            groupBox1.Controls.Add(btnAgrearTipoEmpleado);
            groupBox1.Controls.Add(btnSalir);
            groupBox1.Controls.Add(cmbTipoEmpleado);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtContraseña);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtUsuario);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(dtFechaNacimiento);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtCorreo);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtTelefono);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtNombreEmpleado);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1013, 219);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Empleados";
            // 
            // btnAgregarEmpleado
            // 
            btnAgregarEmpleado.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAgregarEmpleado.Location = new Point(164, 190);
            btnAgregarEmpleado.Name = "btnAgregarEmpleado";
            btnAgregarEmpleado.Size = new Size(75, 23);
            btnAgregarEmpleado.TabIndex = 18;
            btnAgregarEmpleado.Text = "Agregar";
            btnAgregarEmpleado.UseVisualStyleBackColor = true;
            btnAgregarEmpleado.Click += btnAgregarEmpleado_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnActualizar.Location = new Point(258, 190);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 17;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnAgrearTipoEmpleado
            // 
            btnAgrearTipoEmpleado.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAgrearTipoEmpleado.Location = new Point(823, 61);
            btnAgrearTipoEmpleado.Name = "btnAgrearTipoEmpleado";
            btnAgrearTipoEmpleado.Size = new Size(162, 23);
            btnAgrearTipoEmpleado.TabIndex = 16;
            btnAgrearTipoEmpleado.Text = "Agregar Tipo de Empleado";
            btnAgrearTipoEmpleado.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSalir.Location = new Point(910, 190);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 15;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // cmbTipoEmpleado
            // 
            cmbTipoEmpleado.FormattingEnabled = true;
            cmbTipoEmpleado.Location = new Point(776, 22);
            cmbTipoEmpleado.Name = "cmbTipoEmpleado";
            cmbTipoEmpleado.Size = new Size(209, 23);
            cmbTipoEmpleado.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(681, 25);
            label7.Name = "label7";
            label7.Size = new Size(89, 15);
            label7.TabIndex = 13;
            label7.Text = "Tipo Empleado:";
            // 
            // txtContraseña
            // 
            txtContraseña.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtContraseña.Location = new Point(508, 106);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(147, 23);
            txtContraseña.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(427, 109);
            label6.Name = "label6";
            label6.Size = new Size(70, 15);
            label6.TabIndex = 11;
            label6.Text = "Contraseña:";
            // 
            // txtUsuario
            // 
            txtUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtUsuario.Location = new Point(508, 62);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(147, 23);
            txtUsuario.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(447, 65);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 9;
            label5.Text = "Usuario:";
            // 
            // dtFechaNacimiento
            // 
            dtFechaNacimiento.Location = new Point(164, 106);
            dtFechaNacimiento.Name = "dtFechaNacimiento";
            dtFechaNacimiento.Size = new Size(209, 23);
            dtFechaNacimiento.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(52, 109);
            label4.Name = "label4";
            label4.Size = new Size(106, 15);
            label4.TabIndex = 7;
            label4.Text = "Fecha Nacimiento:";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(164, 146);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(209, 23);
            txtCorreo.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(112, 149);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 5;
            label3.Text = "Correo:";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(164, 62);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(209, 23);
            txtTelefono.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(103, 65);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 3;
            label2.Text = "Teléfono:";
            // 
            // frmEmpleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1037, 542);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmEmpleados";
            Text = "frmEmpleados";
            Load += frmEmpleados_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private TextBox txtNombreEmpleado;
        private GroupBox groupBox1;
        private TextBox txtTelefono;
        private Label label2;
        private TextBox txtContraseña;
        private Label label6;
        private TextBox txtUsuario;
        private Label label5;
        private DateTimePicker dtFechaNacimiento;
        private Label label4;
        private TextBox txtCorreo;
        private Label label3;
        private Button btnSalir;
        private ComboBox cmbTipoEmpleado;
        private Label label7;
        private Button btnAgregarEmpleado;
        private Button btnActualizar;
        private Button btnAgrearTipoEmpleado;
    }
}