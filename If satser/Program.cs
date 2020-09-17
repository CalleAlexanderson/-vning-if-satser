using System;

namespace If_satser
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice1Int = 1;
            int choice2Int = 0;
            int choice3Int = 0;
            int choice4Int = 0;
            int win = 0;
            int death = 0;
            string restart = "";




            while (choice1Int == 1)
            {
                Choice1Text();

                string choice1 = AskQuestion();

                if (choice1 == "a")
                {
                    System.Console.WriteLine("You somehow survive the night and another day dawns");
                    choice1Int = 0;
                    choice2Int = 1;
                }
                else if (choice1 == "b")
                {
                    System.Console.WriteLine("A sharp pain wakes you, followed by a numbing feeling in your neck and everything fades to black. \n" +
                    "You Died");
                    choice1Int = 0;
                    death = 1;
                }
                else if (choice1 == "c")
                {
                    System.Console.WriteLine("You find doglike footprints and signs of large animal activity all over the place");
                    choice1Int = 0;
                    choice3Int = 1;
                }
            }

            while (choice2Int == 1)
            {
                Choice2Text();


                string choice2 = AskQuestion();

                if (choice2 == "a")
                {
                    System.Console.WriteLine("You find a cabin and a nice man lets you borrow a phone to call for help");
                    choice2Int = 0;
                    win = 1;

                }
                else if (choice2 == "b")
                {
                    System.Console.WriteLine("A sharp pain wakes you, followed by a numbing feeling in your neck and everything fades to black \n" +
                    "You Died");
                    choice2Int = 0;
                    death = 1;
                }



            }

            while (choice3Int == 1)
            {

                Choice3text();

                string choice3 = AskQuestion();

                if (choice3 == "a")
                {
                    System.Console.WriteLine("You follow the footprints leading to a cove, what's the next move?");
                    choice3Int = 0;
                    choice4Int = 1;
                }

                if (choice3 == "b")
                {
                    System.Console.WriteLine("You find a cabin and a nice man lets you borrow a phone to call for help");
                    choice3Int = 0;
                    win = 1;

                }
            }

            while (choice4Int == 1)
            {

                Choice4text();

                string choice4 = AskQuestion();

                if (choice4 == "a")
                {
                    System.Console.WriteLine("You walk into the cove and find bones before you hear a something running towards you \n" +
                    "The next thing you know you feel a sharp pain before everything fades to black \n" + "You Died");
                    choice4Int = 0;
                    death = 1;
                }

                if (choice4 == "b")
                {
                    System.Console.WriteLine("You find a cabin and a nice man lets you borrow a phone to call for help");
                    choice4Int = 0;
                    win = 1;
                }
            }

            while (win == 1)
            {
                Console.WriteLine("You win");
                win = 0;
                Console.ReadLine();
            }

            while (death == 1)
            {
                Restarttext();
                restart = Console.ReadLine().ToLower();



                if (restart == "r")
                {
                    choice1Int = 1;
                    choice2Int = 0;
                    choice3Int = 0;
                    choice4Int = 0;
                    win = 0;
                    death = 0;

                }
            }

        }

        static void Choice1Text()
        {
            System.Console.WriteLine("Rules: type c for choice a, c for choice b and c for choice c\n" +
                "You wake up naked in a forest in the dead of night, what do you do?" +
                "\n Choice A: Make a fire. \n Choice B: Go back to sleep. \n Choice C: Search the area."
                );

        }

        static void Choice2Text()
        {

            System.Console.WriteLine("After a harrowing night of hearing animals ruffle through the vegetation and howls creeping closer, what's next?" +
            "\n Choice A: Explore the area in dayligt. \n Choice B: Get some actual deepsleep");
        }

        static void Choice3text()
        {
            System.Console.WriteLine("After this finding what is your next action?" +
            "\n Choice A: Follow the footprints. \n Choice B: Continue the search.");
        }

        static void Choice4text()
        {
            System.Console.WriteLine("\n Choice A: Go deeper into the cove. \n Choice B: Continue the search elsewhere.");
        }



        static string AskQuestion()
        {
            string answer = "";

            while (answer != "a" && answer != "b" && answer != "c")
            {

                System.Console.WriteLine("Only A, B C are allowed");
                answer = Console.ReadLine().ToLower();
            }

            return answer;
        }

        static void Restarttext()
        {
            Console.WriteLine("Type r to restart");
        }

    }
}
