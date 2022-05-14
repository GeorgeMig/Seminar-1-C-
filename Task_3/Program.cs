//ПРОГРАММА, ПОЗВОЛЯЮЩАЯ ОПРЕДЕЛИТЬ ЧИСЛА, ЛЕЖАЩИЕ МЕЖДУ ОТРИЦАТЕЛЬНЫМ И ПОЛОЖИТЕЛЬНЫМ ЗНАЧЕНИЯМИ ВВЕДЕННОГО ЧИСЛА ПОЛЬЗОВАТЕЛЕМ
Console.Write("Введите целое число => ");
int b = int.Parse(Console.ReadLine ());
int i = -b - 1;
while (i < b)
{
    i= i + 1;
    Console.Write (i + " ");
}
Console.WriteLine (" " + "(ВЫПОЛНЕНО)");