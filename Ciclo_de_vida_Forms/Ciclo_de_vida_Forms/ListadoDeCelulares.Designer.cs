namespace Ciclo_de_vida_Forms
{
    partial class ListadoDeCelulares
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListadoDeCelulares));
            dtGCelulares = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dtGCelulares).BeginInit();
            SuspendLayout();
            // 
            // dtGCelulares
            // 
            dtGCelulares.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtGCelulares.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtGCelulares.Location = new Point(26, 12);
            dtGCelulares.Name = "dtGCelulares";
            dtGCelulares.RowTemplate.Height = 25;
            dtGCelulares.Size = new Size(601, 294);
            dtGCelulares.TabIndex = 0;
            dtGCelulares.CellContentClick += dtGCelulares_CellContentClick;
            // 
            // ListadoDeCelulares
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(625, 318);
            Controls.Add(dtGCelulares);
            Name = "ListadoDeCelulares";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ListadoDeCelulares";
            Load += ListadoDeCelulares_Load;
            ((System.ComponentModel.ISupportInitialize)dtGCelulares).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtGCelulares;
    }
}