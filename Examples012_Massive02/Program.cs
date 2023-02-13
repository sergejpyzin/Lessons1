// Найти максимум из массива девяти рандомных чисел

// Создаем метод Мах
int Max (int num1, int num2, int num3)
{
    int result = num1;
    if (num2 > result) result = num2;
    if (num3 > result) result = num3;
    return result;
};

// Создаем массив девяти случайных чисел
int [] array = new int [9];

for (int i = 0; i < array.Length; i++)
{
    array [i] = new Random ().Next (1, 10);
    System.Console.WriteLine(array [i]);
}

// Выполняем условие задачи
int max = Max 
(
    Max (array [0], array [1], array [2]),
    Max (array [3], array [4], array [5]),
    Max (array [6], array [7], array [8])
);

// Выводим результат
System.Console.WriteLine("");
System.Console.WriteLine(max);
