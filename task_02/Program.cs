int[] array = {1,2,3,4,5};
int tmp = 0;
for (int i = 0, j = array.Length - 1; i < array.Length / 2; i++,j--)
{
    tmp = array[i];
    array[i] = array[j];
    array[j] = tmp;
}
for ( int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}

