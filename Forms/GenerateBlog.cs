using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace P10_Blog_Generator_AI_Frontend.Forms
{
    public partial class GenerateBlog : Form
    {
        public GenerateBlog()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void btnGenerateBlog_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            ViewBlog ViewBlog = new ViewBlog();
            ViewBlog.ShowDialog();
        }
    }
}
