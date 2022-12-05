using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;

namespace C_Sharp_Arrays_Lists
{
    class C_Sharp_Arrays_Lists
    {
        static void QuoteOfTheDay()
        {
            Random rnd = new Random();
            int quoteChoice = rnd.Next(1, 4);
            string[,] quotes = new string[3, 2];
            quotes[0, 0] = "abc"; quotes[0, 1] = "Harry Tyson"; quotes[1, 0] = "Hello world"; quotes[1, 1] = "Ned newman"; quotes[2, 0] = "live life to the fullest"; quotes[2, 1] = "Flo Linkin";
            if (quoteChoice == 1) { Console.WriteLine("'" + quotes[0, 0] + "' " + quotes[0, 1]); }
            else if (quoteChoice == 2) { Console.WriteLine("'" + quotes[1, 0] + "' " + quotes[1, 1]); }
            else if (quoteChoice == 3) { Console.WriteLine("'" + quotes[2, 0] + "' " + quotes[2, 1]); }
        }

        static void Inventory()
        {
            List<string> Inventory = new List<string>();
            Random rnd = new Random();
            bool x = true;
            while (x)
            {
                Console.WriteLine("\nWhat would you like to do (enter 'stop' to stop entering in commands): pickup item, drop item, pull out or search");
                string inventoryAction = Console.ReadLine().ToLower();

                if (inventoryAction == "pickup item")
                {
                    Console.WriteLine("What have you picked up?");
                    string pickedItem = Console.ReadLine().ToLower();
                    Inventory.Add(pickedItem);
                }

                else if (inventoryAction == "drop item")
                {
                    Console.WriteLine("What item would you like to drop?");
                    string droppedItem = Console.ReadLine().ToLower();
                    Inventory.Remove(droppedItem);
                }

                else if (inventoryAction == "pull out")
                {
                    int randomItem = rnd.Next(0, Inventory.Count());
                    Console.WriteLine(Inventory[randomItem]);
                }
                else if (inventoryAction == "search")
                {
                    Inventory.ForEach(Console.WriteLine);
                }
                else if (inventoryAction == "stop")
                {
                    x = false;
                }
                else if (inventoryAction != "pickup item" && inventoryAction != "drop item" && inventoryAction != "pull out" && inventoryAction != "pickup item" && inventoryAction != "stop")
                {
                    Console.WriteLine("Ive never heard of that command try again");
                }
            }
        }

        static void Notebook()
        {
            bool x = true;
            int a = 0;
            string[,] notes = new string[9, 2];
            while (x)
            {
                Console.WriteLine("Which note would you like to change or view 1-10, to view all notes enter 'all' (To exit your notebook enter 'stop'):");
                string choice = Console.ReadLine();
                if (choice.ToLower() == "stop")
                {
                    x = false;
                }
                if (choice.ToLower() == "all")
                {
                    for (int i = 0; i < 9; i++)
                    {
                        Console.WriteLine(notes[i, 1]);
                    }
                }
                else if (int.Parse(choice) >= 1 && int.Parse(choice) <= 10)
                {
                    Console.WriteLine("Would you like to view or change your note?");
                    string answer = Console.ReadLine().ToLower();
                    if (answer == "view")
                    {
                        Console.WriteLine(notes[int.Parse(choice) - 1, 1]);
                    }
                    if (answer == "change")
                    {
                        Console.WriteLine("What would you like to change your note to...");
                        notes[int.Parse(choice) - 1, 1] = Console.ReadLine();
                    }
                }           
            }
        }

        static void ProceduralGeneration()
        {
            List<string> creatures = new List<string> { "human", "lizard", "alien", "bear", "rodent", "bug", "snake", "bird", "dinosaur"}; List<String> Colours = new List<string> { "red", "blue", "GOLD", "yellow", "brown", "green", "purple", "black", "white"}; List<string> characteristics = new List<String> { "shy", "Angry", "selfish", "timid", "docile", "violent", "ignorant", "brave", "excited"};
            Console.WriteLine("Please enter a 3 integer long seed or enter random for a random seed");
            string seed = Console.ReadLine().ToLower();
            if (seed == "random")
            {
                Random rnd = new Random();
                string num1 = Convert.ToString(rnd.Next(100, 999));
                seed = num1;
            }
            Console.WriteLine($"You have come across a new lifeform... Its a {Colours[int.Parse(Convert.ToString(seed[1]))]}, {characteristics[int.Parse(Convert.ToString(seed[2]))]}, {creatures[int.Parse(Convert.ToString(seed[2]))]}!");
        }

