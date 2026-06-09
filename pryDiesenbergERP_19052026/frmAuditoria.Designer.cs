namespace pryDiesenbergERP_19052026
{
    partial class frmAuditoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAuditoria));
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblIntento = new System.Windows.Forms.Label();
            this.dgvAuditoria = new System.Windows.Forms.DataGridView();
            this.cmbUsuario = new System.Windows.Forms.ComboBox();
            this.cmbIntento = new System.Windows.Forms.ComboBox();
            this.btnMostrarTodo = new System.Windows.Forms.Button();
            this.btnVolverAdmin = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblEstado = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuditoria)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(15, 18);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(57, 17);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblIntento
            // 
            this.lblIntento.AutoSize = true;
            this.lblIntento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntento.Location = new System.Drawing.Point(15, 65);
            this.lblIntento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIntento.Name = "lblIntento";
            this.lblIntento.Size = new System.Drawing.Size(51, 17);
            this.lblIntento.TabIndex = 1;
            this.lblIntento.Text = "Intento";
            // 
            // dgvAuditoria
            // 
            this.dgvAuditoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAuditoria.Location = new System.Drawing.Point(18, 100);
            this.dgvAuditoria.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvAuditoria.Name = "dgvAuditoria";
            this.dgvAuditoria.RowHeadersWidth = 82;
            this.dgvAuditoria.RowTemplate.Height = 33;
            this.dgvAuditoria.Size = new System.Drawing.Size(446, 233);
            this.dgvAuditoria.TabIndex = 2;
            // 
            // cmbUsuario
            // 
            this.cmbUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUsuario.FormattingEnabled = true;
            this.cmbUsuario.Location = new System.Drawing.Point(238, 18);
            this.cmbUsuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbUsuario.Name = "cmbUsuario";
            this.cmbUsuario.Size = new System.Drawing.Size(228, 24);
            this.cmbUsuario.TabIndex = 3;
            // 
            // cmbIntento
            // 
            this.cmbIntento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIntento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbIntento.FormattingEnabled = true;
            this.cmbIntento.Location = new System.Drawing.Point(318, 65);
            this.cmbIntento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbIntento.Name = "cmbIntento";
            this.cmbIntento.Size = new System.Drawing.Size(148, 24);
            this.cmbIntento.TabIndex = 4;
            // 
            // btnMostrarTodo
            // 
            this.btnMostrarTodo.Location = new System.Drawing.Point(379, 360);
            this.btnMostrarTodo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMostrarTodo.Name = "btnMostrarTodo";
            this.btnMostrarTodo.Size = new System.Drawing.Size(85, 29);
            this.btnMostrarTodo.TabIndex = 6;
            this.btnMostrarTodo.Text = "Mostrar Todo";
            this.btnMostrarTodo.UseVisualStyleBackColor = true;
            this.btnMostrarTodo.Click += new System.EventHandler(this.btnMostrarTodo_Click);
            // 
            // btnVolverAdmin
            // 
            this.btnVolverAdmin.Location = new System.Drawing.Point(18, 355);
            this.btnVolverAdmin.Name = "btnVolverAdmin";
            this.btnVolverAdmin.Size = new System.Drawing.Size(118, 40);
            this.btnVolverAdmin.TabIndex = 7;
            this.btnVolverAdmin.Text = "Volver a Administrador";
            this.btnVolverAdmin.UseVisualStyleBackColor = true;
            this.btnVolverAdmin.Click += new System.EventHandler(this.BtnVolverAdmin_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblEstado});
            this.statusStrip1.Location = new System.Drawing.Point(0, 434);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 7, 0);
            this.statusStrip1.Size = new System.Drawing.Size(488, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblEstado
            // 
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(113, 17);
            this.lblEstado.Text = "Estado Conexión BD";
            // 
            // frmAuditoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(488, 456);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnVolverAdmin);
            this.Controls.Add(this.btnMostrarTodo);
            this.Controls.Add(this.cmbIntento);
            this.Controls.Add(this.cmbUsuario);
            this.Controls.Add(this.dgvAuditoria);
            this.Controls.Add(this.lblIntento);
            this.Controls.Add(this.lblUsuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmAuditoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auditoría";
            this.Load += new System.EventHandler(this.frmAuditoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuditoria)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblIntento;
        private System.Windows.Forms.DataGridView dgvAuditoria;
        private System.Windows.Forms.ComboBox cmbUsuario;
        private System.Windows.Forms.ComboBox cmbIntento;
        private System.Windows.Forms.Button btnMostrarTodo;
        private System.Windows.Forms.Button btnVolverAdmin;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblEstado;
    }
}