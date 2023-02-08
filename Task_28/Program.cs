﻿// Задача 28: Напишите программу, которая принимает на вход число N 
// и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120


int GetNumber(string text)
{
  System.Console.Write(text);
  return Convert.ToInt32(Console.ReadLine());
}
int Multiply(int x)
{
  int result = 1;
    for (int i = 1; i <= x; i++)
  {
    result = result * i;
  }
  return result;
}
int num = GetNumber("Введите число: ");
System.Console.WriteLine($"Произведение чисел от 1 до {num} = {Multiply(num)}");