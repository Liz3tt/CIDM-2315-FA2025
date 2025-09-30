     namespace Homework5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Source cited: Microsoft Copilot. Accessed 09/28/2025. "Show me examples of code with the following instructions:"
            // Q1_method
            Console.Write("Enter integer a: ");
            int a = Convert.ToInt16(Console.ReadLine());

            Console.Write("Enter integer b: ");
            int b = Convert.ToInt16(Console.ReadLine());

            int max_num = (a > b) ? a : b;
            Console.WriteLine($"The biggest value is: {max_num}");

            // Q2_method
            Console.Write("Enter integer a2: ");
            int a2 = Convert.ToInt16(Console.ReadLine());

            Console.Write("Enter integer b2: ");
            int b2 = Convert.ToInt16(Console.ReadLine());

            Console.Write("Enter integer c2: ");
            int c2 = Convert.ToInt16(Console.ReadLine());

            Console.Write("Enter integer d2: ");
            int d2 = Convert.ToInt16(Console.ReadLine());

            compare(a2, b2, c2, d2); // Call Q2_method

            // Q3_method
            account(); // Call Q3_method
        }

        static void compare(int a2, int b2, int c2, int d2)
        {
            int max1 = (a2 > b2) ? a2 : b2;
            int max2 = (c2 > d2) ? c2 : d2;
            int max = (max1 > max2) ? max1 : max2;

            Console.WriteLine("The largest number is: " + max);
        }

        static void account()
        {
            createAccount();
        }

        static bool checkAge(int birth_year)
        {
            int current_year = DateTime.Now.Year;
            int age = current_year - birth_year;
            return age >= 18;
        }

        static void createAccount()
        {
            Console.Write("Enter username: ");
            string username = Console.ReadLine();

            Console.Write("Enter password: ");
            string password1 = Console.ReadLine();

            Console.Write("Confirm password: ");
            string password2 = Console.ReadLine();

            Console.Write("Enter your birth year: ");
            int birthYear = Convert.ToInt16(Console.ReadLine());

            if (checkAge(birthYear))
            {
                if (password1 == password2)
                {
                    Console.WriteLine("Account is created successfully.");
                }
                else
                {
                    Console.WriteLine("Wrong password. Passwords do not match.");
                }
            }
            else
            {
                Console.WriteLine("Could not create an account. You must be at least 18 years old.");
            }
        }
    }
}


    

          


