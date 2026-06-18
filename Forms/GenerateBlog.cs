using P10_Blog_Generator_AI_Frontend.DTOs;
using P10_Blog_Generator_AI_Frontend.Enums;
using P10_Blog_Generator_AI_Frontend.Services;
using P9_Blog_Generator_AI_Backend.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net.Http.Json;
using System.Text;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace P10_Blog_Generator_AI_Frontend.Forms
{
    public partial class GenerateBlog : Form
    {
        private readonly ApiService _apiService;
        public GenerateBlog(ApiService apiService)
        {
            InitializeComponent();
            _apiService = apiService;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private async void btnGenerateBlog_Click_1(object sender, EventArgs e)
        {
            btnGenerateBlog.Enabled = false;
            if (!ValidateInputs())
            {
                return;
            }

            var request = new GenerateBlogRequestDto
            {
                Topic = txtTopic.Text.Trim(),
                Category = cmbCategory.Text,
                Audience = cmbAudience.Text,
                Tone = cmbTone.Text,
                WordCount = numWordCount.Text.ToString(),
            };

            try
            {
                var response = await _apiService.GenerateBlogAsync(request);

                if (response.IsSuccessStatusCode)
                {
                    var blog =
                        await response.Content.ReadFromJsonAsync<BlogDto>();

                    ViewBlog viewBlog =
                        new ViewBlog(_apiService, blog);

                    this.Hide();
                    viewBlog.ShowDialog();
                    this.Close();
                }
                else
                {
                    var error = await response.Content.ReadAsStringAsync();
                    if (error.Contains("429"))
                    {
                        MessageBox.Show(
                            "AI service rate limit reached. Please try again in a minute.");
                    }
                    else
                    {
                        MessageBox.Show(error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                btnGenerateBlog.Enabled = true;
            }
        }
        bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtTopic.Text) ||
                string.IsNullOrWhiteSpace(cmbCategory.Text) ||
                string.IsNullOrWhiteSpace(cmbAudience.Text) ||
                string.IsNullOrWhiteSpace(cmbTone.Text))
            {
                MessageBox.Show("All fields are required.");
                return false;
            }

            if (txtTopic.Text.Length < 5)
            {
                MessageBox.Show("Topic must be at least 5 characters.");
                return false;
            }

            return true;
        }

        private void GenerateBlog_Load(object sender, EventArgs e)
        {
            cmbCategory.DataSource =
        Enum.GetNames(typeof(Category));

            cmbAudience.DataSource =
                Enum.GetNames(typeof(Audience));

            cmbTone.DataSource =
                Enum.GetNames(typeof(Tone));
        }
    }
}
