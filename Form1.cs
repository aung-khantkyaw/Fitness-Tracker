using Fitness_Tracker.Controller;

namespace Fitness_Tracker
{
    public partial class Main : Form
    {
        private UserController _userController;

        public Main()
        {
            InitializeComponent();
            _userController = new UserController(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string password = tbPassword.Text;
            _userController.Login(username, password);
        }

        private void linkToRegistration_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register register = new Register(this);
            this.Hide();
            register.Show();
        }

        public void ShowErrorMessage(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ShowSuccessMessage(string message)
        {
            MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void ClearLoginFields()
        {
            tbUsername.Text = string.Empty;
            tbPassword.Text = string.Empty;
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
