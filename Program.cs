//Задача 25: Используя определение степени числа, напишите цикл, который принимает на вход два натуральных числа (A и B) и возводит число A в степень B.
void Task25()
{
    int Vivod(string massage)
    {
        Console.WriteLine(massage);
        string number = Console.ReadLine();
        int result = Convert.ToInt32(number);
        return result;
    }
    int Stepen(int number1, int number2)
    {
        int itog = 1;
        for (int i = 1; i <= number2; i++)
        {
            itog = itog * number1;
        }
        return itog;
    }
    int number1 = Vivod("Введите первое натуральное число: ");
    int number2 = Vivod("Введите второе натуральное число: ");
    int res = Stepen(number1, number2);
    Console.WriteLine($"Число {number1} в степени {number2} равно {res}");
}

//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
void Task27()
{
    int Vivod(string massage)
    {
        Console.WriteLine(massage);
        string number = Console.ReadLine();
        int result = Convert.ToInt32(number);
        return result;
    }
    int Dlin(int number)
    {
        int itog = number;
        int len = 0;
        while (itog > 0)
        {
            itog = itog / 10;
            len = len + 1;
        }
        return len;
    }
    int Sum(int len, int number)
    {
        int sum = 0;
        int n = number;
        for (int i = 0; i < len; i++)
        {
            sum = sum + n % 10;
            n = n / 10;
        }
        return sum;
    }
    int number = Vivod("Введите число: ");
    int dlin = Dlin(number);
    int result = Sum(dlin, number);
    Console.WriteLine($"Сумма всех цифр числа {number} равна {result}");
}

//Задача 29: Напишите программу, которая задаёт массив из 8 случайных целых чисел и выводит отсортированный по модулю массив.
void Task29()
{
    Console.Write("Неотсортированный массив: [");

    int size = 8;
    Random rnd = new Random();
    int[] numbers = new int[size];
    int i = 0;
    while (i < size)
    {
        numbers[i] = rnd.Next(-100, 100);
        i = i + 1;
    }
    i = 0;
    while (i < size)
    {
        Console.Write(numbers[i] + " ");
        i = i + 1;
    }
    Console.WriteLine("]");

    Console.Write("Отсортированный массив: [");
    for (int k = 0; k < size - 1; k++)
    {
        int minposition = k;
        for (int j = k + 1; j < size; j++)
        {
            if (numbers[minposition] >= 0 & numbers[j] >= 0)
            {
                if (numbers[j] < numbers[minposition])
                {
                    minposition = j;
                }
            }
            else if (numbers[minposition] < 0 & numbers[j] < 0)
            {
                if ((numbers[j]) * (-1) < (numbers[minposition]) * (-1))
                {
                    minposition = j;
                }
            }
            else if (numbers[minposition] >= 0 & numbers[j] < 0)
            {
                if ((numbers[j]) * (-1) < numbers[minposition])
                {
                    minposition = j;
                }
            }
            else if (numbers[minposition] < 0 & numbers[j] >= 0)
            {
                if (numbers[j]< (numbers[minposition]) * (-1))
                {
                    minposition = j;
                }
            }
        }
        int temporary = numbers[k];
        numbers[k] = numbers[minposition];
        numbers[minposition] = temporary;
        Console.Write(numbers[k] + " ");
    }
    Console.WriteLine("]");
}

// Для выбора программы (Функция):
void Task()
{
    Console.WriteLine("Выберите программу:");
    int number = Convert.ToInt32(Console.ReadLine());
    if (number == 25)
    {
        Task25();
    }
    else if (number == 27)
    {
        Task27();
    }
    else if (number == 29)
    {
        Task29();
    }
    else
    {
        Console.WriteLine("Ошибка (такой программы не существует)");
    }
}

// Для выбора программы:
Console.WriteLine("Выберите программу:");
int number = Convert.ToInt32(Console.ReadLine());
if (number == 25)
{
    Task25();
}
else if (number == 27)
{
    Task27();
}
else if (number == 29)
{
    Task29();
}
else
{
    Console.WriteLine("Ошибка (такой программы не существует)");
}
