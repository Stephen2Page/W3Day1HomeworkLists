using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3Day1HomeworkLists
{
    class Program
    {
        static void Main(string[] args)
        //Create the following list:
        //  List<bool> boolList = new List<bool>() { true,false, false,  true, false};
        //  Loop through each value
        //  If the value is true print:    "Better bring an umbrella"
        //  If the value is false print:  "No rain today, enjoy the sun!"
        {
            List<bool> boolList = new List<bool> { true, false, false, true, false };
            foreach (bool item in boolList)
            {
                if (item == true)
                {
                    Console.WriteLine("Better bring an umbrella");
                }
                else
                {
                    Console.WriteLine("No rain today, enjoy the sun!");
                }
            }
        }
        public void Excercise3()
        //Create the following array
        //  int[] array1 = new int[] { 5, 2, 3, 4, 1, 5, 6, 3 };
        //  Convert array1 to a List
        //  Use the.Sort() method on the list
        //  Convert the list back to an array and set it to the value for array1

        {
            int[] array1 = new int[] { 5, 2, 3, 4, 1, 5, 6, 3 };
            List<int> newList = new List<int>(array1);
            newList.Sort();

            foreach (int item in newList)
            {
                Console.Write(item + "\t");
            }
            Console.WriteLine();
        }
    }
}
