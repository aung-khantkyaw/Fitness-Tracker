using Fitness_Tracker.Models;
using Fitness_Tracker.DataAccess;
using Fitness_Tracker.Utils;
using System.Data;

namespace Fitness_Tracker.Controller
{
    internal class GoalController
    {
        private string _connectionString;
        private GoalForm _goalForm;
        private GoalModel _goalModel;

        public GoalController(GoalForm goalForm)
        {
            _connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\DELL\\Documents\\FitnessTracker.mdf;Integrated Security=True;Connect Timeout=30";
            _goalForm = goalForm;
            _goalModel = new GoalModel();
        }

        public void DisplayGoals(DataGridView dataGridView)
        {
            try
            {
                DataTable goals = _goalModel.GetGoals();
                if (goals != null)
                {
                    dataGridView.DataSource = goals;
                }
                else
                {
                    _goalForm.ShowErrorMessage("No goals found to display.");
                }
            }
            catch (Exception ex)
            {
                _goalForm.ShowErrorMessage("Error retrieving goals: " + ex.Message);
            }
        }

        public void DisplayGoalsByUsername(DataGridView dataGridView, string username)
        {
            try
            {
                DataTable goals = _goalModel.GetGoalsByUsername(username);
                if (goals != null)
                {
                    dataGridView.DataSource = goals;
                }
                else
                {
                    _goalForm.ShowErrorMessage("No goals found to display.");
                }
            }
            catch (Exception ex)
            {
                _goalForm.ShowErrorMessage("Error retrieving goals: " + ex.Message);
            }
        }

        public void AddGoal(Goals goal)
        {
            if(goal != null)
            {
                if (_goalModel.AddGoal(goal))
                {
                    SessionManager.Goal = _goalModel.GetActiveGoalId(SessionManager.Username);
                    _goalForm.ShowSuccessMessage("Goal Create Successful.");
                }
            }
            else
            {
                _goalForm.ShowErrorMessage("Goal Create Fail.");
            }
        }

        public void UpdateGoal(Goals goal)
        {
            if (goal != null)
            {
                if (_goalModel.UpdateGoal(goal))
                {
                    _goalForm.ShowSuccessMessage("Goal Update Successful.");
                }
            }
            else
            {
                _goalForm.ShowErrorMessage("Goal Update Fail.");
            }
        }

        public void DeleteGoal(int id)
        {
            if (_goalModel.DeleteGoal(id))
            {
                _goalForm.ShowSuccessMessage("Goal Delete Successful.");
            }
            else
            {
                _goalForm.ShowErrorMessage("Goal Delete Fail.");
            }
        }       
    }
}
