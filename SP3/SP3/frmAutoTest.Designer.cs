
namespace SP3
{
    partial class frmAutoTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAutoTest));
            this.grpRegistro = new System.Windows.Forms.GroupBox();
            this.numAnioFabricacion = new System.Windows.Forms.NumericUpDown();
            this.txtTitular = new System.Windows.Forms.TextBox();
            this.txtDominio = new System.Windows.Forms.TextBox();
            this.txtNroTurno = new System.Windows.Forms.TextBox();
            this.lblTitular = new System.Windows.Forms.Label();
            this.lblAnioFabricacion = new System.Windows.Forms.Label();
            this.lblDominio = new System.Windows.Forms.Label();
            this.lblNumeroDeTurno = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.grpConsulta = new System.Windows.Forms.GroupBox();
            this.txtDominio6Caracteres = new System.Windows.Forms.TextBox();
            this.txtAnioMasAntiguo = new System.Windows.Forms.TextBox();
            this.txtCantidadTurnos = new System.Windows.Forms.TextBox();
            this.lblCantidadConDominioDe6 = new System.Windows.Forms.Label();
            this.lblAnioDelMasAntiguo = new System.Windows.Forms.Label();
            this.lblCantidadDeTurno = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.grpRegistro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAnioFabricacion)).BeginInit();
            this.grpConsulta.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpRegistro
            // 
            this.grpRegistro.BackColor = System.Drawing.Color.Fuchsia;
            this.grpRegistro.Controls.Add(this.numAnioFabricacion);
            this.grpRegistro.Controls.Add(this.txtTitular);
            this.grpRegistro.Controls.Add(this.txtDominio);
            this.grpRegistro.Controls.Add(this.txtNroTurno);
            this.grpRegistro.Controls.Add(this.lblTitular);
            this.grpRegistro.Controls.Add(this.lblAnioFabricacion);
            this.grpRegistro.Controls.Add(this.lblDominio);
            this.grpRegistro.Controls.Add(this.lblNumeroDeTurno);
            this.grpRegistro.Location = new System.Drawing.Point(13, 26);
            this.grpRegistro.Margin = new System.Windows.Forms.Padding(4);
            this.grpRegistro.Name = "grpRegistro";
            this.grpRegistro.Padding = new System.Windows.Forms.Padding(4);
            this.grpRegistro.Size = new System.Drawing.Size(551, 237);
            this.grpRegistro.TabIndex = 0;
            this.grpRegistro.TabStop = false;
            this.grpRegistro.Text = "Registro de Turnos";
            // 
            // numAnioFabricacion
            // 
            this.numAnioFabricacion.Enabled = false;
            this.numAnioFabricacion.Location = new System.Drawing.Point(160, 118);
            this.numAnioFabricacion.Margin = new System.Windows.Forms.Padding(4);
            this.numAnioFabricacion.Maximum = new decimal(new int[] {
            2022,
            0,
            0,
            0});
            this.numAnioFabricacion.Minimum = new decimal(new int[] {
            1950,
            0,
            0,
            0});
            this.numAnioFabricacion.Name = "numAnioFabricacion";
            this.numAnioFabricacion.Size = new System.Drawing.Size(73, 22);
            this.numAnioFabricacion.TabIndex = 2;
            this.numAnioFabricacion.Value = new decimal(new int[] {
            2022,
            0,
            0,
            0});
            // 
            // txtTitular
            // 
            this.txtTitular.Enabled = false;
            this.txtTitular.Location = new System.Drawing.Point(160, 160);
            this.txtTitular.Margin = new System.Windows.Forms.Padding(4);
            this.txtTitular.MaxLength = 30;
            this.txtTitular.Name = "txtTitular";
            this.txtTitular.Size = new System.Drawing.Size(360, 22);
            this.txtTitular.TabIndex = 3;
            this.txtTitular.TextChanged += new System.EventHandler(this.txtTitular_TextChanged);
            // 
            // txtDominio
            // 
            this.txtDominio.Enabled = false;
            this.txtDominio.Location = new System.Drawing.Point(160, 75);
            this.txtDominio.Margin = new System.Windows.Forms.Padding(4);
            this.txtDominio.MaxLength = 7;
            this.txtDominio.Name = "txtDominio";
            this.txtDominio.Size = new System.Drawing.Size(132, 22);
            this.txtDominio.TabIndex = 1;
            this.txtDominio.TextChanged += new System.EventHandler(this.txtDominio_TextChanged);
            this.txtDominio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDominio_KeyPress);
            // 
            // txtNroTurno
            // 
            this.txtNroTurno.Location = new System.Drawing.Point(160, 33);
            this.txtNroTurno.Margin = new System.Windows.Forms.Padding(4);
            this.txtNroTurno.MaxLength = 5;
            this.txtNroTurno.Name = "txtNroTurno";
            this.txtNroTurno.Size = new System.Drawing.Size(85, 22);
            this.txtNroTurno.TabIndex = 0;
            this.txtNroTurno.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNroTurno.TextChanged += new System.EventHandler(this.txtNroTurno_TextChanged);
            this.txtNroTurno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNroTurno_KeyPress);
            // 
            // lblTitular
            // 
            this.lblTitular.AutoSize = true;
            this.lblTitular.Location = new System.Drawing.Point(20, 164);
            this.lblTitular.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitular.Name = "lblTitular";
            this.lblTitular.Size = new System.Drawing.Size(44, 16);
            this.lblTitular.TabIndex = 4;
            this.lblTitular.Text = "Titular";
            // 
            // lblAnioFabricacion
            // 
            this.lblAnioFabricacion.AutoSize = true;
            this.lblAnioFabricacion.Location = new System.Drawing.Point(20, 121);
            this.lblAnioFabricacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAnioFabricacion.Name = "lblAnioFabricacion";
            this.lblAnioFabricacion.Size = new System.Drawing.Size(105, 16);
            this.lblAnioFabricacion.TabIndex = 2;
            this.lblAnioFabricacion.Text = "Año Fabricación";
            // 
            // lblDominio
            // 
            this.lblDominio.AutoSize = true;
            this.lblDominio.Location = new System.Drawing.Point(20, 79);
            this.lblDominio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDominio.Name = "lblDominio";
            this.lblDominio.Size = new System.Drawing.Size(57, 16);
            this.lblDominio.TabIndex = 1;
            this.lblDominio.Text = "Dominio";
            // 
            // lblNumeroDeTurno
            // 
            this.lblNumeroDeTurno.AutoSize = true;
            this.lblNumeroDeTurno.Location = new System.Drawing.Point(20, 37);
            this.lblNumeroDeTurno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumeroDeTurno.Name = "lblNumeroDeTurno";
            this.lblNumeroDeTurno.Size = new System.Drawing.Size(112, 16);
            this.lblNumeroDeTurno.TabIndex = 0;
            this.lblNumeroDeTurno.Text = "Número de Turno";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Enabled = false;
            this.btnRegistrar.Location = new System.Drawing.Point(572, 26);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(125, 42);
            this.btnRegistrar.TabIndex = 0;
            this.btnRegistrar.Text = "&Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(572, 78);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(125, 42);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // grpConsulta
            // 
            this.grpConsulta.BackColor = System.Drawing.Color.Fuchsia;
            this.grpConsulta.Controls.Add(this.txtDominio6Caracteres);
            this.grpConsulta.Controls.Add(this.txtAnioMasAntiguo);
            this.grpConsulta.Controls.Add(this.txtCantidadTurnos);
            this.grpConsulta.Controls.Add(this.lblCantidadConDominioDe6);
            this.grpConsulta.Controls.Add(this.lblAnioDelMasAntiguo);
            this.grpConsulta.Controls.Add(this.lblCantidadDeTurno);
            this.grpConsulta.Location = new System.Drawing.Point(13, 308);
            this.grpConsulta.Margin = new System.Windows.Forms.Padding(4);
            this.grpConsulta.Name = "grpConsulta";
            this.grpConsulta.Padding = new System.Windows.Forms.Padding(4);
            this.grpConsulta.Size = new System.Drawing.Size(551, 169);
            this.grpConsulta.TabIndex = 3;
            this.grpConsulta.TabStop = false;
            this.grpConsulta.Text = "Estadísticas";
            // 
            // txtDominio6Caracteres
            // 
            this.txtDominio6Caracteres.Enabled = false;
            this.txtDominio6Caracteres.Location = new System.Drawing.Point(287, 117);
            this.txtDominio6Caracteres.Margin = new System.Windows.Forms.Padding(4);
            this.txtDominio6Caracteres.Name = "txtDominio6Caracteres";
            this.txtDominio6Caracteres.ReadOnly = true;
            this.txtDominio6Caracteres.Size = new System.Drawing.Size(77, 22);
            this.txtDominio6Caracteres.TabIndex = 2;
            this.txtDominio6Caracteres.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtAnioMasAntiguo
            // 
            this.txtAnioMasAntiguo.Enabled = false;
            this.txtAnioMasAntiguo.Location = new System.Drawing.Point(287, 74);
            this.txtAnioMasAntiguo.Margin = new System.Windows.Forms.Padding(4);
            this.txtAnioMasAntiguo.Name = "txtAnioMasAntiguo";
            this.txtAnioMasAntiguo.ReadOnly = true;
            this.txtAnioMasAntiguo.Size = new System.Drawing.Size(77, 22);
            this.txtAnioMasAntiguo.TabIndex = 1;
            this.txtAnioMasAntiguo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCantidadTurnos
            // 
            this.txtCantidadTurnos.Enabled = false;
            this.txtCantidadTurnos.Location = new System.Drawing.Point(287, 33);
            this.txtCantidadTurnos.Margin = new System.Windows.Forms.Padding(4);
            this.txtCantidadTurnos.Name = "txtCantidadTurnos";
            this.txtCantidadTurnos.ReadOnly = true;
            this.txtCantidadTurnos.Size = new System.Drawing.Size(77, 22);
            this.txtCantidadTurnos.TabIndex = 0;
            this.txtCantidadTurnos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblCantidadConDominioDe6
            // 
            this.lblCantidadConDominioDe6.AutoSize = true;
            this.lblCantidadConDominioDe6.Location = new System.Drawing.Point(20, 121);
            this.lblCantidadConDominioDe6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidadConDominioDe6.Name = "lblCantidadConDominioDe6";
            this.lblCantidadConDominioDe6.Size = new System.Drawing.Size(233, 16);
            this.lblCantidadConDominioDe6.TabIndex = 2;
            this.lblCantidadConDominioDe6.Text = "Cantidad con dominio de 6 caracteres";
            // 
            // lblAnioDelMasAntiguo
            // 
            this.lblAnioDelMasAntiguo.AutoSize = true;
            this.lblAnioDelMasAntiguo.Location = new System.Drawing.Point(20, 78);
            this.lblAnioDelMasAntiguo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAnioDelMasAntiguo.Name = "lblAnioDelMasAntiguo";
            this.lblAnioDelMasAntiguo.Size = new System.Drawing.Size(130, 16);
            this.lblAnioDelMasAntiguo.TabIndex = 1;
            this.lblAnioDelMasAntiguo.Text = "Año del más Antiguo";
            // 
            // lblCantidadDeTurno
            // 
            this.lblCantidadDeTurno.AutoSize = true;
            this.lblCantidadDeTurno.Location = new System.Drawing.Point(20, 37);
            this.lblCantidadDeTurno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidadDeTurno.Name = "lblCantidadDeTurno";
            this.lblCantidadDeTurno.Size = new System.Drawing.Size(125, 16);
            this.lblCantidadDeTurno.TabIndex = 0;
            this.lblCantidadDeTurno.Text = "Cantidad de Turnos";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(572, 321);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(4);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(125, 42);
            this.btnConsultar.TabIndex = 2;
            this.btnConsultar.Text = "&Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // frmAutoTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BackgroundImage = global::SP3.Properties.Resources.fondo_auto;
            this.ClientSize = new System.Drawing.Size(889, 505);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.grpConsulta);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.grpRegistro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAutoTest";
            this.Text = "Auto Test";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpRegistro.ResumeLayout(false);
            this.grpRegistro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAnioFabricacion)).EndInit();
            this.grpConsulta.ResumeLayout(false);
            this.grpConsulta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpRegistro;
        private System.Windows.Forms.NumericUpDown numAnioFabricacion;
        private System.Windows.Forms.TextBox txtTitular;
        private System.Windows.Forms.TextBox txtDominio;
        private System.Windows.Forms.TextBox txtNroTurno;
        private System.Windows.Forms.Label lblTitular;
        private System.Windows.Forms.Label lblAnioFabricacion;
        private System.Windows.Forms.Label lblDominio;
        private System.Windows.Forms.Label lblNumeroDeTurno;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox grpConsulta;
        private System.Windows.Forms.TextBox txtDominio6Caracteres;
        private System.Windows.Forms.TextBox txtAnioMasAntiguo;
        private System.Windows.Forms.TextBox txtCantidadTurnos;
        private System.Windows.Forms.Label lblCantidadConDominioDe6;
        private System.Windows.Forms.Label lblAnioDelMasAntiguo;
        private System.Windows.Forms.Label lblCantidadDeTurno;
        private System.Windows.Forms.Button btnConsultar;
    }
}

