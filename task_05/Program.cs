for ( int i = 1; i < 101; i++)
{
    if (i % 5 == 0 && i % 3 == 0 )
    {
        Console.Write("FizzBuzz ");
    }
    else if ( i % 5 == 0 )
    {
        Console.Write("Buzz ");
    }
    else if ( i % 3 == 0 )
    {
        Console.Write("Fizz ");
    }
    Console.Write(i + " ");
}