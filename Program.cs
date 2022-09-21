// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7

Console.Write("enter num1: ");
int num1;
 num1 = Convert.ToInt32(Console.ReadLine());
 Console.Write("enter num2: ");
int num2;
num2 = Convert.ToInt32(Console.ReadLine());
 Console.Write("enter num3: ");
int num3;
num3 = Convert.ToInt32(Console.ReadLine());
int max = num1;
if (num2 > max )
{
 max = num2;
}
if ( num3 > max )
 {
max = num3;
}
Console.WriteLine(max);