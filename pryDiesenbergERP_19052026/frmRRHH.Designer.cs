namespace pryDiesenbergERP_19052026
{
    partial class frmRRHH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRRHH));
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.cmbPerfil = new System.Windows.Forms.ComboBox();
            this.lblPerfil = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.lblDNI = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.gbDomicilio = new System.Windows.Forms.GroupBox();
            this.btnAgregarDireccion = new System.Windows.Forms.Button();
            this.lstDirecciones = new System.Windows.Forms.ListBox();
            this.cmbProvincia = new System.Windows.Forms.ComboBox();
            this.cmbLocalidad = new System.Windows.Forms.ComboBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblProvincia = new System.Windows.Forms.Label();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.chkActivo = new System.Windows.Forms.CheckBox();
            this.txtContrasenia = new System.Windows.Forms.TextBox();
            this.lblContrasenia = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnVolverAdmin = new System.Windows.Forms.Button();
            this.btnEliminarUsuario = new System.Windows.Forms.Button();
            this.gbContacto = new System.Windows.Forms.GroupBox();
            this.chkVer = new System.Windows.Forms.CheckBox();
            this.lstTelefonos = new System.Windows.Forms.ListBox();
            this.btnAgregarTelefonos = new System.Windows.Forms.Button();
            this.txtGmail = new System.Windows.Forms.TextBox();
            this.mskTelefono = new System.Windows.Forms.MaskedTextBox();
            this.cmbRedes = new System.Windows.Forms.ComboBox();
            this.lblRedes = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblEstado = new System.Windows.Forms.ToolStripStatusLabel();
            this.gbDatos.SuspendLayout();
            this.gbDomicilio.SuspendLayout();
            this.gbContacto.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.cmbPerfil);
            this.gbDatos.Controls.Add(this.lblPerfil);
            this.gbDatos.Controls.Add(this.txtNombre);
            this.gbDatos.Controls.Add(this.txtApellido);
            this.gbDatos.Controls.Add(this.txtDNI);
            this.gbDatos.Controls.Add(this.lblDNI);
            this.gbDatos.Controls.Add(this.lblApellido);
            this.gbDatos.Controls.Add(this.lblNombre);
            this.gbDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatos.Location = new System.Drawing.Point(42, 23);
            this.gbDatos.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gbDatos.Size = new System.Drawing.Size(530, 460);
            this.gbDatos.TabIndex = 0;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Datos Personales";
            // 
            // cmbPerfil
            // 
            this.cmbPerfil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPerfil.FormattingEnabled = true;
            this.cmbPerfil.Items.AddRange(new object[] {
            "Vendedor",
            "Invitado",
            "Diseñador",
            "Recursos Humanos",
            "Cliente",
            "Administrador",
            "Editor",
            "Programador",
            "Analista",
            "Supervisor"});
            this.cmbPerfil.Location = new System.Drawing.Point(276, 365);
            this.cmbPerfil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbPerfil.Name = "cmbPerfil";
            this.cmbPerfil.Size = new System.Drawing.Size(196, 39);
            this.cmbPerfil.TabIndex = 3;
            // 
            // lblPerfil
            // 
            this.lblPerfil.AutoSize = true;
            this.lblPerfil.Location = new System.Drawing.Point(22, 373);
            this.lblPerfil.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPerfil.Name = "lblPerfil";
            this.lblPerfil.Size = new System.Drawing.Size(76, 31);
            this.lblPerfil.TabIndex = 11;
            this.lblPerfil.Text = "Perfil";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(276, 265);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(196, 38);
            this.txtNombre.TabIndex = 10;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(276, 171);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(196, 38);
            this.txtApellido.TabIndex = 9;
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(276, 73);
            this.txtDNI.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(196, 38);
            this.txtDNI.TabIndex = 8;
            this.txtDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDNI_KeyPress);
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(22, 79);
            this.lblDNI.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(62, 31);
            this.lblDNI.TabIndex = 0;
            this.lblDNI.Text = "DNI";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(22, 185);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(110, 31);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(22, 279);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(110, 31);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // gbDomicilio
            // 
            this.gbDomicilio.Controls.Add(this.btnAgregarDireccion);
            this.gbDomicilio.Controls.Add(this.lstDirecciones);
            this.gbDomicilio.Controls.Add(this.cmbProvincia);
            this.gbDomicilio.Controls.Add(this.cmbLocalidad);
            this.gbDomicilio.Controls.Add(this.txtDireccion);
            this.gbDomicilio.Controls.Add(this.lblProvincia);
            this.gbDomicilio.Controls.Add(this.lblLocalidad);
            this.gbDomicilio.Controls.Add(this.lblDireccion);
            this.gbDomicilio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDomicilio.Location = new System.Drawing.Point(630, 23);
            this.gbDomicilio.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gbDomicilio.Name = "gbDomicilio";
            this.gbDomicilio.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gbDomicilio.Size = new System.Drawing.Size(978, 460);
            this.gbDomicilio.TabIndex = 1;
            this.gbDomicilio.TabStop = false;
            this.gbDomicilio.Text = "Domicilio";
            this.gbDomicilio.Enter += new System.EventHandler(this.gbDomicilio_Enter);
            // 
            // btnAgregarDireccion
            // 
            this.btnAgregarDireccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarDireccion.Location = new System.Drawing.Point(542, 37);
            this.btnAgregarDireccion.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnAgregarDireccion.Name = "btnAgregarDireccion";
            this.btnAgregarDireccion.Size = new System.Drawing.Size(271, 67);
            this.btnAgregarDireccion.TabIndex = 56;
            this.btnAgregarDireccion.Text = "+ Agregar Dirección";
            this.btnAgregarDireccion.UseVisualStyleBackColor = true;
            this.btnAgregarDireccion.Click += new System.EventHandler(this.btnAgregarDireccion_Click);
            // 
            // lstDirecciones
            // 
            this.lstDirecciones.FormattingEnabled = true;
            this.lstDirecciones.ItemHeight = 31;
            this.lstDirecciones.Location = new System.Drawing.Point(542, 115);
            this.lstDirecciones.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.lstDirecciones.Name = "lstDirecciones";
            this.lstDirecciones.Size = new System.Drawing.Size(398, 283);
            this.lstDirecciones.TabIndex = 55;
            this.lstDirecciones.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // cmbProvincia
            // 
            this.cmbProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProvincia.FormattingEnabled = true;
            this.cmbProvincia.Location = new System.Drawing.Point(286, 246);
            this.cmbProvincia.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cmbProvincia.Name = "cmbProvincia";
            this.cmbProvincia.Size = new System.Drawing.Size(196, 39);
            this.cmbProvincia.TabIndex = 14;
            this.cmbProvincia.SelectedIndexChanged += new System.EventHandler(this.cmbProvincia_SelectedIndexChanged);
            // 
            // cmbLocalidad
            // 
            this.cmbLocalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLocalidad.FormattingEnabled = true;
            this.cmbLocalidad.Location = new System.Drawing.Point(286, 375);
            this.cmbLocalidad.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cmbLocalidad.Name = "cmbLocalidad";
            this.cmbLocalidad.Size = new System.Drawing.Size(196, 39);
            this.cmbLocalidad.TabIndex = 13;
            this.cmbLocalidad.SelectedIndexChanged += new System.EventHandler(this.cmbLocalidad_SelectedIndexChanged);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(286, 117);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(196, 38);
            this.txtDireccion.TabIndex = 11;
            // 
            // lblProvincia
            // 
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.Location = new System.Drawing.Point(22, 260);
            this.lblProvincia.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(126, 31);
            this.lblProvincia.TabIndex = 7;
            this.lblProvincia.Text = "Provincia";
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Location = new System.Drawing.Point(22, 387);
            this.lblLocalidad.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(130, 31);
            this.lblLocalidad.TabIndex = 6;
            this.lblLocalidad.Text = "Localidad";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(26, 129);
            this.lblDireccion.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(128, 31);
            this.lblDireccion.TabIndex = 4;
            this.lblDireccion.Text = "Dirección";
            // 
            // chkActivo
            // 
            this.chkActivo.AutoSize = true;
            this.chkActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkActivo.Location = new System.Drawing.Point(572, 467);
            this.chkActivo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(121, 35);
            this.chkActivo.TabIndex = 54;
            this.chkActivo.Text = "Activo";
            this.chkActivo.UseVisualStyleBackColor = true;
            // 
            // txtContrasenia
            // 
            this.txtContrasenia.Location = new System.Drawing.Point(340, 187);
            this.txtContrasenia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtContrasenia.Name = "txtContrasenia";
            this.txtContrasenia.Size = new System.Drawing.Size(354, 38);
            this.txtContrasenia.TabIndex = 5;
            this.txtContrasenia.UseSystemPasswordChar = true;
            // 
            // lblContrasenia
            // 
            this.lblContrasenia.AutoSize = true;
            this.lblContrasenia.Location = new System.Drawing.Point(54, 198);
            this.lblContrasenia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContrasenia.Name = "lblContrasenia";
            this.lblContrasenia.Size = new System.Drawing.Size(155, 31);
            this.lblContrasenia.TabIndex = 0;
            this.lblContrasenia.Text = "Contraseña";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(1376, 679);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(232, 81);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar usuario";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnVolverAdmin
            // 
            this.btnVolverAdmin.Location = new System.Drawing.Point(42, 1087);
            this.btnVolverAdmin.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnVolverAdmin.Name = "btnVolverAdmin";
            this.btnVolverAdmin.Size = new System.Drawing.Size(280, 44);
            this.btnVolverAdmin.TabIndex = 50;
            this.btnVolverAdmin.Text = "Volver a Administrador";
            this.btnVolverAdmin.UseVisualStyleBackColor = true;
            this.btnVolverAdmin.Click += new System.EventHandler(this.BtnVolverAdmin_Click);
            // 
            // btnEliminarUsuario
            // 
            this.btnEliminarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarUsuario.Location = new System.Drawing.Point(1376, 842);
            this.btnEliminarUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminarUsuario.Name = "btnEliminarUsuario";
            this.btnEliminarUsuario.Size = new System.Drawing.Size(232, 81);
            this.btnEliminarUsuario.TabIndex = 51;
            this.btnEliminarUsuario.Text = "Eliminar Usuario";
            this.btnEliminarUsuario.UseVisualStyleBackColor = true;
            this.btnEliminarUsuario.Click += new System.EventHandler(this.btnEliminarUsuario_Click);
            // 
            // gbContacto
            // 
            this.gbContacto.Controls.Add(this.chkVer);
            this.gbContacto.Controls.Add(this.lstTelefonos);
            this.gbContacto.Controls.Add(this.btnAgregarTelefonos);
            this.gbContacto.Controls.Add(this.lblContrasenia);
            this.gbContacto.Controls.Add(this.txtContrasenia);
            this.gbContacto.Controls.Add(this.chkActivo);
            this.gbContacto.Controls.Add(this.txtGmail);
            this.gbContacto.Controls.Add(this.mskTelefono);
            this.gbContacto.Controls.Add(this.cmbRedes);
            this.gbContacto.Controls.Add(this.lblRedes);
            this.gbContacto.Controls.Add(this.lblTelefono);
            this.gbContacto.Controls.Add(this.lblMail);
            this.gbContacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbContacto.Location = new System.Drawing.Point(42, 492);
            this.gbContacto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbContacto.Name = "gbContacto";
            this.gbContacto.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbContacto.Size = new System.Drawing.Size(1300, 556);
            this.gbContacto.TabIndex = 53;
            this.gbContacto.TabStop = false;
            this.gbContacto.Text = "Contacto y Creación de Usuario";
            this.gbContacto.Enter += new System.EventHandler(this.gbContacto_Enter);
            // 
            // chkVer
            // 
            this.chkVer.AutoSize = true;
            this.chkVer.Location = new System.Drawing.Point(708, 190);
            this.chkVer.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.chkVer.Name = "chkVer";
            this.chkVer.Size = new System.Drawing.Size(88, 35);
            this.chkVer.TabIndex = 58;
            this.chkVer.Text = "Ver";
            this.chkVer.UseVisualStyleBackColor = true;
            this.chkVer.CheckedChanged += new System.EventHandler(this.chkVer_CheckedChanged);
            // 
            // lstTelefonos
            // 
            this.lstTelefonos.FormattingEnabled = true;
            this.lstTelefonos.ItemHeight = 31;
            this.lstTelefonos.Location = new System.Drawing.Point(874, 115);
            this.lstTelefonos.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.lstTelefonos.Name = "lstTelefonos";
            this.lstTelefonos.Size = new System.Drawing.Size(398, 283);
            this.lstTelefonos.TabIndex = 56;
            this.lstTelefonos.SelectedIndexChanged += new System.EventHandler(this.lstTelefonos_SelectedIndexChanged);
            // 
            // btnAgregarTelefonos
            // 
            this.btnAgregarTelefonos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarTelefonos.Location = new System.Drawing.Point(874, 37);
            this.btnAgregarTelefonos.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnAgregarTelefonos.Name = "btnAgregarTelefonos";
            this.btnAgregarTelefonos.Size = new System.Drawing.Size(271, 67);
            this.btnAgregarTelefonos.TabIndex = 57;
            this.btnAgregarTelefonos.Text = "+ Agregar Teléfono";
            this.btnAgregarTelefonos.UseVisualStyleBackColor = true;
            this.btnAgregarTelefonos.Click += new System.EventHandler(this.btnAgregarTelefonos_Click);
            // 
            // txtGmail
            // 
            this.txtGmail.Location = new System.Drawing.Point(368, 96);
            this.txtGmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtGmail.Name = "txtGmail";
            this.txtGmail.Size = new System.Drawing.Size(326, 38);
            this.txtGmail.TabIndex = 4;
            // 
            // mskTelefono
            // 
            this.mskTelefono.Location = new System.Drawing.Point(422, 279);
            this.mskTelefono.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mskTelefono.Mask = "(999)000-0000";
            this.mskTelefono.Name = "mskTelefono";
            this.mskTelefono.Size = new System.Drawing.Size(272, 38);
            this.mskTelefono.TabIndex = 7;
            // 
            // cmbRedes
            // 
            this.cmbRedes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRedes.FormattingEnabled = true;
            this.cmbRedes.Items.AddRange(new object[] {
            "Facebook",
            "Instagram",
            "Twitter",
            "Tik Tok"});
            this.cmbRedes.Location = new System.Drawing.Point(422, 385);
            this.cmbRedes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbRedes.Name = "cmbRedes";
            this.cmbRedes.Size = new System.Drawing.Size(272, 39);
            this.cmbRedes.TabIndex = 6;
            // 
            // lblRedes
            // 
            this.lblRedes.AutoSize = true;
            this.lblRedes.Location = new System.Drawing.Point(52, 398);
            this.lblRedes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRedes.Name = "lblRedes";
            this.lblRedes.Size = new System.Drawing.Size(203, 31);
            this.lblRedes.TabIndex = 2;
            this.lblRedes.Text = "Redes Sociales";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(54, 290);
            this.lblTelefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(120, 31);
            this.lblTelefono.TabIndex = 1;
            this.lblTelefono.Text = "Teléfono";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(54, 102);
            this.lblMail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(63, 31);
            this.lblMail.TabIndex = 0;
            this.lblMail.Text = "Mail";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblEstado});
            this.statusStrip1.Location = new System.Drawing.Point(0, 1175);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 14, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1686, 42);
            this.statusStrip1.TabIndex = 54;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblEstado
            // 
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(230, 32);
            this.lblEstado.Text = "Estado Conexión BD";
            // 
            // frmRRHH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1686, 1217);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.gbContacto);
            this.Controls.Add(this.btnEliminarUsuario);
            this.Controls.Add(this.btnVolverAdmin);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.gbDomicilio);
            this.Controls.Add(this.gbDatos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmRRHH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RRHH";
            this.Load += new System.EventHandler(this.frmRRHH_Load);
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            this.gbDomicilio.ResumeLayout(false);
            this.gbDomicilio.PerformLayout();
            this.gbContacto.ResumeLayout(false);
            this.gbContacto.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.GroupBox gbDomicilio;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label lblProvincia;
        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.Label lblContrasenia;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.ComboBox cmbProvincia;
        private System.Windows.Forms.TextBox txtContrasenia;

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ComboBox cmbPerfil;
        private System.Windows.Forms.Label lblPerfil;
        private System.Windows.Forms.Button btnVolverAdmin;
        private System.Windows.Forms.Button btnEliminarUsuario;
        private System.Windows.Forms.GroupBox gbContacto;
        private System.Windows.Forms.MaskedTextBox mskTelefono;
        private System.Windows.Forms.ComboBox cmbRedes;
        private System.Windows.Forms.TextBox txtGmail;
        private System.Windows.Forms.Label lblRedes;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.CheckBox chkActivo;
        private System.Windows.Forms.ComboBox cmbLocalidad;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblEstado;
        private System.Windows.Forms.ListBox lstDirecciones;
        private System.Windows.Forms.Button btnAgregarDireccion;
        private System.Windows.Forms.Button btnAgregarTelefonos;
        private System.Windows.Forms.ListBox lstTelefonos;
        private System.Windows.Forms.CheckBox chkVer;
    }
}