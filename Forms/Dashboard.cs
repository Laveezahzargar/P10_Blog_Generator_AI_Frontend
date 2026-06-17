using P10_Blog_Generator_AI_Frontend.DTOs;
using P10_Blog_Generator_AI_Frontend.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net.Http.Json;
using System.Text;
using System.Windows.Forms;

namespace P10_Blog_Generator_AI_Frontend.Forms
{
    public partial class Dashboard : Form
    {
        private readonly ApiService _apiService;
        public Dashboard(ApiService apiService)
        {
            InitializeComponent();
            _apiService = apiService;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            UserSession.Token = string.Empty;

            this.Hide();

            Login login = new Login(_apiService);
            login.ShowDialog();

            this.Close();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            LoadBlogs();
        }

        private async void LoadBlogs()
        {
            try
            {
                var blogs = await _apiService.GetBlogsAsync();

                dataGridViewBlogs.DataSource = null;
                dataGridViewBlogs.DataSource = blogs;

                AddActionColumns();

                dataGridViewBlogs.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;

                dataGridViewBlogs.RowTemplate.Height = 60;

                if (dataGridViewBlogs.Columns["GeneratedBlogId"] != null)
                {
                    dataGridViewBlogs.Columns["GeneratedBlogId"].Visible = false;
                }

                if (dataGridViewBlogs.Columns["Title"] != null)
                {
                    dataGridViewBlogs.Columns["Title"].HeaderText = "Title";
                }

                if (dataGridViewBlogs.Columns["ContentPreview"] != null)
                {
                    dataGridViewBlogs.Columns["ContentPreview"].HeaderText =
                        "Preview";
                }

                if (dataGridViewBlogs.Columns["GeneratedAt"] != null)
                {
                    dataGridViewBlogs.Columns["GeneratedAt"].HeaderText =
                        "Created At";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddActionColumns()
        {
            if (dataGridViewBlogs.Columns["View"] == null)
            {
                dataGridViewBlogs.Columns.Add(
                    new DataGridViewButtonColumn
                    {
                        Name = "View",
                        HeaderText = "View",
                        Text = "View",
                        UseColumnTextForButtonValue = true
                    });
            }

            if (dataGridViewBlogs.Columns["Regenerate"] == null)
            {
                dataGridViewBlogs.Columns.Add(
                    new DataGridViewButtonColumn
                    {
                        Name = "Regenerate",
                        HeaderText = "Regenerate",
                        Text = "Regenerate",
                        UseColumnTextForButtonValue = true
                    });
            }

            if (dataGridViewBlogs.Columns["Delete"] == null)
            {
                dataGridViewBlogs.Columns.Add(
                    new DataGridViewButtonColumn
                    {
                        Name = "Delete",
                        HeaderText = "Delete",
                        Text = "Delete",
                        UseColumnTextForButtonValue = true
                    });
            }
        }

        private async void dataGridViewBlogs_CellClick(
    object sender,
    DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            int blogId = Convert.ToInt32(
                dataGridViewBlogs.Rows[e.RowIndex]
                .Cells["GeneratedBlogId"].Value);

            int blogRequestId = Convert.ToInt32(
                dataGridViewBlogs.Rows[e.RowIndex]
                .Cells["BlogRequestId"].Value);

            string columnName =
                dataGridViewBlogs.Columns[e.ColumnIndex].Name;

            if (columnName == "View")
            {
                var blog = await _apiService.GetBlogByIdAsync(blogId);

                if (blog != null)
                {
                    ViewBlog viewBlog =
                        new ViewBlog(_apiService, blog);

                    viewBlog.ShowDialog();
                }
            }
            else if (columnName == "Delete")
            {
                var response =
                    await _apiService.DeleteBlogAsync(blogId);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Blog deleted.");
                    LoadBlogs();
                }
            }
            else if (columnName == "Regenerate")
            {
                var response =
                    await _apiService.RegenerateBlogAsync(blogRequestId);

                if (response.IsSuccessStatusCode)
                {
                    var blog =
                        await response.Content.ReadFromJsonAsync<BlogDto>();

                    MessageBox.Show("Blog regenerated.");

                    LoadBlogs();

                    if (blog != null)
                    {
                        ViewBlog viewBlog =
                            new ViewBlog(_apiService, blog);

                        viewBlog.ShowDialog();
                    }
                }
            }
        }
        

        private void dataGridViewBlogs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnGenerateBlog_Click(object sender, EventArgs e)
        {
            GenerateBlog generateBlog =
                new GenerateBlog(_apiService);

            generateBlog.ShowDialog();

            LoadBlogs();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadBlogs();
        }
    }
}
