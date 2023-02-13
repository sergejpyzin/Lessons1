// Создать массив из введенных пользователем n чисел

// Запрашиваем размер массива у пользователя
System.Console.Write("Введите число (размер создаваемого массива): ");
int index = Convert.ToInt32(Console.ReadLine());

// Создаем массив
int [] array = new int [index];

for (int i = 0; i < array.Length; i++)
{
    System.Console.Write("Введите " + i + " элемент массива ");
    int elem = Convert.ToInt32(Console.ReadLine());
    array [i] = elem;
}

// Выводим массив
System.Console.WriteLine("");

for (int j = 0; j < array.Length; j++)
{
    System.Console.WriteLine(array [j]);
}