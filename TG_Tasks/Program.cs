using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace TG_Tasks
{
    public class Program
    {
        static void Main(string[] args)
        {
            FirstTask();

            Console.WriteLine();
            Console.WriteLine("---");

            SecondTask();

            Console.Read();
        }


        private static void FirstTask()
        {
            Console.WriteLine("FIRST TASK");
            Console.Write("Given Array List: ");
            var firstArrayList = new ArrayList() { "Hilal", 2, "Cerit", 12, 8, "YAZILIM", 9, 74, "software" };
            foreach (var item in firstArrayList)
            {
                Console.Write(item + "  ");

            }

            Console.WriteLine();
            Console.Write("String Type Of Array List:  ");
            var stringArrayList = firstArrayList.OfType<string>();
            foreach (var stringItem in stringArrayList)
            {
                Console.Write(stringItem + "  ");

            }

        }


        private static void SecondTask()
        {
            Console.WriteLine("SECOND TASK");
            Console.Write("Given Array List: ");
            List<string> secondArrayList = new List<string>() { "1", "22", "300", "44", "5", "123" };
            foreach (var item in secondArrayList)
            {
                Console.Write(item + " ");

            }
            Console.WriteLine();
            Console.Write("Sorted Array List:  ");
            var sortedList = secondArrayList.OrderBy(x => int.Parse(x));
            foreach (var sortedItem in sortedList)
            {
                Console.Write(sortedItem + "  ");

            }


        }

    }
}