        static void VictoriaLine()
        {
            List<string> Stations = new List<string> { "brixton", "stockwell", "vauxhall", "pimlico", "victoria",  "green park", "oxford circus", "warren street", "euston", "kings cross", "highbury and islington", "finsbury park", "seven sisters", "tottenham hale", "blackhorse road", "walthamstow central"};
            Console.WriteLine("enter the station you are at:");  string station1 = Console.ReadLine().ToLower();
            Console.WriteLine("Enter the station you wish to arrive at:");  string station2 = Console.ReadLine().ToLower();
            int indexStation1 = Stations.FindIndex(a => a.Contains(station1)) + 1;
            int indexStation2 = Stations.FindIndex(a => a.Contains(station2)) + 1;
            if (indexStation1 < indexStation2)  { Console.WriteLine($"There are {indexStation2 - indexStation1 - 1} stations between {station1} and {station2}"); }
            if (indexStation2 < indexStation1) { Console.WriteLine($"There are {16 - indexStation1 + indexStation2 - 1} stations between {station1} and {station2}"); }
        }

        static void ChristmasSong()
        {
            string[,] daysAndGifts = new string[12 , 2];
            daysAndGifts[0, 0] = "a partridge in a pear tree"; daysAndGifts[0, 1] = "first";
            daysAndGifts[1, 0] = "two turtle doves"; daysAndGifts[1, 1] = "second";
            daysAndGifts[2, 0] = "three french hens"; daysAndGifts[2, 1] = "third";
            daysAndGifts[3, 0] = "four calling birds"; daysAndGifts[3, 1] = "forth";
            daysAndGifts[4, 0] = "five golden rings"; daysAndGifts[4, 1] = "fith";
            daysAndGifts[5, 0] = "six geese a-laying"; daysAndGifts[5, 1] = "sixth";
            daysAndGifts[6, 0] = "seven swans a-swimming"; daysAndGifts[6, 1] = "seventh";
            daysAndGifts[7, 0] = "eight maids a-milking"; daysAndGifts[7, 1] = "eighth";
            daysAndGifts[8, 0] = "nine ladies dancing"; daysAndGifts[8, 1] = "nineth";
            daysAndGifts[9, 0] = "ten lords a-leaping"; daysAndGifts[9, 1] = "tenth";
            daysAndGifts[10, 0] = "eleven pipers piping"; daysAndGifts[10, 1] = "eleventh";
            daysAndGifts[11, 0] = "twelve drummers drumming"; daysAndGifts[11, 1] = "twelth";
            for (int a = 0; a < 12; a++)
            {
                Console.WriteLine($"And on the {daysAndGifts[a, 1]} day of christmas\nMy true love gave to me");
                for (int x = 0; x < a + 1; x++)
                {
                    Console.WriteLine(daysAndGifts[x, 0]); 
                }
            }
        }

        static void MathsTest()
        {
            Random rnd = new Random();
            string[,] scoresAndNames = new string[1, 2];
            int questionsCorrect = 0;
            Console.WriteLine("Please enter your name:");
            string name = Console.ReadLine();
            scoresAndNames[0, 0] = name;
            for (int x = 0; x < 5; x++)
            {
                int number1 = rnd.Next(1, 10);
                int number2 = rnd.Next(1, 10);
                Console.WriteLine($"{number1} + {number2}");
                int answer = int.Parse(Console.ReadLine());
                if (answer == number1 + number2)
                {
                    questionsCorrect++;
                }
                else { }
            }
            scoresAndNames[0, 1] = Convert.ToString(questionsCorrect);
            Console.WriteLine($"Name : {scoresAndNames[0, 0]}\nScore : {scoresAndNames[0, 1]}/5");
        }

