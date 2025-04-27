using Fitness_Tracker.Models;
using System.Data.SqlClient;

namespace Fitness_Tracker.DataAccess
{
    public class UserModel
    {
        private string _connectionString;

        public UserModel()
        {
            _connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\DELL\\Documents\\FitnessTracker.mdf;Integrated Security=True;Connect Timeout=30";
        }

        public User GetUserByUsername(string username)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM Users WHERE Username = @Username";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", username);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        User user = new User
                        {
                            Id = (int)reader["Id"],
                            username = reader["Username"].ToString(),
                            email = reader["Email"].ToString(),
                            password = reader["Password"].ToString(),
                            age = (int)(int?)reader["Age"],
                            gender = reader["Gender"].ToString(),
                            weight = (int)(int?)reader["weight"],
                            height = (int)(int?)reader["height"],
                            role = reader["role"].ToString()
                        };
                        reader.Close();
                        return user;
                    }
                    else
                    {
                        reader.Close();
                        return null;
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Database error in GetUserByUsername: " + ex.Message);
                    // Consider re-throwing a more specific database exception or a custom one
                    throw;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("General error in GetUserByUsername: " + ex.Message);
                    throw;
                }
            }
        }

        public User GetUserByEmail(string email)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "SELECT Id, Username, Password, Email FROM Users WHERE Email = @Email";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Email", email);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        User user = new User
                        {
                            Id = (int)reader["Id"],
                            username = reader["Username"].ToString(), 
                            password = reader["Password"].ToString(), 
                            email = reader["Email"].ToString()        
                        };
                        reader.Close();
                        return user;
                    }
                    else
                    {
                        reader.Close();
                        return null;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error in GetUserByEmail: " + ex.Message);
                    return null; 
                }
            }
        }

        public bool AddUser(User user) 
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "INSERT INTO Users (username, email, password) VALUES (@Username, @Email, @Password)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", user.username);
                command.Parameters.AddWithValue("@Email", user.email);
                command.Parameters.AddWithValue("@Password", user.password);
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

        public bool UpdateUser(User user)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "UPDATE Users SET username = @Username, email = @Email, age = @Age, gender = @Gender, weight = @Weight, height = @Height WHERE Id = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", user.username);
                command.Parameters.AddWithValue("@Email", user.email);
                command.Parameters.AddWithValue("@Age", user.age);
                command.Parameters.AddWithValue("@Gender", user.gender);
                command.Parameters.AddWithValue("@Weight", user.weight);
                command.Parameters.AddWithValue("@Height", user.height);
                command.Parameters.AddWithValue("@Id", user.Id);
                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Database Error during Update: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An unexpected error occurred during Update: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        public bool DeleteUser(string username)
        {
            using(SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "DELETE FROM Users WHERE Username = @Username";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", username);
                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Database Error during Delete: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An unexpected error occurred during Delete: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }
    }
}
