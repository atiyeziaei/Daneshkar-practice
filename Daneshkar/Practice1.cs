using System;

class Program
{
	static void Main()
	{
		while (true)
		{
			Console.WriteLine("\nSelect an exercise:");
			Console.WriteLine("1. Variables & Constants");
			Console.WriteLine("2. Type Conversion & Input");
			Console.WriteLine("3. Number Guessing Game");
			Console.WriteLine("4. Word Guessing Game");
			Console.WriteLine("5. Sum of Odd Numbers");
			Console.WriteLine("6. Exit");

			Console.Write("Enter choice: ");
			string choice = Console.ReadLine();

			switch (choice)
			{
				case "1":
					Exercise1();
					break;
				case "2":
					Exercise2();
					break;
				case "3":
					Exercise3();
					break;
				case "4":
					Exercise4();
					break;
				case "5":
					Exercise5();
					break;
				case "6":
					return; 
				default:
					Console.WriteLine("Invalid choice. Try again.");
					break;
			}
		}
	}

	static void Exercise1()
	{
		const string MessageWellcome = "#C to Wellcome";
		int age = 25;
		Console.WriteLine(MessageWellcome);
		Console.WriteLine("Age: " + age);
	}

	static void Exercise2()
	{
		Console.Write("Enter your name: ");
		string name = Console.ReadLine();

		Console.Write("Enter your age: ");
		int age = Convert.ToInt32(Console.ReadLine());

		Console.WriteLine($"Hello, {name}. You are {age} years old.");
	}

	static void Exercise3()
	{
		int secretNumber = 7;
		int attempts = 0;
		bool isCorrect = false;

		Console.WriteLine("Guess the secret number between 1 and 10:");

		while (!isCorrect && attempts < 5)
		{
			attempts++;
			Console.Write("Enter your guess: ");
			int guess = Convert.ToInt32(Console.ReadLine());

			if (guess == secretNumber)
			{
				isCorrect = true;
				Console.WriteLine("Congratulations! You guessed the correct number.");
			}
			else
			{
				Console.WriteLine("Wrong guess, try again.");
			}
		}

		if (!isCorrect)
		{
			Console.WriteLine($"Sorry! You've used all 5 attempts. The correct number was {secretNumber}.");
		}
	}

	static void Exercise4()
	{
		string secretWord = "CSharp";
		int attempts = 0;
		string userGuess;

		Console.WriteLine("Guess the secret word:");

		while (true)
		{
			attempts++;
			Console.Write("Enter your guess: ");
			userGuess = Console.ReadLine();

			if (userGuess.Equals(secretWord, StringComparison.OrdinalIgnoreCase))
			{
				Console.WriteLine("Congratulations! You guessed the word correctly.");
				break;
			}
			else
			{
				Console.WriteLine("Wrong guess, try again.");
			}
		}

		Console.WriteLine($"You guessed the word in {attempts} attempts.");
	}

	static void Exercise5()
	{
		int n;

		while (true)
		{
			Console.Write("Enter a positive integer: ");
			string input = Console.ReadLine();

			if (int.TryParse(input, out n) && n > 0)
			{
				break;
			}
			else
			{
				Console.WriteLine("Invalid input, please enter a positive number.");
			}
		}

		int sum = 0;
		for (int i = 1; i <= n; i++)
		{
			if (i % 2 != 0)
			{
				sum += i;
			}
		}

		Console.WriteLine($"The sum of odd numbers from 1 to {n} is: {sum}");
	}
}
