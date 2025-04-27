namespace Fitness_Tracker.Utils
{
    public static class SessionManager
    {
        public static int UserId { get; set; }
        public static string Username { get; set; }
        public static string UserEmail { get; set; }
        public static int UserAge { get; set; }
        public static string UserGender { get; set; }
        public static int UserWeight { get; set; }
        public static int UserHeight { get; set; }
        public static string UserRole { get; set; }
        public static int IncorrectLoginAttempts { get; set; }
        public static int Goal { get; set; }
    }
}
