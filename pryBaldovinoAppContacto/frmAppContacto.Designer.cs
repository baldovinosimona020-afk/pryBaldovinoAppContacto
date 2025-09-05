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
            txtContacto.Location = new Point(114, 36);
            txtContacto.Name = "txtContacto";
            txtContacto.Size = new Size(248, 23);
            txtContacto.TabIndex = 0;
            // 
            // lblContacto
            // 
            lblContacto.AutoSize = true;
            lblContacto.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblContacto.Location = new Point(29, 34);
            lblContacto.Name = "lblContacto";
            lblContacto.Size = new Size(77, 21);
            lblContacto.TabIndex = 1;
            lblContacto.Text = "Contacto";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTelefono.Location = new Point(29, 92);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(74, 21);
            lblTelefono.TabIndex = 2;
            lblTelefono.Text = "Teléfono";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(114, 90);
            txtTelefono.Mask = "(999)000-0000";
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(248, 23);
            txtTelefono.TabIndex = 3;
            // 
            // btnGrabar
            // 
            btnGrabar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGrabar.Location = new Point(241, 138);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(121, 28);
            btnGrabar.TabIndex = 4;
            btnGrabar.Text = "Grabar";
            btnGrabar.UseVisualStyleBackColor = true;
            btnGrabar.Click += btnGrabar_Click;
            // 
            // lstDatos
            // 
            lstDatos.FormattingEnabled = true;
            lstDatos.ItemHeight = 15;
            lstDatos.Location = new Point(29, 193);
            lstDatos.Name = "lstDatos";
            lstDatos.Size = new Size(333, 94);
            lstDatos.TabIndex = 5;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(114, 138);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(121, 28);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // frmAppContacto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(383, 309);
            Controls.Add(btnCancelar);
            Controls.Add(lstDatos);
            Controls.Add(btnGrabar);
            Controls.Add(txtTelefono);
            Controls.Add(lblTelefono);
            Controls.Add(lblContacto);
            Controls.Add(txtContacto);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmAppContacto";
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