using System;
using System.Linq;

namespace AssignLembda
{
   public class Program
    {
        public static void Main(string[] args)
        {

          string s1 = "Neetika Paliwal a ss asd a a a abs dd ";

            string[] StringArray = s1.Split(' ');


            Console.WriteLine("Using LINQ");
            var o = from r in StringArray where r.Equals("a") select r;
            Console.WriteLine(o.Count());

            Console.WriteLine("Using Lambda Expression");
            var a = StringArray.Where(r => r.Equals("a"));
            Console.WriteLine(a.Count());

        }
    }
}