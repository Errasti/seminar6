Console.WriteLine("Введите первое число: ");
int firstNum = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int secNum = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int thirdNum = int.Parse(Console.ReadLine());

/* if ( firstNum + secNum > thirdNum && firstNum + thirdNum > secNum && secNum + thirdNum > firstNum)
{
    Console.WriteLine("Треугольник с такими сторонами возможен");
}
else
{
    Console.WriteLine("Треугольник с такими сторонами невозможен");
}
*/

bool IsTriangle (int a, int b, int c)
{
    if ( a + b > c && c + b > a && a + c > b)
    {
       return true;
    }
    else
    {
        return false;
    }
}
if (IsTriangle(firstNum,secNum,thirdNum))
{
    Console.WriteLine("Треугольник реален");
}
else
{
    Console.WriteLine("Треугольник нереален");
}