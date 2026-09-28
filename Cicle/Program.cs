//Console.WriteLine("Введите время!");
//Console.WriteLine("Введите от 0 до 23");

//int hour = Convert.ToInt32(Console.ReadLine());

//if (hour >= 6 && hour < 12)
//{
//    Console.WriteLine("Доброе утро!");
//}
//else if (hour >= 12 && hour < 18)
//{
//    Console.WriteLine("Добрый день!");
//}
//else if (hour >= 18 && hour <= 23)
//{
//    Console.WriteLine("Добрый вечер!");
//}
//else if (hour >= 23 && hour == 0)
//{
//    Console.WriteLine("Доброй ночи!");
//}
//else if (hour >= 1 && hour < 6)
//{
//    Console.WriteLine("Доброй ночи!");
//}
//else if (hour == 24)
//{
//    Console.WriteLine("Полночь!");
//}
//else
//{
//    Console.WriteLine("Неправильное число!");
//}

//Console.WriteLine("Введите команду");
//Console.WriteLine("1.Вход в игру!");
//Console.WriteLine("2.Загрузить игру!");
//Console.WriteLine("3.Выход из игры!");
//string choce = Console.ReadLine();

//switch(choce)
//{
//      case "1":
//          Console.WriteLine("Выполнен вход в игру!");
//          break;
//      case "2":
//          Console.WriteLine("Загрузка игры!...");
//          break;
//      case "3":
//        Console.WriteLine("Выход из игры!");
//        break;
//      default: Console.WriteLine("Введите значение от 1 до 3");
//        break;
//}

//for (int i = 3;  i <= 33; i++)
//{
//    Console.WriteLine($"Текущее значение  {i}");
//}
//Console.ReadLine();

//for (int i = 1; i <= 10; i++)
//{
//    if (i % 2 == 0) //Если число чётное
//    {
//        continue; //Пропускаем остаток тела
//    }
//    Console.WriteLine(i);
//}

//Console.WriteLine();

//for (int y = 1; y <= 10; y++)
//{
//    if (y % 3 == 0) //Если число не чётное
//    {
//        continue; //Пропускаем остаток тела
//    }
//    Console.WriteLine(y);
//}

//Console.WriteLine();

//for (int z = 10; z > 0; z--)
//{
//    Console.WriteLine(z);
//}

//for (int i = 1; i < 10; i++)
//{
//    for (int j = 1; j < 10; j++)
//    {
//        Console.Write($"{i * j}\t");
//    }
//    Console.WriteLine();
//}

//Random random = new Random();
//int secretNumber = random.Next(1,100);

//int userGuess = 0;
//int atters = 0;

//Console.WriteLine("Я загодал число от 0 до 100! Попробуй отгадай!");

//while (userGuess != secretNumber)
//{
//    Console.WriteLine("Ваша догадка!");
//    userGuess = Convert.ToInt32(Console.ReadLine());
//    atters++;

//    if (userGuess < secretNumber)
//    {
//        Console.WriteLine("Загаданное число больше!");
//    }
//    else if (userGuess > secretNumber)
//    {
//        Console.WriteLine("Загаданное число меньше!");
//    }
//}
//Console.WriteLine($"Поздравляю, вы отгадали число {secretNumber}");
//Console.WriteLine("Конец программы!");
//Console.ReadLine();
