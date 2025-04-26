using Fitness_Tracker.Models; 
using Fitness_Tracker.DataAccess;
using Fitness_Tracker.Utils;

namespace Fitness_Tracker.Controller
{
    internal class UserController
    {
        private string _connectionString;
        private Main _loginForm;
        private Register _registrationForm;
        private Profile _profileForm;
        private UserModel _userModel;
        private GoalModel _goalModel;

        public UserController(Main loginForm)
        {
            _connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\DELL\\Documents\\FitnessTracker.mdf;Integrated Security=True;Connect Timeout=30";
            _loginForm = loginForm;
            _userModel = new UserModel();
        }
        public UserController(Register registrationForm, Main loginForm)
        {
            _connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\DELL\\Documents\\FitnessTracker.mdf;Integrated Security=True;Connect Timeout=30";
            _registrationForm = registrationForm;
            _loginForm = loginForm;
            _userModel = new UserModel();
        }

        public UserController(Profile profileForm, Main loginForm)
        {
            _connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\DELL\\Documents\\FitnessTracker.mdf;Integrated Security=True;Connect Timeout=30";
            _profileForm = profileForm;
            _loginForm = loginForm;
            _userModel = new UserModel();
            _goalModel = new GoalModel();
        }

        public User GetUserByUsername(string username)
        {
            return _userModel.GetUserByUsername(username);
        }

        public User GetUserByEmail(string email)
        {
            return _userModel.GetUserByEmail(email);
        }

        public void Register(User user)
        {
            if (string.IsNullOrEmpty(user.username) || string.IsNullOrEmpty(user.password) || string.IsNullOrEmpty(user.email))
            {
                _registrationForm.ShowErrorMessage("Please enter username, password, and email.");
                return;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(user.username, "^[a-zA-Z0-9]+$"))
            {
                _registrationForm.ShowErrorMessage("Username can only contain letters and numbers.");
                return;
            }

            if (user.password.Length != 12)
            {
                _registrationForm.ShowErrorMessage("Password must be exactly 12 characters long.");
                return;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(user.password, "[a-z]") || !System.Text.RegularExpressions.Regex.IsMatch(user.password, "[A-Z]"))
            {
                _registrationForm.ShowErrorMessage("Password must contain at least one lowercase and one uppercase letter.");
                return;
            }

            if (GetUserByUsername(user.username) != null)
            {
                _registrationForm.ShowErrorMessage("Username already exists.");
                return;
            }
            if (GetUserByEmail(user.email) != null)
            {
                _registrationForm.ShowErrorMessage("Email already exists.");
                return;
            }

            user.password = PasswordHasher.HashPassword(user.password);


            if (_userModel.AddUser(user))
            {
                _registrationForm.ShowSuccessMessage("Registration successful!");
                _registrationForm.ClearRegistrationFields();
                _registrationForm.Close();
                _loginForm.Show();

            }
            else
            {
                _registrationForm.ShowErrorMessage("Registration failed. Please try again.");
            }
        }

        public void Login(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                _loginForm.ShowErrorMessage("Please enter both username and password.");
                return;
            }

            User user = GetUserByUsername(username);
            if (user != null)
            {
                if (PasswordHasher.VerifyPassword(password, user.password))
                {
                    SessionManager.UserId = user.Id;
                    SessionManager.Username = user.username;
                    SessionManager.UserEmail = user.email;
                    SessionManager.UserWeight = (int)(user.weight as int?);
                    SessionManager.UserHeight = (int)(user.height as int?);
                    SessionManager.UserRole = user.role;

                    _loginForm.ShowSuccessMessage("Login successful!");

                    _loginForm.ClearLoginFields();

                    Profile profile = new Profile(_loginForm);
                    profile.Show();
                    _loginForm.Hide();
                }
                else
                {
                    if (SessionManager.IncorrectLoginAttempts >= 3)
                    {
                        MessageBox.Show("Too many incorrect login attempts. Please contact support.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Application.Exit();
                    }
                    else
                    {
                        _loginForm.ShowErrorMessage("Invalid password.");
                        SessionManager.IncorrectLoginAttempts++;
                    }
                }
            }
            else
            {
                _loginForm.ShowErrorMessage("User not found.");
            }
        }

        public void Logout()
        {
            SessionManager.UserId = 0;
            SessionManager.Username = string.Empty;
            SessionManager.UserEmail = string.Empty;
            SessionManager.UserWeight = 0;
            SessionManager.UserHeight = 0;
            SessionManager.UserRole= string.Empty;
            SessionManager.IncorrectLoginAttempts = 0;
        }

        public void AccountUpdate(User user)
        {
            if(user != null)
            {
                if (_userModel.UpdateUser(user))
                {
                    SessionManager.UserId = user.Id;
                    SessionManager.Username = user.username;
                    SessionManager.UserEmail = user.email;
                    SessionManager.UserWeight = (int)(user.weight as int?);
                    SessionManager.UserHeight = (int)(user.height as int?);
                    SessionManager.UserRole = user.role;
                    _profileForm.ShowSuccessMessage("Account Update successful!");
                }
                else
                {
                    _profileForm.ShowErrorMessage("Account Update failed. Please try again.");
                }
            }
        }

        public void AccountDelete(string username)
        {
            if (_goalModel.DeleteGoalByUsername(username))
            {
                if (_userModel.DeleteUser(username))
                {
                    Profile profile = new Profile(_loginForm);
                    profile.Hide();
                    _loginForm.Show();
                }
            }
            else
            {
                _profileForm.ShowErrorMessage("Account Delete is not succesful.");
            }
        }
    }
}