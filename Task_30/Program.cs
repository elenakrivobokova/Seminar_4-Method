// // Задача 30: Напишите программу, которая выводит массив из 8 элементов, 
// // заполненный нулями и единицами в случайном порядке.
// // [1,0,1,1,0,1,0,0]

void PrintArray(int[] array)
{
  // int count = array.Length;
  // for (int i = 0; i < count; i++)
  // {
  //   System.Console.Write($"{array[i]} ");
  // }
  System.Console.WriteLine("["+string.Join(", ", array)+"]");
}


int[] FillArray(int size)//int size - универсальный метод. можем задавать любое числоэлементов в массиве
{
  int[] arrN = new int[size];
  for (int i = 0; i < size; i++)
  {
    arrN[i] = new Random().Next(0, 2);
  }
  return arrN;
}

int[] myArray = FillArray(14);
PrintArray(myArray);


//АЛЬТЕРНАТИВА
// int n = 8;
// int[] arr = GetArray(n);

// int[] GetArray(int n)
// {
//   int[] array = new int[n];
//   for (int i = 0; i < n; i++)
//   {
//     array[i] = new Random().Next(0, 2);
//   }
//   return array;
// }

// for (int i = 0; i < arr.Length; i++)
// {
//   System.Console.Write(arr[i] + " ");
// }




int[] GetArray()
{
var arr = new int[8];
var rand = new Random();
for (int i = 0; i < arr.Length; i++)
{
arr[i] = rand.Next(0, 2);
}
return arr;
}

void PrintArray(int[] arr)
{
System.Console.WriteLine("["+string.Join(", ", arr)+"]");
}

var myArray = GetArray();
PrintArray(myArray);



//---------- Версия 2
void GetArray(int[] arr)
{
var rand = new Random();
for (int i = 0; i < arr.Length; i++)
{
arr[i] = rand.Next(0, 2);
}
}

void PrintArray(int[] arr)
{
System.Console.WriteLine("["+string.Join(", ", arr)+"]");
}

int[] myArray = new int[8];
GetArray(myArray);
PrintArray(myArray);

