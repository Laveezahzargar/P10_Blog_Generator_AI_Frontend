namespace P10_Blog_Generator_AI_Frontend
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
            label1 = new Label();
            label2 = new Label();
            btnRegister = new Button();
            btnLogin = new Button();
            btnExit = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(555, 97);
            label1.Name = "label1";
            label1.Size = new Size(253, 25);
            label1.TabIndex = 0;
            label1.Text = "Welcome to AI Blog Generator";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(150, 167);
            label2.Name = "label2";
            label2.Size = new Size(1097, 25);
            label2.TabIndex = 1;
            label2.Text = "AI Blog Generator is an intelligent content creation platform that helps users generate high-quality blog articles using artificial intelligence.";
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(589, 392);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(112, 62);
            btnRegister.TabIndex = 2;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(717, 392);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(112, 63);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(656, 461);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(112, 62);
            btnExit.TabIndex = 4;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(150, 216);
            label3.Name = "label3";
            label3.Size = new Size(1136, 25);
            label3.TabIndex = 5;
            label3.Text = "Simply provide details such as the blog topic, category, target audience, tone, and desired length, and the system will create engaging content";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(150, 267);
            label4.Name = "label4";
            label4.Size = new Size(1156, 25);
            label4.TabIndex = 6;
            label4.Text = "within seconds. Users can securely manage their accounts, view previously generated blogs, regenerate content,and maintain their complete blog";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(150, 321);
            label5.Name = "label5";
            label5.Size = new Size(441, 25);
            label5.TabIndex = 7;
            label5.Text = "history through an intuitive and user-friendly interface.";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(479, 594);
            label6.Name = "label6";
            label6.Size = new Size(488, 25);
            label6.TabIndex = 8;
            label6.Text = "© 2026 AI Blog Generator | Powered by Artificial Intelligence";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1389, 667);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnExit);
            Controls.Add(btnLogin);
            Controls.Add(btnRegister);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnRegister;
        private Button btnLogin;
        private Button btnExit;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}
