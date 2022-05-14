

// НАСТОЯЩАЯ ПРОГРАММА ВЫЧИСЛЯЕТ ЯВЛЯЕТСЯ ЛИ ОДНО ЧИСЛО КВАДРАТОМ ДРУГОГО

int a = 5;
int b = 25;
int numResult = b / a;
Console.WriteLine (numResult);

if (numResult == a)
{
    Console.WriteLine( "Является квадратом.");
}
else 
{
    Console.WriteLine( " Не является квадратом.");
}