using System;
using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Runtime.InteropServices;

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
                Console.WriteLine("Please navigate through the menu by inputting the number \n(1, 2, 3, 4, 5, 0) of your choice"
                    + "\n1. Examine a List"
                    + "\n2. Examine a Queue"
                    + "\n3. Examine a Stack"
                    + "\n4. CheckParenthesis"
                    + "\n5. ReverseText"
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
                        Checkparantheses();
                        break;
                    case '5':
                        ReverseText();
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
            if (theList == null)
            {
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
        /// Vi kan lägga till element och ta bort från kön med denna metod.
        /// </summary>
        static void ExamineQueue(Queue<string> theQueue = null)
        {
            if (theQueue == null)
            {
                theQueue = new Queue<string>();
            }

            Console.WriteLine("Type (+) followed by any value to add the value to the queue. Type (-) to dequeue. Type (Q) to exit to main menu.");
            string input = Console.ReadLine();
            char nav = input[0];
            string value = input.Substring(1);

            switch (nav)
            {
                case '+':
                    theQueue.Enqueue(value);
                    Console.WriteLine($"'{value}' added to the queue.\nThe queue:");
                    Helpers.PrintQueue(theQueue);
                    break;
                case '-':
                    if (theQueue.TryDequeue(out string result))
                    {
                        Console.WriteLine($"'{result}' removed from the queue.\nThe queue:");
                        Helpers.PrintQueue(theQueue);
                    }
                    else
                    {
                        Console.WriteLine("The queue is empty");
                    }
                    break;
                case 'Q':
                case 'q':
                    return;
                default:
                    Console.WriteLine("Invalid input. Type (+) followed by any value to add the value to the queue. Type (-) to dequeue. Type (Q) to exit to main menu.");
                    break;
            }

            ExamineQueue(theQueue);
        }

        /// <summary>
        /// Examines the datastructure Stack
        /// Vi kan lägga till element (push) till stacken och ta bort (pop) element från toppen av stacken. 
        /// </summary>
        static void ExamineStack(Stack<string> theStack = null)
        {
            if (theStack == null)
            {
                theStack = new Stack<string>();
            }

            Console.WriteLine("Type (+) followed by any value to add the value to the stack. Type (-) to pop. Type (Q) to exit to main menu.");
            string input = Console.ReadLine();
            char nav = input[0];
            string value = input.Substring(1);

            switch (nav)
            {
                case '+':
                    theStack.Push(value);
                    Console.WriteLine($"'{value}' added to the stack.\nThe stack:");
                    Helpers.PrintStack(theStack);
                    break;
                case '-':
                    if (theStack.TryPop(out string result))
                    {
                        Console.WriteLine($"'{result}' removed from the stack.\nThe stack:");
                        Helpers.PrintStack(theStack);
                    }
                    else
                    {
                        Console.WriteLine("The stack is empty");
                    }
                    break;
                case 'Q':
                case 'q':
                    return;
                default:
                    Console.WriteLine("Invalid input. Type (+) followed by any value to add the value to the stack. Type (-) to pop. Type (Q) to exit to main menu.");
                    break;
            }

            ExamineStack(theStack);
        }

        // Vänder ordning på användar inmatad text med hjälp av en stack
        static void ReverseText()
        {
            Console.WriteLine("Type a text to be reversed:");
            string input = Console.ReadLine();
            Stack<char> theStack = new Stack<char>();
            // Lägg till varje bokstav till stacken
            foreach (char letter in input)
            {
                theStack.Push(letter);
            }

            string reversedText = "";
            // Metod 1 
            /*  foreach(char letter in theStack) {
                 reversedText += letter;
             } */
            // Metod 2
            while (theStack.TryPeek(out _))
            {
                char letter = theStack.Pop();
                reversedText += letter;
            }
            Console.WriteLine($"Result: {reversedText}");
        }

        /// <summary>
        /// Kollar om användar inmatad text innehåller balanserade paranteser
        /// </summary>
        static void Checkparantheses()
        {
            Console.WriteLine("Type a text with parantheses to validate:");
            string input = Console.ReadLine();

            List<char> parantheses = [];
            // Iterera över input och extrahera alla paranteser till listan ovan
            foreach (char letter in input)
            {
                if (Helpers.IsParanthese(letter))
                {
                    parantheses.Add(letter);
                }
            }

            bool valid = true;
            // Denna stack lagrar alla closing paranteser som stöts på i loopen nedan
            Stack<char> closing = [];
            /* 
            Iterera över alla paranteser i listan och gör checkar på var och en.
            Om vi stötter på en opening parantes t.ex. ( , lägger vi till dens respektive closing parantes till stacken
            Om vi inte stötter på någon opening parantes kollar vi om stacken är tom eller parantesen överst i stacken
            ej är av samma parantes sort. I så fall avbryter vi loopen och retunerar false.
            Om stacken är tom betyder det att det finns en parantes som öppnats men inte stängts.
            Om parantesen övers i stacken ej är av samma sort betyder det att det finns en closing parantes men som inte öppnats.
             */
            foreach (char p in parantheses)
            {
                if (p == '(')
                {
                    closing.Push(')');
                }
                else if (p == '{')
                {
                    closing.Push('}');
                }
                else if (p == '[')
                {
                    closing.Push(']');
                }
                else if (closing.Count == 0 || closing.Pop() != p)
                {
                    valid = false;
                    break;
                }
            }

            Console.WriteLine($"Valid: {valid}");
        }
    }
}

