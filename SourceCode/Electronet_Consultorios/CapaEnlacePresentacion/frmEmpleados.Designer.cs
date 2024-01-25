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
            btnAgregarTipoUsuario = new Button();
            btnSalir = new Button();
            comboBox1 = new ComboBox();
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
            dataGridView1.Location = new Point(12, 220);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1013, 310);
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
            groupBox1.Controls.Add(btnAgregarTipoUsuario);
            groupBox1.Controls.Add(btnSalir);
            groupBox1.Controls.Add(comboBox1);
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
            groupBox1.Size = new Size(1013, 202);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Empleados";
            // 
            // btnAgregarTipoUsuario
            // 
            btnAgregarTipoUsuario.Location = new Point(391, 147);
            btnAgregarTipoUsuario.Name = "btnAgregarTipoUsuario";
            btnAgregarTipoUsuario.Size = new Size(146, 25);
            btnAgregarTipoUsuario.TabIndex = 16;
            btnAgregarTipoUsuario.Text = "Agregar Tipo Empleado";
            btnAgregarTipoUsuario.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSalir.Location = new Point(932, 173);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 15;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(164, 147);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(209, 23);
            comboBox1.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(69, 150);
            label7.Name = "label7";
            label7.Size = new Size(89, 15);
            label7.TabIndex = 13;
            label7.Text = "Tipo Empleado:";
            // 
            // txtContraseña
            // 
            txtContraseña.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtContraseña.Location = new Point(765, 62);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(147, 23);
            txtContraseña.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(684, 65);
            label6.Name = "label6";
            label6.Size = new Size(70, 15);
            label6.TabIndex = 11;
            label6.Text = "Contraseña:";
            // 
            // txtUsuario
            // 
            txtUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtUsuario.Location = new Point(765, 22);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(147, 23);
            txtUsuario.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(704, 25);
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
            txtCorreo.Location = new Point(446, 62);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(209, 23);
            txtCorreo.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(394, 65);
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
        private ComboBox comboBox1;
        private Label label7;
        private Button btnAgregarTipoUsuario;
    }
}