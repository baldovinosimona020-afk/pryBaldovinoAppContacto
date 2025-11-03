namespace pryBaldovinoAppContacto
{
    partial class frmAppContacto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAppContacto));
            txtContacto = new TextBox();
            lblContacto = new Label();
            lblTelefono = new Label();
            txtTelefono = new MaskedTextBox();
            btnGrabar = new Button();
            lstDatos = new ListBox();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // txtContacto
            // 
            txtContacto.Location = new Point(170, 43);
            txtContacto.Margin = new Padding(3, 4, 3, 4);
            txtContacto.Name = "txtContacto";
            txtContacto.Size = new Size(249, 27);
            txtContacto.TabIndex = 0;
            txtContacto.TextChanged += txtContacto_TextChanged;
            // 
            // lblContacto
            // 
            lblContacto.AutoSize = true;
            lblContacto.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblContacto.Location = new Point(39, 40);
            lblContacto.Name = "lblContacto";
            lblContacto.Size = new Size(93, 28);
            lblContacto.TabIndex = 1;
            lblContacto.Text = "Contacto";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTelefono.Location = new Point(39, 117);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(91, 28);
            lblTelefono.TabIndex = 2;
            lblTelefono.Text = "Teléfono";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(170, 115);
            txtTelefono.Margin = new Padding(3, 4, 3, 4);
            txtTelefono.Mask = "(999)000-0000";
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(249, 27);
            txtTelefono.TabIndex = 3;
            // 
            // btnGrabar
            // 
            btnGrabar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGrabar.Location = new Point(281, 179);
            btnGrabar.Margin = new Padding(3, 4, 3, 4);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(138, 37);
            btnGrabar.TabIndex = 4;
            btnGrabar.Text = "Grabar";
            btnGrabar.UseVisualStyleBackColor = true;
            btnGrabar.Click += btnGrabar_Click;
            // 
            // lstDatos
            // 
            lstDatos.FormattingEnabled = true;
            lstDatos.Location = new Point(39, 248);
            lstDatos.Margin = new Padding(3, 4, 3, 4);
            lstDatos.Name = "lstDatos";
            lstDatos.Size = new Size(380, 124);
            lstDatos.TabIndex = 5;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(136, 179);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(138, 37);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // frmAppContacto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(462, 400);
            Controls.Add(btnCancelar);
            Controls.Add(lstDatos);
            Controls.Add(btnGrabar);
            Controls.Add(txtTelefono);
            Controls.Add(lblTelefono);
            Controls.Add(lblContacto);
            Controls.Add(txtContacto);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "frmAppContacto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Aplicación de contacto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtContacto;
        private Label lblContacto;
        private Label lblTelefono;
        private MaskedTextBox txtTelefono;
        private Button btnGrabar;
        private ListBox lstDatos;
        private Button btnCancelar;
    }
}