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
            //Foreach Loops
            //string[] months = { "Jan", "Feb", "March", "April", "May", "June", "July", "Aug", "Sept", "Oct", "Nov", "Dec" };
            //foreach (string month in months) //month is the temporary variable
            //{
            //    Console.WriteLine(month);
            //    if (month == "Dec")
            //    {
            //        Console.WriteLine("DECEMBER IS THE BEST MONTH!");

            //    }
            //    else
            //    {
            //        Console.WriteLine("That month is OK, I guess.");
            //    }

            //}

            //string[] musicians = { "U2", "Maroon 5", "Ed Sheeran", "Nas", "Jarryd" };
            //foreach (string musician in musicians) //temporary variable needs to be the same data type as the array
            //{
            //    Console.WriteLine(musician);
            //}

            //Write a program that takes your three favorite foods and prints them out one at a time. (Use a foreach loop.)
            //string[] favoriteFoods = new string[3];
            //Console.WriteLine("What is your #1 favorite food?");
            //favoriteFoods[0] = Console.ReadLine();
            //Console.WriteLine("What is your #2 favorite food?");
            //favoriteFoods[1] = Console.ReadLine();
            //Console.WriteLine("What is your #3 favorite food?");
            //favoriteFoods[2] = Console.ReadLine();

            //foreach (string food in favoriteFoods)
            //{
            //    Console.WriteLine(food);
            //}

            //Create an array of lucky numbers(just any numbers you like). Using a foreach loop, print the following:
            //If the array holds the numbers 3, 5, 7, 11, 15, then the printed result should say
            //Your Lucky Number is: 3
            //Your Lucky Number is: 5
            //Your Lucky Number is: 7
            //Your Lucky Number is: 11
            //Your Lucky Number is: 15

            //int[] luckyNumbers = { 3, 5, 7, 11, 15 };
            //foreach (int number in luckyNumbers)
            //{
            //    Console.WriteLine("Your Lucky Number is: " + number);
            //}

            //Using a loop to make names lowercase: can't do this with a foreach loop because it is just used for iterations. Need to use a 'for' loop. 
            //We have more control over a 'for' loop - can control how long it goes for (foreach goes through all iterations)
            //string[] Names = { "Jordan", "Max", "Peter" };

            //for (int i = 0; i < Names.Length; i++) // "i" is the temporary variable - can name anything, but 'i' is the standard; i ++ happens at the end and then re-checks if first condition is true
            ////i is the initializer; i < names.Length is the condition; i ++ is the "updater"
            //{
            //    Names[i] = Names[i].ToLower();
            //    Console.WriteLine(Names[i]);
            //}

            //Second Example
            //for (int counter = 1; counter <= 10; counter += 2)
            //{
            //    Console.WriteLine(counter);
            //}

            //Third Example
            //for (int counter = 50; counter <= 100; counter++)
            //{
            //    Console.WriteLine(counter);
            //}

            //Fourth Example
            //string words = "I like cake";
            //foreach (char letters in words)
            //{
            //    Console.WriteLine(letters);
            //}

            //Fifth Example
            //string greetings = "My name is Jordan";
            //string[] greetingsWords = greetings.Split();

            //for (int i = 0; i < greetingsWords.Length; i++)
            //{
            //    Console.WriteLine(greetingsWords[i]);
            //    if (greetingsWords[i] == "Jordan") //can use for loops to change arrays
            //    {
            //        greetingsWords[i] = "Max";
            //    }
            //}
            //Console.WriteLine(greetingsWords[greetingsWords.Length - 1]);

            //Create an array called days with the elements Monday, Tuesday, Wednesday, Thursday, etc...
            //Use a for loop to print the elements.

            //string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            //for (int i = 0; i < days.Length; i++)

            //{
            //    Console.WriteLine(days[i]);
            //}

            //Create an int array size 26 and put the numbers 0 to 25 in the array and print those numbers to the console
            //int[] someNumbers = new int[26];
            //for (int i = 0; i < someNumbers.Length; i++)
            //{
            //    someNumbers[i] = i;
            //    Console.WriteLine(someNumbers[i]);
            //}

            //Start with the string "once upon a time" and create an array called storyWords using the Split method.
            //Reverse the order of the elements in the array and using a for loop, print each word.
            //string story = "once upon a time";
            //string[] storyWords = story.Split();
            //Array.Reverse(storyWords, 0, 4);
            //for (int i = 0; i < storyWords.Length; i++)
            //{
            //    Console.WriteLine(storyWords[i]);
            //}

            //While loops
            //First Example
            //Can put a whole program within a while loop!

            //Console.WriteLine("Do you want to play again?");
            //string playAgain = Console.ReadLine();

            //while (playAgain == "Yes")
            //{
            //    Console.WriteLine("It's a rematch");
            //    Console.WriteLine("Do you want to play again?");
            //    playAgain = Console.ReadLine();
            //}

            //Second Example: can use this to ensure the user enters a correct value (e.g. must enter a ROYGBIV value, or "red" in this case)
            //Console.WriteLine("What is your favorite ROYGBIV color?");
            //string userColor = Console.ReadLine();


            //while (userColor != "red")
            //{
            //    Console.WriteLine("Sorry, that is not the correct color. Please try again.");
            //    userColor = Console.ReadLine();
            //}

            //Avoid infinite loops like the below at all costs:
            //while(true)
            //{
            //    Console.WriteLine(10);
            //}

            //Do While Loops
            //string playAgainPlease;
            //do
            //{
            //    Console.WriteLine("Do you want to build a snowman?");
            //    Console.WriteLine("That was fun.");
            //    Console.WriteLine("Do you want to build another snowman?");
            //    playAgainPlease = Console.ReadLine();
            //}

            //while (playAgainPlease.ToLower() == "yes");

            ////Break example
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //    if(i == 5)
            //        break;
            //}

            //Can use continue to skip certain iterations
            //for(int i = 0; i < 10; i++)
            //{
            //    if(i% 2 == 0)
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(i);
            //}

            //While Loop Example
            //int x = 1;
            //while (x <= 10)
            //{
            //    Console.WriteLine(x);
            //    x++;

            //Guessing Game Example using Boolean value instead (rather than break)
            //int lives = 3;
            //int magicNumber = 24;

            //    while(lives > 0)
            //    {
            //        Console.WriteLine("Guess my lucky number.");
            //        int userGuess = int.Parse(Console.ReadLine());
            //        if(magicNumber == userGuess)
            //        {
            //            Console.WriteLine("You guessed correctly!");
            //            break; 
            //        }
            //        else
            //        {
            //            Console.WriteLine("Sorry, try again.");
            //            lives--;
            //            Console.WriteLine("You have " + lives + " lives left.");
            //        }
            //    }

            //Guessing Game Example
            //int lives2 = 3;
            //int magicNumber2 = 24;
            //bool isPlaying = true;

            //while (lives2 > 0 && isPlaying == true)
            //{
            //    Console.WriteLine("Guess my lucky number.");
            //    int userGuess2 = int.Parse(Console.ReadLine());
            //    if (magicNumber2 == userGuess2)
            //    {
            //        Console.WriteLine("You guessed correctly!");
            //        isPlaying = false;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Sorry, try again.");
            //        lives2--;
            //        Console.WriteLine("You have " + lives + " lives left.");
            //    }
            //}

            //Practice: Print the numbers 1 - 100
            //If the number is a multiple of 3, print fizz
            //If the number is a multiple of 5, print buzz
            //If the number is a multiple of both, print fizzbuzz
            //If neither, print the number to the screen
            //e.g. 1, 2, fizz, etc...

            //int theNumber = 1;
            //while (theNumber < 101)
            //{
            //    if (theNumber % 3 == 0 && theNumber % 5 != 0)
            //        Console.WriteLine("Fizz");
            //    else if (theNumber % 5 == 0 && theNumber % 3 != 0)
            //        Console.WriteLine("Buzz");
            //    else if (theNumber % 3 == 0 && theNumber % 5 == 0)
            //        Console.WriteLine("Fizzbuzz");
            //    else
            //        Console.WriteLine(theNumber);
            //    theNumber++;
            //}

            //Another version of FizzBuzz
            //for (int i = 1; i <= 100; i++)
            //    if (i % 15 == 0)
            //    {
            //        Console.WriteLine("Fizzbuzz");
            //    }
            //    else if (i % 3 == 0)
            //    {
            //        Console.WriteLine("Fizz");
            //    }
            //    else if (i % 5 == 0)
            //    {
            //        Console.WriteLine("Buzz");
            //    }
            //    else
            //    {
            //        Console.WriteLine(i);
            //    }

            //Create an int array with 10 elements 
            //find the mean of these elements and output the result to the console 

            //int[] myArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //int myArrayTotal = 0;
            //foreach(int number in myArray)
            //{
            //    myArrayTotal = number + myArrayTotal; //same as total += number
            //}
            //float myArrayAverage = myArrayTotal / myArray.Length;
            //Console.WriteLine(myArrayAverage);

            //Nesting practice: usually start with i and then go to j

            //            for(int i = 1; i <= 2; i++)
            //            {
            //                for (int j = 1; j <= 4; j++)
            //                {
            //                    Console.Write(j); //columns
            //                }
            //                Console.WriteLine(); //rows - starts the next row for you
            //            }


            //            //Print a triangle
            //            int n = 4; //number of rows and columns
            //            for (int row = 1; row <= n; row++)
            //            {
            //                for(int col = 1; col <=row; col++) //keeps going further as n increases
            //                {
            //                    Console.Write(col + " ");
            //                }
            //                Console.WriteLine();
            //            }
            //Write a program that prints a multiplication table (5 x 5, for example) using a nested loops.
            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= 5; j++)
            //    {
            //        Console.Write(j * i + " "); //columns. can also do: Console.Write("{0} x {1}", i, j); (the 0 and 1 are placeholders)
            //    }
            //    Console.WriteLine(); //rows - starts the next row for you
            //}

            //Create an array of your favorite movies. Print out each movie in the list, unless the movie starts with a vowel. 
            //Hint: Research.startsWith()
            //string[] favoriteMovies = { "Jane Eyre", "Charlie and the Chocolate Factory", "The Big Sad", "Edward Scissorhands" };

            //foreach (string movie in favoriteMovies)
            //{

            //    if (movie.StartsWith("a", StringComparison.CurrentCultureIgnoreCase) || movie.StartsWith("e", StringComparison.CurrentCultureIgnoreCase) || movie.StartsWith("i", StringComparison.CurrentCultureIgnoreCase) || movie.StartsWith("o", StringComparison.CurrentCultureIgnoreCase) || movie.StartsWith("u", StringComparison.CurrentCultureIgnoreCase))
            //    {
            //    }
            //    else
            //    {
            //        Console.WriteLine(movie);
            //    }

            //}

            //Write a console application that asks the user for an integer. 
            //If that integer is evenly divisible by 3, then write “You Won!” If it isn’t, write “You Lost.” Keep asking them for a number (looping)until they win.

            //bool keepPlaying = true;

            //while(keepPlaying == true)
            //{
            //    Console.WriteLine("Please enter an integer.");
            //    int userInteger = int.Parse(Console.ReadLine());

            //    if (userInteger % 3 == 0)
            //    {
            //        Console.WriteLine("You win!");
            //        keepPlaying = false;
            //    }
            //    else
            //    {
            //        Console.WriteLine("You Lost. Try again.");
            //    }

            //}

            //Another console application
            //Console.WriteLine("Please enter an integer.");
            //int userInteger = int.Parse(Console.ReadLine());

            //while(userInteger %3 !=0)
            //{
            //    Console.WriteLine("You lose. Try again.");
            //    userInteger = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine("You win!");

            //Practice:
            //Write a Program and ask the user for 2 numbers(N and M) 
            //Check to see if M is greater than N. If M is not larger than N have the users enter new numbers.
            //Between N and M find all the numbers that are Multiple  of 3 and print those numbers to the console.

            //int N = 0;
            //int M = 0;

            //while(M <= N)
            //{
            //    Console.WriteLine("Please make sure M is bigger than N.");
            //    Console.WriteLine("Please enter an integer (N).");
            //    N = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Please enter another integer (M).");
            //    M = int.Parse(Console.ReadLine());
            //}

            //for(int i = N; i <= M; i++)
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }



        }
    }
  }

