namespace Ciclo_de_vida_Forms
{
    partial class MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            menuStrip = new MenuStrip();
            inicioToolStripMenuItem = new ToolStripMenuItem();
            celularesToolStripMenuItem = new ToolStripMenuItem();
            samsungToolStripMenuItem = new ToolStripMenuItem();
            appleToolStripMenuItem = new ToolStripMenuItem();
            xiaomiToolStripMenuItem = new ToolStripMenuItem();
            stockToolStripMenuItem = new ToolStripMenuItem();
            cerrasToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.BackColor = SystemColors.ActiveCaption;
            menuStrip.Items.AddRange(new ToolStripItem[] { inicioToolStripMenuItem, celularesToolStripMenuItem, stockToolStripMenuItem, cerrasToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(800, 24);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip1";
            menuStrip.ItemClicked += menuStrip_ItemClicked;
            // 
            // inicioToolStripMenuItem
            // 
            inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            inicioToolStripMenuItem.Size = new Size(48, 20);
            inicioToolStripMenuItem.Text = "Inicio";
            inicioToolStripMenuItem.Click += inicioToolStripMenuItem_Click;
            // 
            // celularesToolStripMenuItem
            // 
            celularesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { samsungToolStripMenuItem, appleToolStripMenuItem, xiaomiToolStripMenuItem });
            celularesToolStripMenuItem.Name = "celularesToolStripMenuItem";
            celularesToolStripMenuItem.Size = new Size(67, 20);
            celularesToolStripMenuItem.Text = "Celulares";
            celularesToolStripMenuItem.Click += celularesToolStripMenuItem_Click;
            // 
            // samsungToolStripMenuItem
            // 
            samsungToolStripMenuItem.Name = "samsungToolStripMenuItem";
            samsungToolStripMenuItem.Size = new Size(123, 22);
            samsungToolStripMenuItem.Text = "Samsung";
            // 
            // appleToolStripMenuItem
            // 
            appleToolStripMenuItem.Name = "appleToolStripMenuItem";
            appleToolStripMenuItem.Size = new Size(123, 22);
            appleToolStripMenuItem.Text = "Apple";
            // 
            // xiaomiToolStripMenuItem
            // 
            xiaomiToolStripMenuItem.Name = "xiaomiToolStripMenuItem";
            xiaomiToolStripMenuItem.Size = new Size(123, 22);
            xiaomiToolStripMenuItem.Text = "Xiaomi";
            // 
            // stockToolStripMenuItem
            // 
            stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            stockToolStripMenuItem.Size = new Size(48, 20);
            stockToolStripMenuItem.Text = "Stock";
            stockToolStripMenuItem.Click += stockToolStripMenuItem_Click;
            // 
            // cerrasToolStripMenuItem
            // 
            cerrasToolStripMenuItem.Name = "cerrasToolStripMenuItem";
            cerrasToolStripMenuItem.Size = new Size(51, 20);
            cerrasToolStripMenuItem.Text = "Cerrar";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(-1, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(544, 287);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip;
            Name = "MenuPrincipal";
            Text = "MenuPrincipal";
            Load += MenuPrincipal_Load;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem inicioToolStripMenuItem;
        private ToolStripMenuItem celularesToolStripMenuItem;
        private ToolStripMenuItem samsungToolStripMenuItem;
        private ToolStripMenuItem appleToolStripMenuItem;
        private ToolStripMenuItem xiaomiToolStripMenuItem;
        private ToolStripMenuItem stockToolStripMenuItem;
        private ToolStripMenuItem cerrasToolStripMenuItem;
        private PictureBox pictureBox1;
    }
}