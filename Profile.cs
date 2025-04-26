using Fitness_Tracker.Controller;
using Fitness_Tracker.Utils;
using Fitness_Tracker.Models;

namespace Fitness_Tracker
{
    public partial class Profile : Form
    {
        private UserController _userController;
        private Main _loginForm;
        private GoalForm _goalForm;

        public Profile(Main loginForm)
        {
            InitializeComponent();
            _loginForm = loginForm;
            _userController = new UserController(this, _loginForm);
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void Profile_Load(object sender, EventArgs e)
        {
            tbUsername.Text = SessionManager.Username;
            tbEmail.Text = SessionManager.UserEmail;
            tbWeight.Text = SessionManager.UserWeight.ToString();
            tbHeight.Text = SessionManager.UserHeight.ToString();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to log out?", "Confirm logout", MessageBoxButtons.OK, MessageBoxIcon.Question) == DialogResult.OK)
            {
                _userController.Logout();
                this.Hide();
                _loginForm.Show();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            tbUsername.Enabled = true;
            tbEmail.Enabled = true;
            tbWeight.Enabled = true;
            tbHeight.Enabled = true;

            btnUpdate.Visible = true;
            btnReset.Visible = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            User user = new User
            {
                Id = SessionManager.UserId,
                username = tbUsername.Text,
                email = tbEmail.Text,
                weight = int.TryParse(tbWeight.Text, out int parsedWeight) ? parsedWeight : 0,
                height = int.TryParse(tbHeight.Text, out int parsedHeight) ? parsedHeight : 0,
            };

            _userController.AccountUpdate(user);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Profile_Load(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Delete Account?", "Confirm Account Delete", MessageBoxButtons.OK, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (_userController.AccountDelete(SessionManager.Username))
                {
                    this.Hide();
                    _loginForm.Show();
                }
                else
                {
                    ShowErrorMessage("Account Delete Fail.");
                }
            }
        }

        public void ShowErrorMessage(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ShowSuccessMessage(string message)
        {
            if (MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
            {
                tbUsername.Enabled = false;
                tbEmail.Enabled = false;
                tbWeight.Enabled = false;
                tbHeight.Enabled = false;

                btnUpdate.Visible = false;
                btnReset.Visible = false;
            }
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            return;
        }

        private void btnGoal_Click(object sender, EventArgs e)
        {
            _goalForm = new GoalForm();
            this.Hide();
            _goalForm.Show();
        }
    }
}
