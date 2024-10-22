namespace Exercise001
{
    using System;
    using System.Collections.Generic;
    public class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("matthew", "matt");
            dict.Add("michael", "mix");
            dict.Add("arthur", "artie");
            // Print using foreach and KeyValuePair
            foreach (KeyValuePair<string, string> item in dict)
            {
                Console.WriteLine("{0}'s nickname is {1}",
                    item.Key, item.Value);
            }
        }

    }
}
