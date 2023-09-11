// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
//


Console.Clear();

Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine() ?? "0");
int num = 2;
string result = "";
while (num <= n)
{
    if (num <= n - 2) result += num + ", ";
    else result += num + ".";
    num += 2;
}
Console.WriteLine(result);