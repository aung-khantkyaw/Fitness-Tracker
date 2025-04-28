using System.Data;
using System.Data.SqlClient;
using Fitness_Tracker.Models;

namespace Fitness_Tracker.DataAccess
{
    public class ActivityModel
    {
        private string _connectionString;

        public ActivityModel()
        {
            _connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\DELL\\Documents\\FitnessTracker.mdf;Integrated Security=True;Connect Timeout=30";
        }

        public List<ActivityType> GetActivityTypeList()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM ActivityType";
                SqlCommand command = new SqlCommand(query, connection);
                List<ActivityType> activityTypeList = new List<ActivityType>(); // Initialize the list

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read()) // Iterate through *all* rows
                    {
                        ActivityType activity = new ActivityType
                        {
                            Id = (int)reader["Id"],
                            activity = reader["activity"].ToString(),
                            metric_one = reader["metric_one"].ToString(),
                            metric_two = reader["metric_two"].ToString(),
                            metric_three = reader["metric_three"].ToString()
                        };
                        activityTypeList.Add(activity); // Add each activity to the list
                    }
                    reader.Close();
                    return activityTypeList; // Return the populated list
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Database error in GetActivityTypeList: " + ex.Message);
                    throw;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("General error in GetActivityTypeList: " + ex.Message);
                    throw;
                }
            }
        }

        public ActivityType GetActivityDetailByActivityName(string activityName)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM ActivityType WHERE activity = @ActivityName";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ActivityName", activityName);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        ActivityType activity = new ActivityType
                        {
                            Id = (int)reader["Id"],
                            activity = reader["activity"].ToString(),
                            metric_one = reader["metric_one"].ToString(),
                            metric_two = reader["metric_two"].ToString(),
                            metric_three = reader["metric_three"].ToString()
                        };
                        reader.Close();
                        return activity;
                    }
                    else
                    {
                        reader.Close();
                        return null;
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Database error in GetActivityDetailByActivityName: " + ex.Message);
                    throw;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("General error in GetActivityDetailByActivityName: " + ex.Message);
                    throw;
                }
            } 
        }

        public DataTable GetActivities()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM Activities";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                try
                {
                    connection.Open();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Database Error retrieving Activities: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
        }

        public DataTable GetActivitiesByUsername(string Username)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM Activities WHERE Username = @Username";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", Username);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                try
                {
                    connection.Open();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Database Error retrieving Activities for user: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An unexpected error occurred while retrieving Goals for user: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
        }

        public bool AddActivity(Activities activity)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "INSERT INTO Activities (activity_name, metric_one_value, metric_two_value, metric_three_value, burn_cal, username, goal_id) VALUES (@activityName, @MetricOneValue, @MetricTwoValue, @MetricThreeValue, @burnCal, @Username, @goalId)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@activityName", activity.activity_name);
                command.Parameters.AddWithValue("@MetricOneValue", activity.metric_one_value);
                command.Parameters.AddWithValue("@MetricTwoValue", activity.metric_two_value);
                command.Parameters.AddWithValue("@MetricThreeValue", activity.metric_three_value);
                command.Parameters.AddWithValue("@burnCal", activity.burn_cal);
                command.Parameters.AddWithValue("@Username", activity.username);
                command.Parameters.AddWithValue("@goalId", activity.goal_id);
                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Database Error during AddActivity: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An unexpected error occurred during AddActivity: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        public bool DeleteActivityByUsername(string Username)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "DELETE FROM Activities WHERE Username = @Username";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", Username);
                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Database Error during Registration: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An unexpected error occurred during Registration: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }
    }
}
