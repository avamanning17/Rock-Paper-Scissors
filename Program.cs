  namespace Rock_Paper_Scissors
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random generator = new Random();

            int rock, paper, scissors, bank, bet,computerChoice, playAgin;
            string userChoice;
            rock = 1;
            paper = 2;
            scissors = 3;
            bank = 100;

            while (!done)
            {
                if (bank == 0)
                {
                    Console.WriteLine("Game over, you ran out of money.");
                }
                Console.WriteLine("Would you like to Play rock, paper, scissors?");
                int.TryParse(Console.ReadLine(), out playAgin);
                if (playAgin == "No")
                {
                    Console.WriteLine("Good Bye");
                }
                Console.WriteLine("Please choose: rock paper or scissors");
            userChoice = Console.ReadLine();
            Console.WriteLine("What is your bet? You have " + bank);
            int.TryParse(Console.ReadLine(), out bet);

            computerChoice = generator.Next(1, 4);
            Console.WriteLine(computerChoice);


                if (userChoice == "rock" && computerChoice == paper)
                {
                    Console.WriteLine("Sorry you lose! Paper beats rock.");
                    bank -= bet;
                }
                if (userChoice == "paper" && computerChoice == rock)
                {
                    Console.WriteLine("Yay You win! rock beats paper.");
                    bank += bet;
                }
                if (userChoice == "scissors" && computerChoice == rock)
                {
                    Console.WriteLine("Sorry you lose! rock beats scissors.");
                    bank -= bet;
                }
                if (userChoice == "rock" && computerChoice == scissors)
                {
                    Console.WriteLine("Yay You win! rock beats scissors.");
                    bank += bet;
                }
                if (userChoice == "paper" && computerChoice == scissors)
                {
                    Console.WriteLine("Sorry you lose! scissors beats paper.");
                    bank -= bet;
                }
                if (userChoice == "scissors" && computerChoice == paper)
                {
                    Console.WriteLine("Yay You win! scissors beats paper.");
                    bank += bet;
                }
                if (userChoice == "scissors" && computerChoice == scissors)
                {
                    Console.WriteLine("It was a tie! play again.");
                }
                if (userChoice == "paper" && computerChoice == paper)
                {
                    Console.WriteLine("It was a tie! play again.");
                }
                if (userChoice == "rock" && computerChoice == rock)
                {
                    Console.WriteLine("It was a tie! play again.");
                }
            }
        }
    }
}
