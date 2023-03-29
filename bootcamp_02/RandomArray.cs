
///<summary>
///Создание массива
///</summary>

public static class RandomArray
{
    ///<summary>
    ///Метод создание массива
    ///</summary>
    ///<param name="n">Количество элементов</param>
    ///<returns>Новый массив</returns>

    public static int[] Create(this int n)
    {
        return new int[n];
    }

    ///<summary>
    ///Метод печати массива
    ///</summary>
    ///<param name="array">Массив</param>
    ///<returns>печатает массив в консоле</returns>
    public static string ConvertToStringAndPrintToTerminal(this int[] array)
    {
        string str = $"[{String.Join(':', array)}]";
        Console.WriteLine(str);
        return str;
    }

    ///<summary>
    ///Ранломное заполнение массива
    ///</summary>
    ///<param name="array">Массив</param>
    ///<param name="min">Минимальное значение</param>
    ///<param name="max">Максимальное значение</param>
    public static int[] Fill(this int[] array, int min = 0, int max = 10, int seed = 0)
    {
        Random random = seed == 0? new Random() : new Random(seed);
        return array.Select(item => Random.Shared.Next(min, max)).ToArray();
    }
}
