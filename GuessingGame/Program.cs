
using GuessingGame;

Random random = new Random();
int randomNum = random.Next(1, 101);

List<Guess> listGuesses = new List<Guess>();

int guess = 0;

do
{
    Console.Write("Guess a number: ");
    string userInput = Console.ReadLine();

    if (!int.TryParse(userInput, out guess))
    {
        Console.WriteLine("Please choose a valid number.");
        continue;
    }

    if (guess > randomNum)
    {
        Console.WriteLine("Your guess is higher");
    }
    else if (guess < randomNum)
    {
        Console.WriteLine("Your guess is lower");
    }


}
while (guess != randomNum);
