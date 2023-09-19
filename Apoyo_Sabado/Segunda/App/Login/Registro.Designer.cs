namespace Login
{
    partial class Registro
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
            gbDatos = new GroupBox();
            txtError = new Label();
            tPassDos = new TextBox();
            tPassUno = new TextBox();
            tCorreo = new TextBox();
            tNombre = new TextBox();
            label2 = new Label();
            btnSalir = new Button();
            btnRegistrar = new Button();
            btnHardcode = new Button();
            gbInformacion = new GroupBox();
            label5 = new Label();
            datePickerFecNacimiento = new DateTimePicker();
            label4 = new Label();
            cmbColorFvorito = new ComboBox();
            gbVarios = new GroupBox();
            checkTrabaja = new CheckBox();
            checkEstudia = new CheckBox();
            checkMayorEdad = new CheckBox();
            label3 = new Label();
            numCodSeg = new NumericUpDown();
            gbSexo = new GroupBox();
            rbtnNoBinario = new RadioButton();
            rbtnFemenino = new RadioButton();
            rbtnMasculino = new RadioButton();
            gbDatos.SuspendLayout();
            gbInformacion.SuspendLayout();
            gbVarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numCodSeg).BeginInit();
            gbSexo.SuspendLayout();
            SuspendLayout();
            // 
            // gbDatos
            // 
            gbDatos.Controls.Add(txtError);
            gbDatos.Controls.Add(tPassDos);
            gbDatos.Controls.Add(tPassUno);
            gbDatos.Controls.Add(tCorreo);
            gbDatos.Controls.Add(tNombre);
            gbDatos.Location = new Point(12, 53);
            gbDatos.Name = "gbDatos";
            gbDatos.Size = new Size(279, 158);
            gbDatos.TabIndex = 0;
            gbDatos.TabStop = false;
            gbDatos.Text = "Datos";
            // 
            // txtError
            // 
            txtError.AutoSize = true;
            txtError.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            txtError.ForeColor = Color.Red;
            txtError.Location = new Point(6, 135);
            txtError.Name = "txtError";
            txtError.Size = new Size(46, 15);
            txtError.TabIndex = 14;
            txtError.Text = "ERROR.";
            // 
            // tPassDos
            // 
            tPassDos.BorderStyle = BorderStyle.FixedSingle;
            tPassDos.Location = new Point(6, 109);
            tPassDos.Name = "tPassDos";
            tPassDos.PasswordChar = '*';
            tPassDos.PlaceholderText = "Repetir Contraseña";
            tPassDos.Size = new Size(267, 23);
            tPassDos.TabIndex = 13;
            // 
            // tPassUno
            // 
            tPassUno.BorderStyle = BorderStyle.FixedSingle;
            tPassUno.Location = new Point(6, 80);
            tPassUno.Name = "tPassUno";
            tPassUno.PasswordChar = '*';
            tPassUno.PlaceholderText = "Contraseña";
            tPassUno.Size = new Size(267, 23);
            tPassUno.TabIndex = 12;
            // 
            // tCorreo
            // 
            tCorreo.BorderStyle = BorderStyle.FixedSingle;
            tCorreo.Location = new Point(6, 51);
            tCorreo.Name = "tCorreo";
            tCorreo.PlaceholderText = "Correo";
            tCorreo.Size = new Size(267, 23);
            tCorreo.TabIndex = 11;
            // 
            // tNombre
            // 
            tNombre.BorderStyle = BorderStyle.FixedSingle;
            tNombre.Location = new Point(6, 22);
            tNombre.Name = "tNombre";
            tNombre.PlaceholderText = "Nombre";
            tNombre.Size = new Size(267, 23);
            tNombre.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(5, 9);
            label2.Name = "label2";
            label2.Size = new Size(124, 32);
            label2.TabIndex = 1;
            label2.Text = "REGISTRO";
            // 
            // btnSalir
            // 
            btnSalir.BackColor = SystemColors.Control;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Location = new Point(168, 511);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(123, 42);
            btnSalir.TabIndex = 11;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += Salir_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.LightGreen;
            btnRegistrar.FlatStyle = FlatStyle.Flat;
            btnRegistrar.Location = new Point(12, 457);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(279, 48);
            btnRegistrar.TabIndex = 10;
            btnRegistrar.Text = "REGISTRAR";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnHardcode
            // 
            btnHardcode.BackColor = SystemColors.Control;
            btnHardcode.FlatStyle = FlatStyle.Flat;
            btnHardcode.Location = new Point(12, 511);
            btnHardcode.Name = "btnHardcode";
            btnHardcode.Size = new Size(123, 42);
            btnHardcode.TabIndex = 12;
            btnHardcode.Text = "HARDCODE";
            btnHardcode.UseVisualStyleBackColor = false;
            btnHardcode.Click += btnHardcode_Click;
            // 
            // gbInformacion
            // 
            gbInformacion.Controls.Add(label5);
            gbInformacion.Controls.Add(datePickerFecNacimiento);
            gbInformacion.Controls.Add(label4);
            gbInformacion.Controls.Add(cmbColorFvorito);
            gbInformacion.Controls.Add(gbVarios);
            gbInformacion.Controls.Add(label3);
            gbInformacion.Controls.Add(numCodSeg);
            gbInformacion.Controls.Add(gbSexo);
            gbInformacion.Location = new Point(12, 217);
            gbInformacion.Name = "gbInformacion";
            gbInformacion.Size = new Size(279, 234);
            gbInformacion.TabIndex = 13;
            gbInformacion.TabStop = false;
            gbInformacion.Text = "Información Extra";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 182);
            label5.Name = "label5";
            label5.Size = new Size(119, 15);
            label5.TabIndex = 19;
            label5.Text = "Fecha de Nacimiento";
            // 
            // datePickerFecNacimiento
            // 
            datePickerFecNacimiento.Location = new Point(6, 200);
            datePickerFecNacimiento.Name = "datePickerFecNacimiento";
            datePickerFecNacimiento.Size = new Size(267, 23);
            datePickerFecNacimiento.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(103, 24);
            label4.Name = "label4";
            label4.Size = new Size(82, 15);
            label4.TabIndex = 18;
            label4.Text = "Color Favorito";
            // 
            // cmbColorFvorito
            // 
            cmbColorFvorito.FormattingEnabled = true;
            cmbColorFvorito.Location = new Point(106, 42);
            cmbColorFvorito.Name = "cmbColorFvorito";
            cmbColorFvorito.Size = new Size(167, 23);
            cmbColorFvorito.TabIndex = 17;
            // 
            // gbVarios
            // 
            gbVarios.Controls.Add(checkTrabaja);
            gbVarios.Controls.Add(checkEstudia);
            gbVarios.Controls.Add(checkMayorEdad);
            gbVarios.Location = new Point(106, 71);
            gbVarios.Name = "gbVarios";
            gbVarios.Size = new Size(167, 99);
            gbVarios.TabIndex = 15;
            gbVarios.TabStop = false;
            gbVarios.Text = "Varios";
            // 
            // checkTrabaja
            // 
            checkTrabaja.AutoSize = true;
            checkTrabaja.Location = new Point(5, 73);
            checkTrabaja.Name = "checkTrabaja";
            checkTrabaja.Size = new Size(63, 19);
            checkTrabaja.TabIndex = 2;
            checkTrabaja.Text = "Trabaja";
            checkTrabaja.UseVisualStyleBackColor = true;
            // 
            // checkEstudia
            // 
            checkEstudia.AutoSize = true;
            checkEstudia.Location = new Point(5, 48);
            checkEstudia.Name = "checkEstudia";
            checkEstudia.Size = new Size(64, 19);
            checkEstudia.TabIndex = 1;
            checkEstudia.Text = "Estudia";
            checkEstudia.UseVisualStyleBackColor = true;
            // 
            // checkMayorEdad
            // 
            checkMayorEdad.AutoSize = true;
            checkMayorEdad.Location = new Point(5, 23);
            checkMayorEdad.Name = "checkMayorEdad";
            checkMayorEdad.Size = new Size(105, 19);
            checkMayorEdad.TabIndex = 0;
            checkMayorEdad.Text = "Mayor de Edad";
            checkMayorEdad.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 24);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 16;
            label3.Text = "Cod. Seg.";
            // 
            // numCodSeg
            // 
            numCodSeg.Location = new Point(6, 42);
            numCodSeg.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numCodSeg.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numCodSeg.Name = "numCodSeg";
            numCodSeg.Size = new Size(94, 23);
            numCodSeg.TabIndex = 15;
            numCodSeg.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // gbSexo
            // 
            gbSexo.Controls.Add(rbtnNoBinario);
            gbSexo.Controls.Add(rbtnFemenino);
            gbSexo.Controls.Add(rbtnMasculino);
            gbSexo.Location = new Point(6, 71);
            gbSexo.Name = "gbSexo";
            gbSexo.Size = new Size(94, 99);
            gbSexo.TabIndex = 14;
            gbSexo.TabStop = false;
            gbSexo.Text = "Sexo";
            // 
            // rbtnNoBinario
            // 
            rbtnNoBinario.AutoSize = true;
            rbtnNoBinario.Location = new Point(6, 72);
            rbtnNoBinario.Name = "rbtnNoBinario";
            rbtnNoBinario.Size = new Size(81, 19);
            rbtnNoBinario.TabIndex = 2;
            rbtnNoBinario.TabStop = true;
            rbtnNoBinario.Text = "No Binario";
            rbtnNoBinario.UseVisualStyleBackColor = true;
            // 
            // rbtnFemenino
            // 
            rbtnFemenino.AutoSize = true;
            rbtnFemenino.Location = new Point(6, 47);
            rbtnFemenino.Name = "rbtnFemenino";
            rbtnFemenino.Size = new Size(78, 19);
            rbtnFemenino.TabIndex = 1;
            rbtnFemenino.TabStop = true;
            rbtnFemenino.Text = "Femenino";
            rbtnFemenino.UseVisualStyleBackColor = true;
            // 
            // rbtnMasculino
            // 
            rbtnMasculino.AutoSize = true;
            rbtnMasculino.Location = new Point(6, 22);
            rbtnMasculino.Name = "rbtnMasculino";
            rbtnMasculino.Size = new Size(80, 19);
            rbtnMasculino.TabIndex = 0;
            rbtnMasculino.TabStop = true;
            rbtnMasculino.Text = "Masculino";
            rbtnMasculino.UseVisualStyleBackColor = true;
            // 
            // Registro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(303, 565);
            Controls.Add(gbInformacion);
            Controls.Add(btnHardcode);
            Controls.Add(btnSalir);
            Controls.Add(btnRegistrar);
            Controls.Add(label2);
            Controls.Add(gbDatos);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Registro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registro";
            Load += Registro_Load;
            gbDatos.ResumeLayout(false);
            gbDatos.PerformLayout();
            gbInformacion.ResumeLayout(false);
            gbInformacion.PerformLayout();
            gbVarios.ResumeLayout(false);
            gbVarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numCodSeg).EndInit();
            gbSexo.ResumeLayout(false);
            gbSexo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbDatos;
        private TextBox tNombre;
        private TextBox tPassDos;
        private TextBox tPassUno;
        private TextBox tCorreo;
        private Label txtError;
        private Label label2;
        private Button btnSalir;
        private Button btnRegistrar;
        private Button btnHardcode;
        private GroupBox gbInformacion;
        private Label label3;
        private NumericUpDown numCodSeg;
        private GroupBox gbSexo;
        private RadioButton rbtnNoBinario;
        private RadioButton rbtnFemenino;
        private RadioButton rbtnMasculino;
        private ComboBox cmbColorFvorito;
        private GroupBox gbVarios;
        private CheckBox checkTrabaja;
        private CheckBox checkEstudia;
        private CheckBox checkMayorEdad;
        private Label label4;
        private Label label5;
        private DateTimePicker datePickerFecNacimiento;
    }
}