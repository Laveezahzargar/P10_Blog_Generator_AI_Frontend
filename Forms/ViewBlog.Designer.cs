namespace P10_Blog_Generator_AI_Frontend.Forms
{
    partial class ViewBlog
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
            label3 = new Label();
            lblTitle = new Label();
            richTextBoxBlogContent = new RichTextBox();
            btnRegenerate = new Button();
            btnDelete = new Button();
            btnClose = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(417, 56);
            label2.Name = "label2";
            label2.Size = new Size(44, 25);
            label2.TabIndex = 1;
            label2.Text = "Title";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(450, 585);
            label3.Name = "label3";
            label3.Size = new Size(488, 25);
            label3.TabIndex = 2;
            label3.Text = "© 2026 AI Blog Generator | Powered by Artificial Intelligence";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(521, 56);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(59, 25);
            lblTitle.TabIndex = 3;
            lblTitle.Text = "label4";
            // 
            // richTextBoxBlogContent
            // 
            richTextBoxBlogContent.Location = new Point(417, 116);
            richTextBoxBlogContent.Name = "richTextBoxBlogContent";
            richTextBoxBlogContent.Size = new Size(539, 308);
            richTextBoxBlogContent.TabIndex = 4;
            richTextBoxBlogContent.Text = "";
            richTextBoxBlogContent.TextChanged += richTextBoxBlogContent_TextChanged;
            // 
            // btnRegenerate
            // 
            btnRegenerate.Location = new Point(503, 481);
            btnRegenerate.Name = "btnRegenerate";
            btnRegenerate.Size = new Size(112, 47);
            btnRegenerate.TabIndex = 5;
            btnRegenerate.Text = "Regenerate";
            btnRegenerate.UseVisualStyleBackColor = true;
            btnRegenerate.Click += btnRegenerate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(657, 481);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 47);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(805, 481);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(112, 47);
            btnClose.TabIndex = 7;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // ViewBlog
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1353, 668);
            Controls.Add(btnClose);
            Controls.Add(btnDelete);
            Controls.Add(btnRegenerate);
            Controls.Add(richTextBoxBlogContent);
            Controls.Add(lblTitle);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "ViewBlog";
            Text = "ViewBlog";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private Label lblTitle;
        private RichTextBox richTextBoxBlogContent;
        private Button btnRegenerate;
        private Button btnDelete;
        private Button btnClose;
    }
}