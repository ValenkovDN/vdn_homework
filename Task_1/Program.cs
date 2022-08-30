// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Write("Введите первое число a ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число b ");
int b = Convert.ToInt32(Console.ReadLine());
if(a > b)
{
    Console.WriteLine("a больше чем b");
}
if(a < b)
{
    Console.WriteLine("b больше чем a");
}
if(a == b)
{
    Console.WriteLine("a равно b");
}