namespace P10_Blog_Generator_AI_Frontend.Forms
{
    partial class Register
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
            btnRegister = new Button();
            label6 = new Label();
            lnklblLogin = new LinkLabel();
            txtName = new TextBox();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            txtConfirmPassword = new TextBox();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(625, 43);
            label1.Name = "label1";
            label1.Size = new Size(75, 25);
            label1.TabIndex = 0;
            label1.Text = "Register";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(481, 132);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(481, 197);
            label3.Name = "label3";
            label3.Size = new Size(54, 25);
            label3.TabIndex = 2;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(481, 262);
            label4.Name = "label4";
            label4.Size = new Size(87, 25);
            label4.TabIndex = 3;
            label4.Text = "Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(481, 333);
            label5.Name = "label5";
            label5.Size = new Size(156, 25);
            label5.TabIndex = 4;
            label5.Text = "Confirm Password";
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(768, 395);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(112, 45);
            btnRegister.TabIndex = 5;
            btnRegister.Text = "Sign Up";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(561, 461);
            label6.Name = "label6";
            label6.Size = new Size(221, 25);
            label6.TabIndex = 6;
            label6.Text = "Already Have an account ?";
            label6.Click += label6_Click;
            // 
            // lnklblLogin
            // 
            lnklblLogin.AutoSize = true;
            lnklblLogin.Location = new Point(644, 500);
            lnklblLogin.Name = "lnklblLogin";
            lnklblLogin.Size = new Size(56, 25);
            lnklblLogin.TabIndex = 7;
            lnklblLogin.TabStop = true;
            lnklblLogin.Text = "Login";
            lnklblLogin.LinkClicked += lnklblLogin_LinkClicked;
            // 
            // txtName
            // 
            txtName.Location = new Point(663, 132);
            txtName.Name = "txtName";
            txtName.Size = new Size(245, 31);
            txtName.TabIndex = 8;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(663, 197);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(245, 31);
            txtEmail.TabIndex = 9;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(663, 262);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(245, 31);
            txtPassword.TabIndex = 10;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(663, 327);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(245, 31);
            txtConfirmPassword.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(461, 592);
            label7.Name = "label7";
            label7.Size = new Size(488, 25);
            label7.TabIndex = 12;
            label7.Text = "© 2026 AI Blog Generator | Powered by Artificial Intelligence";
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1344, 671);
            Controls.Add(label7);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtName);
            Controls.Add(lnklblLogin);
            Controls.Add(label6);
            Controls.Add(btnRegister);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Register";
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnRegister;
        private Label label6;
        private LinkLabel lnklblLogin;
        private TextBox txtName;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private TextBox txtConfirmPassword;
        private Label label7;
    }
}