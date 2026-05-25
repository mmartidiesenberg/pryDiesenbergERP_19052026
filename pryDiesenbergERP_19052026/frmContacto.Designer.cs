namespace pryDiesenbergERP_19052026
{
    partial class frmContacto
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
            this.gbContacto = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblRedes = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cbRedes = new System.Windows.Forms.ComboBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.chkActivo = new System.Windows.Forms.CheckBox();
            this.gbContacto.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbContacto
            // 
            this.gbContacto.Controls.Add(this.maskedTextBox1);
            this.gbContacto.Controls.Add(this.cbRedes);
            this.gbContacto.Controls.Add(this.textBox1);
            this.gbContacto.Controls.Add(this.lblRedes);
            this.gbContacto.Controls.Add(this.lblTelefono);
            this.gbContacto.Controls.Add(this.lblMail);
            this.gbContacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbContacto.Location = new System.Drawing.Point(29, 31);
            this.gbContacto.Name = "gbContacto";
            this.gbContacto.Size = new System.Drawing.Size(721, 401);
            this.gbContacto.TabIndex = 0;
            this.gbContacto.TabStop = false;
            this.gbContacto.Text = "Contacto";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(19, 53);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(63, 31);
            this.lblMail.TabIndex = 0;
            this.lblMail.Text = "Mail";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(19, 169);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(120, 31);
            this.lblTelefono.TabIndex = 1;
            this.lblTelefono.Text = "Teléfono";
            // 
            // lblRedes
            // 
            this.lblRedes.AutoSize = true;
            this.lblRedes.Location = new System.Drawing.Point(19, 289);
            this.lblRedes.Name = "lblRedes";
            this.lblRedes.Size = new System.Drawing.Size(203, 31);
            this.lblRedes.TabIndex = 2;
            this.lblRedes.Text = "Redes Sociales";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(336, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(326, 38);
            this.textBox1.TabIndex = 4;
            // 
            // cbRedes
            // 
            this.cbRedes.FormattingEnabled = true;
            this.cbRedes.Items.AddRange(new object[] {
            "Facebook",
            "Instagram",
            "Twitter",
            "Tik Tok"});
            this.cbRedes.Location = new System.Drawing.Point(331, 281);
            this.cbRedes.Name = "cbRedes";
            this.cbRedes.Size = new System.Drawing.Size(273, 39);
            this.cbRedes.TabIndex = 6;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(336, 162);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(268, 38);
            this.maskedTextBox1.TabIndex = 7;
            // 
            // chkActivo
            // 
            this.chkActivo.AutoSize = true;
            this.chkActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkActivo.Location = new System.Drawing.Point(629, 470);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(121, 35);
            this.chkActivo.TabIndex = 2;
            this.chkActivo.Text = "Activo";
            this.chkActivo.UseVisualStyleBackColor = true;
            // 
            // frmContacto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 653);
            this.Controls.Add(this.chkActivo);
            this.Controls.Add(this.gbContacto);
            this.Name = "frmContacto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contacto";
            this.gbContacto.ResumeLayout(false);
            this.gbContacto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbContacto;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.ComboBox cbRedes;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblRedes;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblMail;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.CheckBox chkActivo;
    }
}