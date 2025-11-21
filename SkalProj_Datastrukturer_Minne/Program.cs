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
        /// </summary>
        public static void ExamineList()
        { 
        /*
         * Loop this method untill the user inputs something to exit to main menue.
         * Create a switch statement with cases '+' and '-'
         * '+': Add the rest of the input to the list (The user could write +Adam and "Adam" would be added to the list)
         * '-': Remove the rest of the input from the list (The user could write -Adam and "Adam" would be removed from the list)
         * In both cases, look at the count and capacity of the list
         * As a default case, tell them to use only + or -
         * Below you can see some inspirational code to begin working.
        */

        //List<string> theList = new List<string>();
        //string input = Console.ReadLine();
        //char nav = input[0];
        //string value = input.substring(1);

        //switch(nav){...}

        /* 
         * 1. Skriv klart implementationen av ExamineList-metoden så att undersökningen blir genomförbar.
        */

            List<string> theList = new List<string>();

            while (true)
            {
                Console.Write("Input (+Name / -Name / exit): ");
                string input = Console.ReadLine();

                if (input == null)
                    continue;

                if (input.ToLower() == "exit")
                    break;

                if (input.Length < 2)
                {
                    Console.WriteLine("Please use +Name or -Name");
                    continue;
                }

                char nav = input[0];        // + or -
                string value = input.Substring(1);   // name

                switch (nav)
                {
                    case '+':
                        theList.Add(value);
                        Console.WriteLine($"Added \"{value}\"");
                        Console.WriteLine($"Count = {theList.Count}, Capacity = {theList.Capacity}");
                        break;

                    case '-':
                        if (theList.Remove(value))
                        {
                            Console.WriteLine($"Removed \"{value}\"");
                        }
                        else
                        {
                            Console.WriteLine($"\"{value}\" not found");
                        }
                        Console.WriteLine($"Count = {theList.Count}, Capacity = {theList.Capacity}");
                        break;

                    default:
                        Console.WriteLine("Use only + or -");
                        break;
                }
            }
       

            //
            /*
             * 2. När ökar listans kapacitet? (Alltså den underliggande arrayens storlek)
             * 
             * Capacity ökar bara när du lägger till ett nytt element och Count blir större än den aktuella kapaciteten.
             * Sedan skapar List en ny, större intern array och kopierar elementen till den.
             * 
             * 3. Med hur mycket ökar kapaciteten?
             * 
             * Först, Capacity = 0 sedan 4, 8, 16, 32, 64, …
             * 
             * 4. Varför ökar inte listans kapacitet i samma takt som element läggs till?
             * 
             * Om varje Add-operation utökade listan med exakt ett element, då:
             * Varje Add → allokera en ny array + kopiera alla element
             * Detta skulle vara mycket långsamt och minneskrävande
             * 
             * Så de gör det på följande sätt:
             * de gör ett "stort hopp" i storlek
             * Detta gör att många efterföljande Add-operationer kan utföras utan att omallokera minne
             * Detta uppnår amorterad O(1)-komplexitet för addition.
             * 
             * 5. Minskar kapaciteten när element tas bort ur listan?
             * 
             * Nej, det minskar inte automatiskt.
             * Count    minskar, men Capacity förblir densamma.
             * Men du kan använda list.TrimExcess(), eller explicit ange list.Capacity = list.Count;
             * 
             * 6. När är det då fördelaktigt att använda en egendefinierad array istället för en lista?
             * 
             * Storleken är känd i förväg och inte ändras
             * Prestanda/minne är avgörande
             * Arrayen har något mindre minne
             * Det inte finns någon onödig logik för kapacitetsutbyggnad
             * En flerdimensionell array eller speciell indexåtkomst behövs
             * Du arbetar med en stor mängd data.
             */

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

