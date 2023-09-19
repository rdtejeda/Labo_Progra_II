namespace Login
{
    partial class Clicker
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
            label2 = new Label();
            btnClicker = new Button();
            txtPuntos = new Label();
            lbRanking = new ListBox();
            btnSalir = new Button();
            linkActualizar = new LinkLabel();
            label3 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(6, 9);
            label2.Name = "label2";
            label2.Size = new Size(155, 32);
            label2.TabIndex = 2;
            label2.Text = "CONTADOR: ";
            // 
            // btnClicker
            // 
            btnClicker.BackColor = Color.LightSkyBlue;
            btnClicker.FlatStyle = FlatStyle.Flat;
            btnClicker.Location = new Point(12, 44);
            btnClicker.Name = "btnClicker";
            btnClicker.Size = new Size(420, 48);
            btnClicker.TabIndex = 14;
            btnClicker.Text = "CLICK!";
            btnClicker.UseVisualStyleBackColor = false;
            btnClicker.Click += btnClicker_Click;
            // 
            // txtPuntos
            // 
            txtPuntos.AutoSize = true;
            txtPuntos.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            txtPuntos.ForeColor = SystemColors.ControlDarkDark;
            txtPuntos.Location = new Point(173, 9);
            txtPuntos.Name = "txtPuntos";
            txtPuntos.Size = new Size(27, 32);
            txtPuntos.TabIndex = 15;
            txtPuntos.Text = "0";
            // 
            // lbRanking
            // 
            lbRanking.FormattingEnabled = true;
            lbRanking.ItemHeight = 15;
            lbRanking.Location = new Point(12, 128);
            lbRanking.Name = "lbRanking";
            lbRanking.Size = new Size(420, 214);
            lbRanking.TabIndex = 16;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Salmon;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Location = new Point(12, 348);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(420, 33);
            btnSalir.TabIndex = 14;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // linkActualizar
            // 
            linkActualizar.AutoSize = true;
            linkActualizar.Location = new Point(356, 110);
            linkActualizar.Name = "linkActualizar";
            linkActualizar.Size = new Size(76, 15);
            linkActualizar.TabIndex = 14;
            linkActualizar.TabStop = true;
            linkActualizar.Text = "ACTUALIZAR";
            linkActualizar.LinkClicked += linkActualizar_LinkClicked;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(9, 110);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 17;
            label3.Text = "RANKING";
            // 
            // Clicker
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(444, 388);
            Controls.Add(label3);
            Controls.Add(linkActualizar);
            Controls.Add(btnSalir);
            Controls.Add(lbRanking);
            Controls.Add(txtPuntos);
            Controls.Add(btnClicker);
            Controls.Add(label2);
            MaximizeBox = false;
            Name = "Clicker";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bienvenido Usuario!";
            Load += Clicker_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Button btnClicker;
        private Label txtPuntos;
        private ListBox lbRanking;
        private Button btnSalir;
        private LinkLabel linkActualizar;
        private Label label3;
    }
}