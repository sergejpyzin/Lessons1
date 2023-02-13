// Определить максимум из девяти введенных пользователем чисел

// Создаем метод Max
int Max (int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
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
int max = Max (
    Max (a, b, c),
    Max (d, e, f),
    Max (g, h, i)
);

// Выводим результат
System.Console.WriteLine(max);
