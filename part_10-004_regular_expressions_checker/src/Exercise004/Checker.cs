namespace Exercise004
{
    using System.Runtime.Serialization;

    using System.Text.RegularExpressions;
    public class Checker
    {
        public bool DayOfWeek(string str)
        {
            Regex regex = new Regex("^mon|tue|wed|thu|fri|sat|sun");
            if (regex.IsMatch(str))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool AllVowels(string str)
        {
           Regex regex = new Regex("^[aeiou]+$");
            if (regex.IsMatch(str))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool TimeOfDay(string str)
        {
            Regex regex = new Regex("^(0[0-9]|1[0-9]|2[0-3]):[0-5][0-9]:[0-5][0-9]$");
            if (regex.IsMatch(str))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}