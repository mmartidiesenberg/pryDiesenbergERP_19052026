namespace pryDiesenbergERP_19052026
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblEstado = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblPerfil = new System.Windows.Forms.Label();
            this.lblFechaHora = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnVolverAdmin = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsUserMenu = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmiModificarPass = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFuncionalidades = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCerrarSesion = new System.Windows.Forms.ToolStripMenuItem();
            this.lblIngUsuario = new System.Windows.Forms.Label();
            this.lblIngPerfil = new System.Windows.Forms.Label();
            this.lblIngFechaHora = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblEstado});
            this.statusStrip1.Location = new System.Drawing.Point(0, 692);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1201, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "Estado Conexión BD";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(113, 17);
            this.toolStripStatusLabel1.Text = "Estado Conexión BD";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // lblEstado
            // 
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(0, 17);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(741, 425);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(57, 17);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblPerfil
            // 
            this.lblPerfil.AutoSize = true;
            this.lblPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerfil.Location = new System.Drawing.Point(741, 491);
            this.lblPerfil.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPerfil.Name = "lblPerfil";
            this.lblPerfil.Size = new System.Drawing.Size(40, 17);
            this.lblPerfil.TabIndex = 2;
            this.lblPerfil.Text = "Perfil";
            // 
            // lblFechaHora
            // 
            this.lblFechaHora.AutoSize = true;
            this.lblFechaHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaHora.Location = new System.Drawing.Point(741, 551);
            this.lblFechaHora.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFechaHora.Name = "lblFechaHora";
            this.lblFechaHora.Size = new System.Drawing.Size(93, 17);
            this.lblFechaHora.TabIndex = 3;
            this.lblFechaHora.Text = "Fecha y Hora";
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(642, 607);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(101, 39);
            this.btnVolver.TabIndex = 4;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnVolverAdmin
            // 
            this.btnVolverAdmin.Location = new System.Drawing.Point(629, 606);
            this.btnVolverAdmin.Name = "btnVolverAdmin";
            this.btnVolverAdmin.Size = new System.Drawing.Size(127, 40);
            this.btnVolverAdmin.TabIndex = 5;
            this.btnVolverAdmin.Text = "Volver a Administrador";
            this.btnVolverAdmin.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsUserMenu});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(1201, 25);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsUserMenu
            // 
            this.tsUserMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsUserMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiModificarPass,
            this.tsmiFuncionalidades,
            this.tsmiCerrarSesion});
            this.tsUserMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsUserMenu.Name = "tsUserMenu";
            this.tsUserMenu.Size = new System.Drawing.Size(98, 22);
            this.tsUserMenu.Text = "Usuario (perfil)";
            // 
            // tsmiModificarPass
            // 
            this.tsmiModificarPass.Name = "tsmiModificarPass";
            this.tsmiModificarPass.Size = new System.Drawing.Size(188, 22);
            this.tsmiModificarPass.Text = "Modificar Contraseña";
            // 
            // tsmiFuncionalidades
            // 
            this.tsmiFuncionalidades.Name = "tsmiFuncionalidades";
            this.tsmiFuncionalidades.Size = new System.Drawing.Size(188, 22);
            this.tsmiFuncionalidades.Text = "Funcionalidades";
            this.tsmiFuncionalidades.Click += new System.EventHandler(this.TsmiFuncionalidades_Click);
            // 
            // tsmiCerrarSesion
            // 
            this.tsmiCerrarSesion.Name = "tsmiCerrarSesion";
            this.tsmiCerrarSesion.Size = new System.Drawing.Size(188, 22);
            this.tsmiCerrarSesion.Text = "Cerrar sesión";
            // 
            // lblIngUsuario
            // 
            this.lblIngUsuario.AutoSize = true;
            this.lblIngUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngUsuario.Location = new System.Drawing.Point(507, 425);
            this.lblIngUsuario.Name = "lblIngUsuario";
            this.lblIngUsuario.Size = new System.Drawing.Size(72, 18);
            this.lblIngUsuario.TabIndex = 7;
            this.lblIngUsuario.Text = "Usuario:";
            this.lblIngUsuario.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblIngPerfil
            // 
            this.lblIngPerfil.AutoSize = true;
            this.lblIngPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngPerfil.Location = new System.Drawing.Point(507, 491);
            this.lblIngPerfil.Name = "lblIngPerfil";
            this.lblIngPerfil.Size = new System.Drawing.Size(52, 18);
            this.lblIngPerfil.TabIndex = 8;
            this.lblIngPerfil.Text = "Perfil:";
            this.lblIngPerfil.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblIngFechaHora
            // 
            this.lblIngFechaHora.AutoSize = true;
            this.lblIngFechaHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngFechaHora.Location = new System.Drawing.Point(507, 551);
            this.lblIngFechaHora.Name = "lblIngFechaHora";
            this.lblIngFechaHora.Size = new System.Drawing.Size(198, 18);
            this.lblIngFechaHora.TabIndex = 9;
            this.lblIngFechaHora.Text = "Fecha y Hora de Ingreso:";
            this.lblIngFechaHora.Click += new System.EventHandler(this.label3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::pryDiesenbergERP_19052026.Properties.Resources.network_enterprise_business_shopping_1731;
            this.pictureBox1.Location = new System.Drawing.Point(508, 130);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(363, 261);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1201, 714);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblIngFechaHora);
            this.Controls.Add(this.lblIngPerfil);
            this.Controls.Add(this.lblIngUsuario);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnVolverAdmin);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblFechaHora);
            this.Controls.Add(this.lblPerfil);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal ERP";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblEstado;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblPerfil;
        private System.Windows.Forms.Label lblFechaHora;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnVolverAdmin;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton tsUserMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmiModificarPass;
        private System.Windows.Forms.ToolStripMenuItem tsmiFuncionalidades;
        private System.Windows.Forms.ToolStripMenuItem tsmiCerrarSesion;
        private System.Windows.Forms.Label lblIngUsuario;
        private System.Windows.Forms.Label lblIngPerfil;
        private System.Windows.Forms.Label lblIngFechaHora;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

