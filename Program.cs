  namespace Rock_Paper_Scissors
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random generator = new Random();

            int rock, paper, scissors, bank, bet,computerChoice;
            string userChoice;
            rock = 1;
            paper = 2;
            scissors = 3;

            
            Console.WriteLine("Please choose: rock paper or scissors");
            userChoice = Console.ReadLine();

            computerChoice = generator.Next(1, 4);

            if (userChoice == "rock" && computerChoice == paper)
            {
                Console.WriteLine("Sorry you lose! Paper beats rock.");
            }
            if (userChoice == "paper" && computerChoice == rock)
            {
                Console.WriteLine("Yay You win! rock beats paper.");
            }
            if (userChoice == "scissors" && computerChoice == rock)
            {
                Console.WriteLine("Sorry you lose! rock beats scissors.");
            }
            if (userChoice ==" rock "&& computerChoice == scissors)
            {
                Console.WriteLine("Yay You win! rock beats scissors.");
            }
            if (userChoice == "paper" && computerChoice == scissors)
            {
                Console.WriteLine("Sorry you lose! scissors beats paper.");
            }
            if (userChoice == "scissors" && computerChoice == paper)
            {
                Console.WriteLine("Yay You win! scissors beats paper.");
            }
        }
    }
}
