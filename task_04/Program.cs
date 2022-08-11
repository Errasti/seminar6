int[] array = {1,2,3,4,5};
int[] copyArray = GetCopy(array);

Console.WriteLine("\n Копия массива: {0} ", String.Join(" ", GetCopy(array)));
Console.WriteLine();

int[] GetCopy(int[] array)
{
    int[] copy = new int[array.Length];

    for (int i = 0; i < array.Length; i++ )
    {
        copy[i] = array[i];
    }
    
    return copy;
}

