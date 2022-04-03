using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticeQuestions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            //var a = Console.ReadLine();
            //var b = Console.ReadLine();

            ////Console.WriteLine( a + " + " + b + " = " + GetModulus(int.Parse(a), int.Parse(b)) + GetModulus(int.Parse(a), int.Parse(b)));
            //var output = DifferentTheSame();
            //Console.WriteLine(output + " Press any key to terminate.");

            //TheSeventhSon();
            //Console.WriteLine("Press any key to terminate.");

            //TheSeventhSonUsingWhileLoop(); 
            //Console.WriteLine("Press any key to terminate.");

            //TheJumper(2017);ColleaguesOfFiveAndSix()
            //Console.WriteLine("Press any key to terminate.");

            //ColleaguesOfFiveAndSix();FriendsofNineteen()
            //Console.WriteLine("Press any key to terminate.");

            //FriendsofNineteen(); 
            //Console.WriteLine("Press any key to terminate.");

            //NumberTriangle(5);
            //Console.WriteLine("Press any key to terminate.");

            //InvertedTriangle(5);
            //Console.WriteLine("Press any key to terminate.");

            //bool isomporphic = IsIsomorphic("egg","add");
            //Console.WriteLine(isomporphic.ToString(), "Press any key to terminate.");

            Console.ReadKey();
        }

        public static int GetModulus (int firstNumber, int secondNumber)
        {
            return firstNumber % secondNumber;
        }

        public static int Adder (int a, int b)
        {
            return a + b;
        }

        public static string DifferentTheSame()
        {
            Console.WriteLine("Enter value Player 1:");
            var playerOneInput = Console.ReadLine();

            Console.WriteLine("Enter value Player 2:");
            var playerTwoInput = Console.ReadLine();

            if(playerOneInput.ToLower() != playerTwoInput.ToLower())
            {
                return "Player one wins.";
            }
            else
            {
                return "Player two wins.";
            }
        }

        public static void TheSeventhSon()
        {
            for(int count = 1; count < 1001; count++)
            {
                if(count % 7 == 0)
                {
                    Console.WriteLine("This is a seventh son. " + count);
                }
            }
        }

        public static void TheSeventhSonUsingWhileLoop()
        {
            int count = 0;

            while(count < 1000)
            {
                if (count % 7 == 0)
                {
                    Console.WriteLine("This is a seventh son. " + count);
                    count++;
                }
                else
                {
                    count++;
                }
            }
        }

        public static void CounterDisplay()
        {
            for(int num = 301; num < 650; num++)
            {
                Console.WriteLine(num);
            }
        }

        public static void TheJumper(int currentYear)
        {
            for(int displayYear = currentYear - 4; displayYear > currentYear - 41; displayYear -= 4)
            {
                Console.WriteLine("Here in " + displayYear +  ", this year’s festival has been stopped");
            }

            Console.WriteLine();

            Console.WriteLine("Jumper is now back to 2017." + currentYear);
        }

        public static void ColleaguesOfFiveAndSix()
        {
            for (int num = 1; num < 801; num++)
            {
                if (isColleague(num) == true)
                {
                    Console.WriteLine(num + " This number is a colleague of 5 and 6.");
                }
            }

            bool isColleague(int num)
            {
                int currentValue = num;

                //Add 36
                currentValue = currentValue + 36;

                //Check if divisible by 5
                if(DivisibleByNum(currentValue, 5) != true)
                {
                    return false;
                }
                else
                {
                    //Number minus 28 then get absolute
                    currentValue = Math.Abs(28 - currentValue);

                    //Check if divisible by 6
                    if (DivisibleByNum(currentValue, 6) != true)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
            }

            bool DivisibleByNum(int num, int denominator)
            {
                var outcome = false;
                if(num % denominator == 0)
                {
                    outcome = true;
                }

                return outcome;
            }
        }

        public static void FriendsofNineteen()
        {
            for (int num = 1; num < 501; num++)
            {
                if (((num+19) % 10) == 0)
                {
                    Console.WriteLine(num + " This number is a friend of 19");
                }
            }
        }

        public static void NumberTriangle(int n)
        {
            for(int i = 1; i < n+1; i++)
            {
                for(int j = n; j > n-i; j--)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }

        public static void InvertedTriangle(int n)
        {
            for (int i = n; i > 0; i--)
            {
                for (int j = n; j > n - i; j--)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }

        public static bool IsIsomorphic(string s, string t)
        {
            if (s.Length != t.Length)
            {
                return false;
            }
            else
            {
                var dict = new Dictionary<char, char>();
                int index = 0;

                foreach (char d in s)
                {
                    if (dict.ContainsKey(s[index]))
                    {
                        if (dict[s[index]] != t[index])
                        {
                            return false;
                        }
                    }
                    else
                    {
                        dict.Add(s[index], t[index]);
                    }

                    index++;
                }

                dict.Select(i => $"{i.Key}: {i.Value}").ToList().ForEach(Console.WriteLine);
                return true;
            }
        }
    }
}
