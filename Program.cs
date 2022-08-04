// Console.ReadLine() - получение данных с терминала
// Convert.ToInt32() - из строки в число
// Console.WriteLine() - вывод текста на экран
// Переменные Тип (int, floar, string, bool, double)


// int num1 = Convert.ToInt32(Console.ReadLine());
// int num2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(num1 + num2);

int secretNumber = 7;
int popytki = 3;
bool FlagWin = false;
while (popytki > 0)
{
    Console.WriteLine("введите от 1 до 10");
    int userNumber = Convert.ToInt32(Console.ReadLine());
    popytki--;
    if (userNumber > secretNumber)
    {
        Console.WriteLine("секрет меньше");
        Console.WriteLine("Попыток " + popytki);
    }
    else if (userNumber < secretNumber)
    {
        Console.WriteLine("секретное число борльше");
        Console.WriteLine("Попыток " + popytki);
    }
    else
    {
        Console.WriteLine("Угадал");
        FlagWin = true;
        break;
    }
}
if (!FlagWin)
{
    Console.WriteLine("Проиграл. Число" + secretNumber);
}