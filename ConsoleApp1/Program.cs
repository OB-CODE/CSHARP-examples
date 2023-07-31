namespace ConsoleApp1
{
    internal class Program
    {
        // by adding public 'Public' to the class, it allows it to be accessed from outside the class.
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            SecondMethod();
            CheckNem(3);
        }

        // defining the second method
        static void SecondMethod()
        {
            Console.WriteLine("This is called in the second method of main");
        }

        public static void CheckNem(int userInput)
        {
            if (userInput % 2 == 0)
            {
                Console.WriteLine("It is an even number");
            }
            else
            {
                Console.WriteLine("It is an odd number");
            }
        }

        //Running a loop


    }
}


