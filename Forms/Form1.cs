

using P10_Blog_Generator_AI_Frontend.Forms;
using P10_Blog_Generator_AI_Frontend.Services;

namespace P10_Blog_Generator_AI_Frontend
{
    public partial class Form1 : Form
    {
        private readonly ApiService _apiService;
        public Form1()
        {
            InitializeComponent();
            _apiService = new ApiService();
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register register = new Register(_apiService);   
            register.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login(_apiService);
            login.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
