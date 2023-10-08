namespace Formulario_validacion
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbNombre = new Label();
            lbApellido = new Label();
            lbTelefono = new Label();
            lbEstatura = new Label();
            lbEdad = new Label();
            tbNombre = new TextBox();
            tbApellido = new TextBox();
            tbTelefono = new TextBox();
            tbEstatura = new TextBox();
            tbEdad = new TextBox();
            gbGenero = new GroupBox();
            rbMujer = new RadioButton();
            rbHombre = new RadioButton();
            bGuardar = new Button();
            bCancelar = new Button();
            gbGenero.SuspendLayout();
            SuspendLayout();
            // 
            // lbNombre
            // 
            lbNombre.AutoSize = true;
            lbNombre.Location = new Point(22, 38);
            lbNombre.Name = "lbNombre";
            lbNombre.Size = new Size(54, 15);
            lbNombre.TabIndex = 0;
            lbNombre.Text = "Nombre:";
            // 
            // lbApellido
            // 
            lbApellido.AutoSize = true;
            lbApellido.Location = new Point(17, 67);
            lbApellido.Name = "lbApellido";
            lbApellido.Size = new Size(59, 15);
            lbApellido.TabIndex = 1;
            lbApellido.Text = "Apellidos:";
            // 
            // lbTelefono
            // 
            lbTelefono.AutoSize = true;
            lbTelefono.Location = new Point(22, 96);
            lbTelefono.Name = "lbTelefono";
            lbTelefono.Size = new Size(55, 15);
            lbTelefono.TabIndex = 2;
            lbTelefono.Text = "Telefono:";
            // 
            // lbEstatura
            // 
            lbEstatura.AutoSize = true;
            lbEstatura.Location = new Point(25, 124);
            lbEstatura.Name = "lbEstatura";
            lbEstatura.Size = new Size(52, 15);
            lbEstatura.TabIndex = 3;
            lbEstatura.Text = "Estatura:";
            // 
            // lbEdad
            // 
            lbEdad.AutoSize = true;
            lbEdad.Location = new Point(41, 152);
            lbEdad.Name = "lbEdad";
            lbEdad.Size = new Size(36, 15);
            lbEdad.TabIndex = 4;
            lbEdad.Text = "Edad:";
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(88, 35);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(107, 23);
            tbNombre.TabIndex = 5;
            tbNombre.TextChanged += ValidarNombre;
            // 
            // tbApellido
            // 
            tbApellido.Location = new Point(88, 64);
            tbApellido.Name = "tbApellido";
            tbApellido.Size = new Size(107, 23);
            tbApellido.TabIndex = 6;
            tbApellido.TextChanged += ValidarApellidos;
            // 
            // tbTelefono
            // 
            tbTelefono.Location = new Point(88, 93);
            tbTelefono.Name = "tbTelefono";
            tbTelefono.Size = new Size(107, 23);
            tbTelefono.TabIndex = 7;
            tbTelefono.TextChanged += ValidarTelefono;
            // 
            // tbEstatura
            // 
            tbEstatura.Location = new Point(88, 121);
            tbEstatura.Name = "tbEstatura";
            tbEstatura.Size = new Size(107, 23);
            tbEstatura.TabIndex = 8;
            tbEstatura.TextChanged += ValidarEstatura;
            // 
            // tbEdad
            // 
            tbEdad.Location = new Point(88, 149);
            tbEdad.Name = "tbEdad";
            tbEdad.Size = new Size(107, 23);
            tbEdad.TabIndex = 9;
            tbEdad.TextChanged += ValidarEdad;
            // 
            // gbGenero
            // 
            gbGenero.Controls.Add(rbMujer);
            gbGenero.Controls.Add(rbHombre);
            gbGenero.Location = new Point(12, 188);
            gbGenero.Name = "gbGenero";
            gbGenero.Size = new Size(183, 45);
            gbGenero.TabIndex = 10;
            gbGenero.TabStop = false;
            gbGenero.Text = "Género";
            // 
            // rbMujer
            // 
            rbMujer.AutoSize = true;
            rbMujer.Location = new Point(106, 20);
            rbMujer.Name = "rbMujer";
            rbMujer.Size = new Size(56, 19);
            rbMujer.TabIndex = 1;
            rbMujer.TabStop = true;
            rbMujer.Text = "Mujer";
            rbMujer.UseVisualStyleBackColor = true;
            // 
            // rbHombre
            // 
            rbHombre.AutoSize = true;
            rbHombre.Location = new Point(20, 20);
            rbHombre.Name = "rbHombre";
            rbHombre.Size = new Size(69, 19);
            rbHombre.TabIndex = 0;
            rbHombre.TabStop = true;
            rbHombre.Text = "Hombre";
            rbHombre.UseVisualStyleBackColor = true;
            // 
            // bGuardar
            // 
            bGuardar.Location = new Point(32, 242);
            bGuardar.Name = "bGuardar";
            bGuardar.Size = new Size(151, 49);
            bGuardar.TabIndex = 11;
            bGuardar.Text = "Guardar";
            bGuardar.UseVisualStyleBackColor = true;
            bGuardar.Click += bGuardar_Click;
            // 
            // bCancelar
            // 
            bCancelar.Location = new Point(32, 297);
            bCancelar.Name = "bCancelar";
            bCancelar.Size = new Size(151, 49);
            bCancelar.TabIndex = 12;
            bCancelar.Text = "Cancelar";
            bCancelar.UseVisualStyleBackColor = true;
            bCancelar.Click += bCancelar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(219, 358);
            Controls.Add(bCancelar);
            Controls.Add(bGuardar);
            Controls.Add(gbGenero);
            Controls.Add(tbEdad);
            Controls.Add(tbEstatura);
            Controls.Add(tbTelefono);
            Controls.Add(tbApellido);
            Controls.Add(tbNombre);
            Controls.Add(lbEdad);
            Controls.Add(lbEstatura);
            Controls.Add(lbTelefono);
            Controls.Add(lbApellido);
            Controls.Add(lbNombre);
            Name = "Form1";
            Text = "Form1";
            gbGenero.ResumeLayout(false);
            gbGenero.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbNombre;
        private Label lbApellido;
        private Label lbTelefono;
        private Label lbEstatura;
        private Label lbEdad;
        private TextBox tbNombre;
        private TextBox tbApellido;
        private TextBox tbTelefono;
        private TextBox tbEstatura;
        private TextBox tbEdad;
        private GroupBox gbGenero;
        private RadioButton rbHombre;
        private Button bGuardar;
        private Button bCancelar;
        private RadioButton rbMujer;
    }
}