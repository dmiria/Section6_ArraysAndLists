using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section6_ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {

            //Facebook();

            //reEnter();

            reverseName();

            //noDupes();

            //commaSeparatedNum();
        }


        /* Exercise 1
         * When you post a message on Facebook, depending on the number of people 
         * who like your post, Facebook displays different information.
         * 
         * If no one likes your post, it doesn't display anything. 
         * If only one person likes your post, it displays: [Friend's Name] likes your post.
         * If two people like your post, it displays: [Friend 1] and [Friend 2] like your post.
         * If more than two people like your post, it displays: [Friend 1], [Friend 2] and 
         *      [Number of Other People] others like your post.
         * 
         * 
         * 
         * Write a program and continuously ask the user to enter different names, until the user 
         * presses Enter (without supplying a name). Depending on the number of names provided, 
         * display a message based on the above pattern.
         * 
         * */
        public static void Facebook()
        {
            var friends = new List<string>();

            while (true) { 
                Console.WriteLine("Enter a name (or hit ENTER to quit)");
                var userInputName = Console.ReadLine();
                if (userInputName != "")
                {
                    friends.Add(userInputName);
                    //Console.WriteLine("added user: " + userInputName);
                }
                else { 
                    break;
                }
            }

            if (friends.Count() == 0)
            {
                Console.WriteLine("None.");
            } else if (friends.Count() == 1)
            {
                Console.WriteLine("{0} likes your post.", friends[0]);
            } else if (friends.Count() == 2)
            {
                Console.WriteLine("{0} and {1} likes your post.", friends[0], friends[1]);
            }
            else
            {
                Console.WriteLine("{0}, {1} and {2} others like your post.", friends[0], friends[1], friends.Count - 2);
            }
        }

        /* Exercise 2
         * Write a program and ask the user to enter their name. Use an array to reverse the 
         * name and then store the result in a new string. Display the reversed name on the 
         * console.
         * */
        public static void reverseName()
        {
            Console.Write("Enter your name: ");
            var userInput = Console.ReadLine();

            var reversed = new char[userInput.Length];

            //Console.WriteLine("Before Reverese: " + userInput);
            
            //putting the characters in reverse
            //Console.WriteLine("After Reverese");
            for (int i = 1; i <= userInput.Length; i++)
            {
                reversed[i-1] = userInput[userInput.Length - i];
                //Console.WriteLine(reversed[i-1]);
            }

            var finalString = new String(reversed);
            Console.WriteLine("Your reversed name is: " + finalString);
            
        }

        /* Exercise 3
         * Write a program and ask the user to enter 5 numbers. If a number has been 
         * previously entered, display an error message and ask the user to re-try. 
         * Once the user successfully enters 5 unique numbers, sort them and display 
         * the result on the console.
         * */
        public static void reEnter()
        {
            while (true)
            {
                Console.WriteLine("Enter 5 unique numbers: ");
                var userInput = Console.ReadLine();
                var splitUserInput = userInput.Split(' ');
                
                if (splitUserInput.Distinct().Count() != splitUserInput.Count())
                {
                    //Display and error if there are duplicates. Prompts again.
                    Console.WriteLine("Error: Duplicate Number(s). Re-try. ");
                    
                }
                else
                {
                    //if the list is unique, sort it and print it to the console.
                    //Console.WriteLine("Else statement");
                    Array.Sort(splitUserInput);
                    //print output break the loop or return
                    foreach (var a in splitUserInput)
                    {
                        Console.Write(a + " \n");
                    }
                    return;
                }
            }
         }
        
        /* Exercise 4
         * Write a program and ask the user to continuously enter a number or type "Quit" 
         * to exit. The list of numbers may include duplicates. Display the unique numbers 
         * that the user has entered.
         * */

        public static void noDupes()
        {
            var numList = new List<string>();
            var noDupesList = new List<string>();

            while (true)
            {
                Console.WriteLine("Enter a number or enter Quit: ");
                var userInput = Console.ReadLine();
                if (userInput != "Quit")
                {
                    //add to a list
                    //Console.WriteLine("Print input: " + userInput);
                    numList.Add(userInput);
                    Console.WriteLine("List Count: " + numList.Count());
                    //Console.WriteLine("List: " + numList[0]);
                }
                else
                {
                    //print a unique list
                    Console.WriteLine("Else statement - print list without dupes");
                    
                    noDupesList = numList.Distinct().ToList();
                    foreach (var a in noDupesList)
                    {
                        Console.WriteLine(a);
                    }
                    return;
                }
            }

        }

        /* Exercise 5
         * Write a program and ask the user to supply a list of comma separated numbers 
         * (e.g 5, 1, 9, 2, 10). If the list is empty or includes less than 5 numbers, 
         * display "Invalid List" and ask the user to re-try; otherwise, display the 3 
         * smallest numbers in the list.
         * */

        public static void commaSeparatedNum()
        {
            while (true)
            {
                Console.WriteLine("Enter a list of comma separated numbers: ");
                var userInputStr = Console.ReadLine().Split(',');
                var smallInts = Array.ConvertAll(userInputStr, int.Parse);

                if (userInputStr.Count() < 5)
                {
                    Console.WriteLine("Invalid List.");
                    Console.WriteLine("Try Again... \n");

                }else
                {
                    //Console.WriteLine("Else Statement");
                    //Console.WriteLine("List Count: "+ userInputStr.Count());
                    
                    Array.Sort(smallInts);
                                        
                    Console.WriteLine("The 3 smallest numbers are: ");
                    for (int i = 0; i < 3; i++)
                    {
                       Console.WriteLine(smallInts[i]);
                    }
                    return;
                }
            }


        }
    }
}


