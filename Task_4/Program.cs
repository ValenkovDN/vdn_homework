// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Write("Введите число ");
int a = Convert.ToInt32(Console.ReadLine());
int b = 2;

while(b <= a )
{
if(b % 2 == 0)
{
    Console.Write(b + ", ");
    b= b+1;
}
else
{
    Console.Write(b + ", ");
}   
b= b+1; 
}