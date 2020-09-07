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
            int choice5Int = 0;
            int choice6Int = 0;


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
                    System.Console.WriteLine("A sharp pain wakes you, followed by a numbing feeling in your neck and everything fades to black \n" +
                    "You Died");
                    choice1Int = 0;
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

            System.Console.WriteLine("After a harrowing night of hearing animals ruffle through the vegetation and " + "");
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

    }
}
