using Fitness_Tracker.Controller;
using Fitness_Tracker.Models;
using Fitness_Tracker.Utils;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Fitness_Tracker
{
    public partial class ActivityForm : Form
    {
        private UserController _userController;
        private GoalController _goalController;
        private ActivityController _activityController;
        private Main _loginForm;
        private Profile _profileForm;
        private GoalForm _goalForm;

        public ActivityForm()
        {
            InitializeComponent();
            _loginForm = new Main();
            _userController = new UserController(_loginForm);
            _activityController = new ActivityController(this);
            _activityController.DisplayActivitiesByUsername(dataGridViewActivity, SessionManager.Username);
            InsertDataToComboBox();
        }

        public void InsertDataToComboBox()
        {
            List<ActivityType> activityTypes = _activityController.GetActivityTypeList(); // Get the list of ActivityTypes

            if (activityTypes != null && activityTypes.Any()) // Check for null and empty list
            {
                cbType.DataSource = activityTypes;
                cbType.DisplayMember = "activity"; // Use the "activity" property of ActivityType
                cbType.ValueMember = "Id";       // Optionally, set the ValueMember to the Id
            }
            else
            {
                cbType.Items.Clear(); // Clear any existing items
                cbType.Items.Add("No activities available"); // Add a message
                cbType.Enabled = false;                   // Disable the ComboBox
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
            _goalForm = new GoalForm();
            this.Hide();
            _goalForm.Show();
        }
        private void btnActivity_Click(object sender, EventArgs e)
        {
            return;
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
        public void ShowErrorMessage(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ShowSuccessMessage(string message)
        {
            MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            _activityController.DisplayActivitiesByUsername(dataGridViewActivity, SessionManager.Username);
            tbOne.Text = string.Empty;
            tbTwo.Text = string.Empty;
            tbThree.Text = string.Empty;
        }

        private void dataGridViewActivity_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedRow = dataGridViewActivity.SelectedRows[0];
            if (selectedRow != null)
            {
                tbId.Text = selectedRow.Cells[0].Value.ToString();
            }
        }

        private void ActivityForm_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewActivity_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedRow = dataGridViewActivity.SelectedRows[0];
            if (selectedRow != null)
            {
                tbId.Text = selectedRow.Cells[0].Value.ToString();
            }
        }

        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbType.SelectedItem != null)
            {
                ActivityType activity = (ActivityType)cbType.SelectedItem;
                tbOne.PlaceholderText = activity.metric_one.ToString();
                tbTwo.PlaceholderText = activity.metric_two.ToString();
                tbThree.PlaceholderText = activity.metric_three.ToString();
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            ActivityType activity = (ActivityType)cbType.SelectedItem;
            int metric_one_value = int.TryParse(tbOne.Text, out int parsedOne) ? parsedOne : 0;
            int metric_two_value = int.TryParse(tbTwo.Text, out int parsedTwo) ? parsedTwo : 0;
            int metric_three_value = int.TryParse(tbThree.Text, out int parsedThree) ? parsedThree : 0;

            _activityController.AddActivity(activity.activity, metric_one_value, metric_two_value, metric_three_value);
        }
    }
}
