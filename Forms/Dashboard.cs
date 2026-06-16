using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace P10_Blog_Generator_AI_Frontend.Forms
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            LoadBlogs();
        }

        void LoadBlogs()
        {

        }

        private void dataGridViewBlogs_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewBlogs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnGenerateBlog_Click(object sender, EventArgs e)
        {
            this.Hide();
            GenerateBlog generateBlog = new GenerateBlog();
            generateBlog.ShowDialog();
        }
    }
}
