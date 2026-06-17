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
    public partial class ViewBlog : Form
    {
        private readonly ApiService _apiService;
        private readonly BlogDto _blog;
        public ViewBlog(ApiService apiService, BlogDto blog)
        {
            InitializeComponent();

            _apiService = apiService;
            _blog = blog;

            LoadBlog();
        }
        private void LoadBlog()
        {
            lblTitle.Text = _blog.Title;
            richTextBoxBlogContent.Text = _blog.Content;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void btnRegenerate_Click(object sender, EventArgs e)
        {
            try
            {
                btnRegenerate.Enabled = false;
                var response =
                    await _apiService.RegenerateBlogAsync(_blog.BlogRequestId);

                if (response.IsSuccessStatusCode)
                {
                    var updatedBlog =
                        await response.Content.ReadFromJsonAsync<BlogDto>();

                    lblTitle.Text = updatedBlog.Title;
                    richTextBoxBlogContent.Text = updatedBlog.Content;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                btnRegenerate.Enabled = true;
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                "Are you sure you want to delete this blog?",
                "Confirm Delete",
                MessageBoxButtons.YesNo);

            if (result != DialogResult.Yes)
                return;

            try
            {
                var response =
               await _apiService.DeleteBlogAsync(_blog.BlogId);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Blog deleted successfully.");
                    Close();
                }
                else
                {
                    var error = await response.Content.ReadAsStringAsync();
                    MessageBox.Show(error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
           
        }

        private void richTextBoxBlogContent_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
