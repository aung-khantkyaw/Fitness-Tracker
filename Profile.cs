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
        private ActivityForm _activityForm;

        public Profile(Main loginForm)
        {
            InitializeComponent();
            _loginForm = loginForm;
            _userController = new UserController(this, _loginForm);
            label12.Text = "Goal Id is : " + SessionManager.Goal;
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
            tbAge.Text = SessionManager.UserAge.ToString();
            if (SessionManager.UserGender.Equals("Male", StringComparison.Ordinal))
            {
                rBtnMale.Checked = true;
            }
            else if (SessionManager.UserGender.Equals("Female", StringComparison.Ordinal))
            {
                rBtnFemale.Checked = true;
            }
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

        private void btnProfile_Click(object sender, EventArgs e)
        {

        }

        private void btnGoal_Click(object sender, EventArgs e)
        {
            if (SessionManager.UserWeight > 0)
            {
                _goalForm = new GoalForm();
                this.Hide();
                _goalForm.Show();
            }
            else
            {
                ShowErrorMessage("If your Weight is not greater than 0, you can't go to goal.");
            }
        }

        private void btnActivity_Click(object sender, EventArgs e)
        {
            if (SessionManager.UserWeight > 0)
            {
                _activityForm = new ActivityForm();
                this.Hide();
                _activityForm.Show();
            }
            else
            {
                ShowErrorMessage("If your Weight is not greater than 0, you can't go to goal.");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            tbUsername.Enabled = true;
            tbEmail.Enabled = true;
            tbWeight.Enabled = true;
            tbHeight.Enabled = true;
            tbAge.Enabled = true;
            rBtnMale.Enabled = true;
            rBtnFemale.Enabled = true;

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
                age = int.TryParse(tbAge.Text, out int parsedAge) ? parsedAge : 0,
                gender = rBtnMale.Checked ? "Male" : (rBtnFemale.Checked ? "Female" : null),
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
                tbAge.Enabled = false;
                rBtnMale.Enabled = false;
                rBtnFemale.Enabled = false;

                btnUpdate.Visible = false;
                btnReset.Visible = false;
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
