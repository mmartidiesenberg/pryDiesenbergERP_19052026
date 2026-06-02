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
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.btnMostrarTodo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuditoria)).BeginInit();
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
            this.dgvAuditoria.Size = new System.Drawing.Size(390, 242);
            this.dgvAuditoria.TabIndex = 2;
            // 
            // cmbUsuario
            // 
            this.cmbUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUsuario.FormattingEnabled = true;
            this.cmbUsuario.Location = new System.Drawing.Point(182, 18);
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
            this.cmbIntento.Location = new System.Drawing.Point(262, 65);
            this.cmbIntento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbIntento.Name = "cmbIntento";
            this.cmbIntento.Size = new System.Drawing.Size(148, 24);
            this.cmbIntento.TabIndex = 4;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(24, 366);
            this.btnFiltrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(85, 29);
            this.btnFiltrar.TabIndex = 5;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // btnMostrarTodo
            // 
            this.btnMostrarTodo.Location = new System.Drawing.Point(323, 366);
            this.btnMostrarTodo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMostrarTodo.Name = "btnMostrarTodo";
            this.btnMostrarTodo.Size = new System.Drawing.Size(85, 29);
            this.btnMostrarTodo.TabIndex = 6;
            this.btnMostrarTodo.Text = "Mostrar Todo";
            this.btnMostrarTodo.UseVisualStyleBackColor = true;
            this.btnMostrarTodo.Click += new System.EventHandler(this.btnMostrarTodo_Click);
            // 
            // frmAuditoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 425);
            this.Controls.Add(this.btnMostrarTodo);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.cmbIntento);
            this.Controls.Add(this.cmbUsuario);
            this.Controls.Add(this.dgvAuditoria);
            this.Controls.Add(this.lblIntento);
            this.Controls.Add(this.lblUsuario);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmAuditoria";
            this.Text = "Auditoría";
            this.Load += new System.EventHandler(this.frmAuditoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuditoria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblIntento;
        private System.Windows.Forms.DataGridView dgvAuditoria;
        private System.Windows.Forms.ComboBox cmbUsuario;
        private System.Windows.Forms.ComboBox cmbIntento;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Button btnMostrarTodo;
    }
}