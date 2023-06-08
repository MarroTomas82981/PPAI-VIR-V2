
namespace PPAI_IVR_V2.Pantalla
{
    partial class PantallaRegistrarRegRespuestaOperador
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaRegistrarRegRespuestaOperador));
            this.btnColgarLlamada = new System.Windows.Forms.Button();
            this.gbRespuestaOperador = new System.Windows.Forms.GroupBox();
            this.CBoxAcciones = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtRespuestaOperador = new System.Windows.Forms.RichTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnRegistrarRtaOperador = new System.Windows.Forms.Button();
            this.CboxRespuestaVal1 = new System.Windows.Forms.ComboBox();
            this.gbValidaciones = new System.Windows.Forms.GroupBox();
            this.gbValidacion2 = new System.Windows.Forms.GroupBox();
            this.CBoxValidacion2 = new System.Windows.Forms.ComboBox();
            this.lblValidacionError2 = new System.Windows.Forms.Label();
            this.lblRta2 = new System.Windows.Forms.Label();
            this.txtValidacion2 = new System.Windows.Forms.TextBox();
            this.lblMensajeVal2 = new System.Windows.Forms.Label();
            this.gbValidacion1 = new System.Windows.Forms.GroupBox();
            this.lblValidacionError1 = new System.Windows.Forms.Label();
            this.lblRta1 = new System.Windows.Forms.Label();
            this.txtValidacion1 = new System.Windows.Forms.TextBox();
            this.lblMensajeVal1 = new System.Windows.Forms.Label();
            this.btnValidarRespuestas = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.lblSubOpcion = new System.Windows.Forms.Label();
            this.lblOpcion = new System.Windows.Forms.Label();
            this.lblCategoriaLlamada = new System.Windows.Forms.Label();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gbRespuestaOperador.SuspendLayout();
            this.gbValidaciones.SuspendLayout();
            this.gbValidacion2.SuspendLayout();
            this.gbValidacion1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnColgarLlamada
            // 
            this.btnColgarLlamada.BackColor = System.Drawing.Color.Red;
            this.btnColgarLlamada.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColgarLlamada.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnColgarLlamada.Location = new System.Drawing.Point(450, 659);
            this.btnColgarLlamada.Margin = new System.Windows.Forms.Padding(2);
            this.btnColgarLlamada.Name = "btnColgarLlamada";
            this.btnColgarLlamada.Size = new System.Drawing.Size(146, 41);
            this.btnColgarLlamada.TabIndex = 60;
            this.btnColgarLlamada.Text = "Colgar Llamada";
            this.btnColgarLlamada.UseVisualStyleBackColor = false;
            this.btnColgarLlamada.Click += new System.EventHandler(this.ColgarLlamada);
            // 
            // gbRespuestaOperador
            // 
            this.gbRespuestaOperador.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.gbRespuestaOperador.Controls.Add(this.CBoxAcciones);
            this.gbRespuestaOperador.Controls.Add(this.label13);
            this.gbRespuestaOperador.Controls.Add(this.txtRespuestaOperador);
            this.gbRespuestaOperador.Controls.Add(this.label12);
            this.gbRespuestaOperador.Location = new System.Drawing.Point(16, 449);
            this.gbRespuestaOperador.Margin = new System.Windows.Forms.Padding(2);
            this.gbRespuestaOperador.Name = "gbRespuestaOperador";
            this.gbRespuestaOperador.Padding = new System.Windows.Forms.Padding(2);
            this.gbRespuestaOperador.Size = new System.Drawing.Size(580, 168);
            this.gbRespuestaOperador.TabIndex = 59;
            this.gbRespuestaOperador.TabStop = false;
            this.gbRespuestaOperador.Visible = false;
            // 
            // CBoxAcciones
            // 
            this.CBoxAcciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBoxAcciones.FormattingEnabled = true;
            this.CBoxAcciones.Location = new System.Drawing.Point(11, 133);
            this.CBoxAcciones.Margin = new System.Windows.Forms.Padding(2);
            this.CBoxAcciones.Name = "CBoxAcciones";
            this.CBoxAcciones.Size = new System.Drawing.Size(242, 21);
            this.CBoxAcciones.TabIndex = 45;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 118);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(99, 13);
            this.label13.TabIndex = 44;
            this.label13.Text = "Acciones a realizar:";
            // 
            // txtRespuestaOperador
            // 
            this.txtRespuestaOperador.Location = new System.Drawing.Point(4, 33);
            this.txtRespuestaOperador.Margin = new System.Windows.Forms.Padding(2);
            this.txtRespuestaOperador.Name = "txtRespuestaOperador";
            this.txtRespuestaOperador.Size = new System.Drawing.Size(553, 83);
            this.txtRespuestaOperador.TabIndex = 43;
            this.txtRespuestaOperador.Text = "";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 18);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 13);
            this.label12.TabIndex = 42;
            this.label12.Text = "Respuesta operador:";
            // 
            // btnRegistrarRtaOperador
            // 
            this.btnRegistrarRtaOperador.BackColor = System.Drawing.Color.Green;
            this.btnRegistrarRtaOperador.Enabled = false;
            this.btnRegistrarRtaOperador.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarRtaOperador.ForeColor = System.Drawing.Color.Transparent;
            this.btnRegistrarRtaOperador.Location = new System.Drawing.Point(154, 659);
            this.btnRegistrarRtaOperador.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegistrarRtaOperador.Name = "btnRegistrarRtaOperador";
            this.btnRegistrarRtaOperador.Size = new System.Drawing.Size(140, 41);
            this.btnRegistrarRtaOperador.TabIndex = 46;
            this.btnRegistrarRtaOperador.Text = "Registrar Respuesta";
            this.btnRegistrarRtaOperador.UseVisualStyleBackColor = false;
            this.btnRegistrarRtaOperador.Click += new System.EventHandler(this.tomarAccionYDescripcionRTA);
            // 
            // CboxRespuestaVal1
            // 
            this.CboxRespuestaVal1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CboxRespuestaVal1.FormattingEnabled = true;
            this.CboxRespuestaVal1.Location = new System.Drawing.Point(98, 40);
            this.CboxRespuestaVal1.Margin = new System.Windows.Forms.Padding(2);
            this.CboxRespuestaVal1.Name = "CboxRespuestaVal1";
            this.CboxRespuestaVal1.Size = new System.Drawing.Size(206, 21);
            this.CboxRespuestaVal1.TabIndex = 58;
            // 
            // gbValidaciones
            // 
            this.gbValidaciones.BackColor = System.Drawing.Color.LightCoral;
            this.gbValidaciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.gbValidaciones.Controls.Add(this.gbValidacion2);
            this.gbValidaciones.Controls.Add(this.gbValidacion1);
            this.gbValidaciones.Controls.Add(this.btnValidarRespuestas);
            this.gbValidaciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gbValidaciones.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbValidaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbValidaciones.Location = new System.Drawing.Point(16, 191);
            this.gbValidaciones.Margin = new System.Windows.Forms.Padding(2);
            this.gbValidaciones.Name = "gbValidaciones";
            this.gbValidaciones.Padding = new System.Windows.Forms.Padding(2);
            this.gbValidaciones.Size = new System.Drawing.Size(374, 254);
            this.gbValidaciones.TabIndex = 57;
            this.gbValidaciones.TabStop = false;
            this.gbValidaciones.Text = "VALIDACIONES";
            // 
            // gbValidacion2
            // 
            this.gbValidacion2.Controls.Add(this.CBoxValidacion2);
            this.gbValidacion2.Controls.Add(this.lblValidacionError2);
            this.gbValidacion2.Controls.Add(this.lblRta2);
            this.gbValidacion2.Controls.Add(this.txtValidacion2);
            this.gbValidacion2.Controls.Add(this.lblMensajeVal2);
            this.gbValidacion2.Location = new System.Drawing.Point(13, 116);
            this.gbValidacion2.Margin = new System.Windows.Forms.Padding(2);
            this.gbValidacion2.Name = "gbValidacion2";
            this.gbValidacion2.Padding = new System.Windows.Forms.Padding(2);
            this.gbValidacion2.Size = new System.Drawing.Size(341, 73);
            this.gbValidacion2.TabIndex = 41;
            this.gbValidacion2.TabStop = false;
            this.gbValidacion2.Text = "2° Validacion";
            // 
            // CBoxValidacion2
            // 
            this.CBoxValidacion2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CBoxValidacion2.FormattingEnabled = true;
            this.CBoxValidacion2.Location = new System.Drawing.Point(98, 44);
            this.CBoxValidacion2.Margin = new System.Windows.Forms.Padding(2);
            this.CBoxValidacion2.Name = "CBoxValidacion2";
            this.CBoxValidacion2.Size = new System.Drawing.Size(206, 21);
            this.CBoxValidacion2.TabIndex = 59;
            this.CBoxValidacion2.Text = "Selecciona una Opcion de Validacion";
            // 
            // lblValidacionError2
            // 
            this.lblValidacionError2.AutoSize = true;
            this.lblValidacionError2.Location = new System.Drawing.Point(95, 65);
            this.lblValidacionError2.Name = "lblValidacionError2";
            this.lblValidacionError2.Size = new System.Drawing.Size(0, 13);
            this.lblValidacionError2.TabIndex = 43;
            // 
            // lblRta2
            // 
            this.lblRta2.AutoSize = true;
            this.lblRta2.Location = new System.Drawing.Point(35, 47);
            this.lblRta2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRta2.Name = "lblRta2";
            this.lblRta2.Size = new System.Drawing.Size(61, 13);
            this.lblRta2.TabIndex = 34;
            this.lblRta2.Text = "Respuesta:";
            this.lblRta2.Visible = false;
            // 
            // txtValidacion2
            // 
            this.txtValidacion2.Enabled = false;
            this.txtValidacion2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValidacion2.Location = new System.Drawing.Point(98, 21);
            this.txtValidacion2.Margin = new System.Windows.Forms.Padding(2);
            this.txtValidacion2.Name = "txtValidacion2";
            this.txtValidacion2.Size = new System.Drawing.Size(206, 20);
            this.txtValidacion2.TabIndex = 32;
            // 
            // lblMensajeVal2
            // 
            this.lblMensajeVal2.AutoSize = true;
            this.lblMensajeVal2.Location = new System.Drawing.Point(40, 21);
            this.lblMensajeVal2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMensajeVal2.Name = "lblMensajeVal2";
            this.lblMensajeVal2.Size = new System.Drawing.Size(50, 13);
            this.lblMensajeVal2.TabIndex = 31;
            this.lblMensajeVal2.Text = "Mensaje:";
            // 
            // gbValidacion1
            // 
            this.gbValidacion1.Controls.Add(this.txtValidacion1);
            this.gbValidacion1.Controls.Add(this.lblValidacionError1);
            this.gbValidacion1.Controls.Add(this.lblRta1);
            this.gbValidacion1.Controls.Add(this.lblMensajeVal1);
            this.gbValidacion1.Controls.Add(this.CboxRespuestaVal1);
            this.gbValidacion1.Location = new System.Drawing.Point(13, 26);
            this.gbValidacion1.Margin = new System.Windows.Forms.Padding(2);
            this.gbValidacion1.Name = "gbValidacion1";
            this.gbValidacion1.Padding = new System.Windows.Forms.Padding(2);
            this.gbValidacion1.Size = new System.Drawing.Size(341, 73);
            this.gbValidacion1.TabIndex = 40;
            this.gbValidacion1.TabStop = false;
            this.gbValidacion1.Text = "1° Validacion";
            // 
            // lblValidacionError1
            // 
            this.lblValidacionError1.AutoSize = true;
            this.lblValidacionError1.Location = new System.Drawing.Point(95, 61);
            this.lblValidacionError1.Name = "lblValidacionError1";
            this.lblValidacionError1.Size = new System.Drawing.Size(0, 13);
            this.lblValidacionError1.TabIndex = 35;
            // 
            // lblRta1
            // 
            this.lblRta1.AutoSize = true;
            this.lblRta1.Location = new System.Drawing.Point(35, 40);
            this.lblRta1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRta1.Name = "lblRta1";
            this.lblRta1.Size = new System.Drawing.Size(61, 13);
            this.lblRta1.TabIndex = 33;
            this.lblRta1.Text = "Respuesta:";
            this.lblRta1.Visible = false;
            // 
            // txtValidacion1
            // 
            this.txtValidacion1.Enabled = false;
            this.txtValidacion1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValidacion1.Location = new System.Drawing.Point(99, 14);
            this.txtValidacion1.Margin = new System.Windows.Forms.Padding(2);
            this.txtValidacion1.Name = "txtValidacion1";
            this.txtValidacion1.Size = new System.Drawing.Size(206, 20);
            this.txtValidacion1.TabIndex = 12;
            // 
            // lblMensajeVal1
            // 
            this.lblMensajeVal1.AutoSize = true;
            this.lblMensajeVal1.Location = new System.Drawing.Point(38, 17);
            this.lblMensajeVal1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMensajeVal1.Name = "lblMensajeVal1";
            this.lblMensajeVal1.Size = new System.Drawing.Size(50, 13);
            this.lblMensajeVal1.TabIndex = 10;
            this.lblMensajeVal1.Text = "Mensaje:";
            // 
            // btnValidarRespuestas
            // 
            this.btnValidarRespuestas.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnValidarRespuestas.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidarRespuestas.ForeColor = System.Drawing.Color.Transparent;
            this.btnValidarRespuestas.Location = new System.Drawing.Point(111, 196);
            this.btnValidarRespuestas.Margin = new System.Windows.Forms.Padding(2);
            this.btnValidarRespuestas.Name = "btnValidarRespuestas";
            this.btnValidarRespuestas.Size = new System.Drawing.Size(118, 38);
            this.btnValidarRespuestas.TabIndex = 14;
            this.btnValidarRespuestas.Text = "Validar Información";
            this.btnValidarRespuestas.UseVisualStyleBackColor = false;
            this.btnValidarRespuestas.Click += new System.EventHandler(this.tomarOpcionDeValidacion);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 161);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 20);
            this.label5.TabIndex = 53;
            this.label5.Text = "Subopción:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 134);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 52;
            this.label4.Text = "Opción:";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(25, 102);
            this.lblCategoria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(92, 20);
            this.lblCategoria.TabIndex = 51;
            this.lblCategoria.Text = "Categoría:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(25, 75);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(134, 20);
            this.lblNombre.TabIndex = 50;
            this.lblNombre.Text = "Nombre cliente:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(219, 24);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(219, 28);
            this.lblTitulo.TabIndex = 49;
            this.lblTitulo.Text = "Datos de la llamada";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnCancelar.Location = new System.Drawing.Point(298, 659);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(140, 41);
            this.BtnCancelar.TabIndex = 61;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.CancelarCu);
            // 
            // lblSubOpcion
            // 
            this.lblSubOpcion.AutoSize = true;
            this.lblSubOpcion.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblSubOpcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSubOpcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubOpcion.Location = new System.Drawing.Point(171, 163);
            this.lblSubOpcion.Name = "lblSubOpcion";
            this.lblSubOpcion.Size = new System.Drawing.Size(136, 18);
            this.lblSubOpcion.TabIndex = 59;
            this.lblSubOpcion.Text = "Sub-Opción Llamada";
            // 
            // lblOpcion
            // 
            this.lblOpcion.AutoSize = true;
            this.lblOpcion.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblOpcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOpcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpcion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblOpcion.Location = new System.Drawing.Point(171, 134);
            this.lblOpcion.Name = "lblOpcion";
            this.lblOpcion.Size = new System.Drawing.Size(52, 18);
            this.lblOpcion.TabIndex = 60;
            this.lblOpcion.Text = "Opción";
            // 
            // lblCategoriaLlamada
            // 
            this.lblCategoriaLlamada.AutoSize = true;
            this.lblCategoriaLlamada.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblCategoriaLlamada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCategoriaLlamada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoriaLlamada.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCategoriaLlamada.Location = new System.Drawing.Point(171, 102);
            this.lblCategoriaLlamada.Name = "lblCategoriaLlamada";
            this.lblCategoriaLlamada.Size = new System.Drawing.Size(153, 18);
            this.lblCategoriaLlamada.TabIndex = 61;
            this.lblCategoriaLlamada.Text = "Categoría de la llamada";
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblNombreCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCliente.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNombreCliente.Location = new System.Drawing.Point(171, 75);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(125, 18);
            this.lblNombreCliente.TabIndex = 62;
            this.lblNombreCliente.Text = "Nombre del cliiente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(447, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 63;
            this.label1.Text = "Tiempo Transcurrido:";
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.Location = new System.Drawing.Point(560, 35);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(42, 13);
            this.lblTiempo.TabIndex = 64;
            this.lblTiempo.Text = "Tiempo";
            // 
            // PantallaRegistrarRegRespuestaOperador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(657, 711);
            this.Controls.Add(this.lblTiempo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRegistrarRtaOperador);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.btnColgarLlamada);
            this.Controls.Add(this.lblSubOpcion);
            this.Controls.Add(this.lblOpcion);
            this.Controls.Add(this.lblCategoriaLlamada);
            this.Controls.Add(this.lblNombreCliente);
            this.Controls.Add(this.gbRespuestaOperador);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.gbValidaciones);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PantallaRegistrarRegRespuestaOperador";
            this.Text = "RegistrarRegRespuestaOperador";
            this.Load += new System.EventHandler(this.RegistrarRegRespuestaOperador_Load);
            this.gbRespuestaOperador.ResumeLayout(false);
            this.gbRespuestaOperador.PerformLayout();
            this.gbValidaciones.ResumeLayout(false);
            this.gbValidacion2.ResumeLayout(false);
            this.gbValidacion2.PerformLayout();
            this.gbValidacion1.ResumeLayout(false);
            this.gbValidacion1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnColgarLlamada;
        private System.Windows.Forms.GroupBox gbRespuestaOperador;
        private System.Windows.Forms.ComboBox CBoxAcciones;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RichTextBox txtRespuestaOperador;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnRegistrarRtaOperador;
        public System.Windows.Forms.ComboBox CboxRespuestaVal1;
        public System.Windows.Forms.GroupBox gbValidaciones;
        public System.Windows.Forms.GroupBox gbValidacion2;
        private System.Windows.Forms.Label lblValidacionError2;
        private System.Windows.Forms.Label lblRta2;
        public System.Windows.Forms.TextBox txtValidacion2;
        private System.Windows.Forms.Label lblMensajeVal2;
        public System.Windows.Forms.GroupBox gbValidacion1;
        private System.Windows.Forms.Label lblValidacionError1;
        private System.Windows.Forms.Label lblRta1;
        public System.Windows.Forms.TextBox txtValidacion1;
        private System.Windows.Forms.Label lblMensajeVal1;
        private System.Windows.Forms.Button btnValidarRespuestas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button BtnCancelar;
        public System.Windows.Forms.ComboBox CBoxValidacion2;
        private System.Windows.Forms.Label lblSubOpcion;
        private System.Windows.Forms.Label lblOpcion;
        private System.Windows.Forms.Label lblCategoriaLlamada;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.Timer timer1;
    }
}