namespace Login
{
    partial class Login
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
            label1 = new Label();
            tCorreo = new TextBox();
            linkRegistrar = new LinkLabel();
            btnIngresar = new Button();
            label3 = new Label();
            tPass = new TextBox();
            btnSalir = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 49);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 0;
            label1.Text = "Correo";
            // 
            // tCorreo
            // 
            tCorreo.BorderStyle = BorderStyle.FixedSingle;
            tCorreo.Location = new Point(12, 67);
            tCorreo.Name = "tCorreo";
            tCorreo.Size = new Size(297, 23);
            tCorreo.TabIndex = 1;
            // 
            // linkRegistrar
            // 
            linkRegistrar.AutoSize = true;
            linkRegistrar.Location = new Point(12, 211);
            linkRegistrar.Name = "linkRegistrar";
            linkRegistrar.Size = new Size(65, 15);
            linkRegistrar.TabIndex = 2;
            linkRegistrar.TabStop = true;
            linkRegistrar.Text = "REGISTRAR";
            linkRegistrar.LinkClicked += linkRegistrar_LinkClicked;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.LightGreen;
            btnIngresar.FlatStyle = FlatStyle.Flat;
            btnIngresar.Location = new Point(12, 140);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(296, 48);
            btnIngresar.TabIndex = 3;
            btnIngresar.Text = "INGRESAR";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 93);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 7;
            label3.Text = "Contraseña";
            // 
            // tPass
            // 
            tPass.BorderStyle = BorderStyle.FixedSingle;
            tPass.Location = new Point(12, 111);
            tPass.Name = "tPass";
            tPass.Size = new Size(297, 23);
            tPass.TabIndex = 8;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = SystemColors.Control;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Location = new Point(180, 194);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(129, 48);
            btnSalir.TabIndex = 9;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += Salir_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(6, 9);
            label2.Name = "label2";
            label2.Size = new Size(85, 32);
            label2.TabIndex = 13;
            label2.Text = "LOGIN";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(320, 256);
            Controls.Add(label2);
            Controls.Add(btnSalir);
            Controls.Add(tPass);
            Controls.Add(label3);
            Controls.Add(btnIngresar);
            Controls.Add(linkRegistrar);
            Controls.Add(tCorreo);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tCorreo;
        private LinkLabel linkRegistrar;
        private Button btnIngresar;
        private Label label3;
        private TextBox tPass;
        private Button btnSalir;
        private Label label2;
    }
}