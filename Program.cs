// C# Practice. First homework.

// Задача 2. Напишите программу, которая на вход принимает два числа и выдаёт,
// какое число большее, а какое меньшее.
// Вариант 1. Решение задачи по условию
/*

Console.Write("Input a first number: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber > secondNumber)
{
    Console.WriteLine($"First number: {firstNumber} is bigger than second number: {secondNumber}");
}
else if (firstNumber < secondNumber)
{
    Console.WriteLine($"First number: {firstNumber} is less than second number: {secondNumber}");
}
else
{
    Console.WriteLine($"First number: {firstNumber} is equal to second number: {secondNumber}");
}
*/
// Вариант 2. Решение задачи, как в примере.
/*
Console.Write("Input a first number: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber > secondNumber)
{
    Console.WriteLine("Max = " + firstNumber);
}
else if (firstNumber < secondNumber)
{
    Console.WriteLine("Max = " + secondNumber);
}
else
{
    Console.WriteLine("Первое число равно второму. Max = " + firstNumber);
}
*/

// Задача 4. Напишите программу, которая принимает на вход три числа и 
// выдаёт максимальное из этих чисел.
/*
Console.Write("Input a first number: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a third number: ");
int thirdNumber = Convert.ToInt32(Console.ReadLine());

int max = firstNumber;

if (secondNumber > firstNumber)
{
    max = secondNumber;
}
if (thirdNumber > secondNumber)
{
    max = thirdNumber;
}

Console.Write("Максимальное число: " + max);
*/

