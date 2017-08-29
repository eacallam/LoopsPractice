using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //foreach loops
            string[] months = { "Jan", "Feb", "March", "April", "May", "June", "July", "Aug", "Sept", "Oct", "Nov", "Dec" };
            foreach(string month in months) //month is the temporary variable
            {
                Console.WriteLine(month);
                if (month == "Dec")
                {
                    Console.WriteLine("DECEMBER IS THE BEST MONTH!");

                }
                else
                {
                    Console.WriteLine("That month is OK, I guess.");
                }
                             
            }

            string[] musicians = { "U2", "Maroon 5", "Ed Sheeran", "Nas", "Jarryd" };
            foreach(string musician in musicians) //temporary variable needs to be the same data type as the array
            {
                Console.WriteLine(musician);
            }

            //Write a program that takes your three favorite foods and prints them out one at a time. (Use a foreach loop.)
            string[] favoriteFoods = new string[3];
            Console.WriteLine("What is your #1 favorite food?");
            favoriteFoods[0] = Console.ReadLine();
            Console.WriteLine("What is your #2 favorite food?");
            favoriteFoods[1] = Console.ReadLine();
            Console.WriteLine("What is your #3 favorite food?");
            favoriteFoods[2] = Console.ReadLine();

            foreach(string food in favoriteFoods)
            {
                Console.WriteLine(food  );
            }

            //Create an array of lucky numbers(just any numbers you like). Using a foreach loop, print the following:
            //If the array holds the numbers 3, 5, 7, 11, 15, then the printed result should say
            //Your Lucky Number is: 3
            //Your Lucky Number is: 5
            //Your Lucky Number is: 7
            //Your Lucky Number is: 11
            //Your Lucky Number is: 15

            int[] luckyNumbers = { 3, 5, 7, 11, 15 };
            foreach (int number in luckyNumbers)
            {
                Console.WriteLine("Your Lucky Number is: " + number);
            }
        }
    }
}
