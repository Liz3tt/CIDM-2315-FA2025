namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a letter grade: ");
            string grade = Console.ReadLine().ToUpper(); // normalize input

            switch (grade)
            {
                case "A":
                    Console.WriteLine("Letter Grade: A");
                    break;
                case "B":
                    Console.WriteLine("Letter Grade: B");
                    break;
                case "C":
                    Console.WriteLine("Letter Grade: C");
                    break;
                case "D":
                    Console.WriteLine("Letter Grade: D");
                    break;
                case "F":
                    Console.WriteLine("Letter Grade: F");
                    break;
                default:
                    Console.WriteLine("Wrong Letter Grade!");
                    break;
            }
        }
    }
}

