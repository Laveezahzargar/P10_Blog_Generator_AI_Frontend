namespace P10_Blog_Generator_AI_Frontend.Forms
{
    partial class Dashboard
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
            lblName = new Label();
            btnGenerateBlog = new Button();
            btnRefresh = new Button();
            btnLogout = new Button();
            label3 = new Label();
            dataGridViewBlogs = new DataGridView();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBlogs).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(399, 30);
            label1.Name = "label1";
            label1.Size = new Size(180, 25);
            label1.TabIndex = 0;
            label1.Text = "AI BLOG GENERATOR";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(399, 75);
            lblName.Name = "lblName";
            lblName.Size = new Size(125, 25);
            lblName.TabIndex = 1;
            lblName.Text = "Welcome User";
            lblName.Click += label2_Click;
            // 
            // btnGenerateBlog
            // 
            btnGenerateBlog.Location = new Point(399, 122);
            btnGenerateBlog.Name = "btnGenerateBlog";
            btnGenerateBlog.Size = new Size(149, 47);
            btnGenerateBlog.TabIndex = 2;
            btnGenerateBlog.Text = "Generate Blog";
            btnGenerateBlog.UseVisualStyleBackColor = true;
            btnGenerateBlog.Click += btnGenerateBlog_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(620, 122);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(112, 47);
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(807, 122);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(112, 47);
            btnLogout.TabIndex = 4;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(399, 195);
            label3.Name = "label3";
            label3.Size = new Size(56, 25);
            label3.TabIndex = 5;
            label3.Text = "Blogs";
            // 
            // dataGridViewBlogs
            // 
            dataGridViewBlogs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBlogs.Location = new Point(105, 231);
            dataGridViewBlogs.Name = "dataGridViewBlogs";
            dataGridViewBlogs.RowHeadersWidth = 62;
            dataGridViewBlogs.Size = new Size(1158, 355);
            dataGridViewBlogs.TabIndex = 6;
            dataGridViewBlogs.CellClick += dataGridViewBlogs_CellClick;
            dataGridViewBlogs.CellContentClick += dataGridViewBlogs_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(417, 603);
            label2.Name = "label2";
            label2.Size = new Size(488, 25);
            label2.TabIndex = 7;
            label2.Text = "© 2026 AI Blog Generator | Powered by Artificial Intelligence";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1352, 671);
            Controls.Add(label2);
            Controls.Add(dataGridViewBlogs);
            Controls.Add(label3);
            Controls.Add(btnLogout);
            Controls.Add(btnRefresh);
            Controls.Add(btnGenerateBlog);
            Controls.Add(lblName);
            Controls.Add(label1);
            Name = "Dashboard";
            Text = "Dashboard";
            Load += Dashboard_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewBlogs).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblName;
        private Button btnGenerateBlog;
        private Button btnRefresh;
        private Button btnLogout;
        private Label label3;
        private DataGridView dataGridViewBlogs;
        private Label label2;
    }
}