        static void Tanks()
        {
            int tanksLeft = 10;
            string[,] board = new string[8, 8];
            Random rnd = new Random();
            for (int x = 0; x < 11; x++)
            {
                int row = rnd.Next(0, 8);
                int column = rnd.Next(0, 8);
                if (board[row, column] == " T") { x--; }
                else { board[row, column] = " T"; }
            }
            for (int col = 0; col < board.GetLength(0); col++)
                for (int row = 0; row < board.GetLength(1); row++)
                    if (board[col, row] == " T") { }
                    else
                    {
                        board[col, row] = " |";
                    }
            Console.WriteLine("  1   2   3   4   5   6   7");
            for (int x = 0; x < 7; x++)
            {
                Console.WriteLine((x + 1) + board[x, 0] + " " + board[x, 1] + " " + board[x, 2] + " " + board[x, 3] + " " + board[x, 4] + " " + board[x, 5] + " " + board[x, 6] + " " + board[x, 7]);
            }



            for (int x = 0; x < 50; x++)
            {
                if (tanksLeft == 0)
                {
                    Console.WriteLine("You have won!"); Thread.Sleep(5000); Environment.Exit(0);
                }
                Console.WriteLine("Enter your guess (format your guess as row,column)...");
                string guess = Console.ReadLine();
                int guess1 = int.Parse(Convert.ToString(guess[0])); int guess2 = int.Parse(Convert.ToString(guess[guess.Length-1]));
                if (board[guess1 - 1, guess2 - 1] == " T")
                {
                    tanksLeft--;
                    board[guess1, guess2] = " |";
                    Console.WriteLine("You have destroyed a tank!");
                }
                else
                {
                    Console.WriteLine("You have missed! Try again:");
                }
            }
            if (tanksLeft > 0)
            {
                Console.WriteLine("You have lost.");
            }
        }

        static void StrongNumbers()
        {
            double total = 0;
            Console.WriteLine("Enter an integer:"); string enteredNumber = Console.ReadLine();
            Console.WriteLine(enteredNumber.Length);
            for (int x = 0; x < enteredNumber.Length; x++)
            {
                double manipulatedNumber = int.Parse(Convert.ToString(enteredNumber[x]));
                double n = manipulatedNumber;
                for (double i = n - 1; i > 0; i--)
                {
                    n *= i;
                }
                Console.WriteLine("Factorial of !{0} = {1}\n", manipulatedNumber, n);
                total += n;
                manipulatedNumber--;
                Thread.Sleep(200);
            }
            Console.WriteLine("Total = " + total);
            if (total == int.Parse(enteredNumber)) { Console.WriteLine("Your number is a strong number."); }
            else if (total != int.Parse(enteredNumber)){ Console.WriteLine("You number is not a strong number."); }
        }

        static void Main()
        {
            Console.WriteLine("Enter 1 for quote of the day, enter 2 for inventory manager, enter 3 for notebook, enter 4 for procedural generation, enter 5 for victoria line stations, enter 6 for christmas songs, enter 7 for maths test, enter 8 for tanks game, enter 9 for strong number");
            int Decision = int.Parse(Console.ReadLine());
            if (Decision == 1)
            {
                QuoteOfTheDay();
                Console.ReadLine();
            }
            if (Decision == 2)
            {
                Inventory();
                Console.ReadLine();
            }
            if (Decision == 3)
            {
                Notebook();
                Console.ReadLine();
            }
            if (Decision == 4)
            {
                ProceduralGeneration();
                Console.ReadLine();
            }
            if (Decision == 5)
            {
                VictoriaLine();
                Console.ReadLine();
            }
            if (Decision == 6)
            {
                ChristmasSong();
                Console.ReadLine();
            }
            if (Decision == 7)
            {
                MathsTest();
                Console.ReadLine();
            }
            if (Decision == 8)
            {
                Tanks();
                Console.ReadLine();
            }
            if (Decision == 9)
            {
                StrongNumbers();
                Console.ReadLine();
            }
        }
    }
}