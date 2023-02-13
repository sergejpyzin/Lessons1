// Найти максимум из девяти целых чисел

// Создаем метод Max
int Max (int agr1, int agr2, int agr3)
{
    int result = agr1;

    if (agr2 > result) result = agr2;
    if (agr3 > result) result = agr3;
    return result;
}

// Запрашиваем информацию у пользователя
System.Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите четвертое число: ");
int d = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите пятое число: ");
int e = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите шестое число: ");
int f = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите седьмое число: ");
int g = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите восьмое число: ");
int h = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите девятое число: ");
int i = Convert.ToInt32(Console.ReadLine());

// Выполняем условия задачи
int max1 = Max (a, b, c);
int max2 = Max (d, e, f);
int max3 = Max (g, h, i);

int max = Max (max1, max2, max3);

// Выводим результат
System.Console.WriteLine("Максимальное число " + max);
