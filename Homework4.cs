namespace Homework4;

class Program
{
    static void Main(string[] args)
    {//code for Q1
        int num1, num2, max_num;

        Console.WriteLine("Please input a number: ");
        num1 = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine("Please enter a second number: ");
        num2 = Convert.ToInt16(Console.ReadLine());

        if (num1 > num2)
        {
            max_num = num1;
        }
        else
        {
            max_num = num2;
        }
        Console.WriteLine($"The largest number is: {max_num}");
    }
    
static void Shape()
    {
        //code for Q2
        PrintShape(5, "left");
    }

    static void PrintShape(int N, string shape)
    {
        if (shape == "left")
        {
            Console.WriteLine("------------------");
            for (int row = 0; row < 5; row++)
            {
                for (int col = 0; col < 5; col++)
                {
                    if (row >= col) // no {} if only one code line
                        Console.Write('*');
                }
                Console.WriteLine("");
            }
        }
        else
        {//source cited: Chat GPT. Accessed 09.22.2025, "shoe me how to make a right-aligned triangle out of the following code:"
            Console.WriteLine("----------");
            for (int row = 0; row < N; row++)
            {
                for (int space = 0; space < N -row - 1; space++) 

                for (int col = 0; col <= row; col++)
                {
                    Console.Write('*');
                }
                Console.WriteLine("");
            }
        }
    }

}
