// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7


Console.Write("enter number: ");
int number1;
 number1 = Convert.ToInt32(Console.ReadLine());
 Console.Write("enter number2: ");
int number2;
number2 = Convert.ToInt32(Console.ReadLine());
int max; 

if ( number1 > number2) 
{
    max = number1;
Console.WriteLine($"max =  { number1 } ");
}
else {
    max = number2;
Console.WriteLine($"max =  { number2 }");
}


  


