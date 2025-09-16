namespace Homework3;

class Program
{
    static void Main(string[] args)
    {
        //code for Q1
        //source cited: ChatGPT. Accessed 09.15.2025 "show me an ecample of a loop for the following instructions:"
        Console.Write("Input an integer");
        int N = Convert.ToInt32(Console.ReadLine());
        bool isPrime = true;
        if (N <= 1)
        {
            isPrime = false; //0, 1, and negatives are not prime

        }
        else
        {
            //checks if divisible by 2 or N-1
            for (int i = 2; i < N; i++)
            {
                if (N % i == 0)
                {
                    isPrime = false;
                    break;
                }
                if (isPrime)
                {
                    Console.WriteLine("is prime");

                }
                else
                {
                    Console.WriteLine("is non-prime");
                }
            }
        }
        //code for Q2
        for (int row = 0; row < 5; row++)
        {
            for (int col = 0; col < 5; col++)
            {
                Console.Write('#');
            }
            Console.WriteLine("");
        }
        //code for bonus question
        //Source cited: ChatGPT. accessed 09.15.2025 "Show me hoe to fix the death loop in the following code"

        int n = 5; // number of rows

        for (int row = 0; row < n; row++)
        {
            // print spaces first
            for (int space = 0; space < n - row - 1; space++)
            {
                Console.Write(" ");
            }

            // then print stars
            for (int star = 0; star <= row; star++)
            {
                Console.Write("*");
            }

            Console.WriteLine(); // move to next line
        }
    }
}

    

