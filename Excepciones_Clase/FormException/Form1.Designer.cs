namespace FormException
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
            txtBox2 = new TextBox();
            txtBox1 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtBox2
            // 
            txtBox2.Location = new Point(138, 33);
            txtBox2.Name = "txtBox2";
            txtBox2.Size = new Size(100, 23);
            txtBox2.TabIndex = 0;
            txtBox2.Text = "Box2";
            // 
            // txtBox1
            // 
            txtBox1.Location = new Point(12, 33);
            txtBox1.Name = "txtBox1";
            txtBox1.Size = new Size(100, 23);
            txtBox1.TabIndex = 1;
            txtBox1.Text = "Box1";
            // 
            // button1
            // 
            button1.Location = new Point(91, 96);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(260, 192);
            Controls.Add(button1);
            Controls.Add(txtBox1);
            Controls.Add(txtBox2);
            Name = "Form1";
            Text = "Veamos Excepciones";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBox2;
        private TextBox txtBox1;
        private Button button1;
    }
}