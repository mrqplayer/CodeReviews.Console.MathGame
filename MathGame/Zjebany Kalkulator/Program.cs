using System.Diagnostics;

string? name = Name();

List<string> history = new List<string>();

Menu(name);
static string Name()
{
    Console.WriteLine("What's Your name?\n");

    string? name = "";

    while (true)
    {
        name = Console.ReadLine();


        if (!string.IsNullOrWhiteSpace(name) && name.All(char.IsLetter))
        {
            Console.Clear();
            Console.WriteLine($"Welcome {name}! Today is {DateTime.Now:D}\n");
            break;
        }

        Console.WriteLine("Invalid input! You have to insert a name (letters only):");
    }

    return name;
}
void Menu(string)
{
    bool isRunning = true;

    while (isRunning)
    {

        Console.WriteLine("Press any key to continue");
        Console.ReadLine();
        Console.Clear();

        Console.WriteLine("Select Game:\n");

        Console.WriteLine("" +
            "1 - Addition\n" +
            "2 - Subtraction\n" +
            "3 - Multiplication\n" +
            "4 - Division\n" +
            "5 - Random Mode\n" +
            "6 - Game History\n" +
            "7 - Exit Program");

        var gameMode = Console.ReadLine();

        while (string.IsNullOrEmpty(gameMode))
        {
            Console.WriteLine("You have to select a game mode!");
            gameMode = Console.ReadLine();
        }

        switch (gameMode.Trim())
        {
            case "1":
                Console.Clear();
                Addition("Addition");
                break;
            case "2":
                Console.Clear();
                Subtraction("Subtraction");
                break;
            case "3":
                Console.Clear();
                Multiplication("Multiplication");
                break;
            case "4":
                Console.Clear();
                Division("Division");
                break;
            case "5":
                Console.Clear();
                Random randomGame = new Random();
                {
                    int rolledGame = randomGame.Next(1, 5);
                    switch (rolledGame)
                    {
                        case 1:
                            Addition("Addition");
                            break;
                        case 2:
                            Subtraction("Subtraction");
                            break;
                        case 3:
                            Multiplication("Multiplication");
                            break;
                        case 4:
                            Division("Division");
                            break;
                    }
                }
                break;
            case "6":
                Console.Clear();
                gameHistory("Game History");
                break;
            case "7":
                Console.Clear();
                Environment.Exit(0);
                break;

        }
    }
}
void Addition(string)
{
    Console.WriteLine("Selected Addition\n");
    Console.WriteLine("Choose difficulty:\n1 - Easy (1-10)\n2 - Medium (1-50)\n3 - Hard (1-100)");
    string? gameDifficulty = Console.ReadLine();
    int maxNumber = 10;
    string difficultyName = "";
    switch (gameDifficulty)
    {
        case "1":
            Console.WriteLine("Selected Easy Difficulty\n");
            maxNumber = 10;
            difficultyName = "Easy";
            break;
        case "2":
            Console.WriteLine("Selected Medium Difficulty\n");
            maxNumber = 50;
            difficultyName = "Medium";
            break;
        case "3":
            Console.WriteLine("Selected Hard Difficulty\n");
            maxNumber = 100;
            difficultyName = "Hard";
            break;
        default:
            Console.WriteLine("Invalid selection, defaulting to Easy Difficulty\n");
            maxNumber = 10;
            break;
    }

    var stopwatch = Stopwatch.StartNew();

    int points = 0;

    for (int i = 0; i < 5; i++)
    {
        Random random = new Random();

        int FirstNumber = random.Next(1, maxNumber + 1);
        int SecondNumber = random.Next(1, maxNumber + 1);

        Console.WriteLine($"What is {FirstNumber} + {SecondNumber} ?\n");

        string? answer = Console.ReadLine();
        if (answer == (FirstNumber + SecondNumber).ToString())
        {
            Console.WriteLine("Correct Answer!");
            points++;
        }
        else
        {
            Console.WriteLine("Wrong Answer!");
            Console.ReadLine();
        }
        if (i == 4)
        {
            stopwatch.Stop();
            Console.WriteLine($"Game Over! Your Points: {points}");
            Console.WriteLine($"Game Time: {stopwatch.Elapsed.TotalSeconds:F1} seconds");
            history.Add($"Addition: {points}/5 points, Difficulty: {difficultyName} ({DateTime.Now}, time: {stopwatch.Elapsed.TotalSeconds:F1} seconds)");

        }
    }
}
void Subtraction(string)
{
    Console.WriteLine("Selected Subtraction\n");
    Console.WriteLine("Choose difficulty:\n1 - Easy (1-10)\n2 - Medium (1-50)\n3 - Hard (1-100)");
    string? gameDifficulty = Console.ReadLine();
    int maxNumber = 10;
    string difficultyName = "";
    switch (gameDifficulty)
    {
        case "1":
            Console.WriteLine("Selected Easy Difficulty\n");
            maxNumber = 10;
            difficultyName = "Easy";
            break;
        case "2":
            Console.WriteLine("Selected Medium Difficulty\n");
            maxNumber = 50;
            difficultyName = "Medium";
            break;
        case "3":
            Console.WriteLine("Selected Hard Difficulty\n");
            maxNumber = 100;
            difficultyName = "Hard";
            break;
        default:
            Console.WriteLine("Invalid selection, defaulting to Easy Difficulty\n");
            maxNumber = 10;
            difficultyName = "Easy";
            break;
    }

    var stopwatch = Stopwatch.StartNew();

    int points = 0;

    for (int i = 0; i < 5; i++)
    {
        Random random = new Random();

        int FirstNumber = random.Next(1, maxNumber + 1);
        int SecondNumber = random.Next(1, maxNumber + 1);

        if (SecondNumber > FirstNumber)
        {
            int temp = FirstNumber;
            FirstNumber = SecondNumber;
            SecondNumber = temp;
        }

        Console.WriteLine($"What is {FirstNumber} - {SecondNumber} ?\n");

        if (Console.ReadLine() == (FirstNumber - SecondNumber).ToString())
        {
            Console.WriteLine("Correct Answer!");
            points++;
        }
        else
        {
            Console.WriteLine("Wrong Answer!");
            Console.ReadLine();
        }
        if (i == 4)
        {
            stopwatch.Stop();
            Console.WriteLine($"Game Over! Your points: {points}");
            Console.WriteLine($"Game Time: {stopwatch.Elapsed.TotalSeconds:F1} seconds");
            history.Add($"Subtraction: {points}/5 points, Difficulty: {difficultyName} ({DateTime.Now}, time: {stopwatch.Elapsed.TotalSeconds:F1} seconds)");

        }

    }
}
void Multiplication(string)
{
    Console.WriteLine("Selected Multiplication\n");
    Console.WriteLine("Choose difficulty:\n1 - Easy (1-10)\n2 - Medium (1-50)\n3 - Hard (1-100)");
    string? gameDifficulty = Console.ReadLine();
    int maxNumber = 10;
    string difficultyName = "";
    switch (gameDifficulty)
    {
        case "1":
            Console.WriteLine("Selected Easy Difficulty\n");
            maxNumber = 10;
            difficultyName = "Easy";
            break;
        case "2":
            Console.WriteLine("Selected Medium Difficulty\n");
            maxNumber = 50;
            difficultyName = "Medium";
            break;
        case "3":
            Console.WriteLine("Selected Hard Difficulty\n");
            maxNumber = 100;
            difficultyName = "Hard";
            break;
        default:
            Console.WriteLine("Invalid selection, defaulting to Easy Difficulty\n");
            maxNumber = 10;
            difficultyName = "Easy";
            break;
    }


    var stopwatch = Stopwatch.StartNew();

    int points = 0;

    for (int i = 0; i < 5; i++)
    {
        Random random = new Random();

        int FirstNumber = random.Next(1, maxNumber + 1);
        int SecondNumber = random.Next(1, maxNumber + 1);

        Console.WriteLine($"What is {FirstNumber} x {SecondNumber} ?\n");

        if (Console.ReadLine() == (FirstNumber * SecondNumber).ToString())
        {
            Console.WriteLine("Correct Answer!");
            points++;
        }
        else
        {
            Console.WriteLine("Wrong Answer!");
            Console.ReadLine();
        }
        if (i == 4)
        {
            stopwatch.Stop();
            Console.WriteLine($"Game Over! Your points: {points}");
            Console.WriteLine($"Game Time: {stopwatch.Elapsed.TotalSeconds:F1} seconds");
            history.Add($"Multiplication: {points}/5 points, Difficulty: {difficultyName} ({DateTime.Now}, time: {stopwatch.Elapsed.TotalSeconds:F1} seconds)");
        }

    }
}
void Division(string)
{
    Console.WriteLine("Selected Division\n");
    Console.WriteLine("Choose difficulty:\n1 - Easy (1-10)\n2 - Medium (1-50)\n3 - Hard (1-100)");
    string? gameDifficulty = Console.ReadLine();
    int maxNumber = 10;
    string difficultyName = "";
    switch (gameDifficulty)
    {
        case "1":
            Console.WriteLine("Selected Easy Difficulty\n");
            maxNumber = 10;
            difficultyName = "Easy";
            break;
        case "2":
            Console.WriteLine("Selected Medium Difficulty\n");
            maxNumber = 50;
            difficultyName = "Medium";
            break;
        case "3":
            Console.WriteLine("Selected Hard Difficulty\n");
            maxNumber = 100;
            difficultyName = "Hard";
            break;
        default:
            Console.WriteLine("Invalid selection, defaulting to Easy Difficulty\n");
            maxNumber = 10;
            difficultyName = "Easy";
            break;
    }


    var stopwatch = Stopwatch.StartNew();

    int points = 0;
    Random random = new Random();

    for (int i = 0; i < 5; i++)
    {
        int SecondNumber, FirstNumber, score;

        score = random.Next(2, maxNumber + 1);

        int dividerLimit = maxNumber / score;

        if (dividerLimit < 2)
            dividerLimit = 2;

        SecondNumber = random.Next(1, maxNumber + 1);

        FirstNumber = score * SecondNumber;

        Console.WriteLine($"What is {FirstNumber} / {SecondNumber} ?\n");

        if (Console.ReadLine() == score.ToString())
        {
            Console.WriteLine("Correct Answer!");
            points++;
        }
        else
        {
            Console.WriteLine("Wrong Answer!");
            Console.ReadLine();
        }
        if (i == 4)
        {
            stopwatch.Stop();
            Console.WriteLine($"Game Over! Your points: {points}");
            Console.WriteLine($"Game Time: {stopwatch.Elapsed.TotalSeconds:F1} seconds");
            history.Add($"Division: {points}/5 points, Difficulty: {difficultyName} ({DateTime.Now}, time: {stopwatch.Elapsed.TotalSeconds:F1} seconds)");

        }

    }
}
void gameHistory(string)
{
    Console.WriteLine("Selected Game History\n");

    if (history.Count == 0)
    {
        Console.WriteLine("\nNo Saved Games\n");
    }
    else
    {
        foreach (var entry in history)
        {
            Console.WriteLine($"\n{entry}");
        }
    }

    Console.WriteLine("\nPress any button, to return to menu...");
}