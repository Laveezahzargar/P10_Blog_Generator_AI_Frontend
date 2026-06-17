namespace P10_Blog_Generator_AI_Frontend.Forms
{
    partial class Login
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
            lnklblRegister = new LinkLabel();
            label5 = new Label();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(643, 49);
            label1.Name = "label1";
            label1.Size = new Size(56, 25);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(518, 123);
            label2.Name = "label2";
            label2.Size = new Size(54, 25);
            label2.TabIndex = 1;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(518, 185);
            label3.Name = "label3";
            label3.Size = new Size(87, 25);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(584, 366);
            label4.Name = "label4";
            label4.Size = new Size(205, 25);
            label4.TabIndex = 3;
            label4.Text = "Don't Have an account ?";
            // 
            // lnklblRegister
            // 
            lnklblRegister.AutoSize = true;
            lnklblRegister.Location = new Point(643, 417);
            lnklblRegister.Name = "lnklblRegister";
            lnklblRegister.Size = new Size(75, 25);
            lnklblRegister.TabIndex = 4;
            lnklblRegister.TabStop = true;
            lnklblRegister.Text = "Register";
            lnklblRegister.LinkClicked += lnklblRegister_LinkClicked;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(455, 545);
            label5.Name = "label5";
            label5.Size = new Size(488, 25);
            label5.TabIndex = 5;
            label5.Text = "© 2026 AI Blog Generator | Powered by Artificial Intelligence";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(662, 117);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(224, 31);
            txtEmail.TabIndex = 6;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(662, 179);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(224, 31);
            txtPassword.TabIndex = 7;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(752, 232);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(112, 49);
            btnLogin.TabIndex = 8;
            btnLogin.Text = "Sign In";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1349, 666);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(label5);
            Controls.Add(lnklblRegister);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private LinkLabel lnklblRegister;
        private Label label5;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private Button btnLogin;
    }
}