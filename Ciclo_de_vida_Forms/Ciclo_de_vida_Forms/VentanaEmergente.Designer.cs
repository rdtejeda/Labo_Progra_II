﻿namespace Ciclo_de_vida_Forms
{
    partial class VentanaEmergente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaEmergente));
            lblTitulo = new Label();
            lblMsj = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(81, 18);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(37, 15);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Titulo";
            // 
            // lblMsj
            // 
            lblMsj.AutoSize = true;
            lblMsj.Location = new Point(70, 70);
            lblMsj.Name = "lblMsj";
            lblMsj.Size = new Size(59, 15);
            lblMsj.TabIndex = 1;
            lblMsj.Text = ">Mensaje";
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(161, 194);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "Ok";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // VentanaEmergente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(336, 296);
            Controls.Add(btnSalir);
            Controls.Add(lblMsj);
            Controls.Add(lblTitulo);
            DoubleBuffered = true;
            Name = "VentanaEmergente";
            RightToLeftLayout = true;
            ShowIcon = false;
            Text = "VentanaEmergente";
            Load += VentanaEmergente_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblMsj;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button btnSalir;
    }
}