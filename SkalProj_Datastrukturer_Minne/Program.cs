using System;

namespace SkalProj_Datastrukturer_Minne
{
    class Program
    {
        /// <summary>
        /// The main method, vill handle the menues for the program
        /// </summary>
        /// <param name="args"></param>
        static void Main()
        {

            while (true)
            {
                Console.WriteLine("Please navigate through the menu by inputting the number \n(1, 2, 3 ,4, 0) of your choice"
                    + "\n1. Examine a List"
                    + "\n2. Examine a Queue"
                    + "\n3. Examine a Stack"
                    + "\n4. CheckParenthesis"
                    + "\n0. Exit the application");
                char input = ' '; //Creates the character input to be used with the switch-case below.
                try
                {
                    input = Console.ReadLine()![0]; //Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                }
                switch (input)
                {
                    case '1':
                        ExamineList();
                        break;
                    case '2':
                        ExamineQueue();
                        break;
                    case '3':
                        ExamineStack();
                        break;
                    case '4':
                        CheckParanthesis();
                        break;
                    /*
                     * Extend the menu to include the recursive 
                     * and iterative exercises.
                     */
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4)");
                        break;
                }
            }
        }

        /// <summary>
        /// Examines the datastructure List
        /// Den underliggande arrayen ökar i storlek när arrayen har fyllts och den inte har mer plats.
        /// Arrayen börjar med en storlek på 4 och ökar sedan exponentiellt i storlek när det behövs.
        /// Eftersom att det är dyrt att lägga till nya element i listan är det mer effektiv att öka arrayens storlek på detta sätt
        /// än att öka i samma takt som det läggs till element.
        /// Kapaciteten minskar inte när man tar bort element. 
        /// Det är mer fördelaktigt att använda en egendefinerad array när man vet i förhand hur stor array man behöver.
        /// </summary>
        static void ExamineList(List<string> theList = null)
        {
            if (theList == null) {
                theList = new List<string>();
            }

            Console.WriteLine("Type either (+) or (-) followed by any value to add or remove from the list. Type (Q) to exit to main menu.");
            string input = Console.ReadLine();
            char nav = input[0];
            string value = input.Substring(1);

            switch (nav)
            {
                case '+':
                    theList.Add(value);
                    Console.WriteLine($"'{value}' added to the list.\nList count: {theList.Count}\nList capacity: {theList.Capacity}");
                    break;
                case '-':
                    theList.Remove(value);
                    Console.WriteLine($"'{value}' removed from the list.\nList count: {theList.Count}\nList capacity: {theList.Capacity}");
                    break;
                case 'Q':
                case 'q':
                    return;
                default:
                    Console.WriteLine("Invalid input. Type either (+) or (-) followed by any value to add or remove from the list. Type (Q) to exit to main menu.");
                    break;
            }

            ExamineList(theList);
        }

        /// <summary>
        /// Examines the datastructure Queue
        /// </summary>
        static void ExamineQueue()
        {
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch with cases to enqueue items or dequeue items
             * Make sure to look at the queue after Enqueueing and Dequeueing to see how it behaves
            */
        }

        /// <summary>
        /// Examines the datastructure Stack
        /// </summary>
        static void ExamineStack()
        {
            /*
             * Loop this method until the user inputs something to exit to main menue.
             * Create a switch with cases to push or pop items
             * Make sure to look at the stack after pushing and and poping to see how it behaves
            */
        }

        static void CheckParanthesis()
        {
            /*
             * Use this method to check if the paranthesis in a string is Correct or incorrect.
             * Example of correct: (()), {}, [({})],  List<int> list = new List<int>() { 1, 2, 3, 4 };
             * Example of incorrect: (()]), [), {[()}],  List<int> list = new List<int>() { 1, 2, 3, 4 );
             */

        }

    }
}

