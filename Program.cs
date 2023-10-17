string[] sample1 = new string[] { "Hello", "2", "world", ":-)" };
sample1.WriteStringArrayExt("Пример 1. Входной массив:");
ArrayHelper.WriteStringArray(ArrayHelper.SelectStringsShorterThan(sample1), "Выходной массив:");
Console.WriteLine();

string[] sample2 = new string[] {"1234", "1567", "-2", "computer science"};
sample2.WriteStringArrayExt("Пример 2. Входной массив:");
ArrayHelper.WriteStringArray(ArrayHelper.SelectStringsShorterThan(sample2), "Выходной массив:");
Console.WriteLine();

string[] sample3 = new string[] { "Russia", "Denmark", "Kazan" };
sample3.WriteStringArrayExt("Пример 3. Входной массив:");
ArrayHelper.WriteStringArray(ArrayHelper.SelectStringsShorterThan(sample3), "Выходной массив:");
Console.WriteLine();

Console.WriteLine("Вы можете проверить, как работает эта программа. Введите количество элементов для заполнения массива:");
int n;
try
{
    n = Convert.ToInt32(Console.ReadLine());   
}
catch
{
    Console.WriteLine("Ошибка ввода. Длина массива принята равной 5.");
    n = 5;
}

if (n<0)
{
    Console.WriteLine($"Вы ввели число {n} меньше нуля. Будет использовано значение 5.");
    n = 5;
}

Console.WriteLine("Введите последовательно строки для заполнения массива. Для ввода нажмите Enter.");
string[] sample4 = new string[n];
for (int i = 0; i < n; i++)
{
    sample4[i] = Console.ReadLine()??"";
}
sample4.WriteStringArrayExt("Пример 4. Входной массив:");
ArrayHelper.WriteStringArray(ArrayHelper.SelectStringsShorterThan(sample4), "Выходной массив:");
Console.WriteLine();

Console.WriteLine("Нажмите любую клавишу для завершения программы.");
Console.ReadKey();