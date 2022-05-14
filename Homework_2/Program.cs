//ПРОГРАММА, ПОЗВОЛЯЮЩАЯ ОПРЕДЕЛИТЬ НАИБОЛЬШЕЕ ЧИСЛО ИЗ ТРЁХ ВВЕДЕННЫХ ЦЕЛЫХ ЧИСЕЛ ПОЛЬЗОВАТЕЛЕМ
Console.Write("Введите любое целое число => ");
int a = int.Parse(Console.ReadLine ());
Console.Write("ещё одно => ");
int b = int.Parse(Console.ReadLine ());
Console.Write("и последнее число => ");
int c = int.Parse(Console.ReadLine ());
int max = 0;
if (a > b)
{
    max = a;
}
else 
{
    max = b;
}
if (max > c)
{
    max = max;
}
else 
{
    max = c;
}
Console.Write (max);
Console.Write (" " + "- наибольшее число");