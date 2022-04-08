using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Newtonsoft.Json;

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

            //List<int> sampleNumList = new List<int> { 8, 7, 0, 0, 15, 3, 7, 0, 0, 0, 0, 15, 3, 7, 0, 11, 6, 0, 0, 15, 3, 7, 0, 0, 0, 0, 15, 3, 7, 0, 0, 0, 0, 15, 3, 7, 0, 0, 0, 0, 15, 3, 0 };

            //Console.WriteLine("TwoElementsSumUpToKOne : " + TwoElementsSumUpToKOne(sampleNumList, 16));

            //Console.WriteLine();

            //Console.WriteLine("TwoElementsSumUpToKTwo : " + TwoElementsSumUpToKTwo(sampleNumList, 16));

            //Console.WriteLine();

            //List<int> socks = new List<int> { 10, 20, 20, 10, 10, 30, 50, 10, 20 };

            //Console.WriteLine("Number of pairs : " + SockMerchant(socks.Count, socks));

            //Console.WriteLine(CountingValleys(8, "DDUUDDUDUUUD"));

            //List<int> clouds = new List<int> { 0, 0, 0, 1, 0, 0 }; //3 jumps

            //List<int> cloudsTest2 = new List<int> { 0, 0, 1, 0, 0, 1, 0 }; //4 jumps

            //Console.WriteLine("Jumping clouds test 1 " + JumpingOnClouds(clouds));

            //Console.WriteLine("Jumping clouds test 2 " + JumpingOnClouds(cloudsTest2));

            //Console.WriteLine("RepeatedString " + RepeatedString("abc", 7));

            //Console.WriteLine("RepeatedString2 " + RepeatedString2("abc", 7));

            //List<int> numbersTestCase1 = new List<int> { 1, 2, 3, 4, 5 };

            //List<int> numbersTestCase2 = new List<int> { 3, 2, 1 };

            //List<int> numbersTestCase3 = new List<int> { 9, 0, 1 };

            //UberInterview(numbersTestCase1);

            //Console.WriteLine();

            //UberInterview(numbersTestCase2);

            //Console.WriteLine();

            //UberInterview(numbersTestCase3);

            //TestBinaryQuestion();

            //List<int> equalizeArr = new List<int> { 3, 3, 2, 1, 3 };

            //Console.WriteLine(EqualizeArray(equalizeArr));

            //List<int> lowestPossibleIntcase1 = new List<int> { 3, 1, -1, 1 }; //2

            //Console.WriteLine(LowestPositiveInteger(lowestPossibleIntcase1));

            //List<int> lowestPossibleIntCase2 = new List<int> { 1, 2, 0 }; //3

            //Console.WriteLine(LowestPositiveInteger(lowestPossibleIntCase2));

            //List<int> lowestPossibleIntCase3 = new List<int> { 0, 0, 0, 0 }; //1

            //Console.WriteLine(LowestPositiveInteger(lowestPossibleIntCase3));

            //List<int> lowestPossibleIntCase4 = new List<int> { 1, 2, 2, 3, 0 }; //4

            //Console.WriteLine(LowestPositiveInteger(lowestPossibleIntCase4));

            //List<int> lowestPossibleIntCase5 = new List<int> { 0, -1, 4, 3, 1 }; //2

            //Console.WriteLine(LowestPositiveInteger(lowestPossibleIntCase5));

            //List<int> plusMin = new List<int> { 1, 1, 0, -2, -1 };

            //PlusMinus(plusMin);

            //Staircase(5);

            //List<int> miniMaxSum = new List<int> { 1, 2, 3, 4, 5 };

            //MiniMaxSum(miniMaxSum);

            //List<int> row1 = new List<int> { 11, 2, 4 };
            //List<int> row2 = new List<int> { 4, 5, 6 };
            //List<int> row3 = new List<int> { 10, 8, - 12 };

            //List<List<int>> testInput = new List<List<int>> { row1, row2, row3 };

            //Console.WriteLine(DiagonalDifference(testInput));

            //Console.WriteLine(Car(Cons(3,4)));

            //Console.WriteLine(Cdr(Cons(3, 4)));

            //List<int> nonDivisibleSub = new List<int> { 1, 7, 2, 4 };

            //Console.WriteLine(NonDivisibleSubset(3, nonDivisibleSub));

            List<int> gradingProb = new List<int> { 73, 67, 38, 33 };

            var x = GradingStudents(gradingProb);

            Console.ReadKey();
        }

        public static int GetModulus(int firstNumber, int secondNumber)
        {
            return firstNumber % secondNumber;
        }

        public static int Adder(int a, int b)
        {
            return a + b;
        }

        public static string DifferentTheSame()
        {
            Console.WriteLine("Enter value Player 1:");
            var playerOneInput = Console.ReadLine();

            Console.WriteLine("Enter value Player 2:");
            var playerTwoInput = Console.ReadLine();

            if (playerOneInput.ToLower() != playerTwoInput.ToLower())
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
            for (int count = 1; count < 1001; count++)
            {
                if (count % 7 == 0)
                {
                    Console.WriteLine("This is a seventh son. " + count);
                }
            }
        }

        public static void TheSeventhSonUsingWhileLoop()
        {
            int count = 0;

            while (count < 1000)
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
            for (int num = 301; num < 650; num++)
            {
                Console.WriteLine(num);
            }
        }

        public static void TheJumper(int currentYear)
        {
            for (int displayYear = currentYear - 4; displayYear > currentYear - 41; displayYear -= 4)
            {
                Console.WriteLine("Here in " + displayYear + ", this year’s festival has been stopped");
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
                if (DivisibleByNum(currentValue, 5) != true)
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
                if (num % denominator == 0)
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
                if (((num + 19) % 10) == 0)
                {
                    Console.WriteLine(num + " This number is a friend of 19");
                }
            }
        }

        public static void NumberTriangle(int n)
        {
            for (int i = 1; i < n + 1; i++)
            {
                for (int j = n; j > n - i; j--)
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

        //Using 2 FOR-loops
        public static bool TwoElementsSumUpToKOne(List<int> numbers, int k)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                for (int j = 0; j < numbers.Count; j++)
                {
                    if (i != j)
                    {
                        if (numbers[i] + numbers[j] == k)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        //  Thinking out loud
        public static bool TwoElementsSumUpToKTwo(List<int> numbers, int k)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                for (int j = 0; j < numbers.Count; j++)
                {
                    if (i != j)
                    {
                        if (numbers[i] + numbers[j] == k)
                        {
                            return true;
                        }
                    }
                }

                //Can iterating through the list in reverse make a difference?
                for (int j = numbers.Count - 1; j > 0; j--)
                {
                    if (i != j)
                    {
                        if (numbers[i] + numbers[j] == k)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        public class SocksOfSameColour
        {
            public int Colour { get; set; }
            public int NumberOfPairs { get; set; }
        }

        public static int SockMerchant(int n, List<int> ar)
        {
            var sumOfPairs = 0;
            List<SocksOfSameColour> uniquePairs = new List<SocksOfSameColour>();

            foreach (int sockColour in ar)
            {
                int pairsOfSameColor = ar.Where(socCol => socCol == sockColour).Count() / 2;

                if (pairsOfSameColor > 0)
                {
                    SocksOfSameColour socksOfSameColour = new SocksOfSameColour();
                    socksOfSameColour.NumberOfPairs = pairsOfSameColor;
                    socksOfSameColour.Colour = sockColour;

                    var exists = uniquePairs.Where(uniquePair => uniquePair.Colour == socksOfSameColour.Colour).Any();

                    if (exists != true)
                    {
                        uniquePairs.Add(socksOfSameColour);
                        sumOfPairs += socksOfSameColour.NumberOfPairs;
                    }
                }
            }

            return sumOfPairs;
        }

        public static int CountingValleys(int steps, string path)
        {
            int currentPoint = 1;
            char[] pathCharArr = path.ToCharArray();

            foreach (char c in pathCharArr)
            {
                if ((c.ToString()).ToLower() == "D".ToLower())
                {
                    currentPoint = currentPoint - 1;
                }
                else
                {
                    currentPoint = currentPoint + 1;
                }
            }
            return currentPoint;
        }

        public static int JumpingOnClouds(List<int> c)
        {
            int stepsTaken = 0;
            int index = 0;
            while (index < c.Count - 1)
            {
                if ((index + 2 < c.Count) && (c[index + 2] == 0))
                {
                    index += 2;
                    stepsTaken++;
                }
                else
                {
                    index += 1;
                    stepsTaken++;
                }
            }

            return stepsTaken++; ;
        }

        public static long RepeatedString(string s, long n)
        {
            if (s.Length == 1)
            {
                return n;
            }
            else
            {
                char[] pathCharArr = s.ToCharArray();
                int index = 0;

                string finalString = "";

                while (finalString.Length != n)
                {
                    if (index < s.Length)
                    {
                        finalString += pathCharArr[index].ToString();
                        index++;
                    }
                    else
                    {
                        index = 0;
                        finalString += pathCharArr[index].ToString();
                        index++;
                    }
                }

                return finalString.ToList().Where(character => character.ToString() == "a").Count();
            }
        }

        public static long RepeatedString2(string s, long n)
        {
            if (s.Length == 1)
            {
                return n;
            }
            else
            {
                var aInS = s.ToList().Where(character => character.ToString() == "a").Count();

                long repetitions = n / s.Length;

                return (repetitions * aInS) + (n % s.Length);
            }
        }

        public static void UberInterview(List<int> numbers)
        {
            List<int> updatedArray = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                int product = 1;

                for (int j = 0; j < numbers.Count; j++)
                {
                    if (i != j)
                    {
                        product *= numbers[j];

                        if (j == numbers.Count - 1)
                        {
                            updatedArray.Add(product);
                        }
                    }
                    else if (updatedArray.Count == numbers.Count - 1)
                    {
                        updatedArray.Add(product);
                    }
                }
            }

            foreach (int n in updatedArray)
            {
                Console.Write(n + " ");
            }
        }

        public class Root
        {
            public dynamic Data { get; set; }
            public dynamic Left { get; set; }
            public dynamic Right { get; set; }
        }

        public static string SerializeRoot(Root root)
        {
            return JsonConvert.SerializeObject(root);
        }

        public static Root DeserializeRoot(string root)
        {
            return JsonConvert.DeserializeObject<Root>(root);
        }

        public static void TestBinaryQuestion()
        {
            Root root = new Root();

            root.Data = "data";
            root.Left = "left";
            root.Right = "right";

            Console.WriteLine(DeserializeRoot(SerializeRoot(root)).Left == root.Left);
        }

        public class IntegerOccurences
        {
            public int Number { get; set; }
            public int Count { get; set; }
        }

        public static int EqualizeArray(List<int> arr)
        {
            List<IntegerOccurences> integerOccurences = new List<IntegerOccurences>();

            foreach(int number in arr)
            {
                IntegerOccurences existingIntegerOccurence = integerOccurences.Where(occurence => occurence.Number == number).FirstOrDefault();

                if(existingIntegerOccurence == null)
                {
                    IntegerOccurences newIntegerOccurence = new IntegerOccurences();

                    newIntegerOccurence.Number = number;
                    newIntegerOccurence.Count = arr.Where(num => num == number).Count();

                    integerOccurences.Add(newIntegerOccurence);
                }
            }

            var mostOccuring = integerOccurences.OrderByDescending(occ => occ.Count).FirstOrDefault();

            return arr.Count - mostOccuring.Count;
        }

        public static int LowestPositiveInteger (List<int> numbers)
        {
            //Remove negative numbers
            numbers.RemoveAll(number => number < 0);

            ////Remove duplicates
            numbers = numbers.Distinct().ToList();

            //Sort list
            numbers.Sort();

            int nextNum = numbers[0];

            for(int i=numbers[0]; i<numbers.Count; i++)
            {
                if(numbers[i] != nextNum && (numbers[i] == numbers[^1]) == false)
                {
                    return nextNum;
                }
                else if(numbers[i] == numbers[^1])
                {
                    nextNum++;
                    return nextNum;
                }
                else
                {
                    nextNum++;
                }
            }

            return nextNum;
        }

        public static void PlusMinus(List<int> arr)
        {
            var x = arr.Where(num => num == 0).Count();
            float numOfZeros = arr.Where(num => num == 0).Count() / (float)arr.Count;
            float numOfPositive = arr.Where(num => num > 0).Count() / (float)arr.Count;
            float numOfNegative = arr.Where(num => num < 0).Count() / (float)arr.Count;

            Console.WriteLine(numOfPositive);
            Console.WriteLine(numOfNegative);
            Console.WriteLine(numOfZeros);
        }

        public static void Staircase(int n)
        {
            for (int i = 1; i < n+1; i++)
            {
                Console.WriteLine(PrintStr(n-i, " ") + PrintStr(i, "#"));
            }

            string PrintStr(int i, string str)
            {
                string returnStr = "";
                for(int a=0 ; a<i; a++)
                {
                    returnStr += str;
                }

                return returnStr;
            }
        }

        public static void MiniMaxSum(List<int> arr)
        {
            List<long> sums = new List<long> ();

            for(int i=0; i<arr.Count; i++)
            {
                long sum = 0;
                for (int j = 0; j < arr.Count; j++)
                {
                    if (i != j)
                    {
                        sum += arr[j];
                    }
                }
                sums.Add(sum);
            }

            sums.Sort();

            Console.Write(sums[0] + " " + sums[arr.Count-1]);
        }

        public static int DiagonalDifference(List<List<int>> arr)
        {
            int sumOfLeftDiagonal = 0;
            int sumOfRightDiagonal = 0;

            for(int k = 0; k < arr.Count; k++)
            {
                sumOfLeftDiagonal += arr[k][k];

                sumOfRightDiagonal += arr[k][arr.Count-1-k];
            }

            return Math.Abs(sumOfLeftDiagonal - sumOfRightDiagonal);
        }

        public class Pair
        {
            public dynamic First { get; set; }
            public dynamic Last { get; set; }
        }

        public static dynamic Cons(dynamic a, dynamic b)
        {
            Pair pair = new Pair();

            pair.First = a;
            pair.Last = b;
            return pair;
        }

        public static dynamic Car(Pair pair)
        {
            return pair.First;
        }

        public static dynamic Cdr(Pair pair)
        {
            return pair.Last;
        }

       

        public static List<int> GradingStudents(List<int> grades)
        {
            List<int> finalGrades = new List<int>();

            foreach(int grade in grades)
            {
                if(grade < 38 || (grade % 5) == 0)
                {
                    finalGrades.Add(grade);
                }
                else if((grade + 2) % 5 == 0)
                {
                    finalGrades.Add(grade + 2);
                }
                else if((grade + 1) % 5 == 0)
                {
                    finalGrades.Add(grade + 1);
                }
                else
                {
                    finalGrades.Add(grade);
                }
            }

            return finalGrades;
        }
    }
}
