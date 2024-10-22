namespace Exercise003
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;


    public class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("f.e", "for example");
            dict.Add("etc.", "and so on");
            dict.Add("i.e", "more precisely");

            PrintKeys(dict);
            Console.WriteLine("---");
            PrintKeysWhere(dict, "i");
            Console.WriteLine("---");
            PrintValuesOfKeysWhere(dict, ".e");
        }
        public static void PrintKeys(Dictionary<string, string> dict)
        {
            foreach (string key in dict.Keys)
            {
                Console.WriteLine(key);
            }
        }
        public static void PrintKeysWhere(Dictionary<string, string> dict, string text)
        {
            foreach (string key in dict.Keys)
            {
                if (key.Contains(text))
                {
                    Console.WriteLine(key);
                }
            }
        }
        public static void PrintValuesOfKeysWhere(Dictionary<string, string> dict, string text)
        {
            foreach (string key in dict.Keys)
            {
                if (key.Contains(text))
                {
                   Console.WriteLine(dict[key]); 
                }
                
            }
        }


    }
}
