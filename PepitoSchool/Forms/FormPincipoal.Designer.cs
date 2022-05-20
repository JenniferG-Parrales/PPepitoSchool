
namespace PepitoSchool.Forms
{
    partial class FormPincipoal
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
            this.lblRegistro = new System.Windows.Forms.Label();
            this.lblNombres = new System.Windows.Forms.Label();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.lblCarnet = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtNames = new System.Windows.Forms.TextBox();
            this.txtLastnames = new System.Windows.Forms.TextBox();
            this.txtCarnet = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblNotas = new System.Windows.Forms.Label();
            this.lblMatematicas = new System.Windows.Forms.Label();
            this.lblContabilidad = new System.Windows.Forms.Label();
            this.lblProgramacion = new System.Windows.Forms.Label();
            this.lblEstadistica = new System.Windows.Forms.Label();
            this.nudMatematicas = new System.Windows.Forms.NumericUpDown();
            this.nudContabilidad = new System.Windows.Forms.NumericUpDown();
            this.nudProgramacion = new System.Windows.Forms.NumericUpDown();
            this.nudEstadistica = new System.Windows.Forms.NumericUpDown();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudMatematicas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudContabilidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudProgramacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEstadistica)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRegistro
            // 
            this.lblRegistro.AutoSize = true;
            this.lblRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistro.Location = new System.Drawing.Point(43, 24);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(112, 29);
            this.lblRegistro.TabIndex = 0;
            this.lblRegistro.Text = "Registro";
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombres.Location = new System.Drawing.Point(22, 101);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(85, 20);
            this.lblNombres.TabIndex = 1;
            this.lblNombres.Text = "Nombres:";
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidos.Location = new System.Drawing.Point(23, 137);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(87, 20);
            this.lblApellidos.TabIndex = 2;
            this.lblApellidos.Text = "Apellidos:";
            // 
            // lblCarnet
            // 
            this.lblCarnet.AutoSize = true;
            this.lblCarnet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarnet.Location = new System.Drawing.Point(23, 170);
            this.lblCarnet.Name = "lblCarnet";
            this.lblCarnet.Size = new System.Drawing.Size(68, 20);
            this.lblCarnet.TabIndex = 3;
            this.lblCarnet.Text = "Carnet:";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(22, 206);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(84, 20);
            this.lblTelefono.TabIndex = 4;
            this.lblTelefono.Text = "Telefono:";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.Location = new System.Drawing.Point(23, 238);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(68, 20);
            this.lblCorreo.TabIndex = 5;
            this.lblCorreo.Text = "Correo:";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(23, 275);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(89, 20);
            this.lblDireccion.TabIndex = 6;
            this.lblDireccion.Text = "Direccion:";
            // 
            // txtNames
            // 
            this.txtNames.Location = new System.Drawing.Point(116, 101);
            this.txtNames.Name = "txtNames";
            this.txtNames.Size = new System.Drawing.Size(238, 20);
            this.txtNames.TabIndex = 7;
            // 
            // txtLastnames
            // 
            this.txtLastnames.Location = new System.Drawing.Point(116, 137);
            this.txtLastnames.Name = "txtLastnames";
            this.txtLastnames.Size = new System.Drawing.Size(238, 20);
            this.txtLastnames.TabIndex = 8;
            // 
            // txtCarnet
            // 
            this.txtCarnet.Location = new System.Drawing.Point(116, 170);
            this.txtCarnet.Name = "txtCarnet";
            this.txtCarnet.Size = new System.Drawing.Size(238, 20);
            this.txtCarnet.TabIndex = 9;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(116, 206);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(238, 20);
            this.txtPhone.TabIndex = 10;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(116, 238);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(238, 20);
            this.txtCorreo.TabIndex = 11;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(116, 275);
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(238, 94);
            this.txtDireccion.TabIndex = 12;
            // 
            // lblNotas
            // 
            this.lblNotas.AutoSize = true;
            this.lblNotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotas.Location = new System.Drawing.Point(481, 24);
            this.lblNotas.Name = "lblNotas";
            this.lblNotas.Size = new System.Drawing.Size(81, 29);
            this.lblNotas.TabIndex = 13;
            this.lblNotas.Text = "Notas";
            // 
            // lblMatematicas
            // 
            this.lblMatematicas.AutoSize = true;
            this.lblMatematicas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatematicas.Location = new System.Drawing.Point(416, 99);
            this.lblMatematicas.Name = "lblMatematicas";
            this.lblMatematicas.Size = new System.Drawing.Size(111, 20);
            this.lblMatematicas.TabIndex = 14;
            this.lblMatematicas.Text = "Matematicas";
            // 
            // lblContabilidad
            // 
            this.lblContabilidad.AutoSize = true;
            this.lblContabilidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContabilidad.Location = new System.Drawing.Point(416, 137);
            this.lblContabilidad.Name = "lblContabilidad";
            this.lblContabilidad.Size = new System.Drawing.Size(109, 20);
            this.lblContabilidad.TabIndex = 15;
            this.lblContabilidad.Text = "Contabilidad";
            // 
            // lblProgramacion
            // 
            this.lblProgramacion.AutoSize = true;
            this.lblProgramacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgramacion.Location = new System.Drawing.Point(416, 170);
            this.lblProgramacion.Name = "lblProgramacion";
            this.lblProgramacion.Size = new System.Drawing.Size(119, 20);
            this.lblProgramacion.TabIndex = 16;
            this.lblProgramacion.Text = "Programacion";
            // 
            // lblEstadistica
            // 
            this.lblEstadistica.AutoSize = true;
            this.lblEstadistica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadistica.Location = new System.Drawing.Point(417, 222);
            this.lblEstadistica.Name = "lblEstadistica";
            this.lblEstadistica.Size = new System.Drawing.Size(98, 20);
            this.lblEstadistica.TabIndex = 17;
            this.lblEstadistica.Text = "Estadistica";
            // 
            // nudMatematicas
            // 
            this.nudMatematicas.Location = new System.Drawing.Point(562, 104);
            this.nudMatematicas.Name = "nudMatematicas";
            this.nudMatematicas.Size = new System.Drawing.Size(120, 20);
            this.nudMatematicas.TabIndex = 18;
            // 
            // nudContabilidad
            // 
            this.nudContabilidad.Location = new System.Drawing.Point(562, 140);
            this.nudContabilidad.Name = "nudContabilidad";
            this.nudContabilidad.Size = new System.Drawing.Size(120, 20);
            this.nudContabilidad.TabIndex = 19;
            // 
            // nudProgramacion
            // 
            this.nudProgramacion.Location = new System.Drawing.Point(562, 173);
            this.nudProgramacion.Name = "nudProgramacion";
            this.nudProgramacion.Size = new System.Drawing.Size(120, 20);
            this.nudProgramacion.TabIndex = 20;
            // 
            // nudEstadistica
            // 
            this.nudEstadistica.Location = new System.Drawing.Point(562, 222);
            this.nudEstadistica.Name = "nudEstadistica";
            this.nudEstadistica.Size = new System.Drawing.Size(120, 20);
            this.nudEstadistica.TabIndex = 21;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(126, 450);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(93, 32);
            this.btnRegistrar.TabIndex = 22;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(351, 449);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(92, 33);
            this.btnModificar.TabIndex = 23;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(596, 450);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(97, 32);
            this.btnCancelar.TabIndex = 24;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // FormPincipoal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 534);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.nudEstadistica);
            this.Controls.Add(this.nudProgramacion);
            this.Controls.Add(this.nudContabilidad);
            this.Controls.Add(this.nudMatematicas);
            this.Controls.Add(this.lblEstadistica);
            this.Controls.Add(this.lblProgramacion);
            this.Controls.Add(this.lblContabilidad);
            this.Controls.Add(this.lblMatematicas);
            this.Controls.Add(this.lblNotas);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtCarnet);
            this.Controls.Add(this.txtLastnames);
            this.Controls.Add(this.txtNames);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblCarnet);
            this.Controls.Add(this.lblApellidos);
            this.Controls.Add(this.lblNombres);
            this.Controls.Add(this.lblRegistro);
            this.Name = "FormPincipoal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormPincipoal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudMatematicas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudContabilidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudProgramacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEstadistica)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRegistro;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.Label lblCarnet;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtNames;
        private System.Windows.Forms.TextBox txtLastnames;
        private System.Windows.Forms.TextBox txtCarnet;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblNotas;
        private System.Windows.Forms.Label lblMatematicas;
        private System.Windows.Forms.Label lblContabilidad;
        private System.Windows.Forms.Label lblProgramacion;
        private System.Windows.Forms.Label lblEstadistica;
        private System.Windows.Forms.NumericUpDown nudMatematicas;
        private System.Windows.Forms.NumericUpDown nudContabilidad;
        private System.Windows.Forms.NumericUpDown nudProgramacion;
        private System.Windows.Forms.NumericUpDown nudEstadistica;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnCancelar;
    }
}