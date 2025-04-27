namespace Fitness_Tracker.Utils
{
    public class CalculateCaloriesBurned
    {
        public static int Calculation(string activityName, int metricOneValue, int metricTwoValue, int metricThreeValue)
        {
            int age = SessionManager.UserAge;
            string gender = SessionManager.UserGender;
            int weight = SessionManager.UserWeight;
            int height = SessionManager.UserHeight;

            switch (activityName)
            {
                case "Walking":
                    return Walking(metricOneValue, metricTwoValue, metricThreeValue, weight);
                case "Swimming":
                    return Swimming(metricOneValue, metricTwoValue, metricThreeValue, gender, age, weight);
                case "Jumping Ropes":
                    return JumpingRopes(metricOneValue, metricTwoValue, metricThreeValue, weight);
                case "Running":
                    return Running(metricOneValue, metricTwoValue, metricThreeValue, weight);
                case "Cycling":
                    return Cycling(metricOneValue, metricTwoValue, metricThreeValue, weight);
                case "Pushups":
                    return Pushups(metricOneValue, metricTwoValue, metricThreeValue, weight);
                default:
                    return 0;
            }
        }

        public static int Walking(int step, int distance, int timeTaken, int weight)
        {
            int speed = (distance * 60) / timeTaken;
            float METs = 0;

            if (speed <= 3.2) METs = 3;
            else if (speed > 3.2 && speed <= 4.8) METs = 3.5F;
            else if (speed > 4.8 && speed <= 5.6) METs = 4.3F;
            else if (speed > 5.6) METs = 5;

            int CaloriesBurn = (int)(METs * weight * 0.0175 * timeTaken);
            return CaloriesBurn;
        }

        public static int Swimming(int laps, int heartRate, int timeTaken, string gender, int age, int weight)
        {
            int CaloriesBurn = 0;
            if (gender.Equals("Male"))
            {
                CaloriesBurn = (int)(((-55.0969) + (0.6309 * heartRate) + (0.1988 * weight) + (0.2017 * age)) / 4.184) * timeTaken;
            }
            else
            {
                CaloriesBurn = (int)(((-20.4022) + (0.4472 * heartRate) - (0.1263 * weight) + (0.074 * age)) / 4.184) * timeTaken;
            }
            return CaloriesBurn;
        }

        public static int JumpingRopes(int jump, int jumpSpeed, int timeTaken, int weight)
        {
            float METs = 0;

            if (jumpSpeed < 100) METs = 8.8F;
            else if (jumpSpeed > 100 && jumpSpeed < 120) METs = 11.8F;
            else if (jumpSpeed > 120) METs = 12.3F;

            int CaloriesBurn = (int)(METs * weight * 0.0175 * timeTaken);
            return CaloriesBurn;
        }

        public static int Running(int step, int distance, int timeTaken, int weight)
        {
            int speed = (distance * 60) / timeTaken;
            float METs = 0;

            if (speed <= 8) METs = 8.3F;
            else if (speed > 8 && speed <= 9.7) METs = 9.8F;
            else if (speed > 9.7 && speed <= 11.3) METs = 11F;
            else if (speed > 11.3 && speed <= 12.9) METs = 11.8F;
            else if (speed > 12.9 && speed <= 14.5) METs = 12.8F;
            else if (speed > 14.5) METs = 14.5F;

            int CaloriesBurn = (int)(METs * weight * 0.0175 * timeTaken);
            return CaloriesBurn;
        }

        public static int Cycling(int speed, int distance, int timeTaken, int weight)
        {
            float METs = 0;

            if (speed <= 16) METs = 4;
            else if (speed > 16 && speed <= 19) METs = 6;
            else if (speed > 19 && speed <= 22) METs = 8;
            else if (speed > 22 && speed <= 25) METs = 10;
            else if (speed > 25 && speed <= 30) METs = 12;
            else if (speed > 30) METs = 16;

            int CaloriesBurn = (int)(METs * weight * 0.0175 * timeTaken);
            return CaloriesBurn;
        }

        public static int Pushups(int set, int pushupsPerSet, int timeTaken, int weight)
        {
            int CaloriesBurn = (int)(3.8 * weight * 0.0175 * timeTaken);
            return CaloriesBurn;
        }
    }
}
