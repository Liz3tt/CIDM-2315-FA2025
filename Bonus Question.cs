namespace BonusQuestion;
class HumanPlayer
{
    //Source cited: Microsoft copilot. Accessed 10/27/2025. "Show me how to fix my RockPaperScissors class"
    private int points;

    public HumanPlayer(int initial)
    {
        points = initial;
    }

    public int GetPoints()
    {
        return points;
    }

    public void WinRound()
    {
        points += 5;
    }

    public void LoseRound()
    {
        points -= 5;
    }

    public string HumanDecision()
    {
        Console.Write("Choose Rock, Paper, or Scissors: ");
        string choice = Console.ReadLine().Trim().ToLower();
        while (choice != "rock" && choice != "paper" && choice != "scissors")
        {
            Console.Write("Invalid input. Choose Rock, Paper, or Scissors: ");
            choice = Console.ReadLine().Trim().ToLower();
        }
        return choice;
    }
}

class ComputerPlayer
{
    private static readonly string[] choices = { "rock", "paper", "scissors" };
    private Random rand = new Random();

    public string ComputerDecision()
    {
        int index = rand.Next(choices.Length);
        return choices[index];
    }
    class RockPaperScissors
    {
        static void Main(string[] args)
        {
            HumanPlayer human = new HumanPlayer(5);
            ComputerPlayer computer = new ComputerPlayer();

            while (human.GetPoints() > 0)
            {
                Console.WriteLine($"\nYour current points: {human.GetPoints()}");

                string humanChoice = human.HumanDecision();
                string computerChoice = computer.ComputerDecision();

                Console.WriteLine($"Computer chose: {computerChoice}");

                if (humanChoice == computerChoice)
                {
                    Console.WriteLine("It's a tie. No points gained or lost.");
                }
                else if (
                    (humanChoice == "rock" && computerChoice == "scissors") ||
                    (humanChoice == "paper" && computerChoice == "rock") ||
                    (humanChoice == "scissors" && computerChoice == "paper"))
                {
                    Console.WriteLine("You win this round!");
                    human.WinRound();
                }
                else
                {
                    Console.WriteLine("You lose this round.");
                    human.LoseRound();
                }

                if (human.GetPoints() <= 0)
                {
                    Console.WriteLine("Game over. You have 0 points.");
                    break;
                }

                Console.Write("Do you want to play another round? (yes/no): ");
                string response = Console.ReadLine().Trim().ToLower();
                if (response != "yes")
                {
                    Console.WriteLine("Thanks for playing!");
                    break;
                }
            }
        }
    }
}