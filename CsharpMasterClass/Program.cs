using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpMasterClass
{
    public class Program
    {




        public static void Main(string[] args)
        {
            //    string[,] matrix;
            //    int[,,] threeD;

            //    int[,] array2D = new int[,] 
            //{
            //    {1,2,3},
            //    { 4,5,6},
            //    { 7,8,9}
            //};

            //    Console.WriteLine("Central value is {0}", array2D[1,1]);
            //     Console.WriteLine("First value in the third row is: {0}", array2D[2,0]);

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Arrays.GetEven(numbers);
            Arrays.GetOdd(numbers);
            
            Console.ReadKey();
        }
    }

    #region     My sample work using switches and foreach loops
    //        static bool IsStringOrInt (string value)
    //        {
    //            foreach (char c in value)
    //            {
    //                if (char.IsLetter(c))
    //                {
    //                    Console.WriteLine("You have  entered a string");
    //                    return true;

    //                }

    //                else if (char.IsNumber(c))
    //                    {
    //                    Console.WriteLine("You have entered an integer");
    //                    return true;
    //                    }

    //                else if (!char.IsNumber(c) || (!char.IsLetter(c)))
    //                {
    //                    Console.WriteLine("You must have entered a boolean");
    //                }
    //            }
    //            return false;
    //        }
    //        static bool IsInt(string value)
    //        {
    //            foreach (char c in value)
    //            {
    //                if (!char.IsNumber(c))
    //                {
    //                    return false;
    //                }
    //            }
    //            return true;
    //        }





    //        Console.WriteLine("Enter a value");
    //            var input1 = Console.ReadLine();
    //        Console.WriteLine("Enter the datatype of your input using trhe folloiwng:" + "\n" + 
    //                " Press 1 for String" + "\n" + " Press 2 for Integer" + "\n" + "Press 3 for Boolean");
    //            var input2 = Console.ReadLine();
    //        bool isValid = true;


    //            switch (input2)

    //            {
    //                case "1":
    //                    {

    //                        if (IsStringOrInt(input1) == isValid)
    //                        {
    //                            Console.WriteLine("You have entered a value: {0}", input1);
    //                        }
    //                        else Console.WriteLine("You have not entered a string");



    //                    }
    //                    break;

    //                case "2":
    //                    {
    //                        IsStringOrInt(input1);
    //Console.WriteLine("You have entered a value: {0}", input1);

    //                    }
    //                    break;

    //                case "3":
    //                    {
    //                        IsStringOrInt(input1);
    //Console.WriteLine("You have entered a value: {0}", input1);
    //                        Console.WriteLine("It is  Boolean");

    //                    }


    //                    break;
    //            }

    //            Console.ReadKey();


    //    }
    #endregion

    //public static void WriteStatement(string text)
    //{
    //    Console.WriteLine(text);
    //}

    //public static int Add(int num1, int num2)
    //{
    //    return num1 + num2;
    //}
    //public static int Divide(int num1, int num2)
    //{
    //    return num1 / num2;
    //}


    //public static void ScoreAndPlayerName(int score, string playerName)
    //{
    //    WriteStatement("Enter your score here:");
    //    string scoreEntered = Console.ReadLine();
    //    score= int.Parse(scoreEntered);
    //    WriteStatement("Enter your name here: ");
    //    playerName = Console.ReadLine();

    //    int highScore = 900;
    //    if (score > highScore)
    //    {
    //        WriteStatement("New High Score is: " + score + "\n" + "New High score Player is : " + playerName);
    //    }
    //    else
    //    {
    //        WriteStatement("The old score of " + highScore + " could not be broken and is still held by " + highScorePlayer);
    //    }




    //}

    #region LoopsChallenge
    //    string input = "0";
    //    int total = 0;
    //    int currentnumber = 0;
    //    int counter = 0;

    //    double average; // score total / # of students

    //        try
    //        {

    //            while (input !="-1")
    //            {
    //                Console.WriteLine("The current number is {0}", currentnumber);
    //                Console.WriteLine("The current count is {0}", counter);
    //                Console.WriteLine("Enter the student score:");
    //            input = Console.ReadLine();

    //                if(input.Equals("-1"))
    //                {
    //                    //Calculate average
    //                    average = (double) total / (double) counter;
    //    Console.WriteLine("The average total score for students is {0}", average);
    //                }
    //                if (int.TryParse(input, out currentnumber) && currentnumber > 0 && currentnumber< 21)
    //                {
    //                    total = +currentnumber;
    //                }
    //                else
    //                {
    //                    if (!(input.Equals("-1")))
    //                    {
    //                        Console.WriteLine("Please enter a value between 1 and 20");
    //                    }
    //                    continue;
    //                }

    //                counter++;
    //            }














    //        }
    //        catch (Exception)
    //        {

    //            Console.WriteLine("You didn't enter any text");
    //        }
    //}
    #endregion




}



