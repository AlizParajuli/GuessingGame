
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

    int findIndexInPreviousGuessList = listGuesses.FindIndex(x => x.UserGuessNum == guess);
    if (findIndexInPreviousGuessList != -1)
    {
        Console.WriteLine($"You guessed this number {listGuesses.Count - findIndexInPreviousGuessList} turns ago!");
    }
    listGuesses.Add(new Guess(guess));

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

//If matched 
Console.WriteLine($"You Won! The answer was {randomNum}."); //when numbe is matched