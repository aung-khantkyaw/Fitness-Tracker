using Fitness_Tracker.Models;
using Fitness_Tracker.DataAccess;
using Fitness_Tracker.Utils;
using System.Data;

namespace Fitness_Tracker.Controller
{
    internal class ActivityController
    {
        private string _connectionString;
        private ActivityForm _activityForm;
        private ActivityModel _activityModel;
        private GoalModel _goalModel;

        public ActivityController(ActivityForm activityForm)
        {
            _connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\DELL\\Documents\\FitnessTracker.mdf;Integrated Security=True;Connect Timeout=30";
            _activityForm = activityForm;
            _activityModel = new ActivityModel();
            _goalModel = new GoalModel();
        }

        public List<ActivityType> GetActivityTypeList()
        {
            return _activityModel.GetActivityTypeList();
        }

        public ActivityType GetActivityDetailByActivityName(string activityName)
        {
            return _activityModel.GetActivityDetailByActivityName(activityName);
        }

        public void DisplayActivities(DataGridView dataGridView)
        {
            try
            {
                DataTable activities = _activityModel.GetActivities();
                if (activities != null)
                {
                    dataGridView.DataSource = activities;
                }
                else
                {
                    _activityForm.ShowErrorMessage("No goals found to display.");
                }
            }
            catch (Exception ex)
            {
                _activityForm.ShowErrorMessage("Error retrieving goals: " + ex.Message);
            }
        }

        public void DisplayActivitiesByUsername(DataGridView dataGridView, string username)
        {
            try
            {
                DataTable activities = _activityModel.GetActivitiesByUsername(username);
                if (activities != null)
                {
                    dataGridView.DataSource = activities;
                }
                else
                {
                    _activityForm.ShowErrorMessage("No goals found to display.");
                }
            }
            catch (Exception ex)
            {
                _activityForm.ShowErrorMessage("Error retrieving goals: " + ex.Message);
            }
        }

        public void AddActivity(string activityName, int metricOneValue, int metricTwoValue, int metricThreeValue)
        {
            if (SessionManager.Goal > 0)
            {
                int CalBurn = CalculateCaloriesBurned.Calculation(activityName, metricOneValue, metricTwoValue, metricThreeValue);

                Activities activity = new Activities
                {
                    activity_name = activityName,
                    metric_one_value = metricOneValue,
                    metric_two_value = metricTwoValue,
                    metric_three_value = metricThreeValue,
                    burn_cal = CalBurn,
                    username = SessionManager.Username,
                    goal_id = SessionManager.Goal,
                };

                if (_goalModel.UpdateGoalCaloriesBurned(CalBurn, SessionManager.Goal))
                {
                    if (_goalModel.UpdateGoalIsAchieve(SessionManager.Goal))
                    {
                        SessionManager.Goal = 0;
                    }
                    if (_activityModel.AddActivity(activity))
                    {
                        _activityForm.ShowSuccessMessage("Add Activity");
                    }
                }
            }
            else
            {
                _activityForm.ShowErrorMessage("Please create a goal before set up activity.");
            }
        }
    }
}
