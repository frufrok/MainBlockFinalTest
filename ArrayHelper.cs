public static class ArrayHelper
{
    /// <summary>
    /// Возвращает массив строк, образованный выбором из исходного массива строк только тех, что короче заданного количества символов.
    /// </summary>
    /// <param name="array">Исходный массив строк.</param>
    /// <param name="maxChars">Максимальное количество символов в строке.</param>
    /// <returns></returns>
    public static string[] SelectStringsNoLongerThan(string[] array, int maxChars = 3)
    {
        int count = array.Length;
        string[] result = new string[count];
        int k = 0;
        for (int i = 0; i < count; i++)
        {
            if (array[i].Length <= maxChars)
            {
                result[k] = array[i];
                k++;
            }
        }
        Array.Resize(ref result, k);
        return result;
    }
    /// <summary>
    /// Возвращает строку, образованную объединением элементов массива строк, разделенных набором символов. Результат заключен в квадратные скобки.
    /// </summary>
    /// <param name="array">Массив строк для объединения.</param>
    /// <param name="separator">Набор символов для разделения элементов массива в результирующей строке.</param>
    /// <returns></returns>
    public static string JoinString(this string[] array, string separator = ", ")
    {
        return $"[{String.Join(separator, array)}]";
    }
    /// <summary>
    /// Записывает массив строк в консоль.
    /// </summary>
    /// <param name="array">Массив строк для записи.</param>
    /// <param name="message">Сообщение перед выводом массива.</param>
    public static void WriteStringArray(string[] array, string message = "")
    {
        if (message != "") Console.WriteLine(message);
        Console.WriteLine(array.JoinString());
    }
    /// <summary>
    /// Метод расширения. Записывает массив строк в консоль.
    /// </summary>
    /// <param name="array">Массив строк для записи.</param>
    /// <param name="message">Сообщение перед выводом массива.</param>
    public static void WriteStringArrayExt(this string[] array, string message = "")
    {
        WriteStringArray(array, message);
    }
}