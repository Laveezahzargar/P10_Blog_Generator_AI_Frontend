using P10_Blog_Generator_AI_Frontend.DTOs;
using P10_Blog_Generator_AI_Frontend.Services;
using System.Net.Http.Json;

namespace P10_Blog_Generator_AI_Frontend.Forms
{
    public partial class Login : Form
    {
        private readonly ApiService _apiService;
        public Login(ApiService apiService)
        {
            InitializeComponent();
            _apiService = apiService;

        }

        private void lnklblRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Register register = new Register(_apiService);
            register.ShowDialog();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            btnLogin.Enabled = false;
            if (!ValidateInputs())
            {
                return;
            }
            var request = new LoginRequestDto
            {
                Email = txtEmail.Text.Trim(),
                Password = txtPassword.Text
            };
            try
            {
                var response = await _apiService.LoginAsync(request);

                if (response.IsSuccessStatusCode)
                {
                    var loginResponse =
                        await response.Content.ReadFromJsonAsync<LoginResponseDto>();

                    UserSession.Token = loginResponse.Token;

                    this.Hide();

                    Dashboard dashboard = new Dashboard(_apiService);
                    dashboard.ShowDialog();

                    this.Close();
                }
                else
                {
                    var error = await response.Content.ReadAsStringAsync();
                    MessageBox.Show(error);
                }
            }
            catch (Exception ex)
            { 
                MessageBox.Show(ex.Message);
            }
            finally
            {
                btnLogin.Enabled = true;
            }

        }

        bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Email and Password are required.");
                return false;
            }

            if (!txtEmail.Text.Contains("@"))
            {
                MessageBox.Show("Please enter a valid email.");
                return false;
            }

            return true;
        }
    }
}
