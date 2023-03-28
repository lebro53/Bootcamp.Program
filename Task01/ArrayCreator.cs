/// <summary>
/// Этот класс отвеающий за создание массива
/// </summary>
public static class ArrayCreator
{
	/// <summary>
	/// Метод создания массива
	/// </summary>
	/// <param name="n">Количество элементов</param>
	/// <returns>Новый массив</returns>
	public static int[] Create(this int n)
	{
		return new int[n];
	}
	/// <summary>
	/// Метод который лепит массив в строку
	/// </summary>
	/// <param name="array">Массив</param>
	/// <returns>Строка с представлением массива</returns>
	public static string COnvertToString(this int[] array)
	{
		string str = $"[{String.Join(',', array)}]";
		Console.WriteLine(str);
		return str;
	}
	/// <summary>
	/// Зфполняем массив
	/// </summary>
	/// <param name="array">Массив</param>
	/// <param name="min">Нижняя граница диапазона генератора случайных чисел</param>
	/// <param name="max">Верхняя граница диапазона генератора случайных чисел</param>
	public static int[] Fill(this int[] array, int min = 0, int max = 10, int seed = 0)
	{
		Random random = seed == 0 ? new Random() : new Random(seed);
		return array.Select(item => random.Next(min, max)).ToArray();
	}
}