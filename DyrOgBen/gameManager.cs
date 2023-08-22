namespace DyrOgBen;

public class GameManager
{
    private List<Animal> _animals;
    private Animal _currentAnimal;
    private int _guess;
    private bool _gameActive;

    private enum UserAnswer
    {
        Yes,
        No
    };

    public GameManager()
    {
        _animals = new List<Animal>();
        
        _animals.Add(new Animal("Donkey", 4, "Commonly used for carrying heavy loads. "));
        _animals.Add(new Animal("Hawk", 2, "A bird of prey knows for its keen eyesight. "));
        _animals.Add(new Animal("Spider", 8, "Spins something to catch it's prey"));
        _animals.Add(new Animal("Centipede", 10000, "Has many legs, but not as the name suggests"));
        _animals.Add(new Animal("Ant", 6, "Known for its strong work etchic and teamwork"));
        _animals.Add(new Animal("Elephant", 4, "Known for its large size and long trunk."));
        _animals.Add(new Animal("Giraffe", 4, "Has a long neck and spots on its body."));
        _animals.Add(new Animal("Dolphin", 0, "A marine mammal known for its intelligence and playful behavior."));
        _animals.Add(new Animal("Lion", 4, "A big cat known as the 'king of the jungle.'"));
        _animals.Add(new Animal("Crocodile", 4, "A reptile with a long snout and sharp teeth."));
        
        _currentAnimal = GetRandomAnimal();
        _guess = Guess();
        //_userAnswer = TryAgain();
    }
    
    // A simple method to show the whole list if needed
    public void ShowList()
    {
        foreach (var animal in _animals)
        {
            Console.WriteLine("Name: " + animal.name);
            Console.WriteLine("Number of legs: " + animal.numberOfLegs);
            Console.WriteLine("");
        }
    }
    
    // Used to retrieve a random Animal object from the animals List
    public Animal GetRandomAnimal()
    {
        var random = new Random();
        int index = random.Next(_animals.Count);

        Animal randomAnimal = _animals[index];
        
        // Console.WriteLine("Random animal: " + randomAnimal.name);
        // Console.WriteLine("Number of legs: " + randomAnimal.numberOfLegs);
        //Console.WriteLine();

        return randomAnimal;
    }
    // A simple method used to replace all letters in the name for " * " 
    public string BlurAnimalName()
    {
        _currentAnimal = GetRandomAnimal();
        string nameToBlur = _currentAnimal.name;
        string blurredName = "";
        
        foreach (char c in nameToBlur)
        {
            if (char.IsLetter(c))
            {
                blurredName += "*";
            }
            else
            {
                blurredName += c;
            }
        }

        return blurredName;
    }
    
    // Method that returns the guess from the user as an Integer
    public int Guess()
    {
        string? input = Console.ReadLine();
        int guess;

        if (int.TryParse(input, out guess))
        {
            Console.WriteLine("You guessed: " + guess);
        }
        else
        {
            Console.WriteLine("How many legs do you think this animal has? ");
            // This might need another solution, like a throw-exception. 
            return -1;
        }
        
        return guess;
    }

    // Used to check if the guess corresponds to the current animal that was randomly retrieved
    public bool CheckIfCorrect(int guess)
    {
        if (guess == _currentAnimal.numberOfLegs)
        {
            return true;
        }
        return false;
    }

    public bool TryAgain()
    {
        Console.WriteLine("Try again? Please write: Yes or No");
        string? answer = Console.ReadLine()?.ToLower();
        
        if (answer == UserAnswer.Yes.ToString().ToLower())
        {
            return true;
        }

        if (answer == UserAnswer.No.ToString().ToLower())
        {
            return false;
        }

        Console.WriteLine("Incorrect input");
        return false;
    }
    // Bigger method where i pack the game logic and use the other methods
    public void StartGame()
    {
        Console.WriteLine("Guess the number of legs: ");
        _gameActive = true;
        
        while (_gameActive)
        {
            Console.WriteLine(BlurAnimalName());
            Console.WriteLine(_currentAnimal.hint);
            
            int guess = Guess();
            bool isCorrect = CheckIfCorrect(guess);

            if (isCorrect)
            {
                Console.WriteLine("Correct! The animal was: " + _currentAnimal.name);
                bool userAnswer = TryAgain();
                if (userAnswer)
                {
                    Console.WriteLine("Starting a new game..");
                    // StartGame();
                    // To save memory it's better to reset the
                    // state these objects to their initial values instead of creating a new instance
                    // of gameManager.
                    _currentAnimal = GetRandomAnimal();
                    _guess = Guess();
                }
                else
                {
                    Console.WriteLine("Closing program..");
                    _gameActive = false;
                    //Environment.Exit(0);
                }
            }
            else
            {
                Console.WriteLine("Wrong guess, please try again.");
                _gameActive = true;
            }
        }
    }
}