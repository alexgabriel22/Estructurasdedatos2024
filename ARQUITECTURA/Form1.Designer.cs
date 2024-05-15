namespace ARQUITECTURA
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtIdentificacion = new System.Windows.Forms.TextBox();
            this.txtAsignacionDia = new System.Windows.Forms.TextBox();
            this.txtDiaslaborados = new System.Windows.Forms.TextBox();
            this.btnAlmacenarRegistro = new System.Windows.Forms.Button();
            this.btnCalcularSalario = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotalDevengado = new System.Windows.Forms.TextBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.error1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.error1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(359, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "ARQUITECTO";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(126, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Identificacion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(126, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Asignacion salario dia";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(126, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Dias laborados";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(335, 110);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(266, 22);
            this.txtNombre.TabIndex = 5;
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.Location = new System.Drawing.Point(337, 164);
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.Size = new System.Drawing.Size(264, 22);
            this.txtIdentificacion.TabIndex = 6;
            // 
            // txtAsignacionDia
            // 
            this.txtAsignacionDia.Location = new System.Drawing.Point(333, 228);
            this.txtAsignacionDia.Name = "txtAsignacionDia";
            this.txtAsignacionDia.Size = new System.Drawing.Size(268, 22);
            this.txtAsignacionDia.TabIndex = 7;
            // 
            // txtDiaslaborados
            // 
            this.txtDiaslaborados.Location = new System.Drawing.Point(328, 281);
            this.txtDiaslaborados.Name = "txtDiaslaborados";
            this.txtDiaslaborados.Size = new System.Drawing.Size(272, 22);
            this.txtDiaslaborados.TabIndex = 8;
            // 
            // btnAlmacenarRegistro
            // 
            this.btnAlmacenarRegistro.Location = new System.Drawing.Point(348, 345);
            this.btnAlmacenarRegistro.Name = "btnAlmacenarRegistro";
            this.btnAlmacenarRegistro.Size = new System.Drawing.Size(228, 39);
            this.btnAlmacenarRegistro.TabIndex = 9;
            this.btnAlmacenarRegistro.Text = "Guardar el regitro del empleado";
            this.btnAlmacenarRegistro.UseVisualStyleBackColor = true;
            this.btnAlmacenarRegistro.Click += new System.EventHandler(this.btnAlmacenarRegistro_Click);
            // 
            // btnCalcularSalario
            // 
            this.btnCalcularSalario.Location = new System.Drawing.Point(350, 400);
            this.btnCalcularSalario.Name = "btnCalcularSalario";
            this.btnCalcularSalario.Size = new System.Drawing.Size(225, 23);
            this.btnCalcularSalario.TabIndex = 10;
            this.btnCalcularSalario.Text = "Calcular Salario";
            this.btnCalcularSalario.UseVisualStyleBackColor = true;
            this.btnCalcularSalario.Click += new System.EventHandler(this.btnCalcularSalario_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(132, 455);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Valor total devengado";
            // 
            // txtTotalDevengado
            // 
            this.txtTotalDevengado.Location = new System.Drawing.Point(327, 446);
            this.txtTotalDevengado.Name = "txtTotalDevengado";
            this.txtTotalDevengado.Size = new System.Drawing.Size(234, 22);
            this.txtTotalDevengado.TabIndex = 12;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(145, 509);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(141, 32);
            this.btnNuevo.TabIndex = 13;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(481, 507);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(158, 33);
            this.btnSalir.TabIndex = 14;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // error1
            // 
            this.error1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 551);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.txtTotalDevengado);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCalcularSalario);
            this.Controls.Add(this.btnAlmacenarRegistro);
            this.Controls.Add(this.txtDiaslaborados);
            this.Controls.Add(this.txtAsignacionDia);
            this.Controls.Add(this.txtIdentificacion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Guardar Registro de Empleado";
            ((System.ComponentModel.ISupportInitialize)(this.error1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtIdentificacion;
        private System.Windows.Forms.TextBox txtAsignacionDia;
        private System.Windows.Forms.TextBox txtDiaslaborados;
        private System.Windows.Forms.Button btnAlmacenarRegistro;
        private System.Windows.Forms.Button btnCalcularSalario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTotalDevengado;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ErrorProvider error1;
    }
}

