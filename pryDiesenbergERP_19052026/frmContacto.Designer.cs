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
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.cbRedes = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblRedes = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.chkActivo = new System.Windows.Forms.CheckBox();
            this.btnVolverAdmin = new System.Windows.Forms.Button();
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
            this.gbContacto.Location = new System.Drawing.Point(14, 16);
            this.gbContacto.Margin = new System.Windows.Forms.Padding(2);
            this.gbContacto.Name = "gbContacto";
            this.gbContacto.Padding = new System.Windows.Forms.Padding(2);
            this.gbContacto.Size = new System.Drawing.Size(360, 209);
            this.gbContacto.TabIndex = 0;
            this.gbContacto.TabStop = false;
            this.gbContacto.Text = "Contacto";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(168, 84);
            this.maskedTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(136, 23);
            this.maskedTextBox1.TabIndex = 7;
            // 
            // cbRedes
            // 
            this.cbRedes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRedes.FormattingEnabled = true;
            this.cbRedes.Items.AddRange(new object[] {
            "Facebook",
            "Instagram",
            "Twitter",
            "Tik Tok"});
            this.cbRedes.Location = new System.Drawing.Point(166, 146);
            this.cbRedes.Margin = new System.Windows.Forms.Padding(2);
            this.cbRedes.Name = "cbRedes";
            this.cbRedes.Size = new System.Drawing.Size(138, 24);
            this.cbRedes.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(168, 24);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(165, 23);
            this.textBox1.TabIndex = 4;
            // 
            // lblRedes
            // 
            this.lblRedes.AutoSize = true;
            this.lblRedes.Location = new System.Drawing.Point(10, 150);
            this.lblRedes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRedes.Name = "lblRedes";
            this.lblRedes.Size = new System.Drawing.Size(106, 17);
            this.lblRedes.TabIndex = 2;
            this.lblRedes.Text = "Redes Sociales";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(10, 88);
            this.lblTelefono.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(64, 17);
            this.lblTelefono.TabIndex = 1;
            this.lblTelefono.Text = "Teléfono";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(10, 28);
            this.lblMail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(33, 17);
            this.lblMail.TabIndex = 0;
            this.lblMail.Text = "Mail";
            // 
            // chkActivo
            // 
            this.chkActivo.AutoSize = true;
            this.chkActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkActivo.Location = new System.Drawing.Point(314, 244);
            this.chkActivo.Margin = new System.Windows.Forms.Padding(2);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(65, 21);
            this.chkActivo.TabIndex = 2;
            this.chkActivo.Text = "Activo";
            this.chkActivo.UseVisualStyleBackColor = true;
            // 
            // btnVolverAdmin
            // 
            this.btnVolverAdmin.Location = new System.Drawing.Point(124, 305);
            this.btnVolverAdmin.Name = "btnVolverAdmin";
            this.btnVolverAdmin.Size = new System.Drawing.Size(140, 23);
            this.btnVolverAdmin.TabIndex = 4;
            this.btnVolverAdmin.Text = "Volver a Administrador";
            this.btnVolverAdmin.UseVisualStyleBackColor = true;
            this.btnVolverAdmin.Click += new System.EventHandler(this.BtnVolverAdmin_Click);
            // 
            // frmContacto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 340);
            this.Controls.Add(this.btnVolverAdmin);
            this.Controls.Add(this.chkActivo);
            this.Controls.Add(this.gbContacto);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmContacto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contacto";
            this.Load += new System.EventHandler(this.frmContacto_Load);
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
        private System.Windows.Forms.Button btnVolverAdmin;
    }
}