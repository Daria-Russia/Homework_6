// Task 31. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

//Console.Write("Введите числа: ");
//int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
//int count = 0;
 
//for (int i = 0; i < array.Length; i++)
//{
//    if (array[i] > 0)
//    {
//        count++;
//    }
//}
 
//Console.WriteLine($"Количество чисел > 0: {count}");

//Task 43. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
Console.Write("k1: ");
var k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("b1: ");
var b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("k2: ");
var k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("b2: ");
var b2 = Convert.ToDouble(Console.ReadLine());
 
 
var x = -(b1 - b2) / (k1 - k2);
var y = k1 * x + b1;
 
x = Math.Round(x, 3);
y = Math.Round(y, 3);
 
Console.WriteLine($"Координаты пересечения: ({x};{y})");

