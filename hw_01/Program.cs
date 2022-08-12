void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine("Введите количество  подсчитываемых чисел: ");
int amount = int.Parse(Console.ReadLine());
int[] userNumbers = new int[amount];
int count = 0;
for (int i = 0; i < userNumbers.Length; i++)
{
    Console.WriteLine("Введите число:");
    userNumbers[i] = int.Parse(Console.ReadLine());
    if ( userNumbers[i] > 0 )
    {
        count++;
    }
}

Console.WriteLine("Вы ввели числа: ");
ShowArray(userNumbers);
Console.WriteLine("Из них положительных - " + count);

