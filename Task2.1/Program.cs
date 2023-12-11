namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //EvenOrNot();
            //Game21();
            //PrimeNumber();
            //Sequence();
            //GuessingGame();
        }


        private static void EvenOrNot()
        {
            int inputNumber;

            Console.WriteLine("Введите любое число");
            inputNumber = int.Parse(Console.ReadLine());
            if (inputNumber % 2 == 1)
            {
                Console.WriteLine("нечетное");
            }
            else
            {
                Console.WriteLine("четное");

            }
        }


        private static void Game21()
        {
            int sumWeight = 0;
            int numberOfCards;
            int iterator = 1;



            Console.WriteLine("Введите число, сколько карт у вас на руках");
            numberOfCards = int.Parse(Console.ReadLine());

            for (int number = numberOfCards; number > 0; number--)
            {
                Console.WriteLine($"Введите номинал {iterator}-й карты ");
                iterator++;
                string playerInput = Console.ReadLine();

                switch (playerInput)
                {
                    case "1":
                        sumWeight += int.Parse(playerInput);
                        break;
                    case "2":
                        sumWeight += int.Parse(playerInput);
                        break;
                    case "3":
                        sumWeight += int.Parse(playerInput);
                        break;
                    case "4":
                        sumWeight += int.Parse(playerInput);
                        break;
                    case "5":
                        sumWeight += int.Parse(playerInput);
                        break;
                    case "6":
                        sumWeight += int.Parse(playerInput);
                        break;
                    case "7":
                        sumWeight += int.Parse(playerInput);
                        break;
                    case "8":
                        sumWeight += int.Parse(playerInput);
                        break;
                    case "9":
                        sumWeight += int.Parse(playerInput);
                        break;
                    case "10":
                        sumWeight += int.Parse(playerInput);
                        break;
                    case "J":
                        sumWeight += 10;
                        break;
                    case "Q":
                        sumWeight += 10;
                        break;
                    case "K":
                        sumWeight += 10;
                        break;
                    case "A":
                        sumWeight += 10;
                        break;
                    default:
                        Console.WriteLine("Вы ввели неверное значение! Давай по новой, Миша!");
                        number++;
                        iterator--;
                        break;
                }

            }
            Console.WriteLine($"Сумма ваших карт = {sumWeight}");
        }


        private static void PrimeNumber()
        {
            Console.WriteLine("Введите любое число. Программа определит - простое оно или нет.");
            var textInput = Console.ReadLine();
            var denominator = 2;

            while (true)
            {
                if (int.TryParse(textInput, out int playerInput))
                {
                    if (playerInput == 1)
                    {
                        Console.WriteLine("Ваше число простое");
                        break;
                    }

                    if (playerInput == denominator)
                    {
                        Console.WriteLine("Ваше число простое");
                        break;
                    }
                    if (playerInput % denominator != 0)
                    {
                        denominator++;
                    }
                    else
                    {
                        Console.WriteLine("Ваше число не простое");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Неправильный инпут");
                    break;
                }

            }
        }


        private static void Sequence()
        {
            int minNumber = int.MaxValue;

            Console.WriteLine("Введите длину последовательности");
            var secLength = int.Parse(Console.ReadLine());
            for (int i = 0; i < secLength; i++)
            {
                Console.WriteLine("Введите число");
                int playerInput = int.Parse(Console.ReadLine());
                if (playerInput < minNumber)
                {
                    minNumber = playerInput;
                }
            }
            Console.WriteLine($"Наименьшее число последовательности: {minNumber}");
        }


        private static void GuessingGame()
        {
            Console.WriteLine("Введите максимальное число, которое может быть загадано");
            Random r = new Random();
            var maxNumber = int.Parse(Console.ReadLine());
            var guessedNumber = r.Next(0, maxNumber + 1);

            while (true)
            {
                Console.WriteLine("Попробуйте отгадать загаданное число!");
                int playerGuess;
                if (int.TryParse(Console.ReadLine(), out playerGuess) == false) break;

                if (playerGuess == null) break;
                else
                {
                    if (playerGuess < guessedNumber)
                    {
                        Console.WriteLine("Берите выше!");
                    }
                    else
                    {
                        if (playerGuess > guessedNumber)
                        {
                            Console.WriteLine("Берите ниже");
                        }
                        else
                        {
                            Console.WriteLine("Урааа, победа!!!");
                            break;
                        }
                    }
                }











            }

        }
    }
}
