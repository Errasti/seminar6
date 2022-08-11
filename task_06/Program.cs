Console.WriteLine("Введите число в десятичной системе: ");
int n = int.Parse(Console.ReadLine());
int[] res = new int[32];
int i = 0;
while( n > 0 )
{
    res[i] = n % 2;
    i++;
    n /= 2;
}

for ( int j = i - 1; j >= 0; j-- )
{
    Console.Write(res[j]);
}

