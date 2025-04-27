using Fitness_Tracker.Models;
using Fitness_Tracker.Controller;

namespace Fitness_Tracker
{
    public partial class Register : Form
    {
        private UserController _userController;
        private Main _loginForm;

        public Register(Main loginForm)
        {
            InitializeComponent();
            _loginForm = loginForm; 
            _userController = new UserController(this, _loginForm);
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            if (tbPassword.Text != tbConfirmPassword.Text)
            {
                ShowErrorMessage("Passwords do not match.");
                return;
            }

            User user = new User
            {
                username = tbUsername.Text, 
                email = tbEmail.Text,       
                password = tbPassword.Text, 
            };

            _userController.Register(user);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearRegistrationFields();
        }

        private void linkToLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            this.Hide();
            _loginForm.Show();
        }

        public void ShowErrorMessage(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ShowSuccessMessage(string message)
        {
            if (MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
            {
                Main login = new Main();
                this.Close();
            }
        }

        public void ClearRegistrationFields()
        {
            tbUsername.Text = string.Empty;
            tbEmail.Text = string.Empty;
            tbPassword.Text = string.Empty;
            tbConfirmPassword.Text = string.Empty;
        }
    }
}