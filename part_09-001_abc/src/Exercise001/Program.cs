namespace Exercise001
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            A a = new A();
            B b = new B();
            C c = new C();

            a.APrint();
            b.BPrint();
            c.CPrint();

            Console.WriteLine();

            c.APrint();
            c.BPrint();
            c.CPrint();
        }
        


        }
    }



