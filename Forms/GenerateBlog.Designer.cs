namespace P10_Blog_Generator_AI_Frontend.Forms
{
    partial class GenerateBlog
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnGenerateBlog = new Button();
            label7 = new Label();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            numericUpDown1 = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(617, 49);
            label1.Name = "label1";
            label1.Size = new Size(163, 25);
            label1.TabIndex = 0;
            label1.Text = "Generate New Blog";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(504, 105);
            label2.Name = "label2";
            label2.Size = new Size(53, 25);
            label2.TabIndex = 1;
            label2.Text = "Topic";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(504, 160);
            label3.Name = "label3";
            label3.Size = new Size(84, 25);
            label3.TabIndex = 2;
            label3.Text = "Category";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(504, 217);
            label4.Name = "label4";
            label4.Size = new Size(85, 25);
            label4.TabIndex = 3;
            label4.Text = "Audience";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(504, 272);
            label5.Name = "label5";
            label5.Size = new Size(49, 25);
            label5.TabIndex = 4;
            label5.Text = "Tone";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(504, 330);
            label6.Name = "label6";
            label6.Size = new Size(109, 25);
            label6.TabIndex = 5;
            label6.Text = "Word Count";
            // 
            // btnGenerateBlog
            // 
            btnGenerateBlog.Location = new Point(764, 393);
            btnGenerateBlog.Name = "btnGenerateBlog";
            btnGenerateBlog.Size = new Size(145, 50);
            btnGenerateBlog.TabIndex = 6;
            btnGenerateBlog.Text = "Generate Blog";
            btnGenerateBlog.UseVisualStyleBackColor = true;
            btnGenerateBlog.Click += btnGenerateBlog_Click_1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(473, 537);
            label7.Name = "label7";
            label7.Size = new Size(488, 25);
            label7.TabIndex = 7;
            label7.Text = "© 2026 AI Blog Generator | Powered by Artificial Intelligence";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(664, 99);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(257, 31);
            textBox1.TabIndex = 8;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(664, 152);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(257, 33);
            comboBox1.TabIndex = 9;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(664, 209);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(257, 33);
            comboBox2.TabIndex = 10;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(664, 264);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(257, 33);
            comboBox3.TabIndex = 11;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(664, 324);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(257, 31);
            numericUpDown1.TabIndex = 12;
            // 
            // GenerateBlog
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1354, 670);
            Controls.Add(numericUpDown1);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(label7);
            Controls.Add(btnGenerateBlog);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "GenerateBlog";
            Text = "GenerateBlog";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnGenerateBlog;
        private Label label7;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private NumericUpDown numericUpDown1;
    }
}