using Fitness_Tracker.Controller;
using Fitness_Tracker.Models;
using Fitness_Tracker.Utils;

namespace Fitness_Tracker
{
    public partial class GoalForm : Form
    {
        private UserController _userController;
        private GoalController _goalController;
        private Main _loginForm;
        private Profile _profileForm;
        private ActivityForm _activityForm;

        public GoalForm()
        {
            InitializeComponent();
            _loginForm = new Main();
            _userController = new UserController(_loginForm);
            _goalController = new GoalController(this);
            _goalController.DisplayGoalsByUsername(dataGridViewGoal, SessionManager.Username);
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
            _profileForm = new Profile(_loginForm);
            this.Hide();
            _profileForm.Show();
        }

        private void btnGoal_Click(object sender, EventArgs e)
        {
            return;
        }

        private void btnActivity_Click(object sender, EventArgs e)
        {
            _activityForm = new ActivityForm();
            this.Hide();
            _activityForm.Show();
        }

        public void ShowErrorMessage(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ShowSuccessMessage(string message)
        {
            if (MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
            {
                _goalController.DisplayGoalsByUsername(dataGridViewGoal, SessionManager.Username);
                tbId.Text = string.Empty;
                tbCalBurn.Text = string.Empty;
            }

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (IsNumber.IsNumberOrNot(tbCalBurn.Text))
            {
                Goals goal = new Goals
                {
                    Username = SessionManager.Username,
                    Goal = int.TryParse(tbCalBurn.Text, out int parsedGoal) ? parsedGoal : 0,
                    StartDate = dtpStart.Value.ToString("M/dd/yyyy"),
                    EndDate = dtpEnd.Value.ToString("M/dd/yyyy"),
                };

                _goalController.AddGoal(goal);
            }
            else
            {
                ShowErrorMessage("Calories must be Number");
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (IsNumber.IsNumberOrNot(tbCalBurn.Text))
            {
                Goals goal = new Goals
                {
                    Id = int.TryParse(tbId.Text, out int parsedId) ? parsedId : 0,
                    Username = SessionManager.Username,
                    Goal = int.TryParse(tbCalBurn.Text, out int parsedGoal) ? parsedGoal : 0,
                    StartDate = dtpStart.Value.ToString("M/dd/yyyy"),
                    EndDate = dtpEnd.Value.ToString("M/dd/yyyy"),
                };

                _goalController.UpdateGoal(goal);
            }
            else
            {
                ShowErrorMessage("Calories must be Number");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int Id = int.TryParse(tbId.Text, out int parsedId) ? parsedId : 0;
            if (MessageBox.Show("Are you sure you want to Delete Goal?", "Confirm Goal Delete", MessageBoxButtons.OK, MessageBoxIcon.Question) == DialogResult.OK)
            {
                _goalController.DeleteGoal(Id);
            }
        }

        private void dataGridViewGoal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedRow = dataGridViewGoal.SelectedRows[0];
            if (selectedRow != null)
            {
                tbId.Text = selectedRow.Cells[0].Value.ToString();
                tbCalBurn.Text = selectedRow.Cells[2].Value.ToString();
            }
        }

        private void dataGridViewGoal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
