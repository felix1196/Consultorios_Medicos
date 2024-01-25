namespace CapaEnlacePresentacion
{
    partial class frmPrincipal
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
            pnlButtons = new Panel();
            btnModulos = new Button();
            btnEmpleados = new Button();
            pbLogo = new PictureBox();
            pnlPrincipal = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            pnlButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            pnlPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnlButtons
            // 
            pnlButtons.BackColor = SystemColors.ActiveCaption;
            pnlButtons.Controls.Add(btnModulos);
            pnlButtons.Controls.Add(btnEmpleados);
            pnlButtons.Controls.Add(pbLogo);
            pnlButtons.Dock = DockStyle.Left;
            pnlButtons.Location = new Point(0, 0);
            pnlButtons.Name = "pnlButtons";
            pnlButtons.Size = new Size(185, 716);
            pnlButtons.TabIndex = 0;
            // 
            // btnModulos
            // 
            btnModulos.Dock = DockStyle.Top;
            btnModulos.FlatAppearance.BorderSize = 0;
            btnModulos.FlatStyle = FlatStyle.Flat;
            btnModulos.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnModulos.ImageAlign = ContentAlignment.MiddleRight;
            btnModulos.Location = new Point(0, 120);
            btnModulos.Name = "btnModulos";
            btnModulos.Size = new Size(185, 31);
            btnModulos.TabIndex = 5;
            btnModulos.Text = "Modulos";
            btnModulos.TextAlign = ContentAlignment.MiddleLeft;
            btnModulos.UseVisualStyleBackColor = true;
            // 
            // btnEmpleados
            // 
            btnEmpleados.Dock = DockStyle.Top;
            btnEmpleados.FlatAppearance.BorderSize = 0;
            btnEmpleados.FlatStyle = FlatStyle.Flat;
            btnEmpleados.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnEmpleados.ImageAlign = ContentAlignment.MiddleRight;
            btnEmpleados.Location = new Point(0, 89);
            btnEmpleados.Name = "btnEmpleados";
            btnEmpleados.Size = new Size(185, 31);
            btnEmpleados.TabIndex = 4;
            btnEmpleados.Text = "Empleados";
            btnEmpleados.TextAlign = ContentAlignment.MiddleLeft;
            btnEmpleados.UseVisualStyleBackColor = true;
            btnEmpleados.Click += btnEmpleados_Click;
            // 
            // pbLogo
            // 
            pbLogo.BackColor = Color.White;
            pbLogo.BackgroundImage = Properties.Resources.salud_electronet;
            pbLogo.BackgroundImageLayout = ImageLayout.Zoom;
            pbLogo.Dock = DockStyle.Top;
            pbLogo.Location = new Point(0, 0);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(185, 89);
            pbLogo.TabIndex = 2;
            pbLogo.TabStop = false;
            // 
            // pnlPrincipal
            // 
            pnlPrincipal.Controls.Add(pictureBox1);
            pnlPrincipal.Controls.Add(label1);
            pnlPrincipal.Controls.Add(label2);
            pnlPrincipal.Dock = DockStyle.Fill;
            pnlPrincipal.Location = new Point(185, 0);
            pnlPrincipal.Name = "pnlPrincipal";
            pnlPrincipal.Size = new Size(1169, 716);
            pnlPrincipal.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.salud_electronet;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(468, 161);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(276, 247);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Edwardian Script ITC", 54.75F, FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaption;
            label1.Location = new Point(335, 398);
            label1.Name = "label1";
            label1.Size = new Size(486, 86);
            label1.TabIndex = 4;
            label1.Text = "Consultorios Medicos\r\n";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaption;
            label2.Location = new Point(450, 477);
            label2.Name = "label2";
            label2.Size = new Size(313, 42);
            label2.TabIndex = 5;
            label2.Text = "- ELECTRONET -";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1354, 716);
            Controls.Add(pnlPrincipal);
            Controls.Add(pnlButtons);
            MinimumSize = new Size(1364, 736);
            Name = "frmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consultorios Medicos";
            WindowState = FormWindowState.Maximized;
            Load += frmPrincipal_Load;
            pnlButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            pnlPrincipal.ResumeLayout(false);
            pnlPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel pnlButtons;
        private Panel pnlPrincipal;
        private Label label1;
        private Label label2;
        private PictureBox pbLogo;
        private Button btnModulos;
        private Button btnEmpleados;
    }
}