namespace CodeWars.Models
{
    public class HumanTime
    {
        public static string GetReadableTime(int seconds)
        {
            if (seconds == 0)
            {
                return "00:00:00";
            }

            if (seconds < 60)
            {
                return $"00:00:{seconds.ToString().PadLeft(2, '0')}";
            }

            var hours = seconds / 3600;

            var minutes = (seconds % 3600) / 60;

            var remainingSeconds = seconds % 60;

            return $"{hours.ToString().PadLeft(2, '0')}:{minutes.ToString().PadLeft(2, '0')}:{remainingSeconds.ToString().PadLeft(2, '0')}";
        }
    }
}
