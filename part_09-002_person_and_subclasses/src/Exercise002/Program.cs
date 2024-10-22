﻿namespace Exercise002
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            Person ada = new Person("Ada Lovelace", "24 Maddox St. London W1S 2QN");
            Person esko = new Person("Esko Ukkonen", "Mannerheimintie 15 00100 Helsinki");
            Console.WriteLine(ada);
            Console.WriteLine(esko);
        }
    }
}