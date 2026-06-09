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
            this.lblUsuario.Location = new System.Drawing.Point(30, 35);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(108, 31);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblIntento
            // 
            this.lblIntento.AutoSize = true;
            this.lblIntento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntento.Location = new System.Drawing.Point(30, 125);
            this.lblIntento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIntento.Name = "lblIntento";
            this.lblIntento.Size = new System.Drawing.Size(98, 31);
            this.lblIntento.TabIndex = 1;
            this.lblIntento.Text = "Intento";
            // 
            // dgvAuditoria
            // 
            this.dgvAuditoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAuditoria.Location = new System.Drawing.Point(36, 192);
            this.dgvAuditoria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvAuditoria.Name = "dgvAuditoria";
            this.dgvAuditoria.RowHeadersWidth = 82;
            this.dgvAuditoria.RowTemplate.Height = 33;
            this.dgvAuditoria.Size = new System.Drawing.Size(892, 448);
            this.dgvAuditoria.TabIndex = 2;
            // 
            // cmbUsuario
            // 
            this.cmbUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUsuario.FormattingEnabled = true;
            this.cmbUsuario.Location = new System.Drawing.Point(476, 35);
            this.cmbUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbUsuario.Name = "cmbUsuario";
            this.cmbUsuario.Size = new System.Drawing.Size(452, 39);
            this.cmbUsuario.TabIndex = 3;
            // 
            // cmbIntento
            // 
            this.cmbIntento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIntento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbIntento.FormattingEnabled = true;
            this.cmbIntento.Location = new System.Drawing.Point(636, 125);
            this.cmbIntento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbIntento.Name = "cmbIntento";
            this.cmbIntento.Size = new System.Drawing.Size(292, 39);
            this.cmbIntento.TabIndex = 4;
            // 
            // btnMostrarTodo
            // 
            this.btnMostrarTodo.Location = new System.Drawing.Point(758, 693);
            this.btnMostrarTodo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMostrarTodo.Name = "btnMostrarTodo";
            this.btnMostrarTodo.Size = new System.Drawing.Size(170, 56);
            this.btnMostrarTodo.TabIndex = 6;
            this.btnMostrarTodo.Text = "Mostrar Todo";
            this.btnMostrarTodo.UseVisualStyleBackColor = true;
            this.btnMostrarTodo.Click += new System.EventHandler(this.btnMostrarTodo_Click);
            // 
            // btnVolverAdmin
            // 
            this.btnVolverAdmin.Location = new System.Drawing.Point(36, 683);
            this.btnVolverAdmin.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnVolverAdmin.Name = "btnVolverAdmin";
            this.btnVolverAdmin.Size = new System.Drawing.Size(236, 77);
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 834);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(976, 42);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblEstado
            // 
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(230, 32);
            this.lblEstado.Text = "Estado Conexión BD";
            // 
            // frmAuditoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 876);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnVolverAdmin);
            this.Controls.Add(this.btnMostrarTodo);
            this.Controls.Add(this.cmbIntento);
            this.Controls.Add(this.cmbUsuario);
            this.Controls.Add(this.dgvAuditoria);
            this.Controls.Add(this.lblIntento);
            this.Controls.Add(this.lblUsuario);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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