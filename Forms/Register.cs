using P10_Blog_Generator_AI_Frontend.DTOs;
using P10_Blog_Generator_AI_Frontend.Services;

namespace P10_Blog_Generator_AI_Frontend.Forms
{
    public partial class Register : Form
    {
        private readonly ApiService _apiService;
        public Register(ApiService apiService)
        {
            InitializeComponent();
            _apiService = apiService;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void lnklblLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Login login = new Login(_apiService);
            login.ShowDialog();
        }

        private async void btnRegister_Click(object sender, EventArgs e)
        {
            btnRegister.Enabled = false;
            if (!ValidateInputs())
            {
                MessageBox.Show(
                    "Please enter valid information.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            var request = new RegisterRequestDto
            {
                Name = txtName.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Password = txtPassword.Text
            };

            try
            {
                var response = await _apiService.RegisterAsync(request);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Registration Successful!");

                    this.Hide();
                    Login login = new Login(_apiService);
                    login.ShowDialog();
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
                btnRegister.Enabled = true;
            }

        }

        bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text) ||
                string.IsNullOrWhiteSpace(txtConfirmPassword.Text))
            {
                MessageBox.Show("All fields are required.");
                return false;
            }

            if (txtName.Text.Length < 3 || txtName.Text.Length > 10)
            {
                MessageBox.Show("Name must be between 3 and 10 characters.");
                return false;
            }

            if (!txtEmail.Text.Contains("@"))
            {
                MessageBox.Show("Please enter a valid email.");
                return false;
            }

            if (txtPassword.Text.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters.");
                return false;
            }

            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Passwords do not match.");
                return false;
            }

            return true;
        }
    }
}
