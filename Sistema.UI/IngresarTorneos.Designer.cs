
namespace Sistema.UI
{
    partial class IngresarTorneos
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
            this.lbltorneo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblpremio = new System.Windows.Forms.Label();
            this.dtpfechatorneo = new System.Windows.Forms.DateTimePicker();
            this.txtPago = new System.Windows.Forms.TextBox();
            this.lblDolarEstudiante = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblganador = new System.Windows.Forms.Label();
            this.txtganador = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbltorneo
            // 
            this.lbltorneo.AutoSize = true;
            this.lbltorneo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbltorneo.Font = new System.Drawing.Font("Maiandra GD", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltorneo.Location = new System.Drawing.Point(96, 18);
            this.lbltorneo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltorneo.Name = "lbltorneo";
            this.lbltorneo.Size = new System.Drawing.Size(310, 29);
            this.lbltorneo.TabIndex = 0;
            this.lbltorneo.Text = "Administración de Torneos";
            this.lbltorneo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 96);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha del Torneo";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(175, 319);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(62, 27);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(96, 319);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(65, 27);
            this.btnAceptar.TabIndex = 7;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblpremio
            // 
            this.lblpremio.AutoSize = true;
            this.lblpremio.Enabled = false;
            this.lblpremio.Location = new System.Drawing.Point(15, 149);
            this.lblpremio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblpremio.Name = "lblpremio";
            this.lblpremio.Size = new System.Drawing.Size(39, 13);
            this.lblpremio.TabIndex = 9;
            this.lblpremio.Text = "Premio";
            // 
            // dtpfechatorneo
            // 
            this.dtpfechatorneo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfechatorneo.Location = new System.Drawing.Point(123, 92);
            this.dtpfechatorneo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpfechatorneo.Name = "dtpfechatorneo";
            this.dtpfechatorneo.Size = new System.Drawing.Size(114, 20);
            this.dtpfechatorneo.TabIndex = 3;
            // 
            // txtPago
            // 
            this.txtPago.Enabled = false;
            this.txtPago.Location = new System.Drawing.Point(120, 147);
            this.txtPago.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPago.Name = "txtPago";
            this.txtPago.ReadOnly = true;
            this.txtPago.Size = new System.Drawing.Size(117, 20);
            this.txtPago.TabIndex = 16;
            // 
            // lblDolarEstudiante
            // 
            this.lblDolarEstudiante.AutoSize = true;
            this.lblDolarEstudiante.Location = new System.Drawing.Point(93, 149);
            this.lblDolarEstudiante.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDolarEstudiante.Name = "lblDolarEstudiante";
            this.lblDolarEstudiante.Size = new System.Drawing.Size(13, 13);
            this.lblDolarEstudiante.TabIndex = 18;
            this.lblDolarEstudiante.Text = "$";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(15, 210);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Usuario";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(120, 207);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(117, 20);
            this.txtUsuario.TabIndex = 20;
            // 
            // lblganador
            // 
            this.lblganador.AutoSize = true;
            this.lblganador.BackColor = System.Drawing.Color.Transparent;
            this.lblganador.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblganador.Location = new System.Drawing.Point(18, 259);
            this.lblganador.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblganador.Name = "lblganador";
            this.lblganador.Size = new System.Drawing.Size(48, 13);
            this.lblganador.TabIndex = 23;
            this.lblganador.Text = "Ganador";
            // 
            // txtganador
            // 
            this.txtganador.Location = new System.Drawing.Point(123, 256);
            this.txtganador.Margin = new System.Windows.Forms.Padding(2);
            this.txtganador.Name = "txtganador";
            this.txtganador.Size = new System.Drawing.Size(117, 20);
            this.txtganador.TabIndex = 22;
            // 
            // Torneos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 357);
            this.Controls.Add(this.lblganador);
            this.Controls.Add(this.txtganador);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblDolarEstudiante);
            this.Controls.Add(this.txtPago);
            this.Controls.Add(this.dtpfechatorneo);
            this.Controls.Add(this.lblpremio);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbltorneo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(510, 400);
            this.MinimumSize = new System.Drawing.Size(510, 400);
            this.Name = "Torneos";
            this.Text = "Torneo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltorneo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblpremio;
        private System.Windows.Forms.DateTimePicker dtpfechatorneo;
        private System.Windows.Forms.TextBox txtPago;
        private System.Windows.Forms.Label lblDolarEstudiante;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblganador;
        private System.Windows.Forms.TextBox txtganador;
    }
}