//ПРОГРАММА, ПОЗВОЛЯЮЩАЯ ОПРЕДЕЛИТЬ НАИБОЛЬШЕЕ ЧИСЛО ИЗ ДВУХ ВВЕДЕННЫХ ЦЕЛЫХ ЧИСЕЛ ПОЛЬЗОВАТЕЛЕМ
Console.Write("Введите любое целое число => ");
int a = int.Parse(Console.ReadLine ());
Console.Write("и ещё одно => ");
int b = int.Parse(Console.ReadLine ());
int max = 0;
if (a > b)
{
    max = a;
    Console.Write (max);
    Console.Write (" " + "- наибольшее число");
}
else 
{
    max = b;
    Console.Write(max);
    Console.Write (" " + "- наибольшее число");
}