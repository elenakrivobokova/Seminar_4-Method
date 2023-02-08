// Задача 19: Напишите программу, которая принимает 
// на вход пятизначное число и проверяет, является ли 
// оно палиндромом.

// 14212 -> нет
// 23432 -> да
// 12821 -> да

System.Console.WriteLine("Введите пятизначное число: ");
string? num = Console.ReadLine(); //? чтобы указать системе, что строка не будет пустой (null)

if (num![0] == num[4] && num[1] == num[3]) //! - чтобы указать,что значение не будет пустым
{
  System.Console.WriteLine("Это палиндром");
}
else
{
  System.Console.WriteLine("Это не палиндром");
}
int convertedNum = Convert.ToInt32(Convert.ToString(num[2])); //конвертация char  в int (через string)
string? num = Console.ReadLine();
if (num!.Length == 5);

System.Console.Write("Введите число: ");
string? num = Console.ReadLine();
if (num[0] == num[4] && num[1] == num[3])
{
  System.Console.WriteLine("Число является палиндромом");
}
else
{
  System.Console.WriteLine("Число не является палиндромом");
}

