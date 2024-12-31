namespace CodeWars.Models
{
    public class SuzukiStudents
    {
        public static String[] LineupStudents(String a)
        {
            return a.Split(' ').OrderByDescending(x => x.Length).ThenByDescending(x => x).ToArray();
        }
    }
}