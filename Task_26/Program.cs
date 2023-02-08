// Задача 26: Напишите программу, которая принимает на вход число и 
// выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

string getNumber(string text)
{
  System.Console.Write(text);
  return Console.ReadLine();
}

string a = getNumber ("Введите число: ");
int len = a.Length;
System.Console.WriteLine(len); 

