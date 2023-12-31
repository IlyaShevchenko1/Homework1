﻿// C# Practice. First homework.

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

// Задача 6. Напишите программу, которая на вход принимает число и 
// выдаёт, является ли число чётным (делится ли оно на два без остатка).
/*
Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0)
{
    Console.WriteLine("Число четное");
}
else
{
    Console.WriteLine("Число нечетное");
}
*/

// Задача 8. Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.
/*
Console.Write("Input a positive number: ");
int number = Convert.ToInt32(Console.ReadLine());

int current = 2;

if (number < 2)
{
    Console.Write($"Согласно условиям задачи, четных чисел до числа {number} не обнаружено");
}

while (current <= number)
{
    Console.Write(current + " ");
    current = current +2;
}
*/

// Задача про собаку
/*
Console.Write("Set up a distance between two friends (meters): ");
int distance = Convert.ToInt32(Console.ReadLine());
Console.Write("Set up a speed of the first friend: ");
int firstFriendSpeed = Convert.ToInt32(Console.ReadLine());
Console.Write("Set up a speed of the second friend: ");
int secondFriendSpeed = Convert.ToInt32(Console.ReadLine());
Console.Write("Set up a dog speed: ");
int dogSpeed = Convert.ToInt32(Console.ReadLine());
Console.Write("Set up a dog position: First Friend = 1 or Second Friend = 2: ");
int dogPosition = Convert.ToInt32(Console.ReadLine());

int count = 0;
int meetingPoint = 10;

while (meetingPoint < distance)
{
    if (dogPosition == 1)
    {
        distance = distance - distance*(firstFriendSpeed + secondFriendSpeed)/(secondFriendSpeed + dogSpeed);
        count++;
        dogPosition = 2;
    }
    else 
    {
       distance = distance - distance*(firstFriendSpeed + secondFriendSpeed)/(firstFriendSpeed + dogSpeed); 
       count++;
       dogPosition = 1;
    }
}
Console.WriteLine("Собака пробежала " + count + " раз");
*/


