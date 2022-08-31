// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.

void CheckPalindromicNumber(int num)
{
    if(num >= 10000)
    {
        int division1 = num / 10000;
        int remainder1 = num % 10;
 
            if(division1 == remainder1)
            {
                num = num / 10;
                int division2 = (num / 100) % 10;
                int remainder2 = num % 10;
                if(division2 == remainder2)
                    Console.WriteLine("Данное число является палиндромом");
            }
            else 
            Console.WriteLine("Данное число не является палиндромом");
            
    }
    else
    Console.WriteLine("Ошибка ввода.Данное число не является пятизначным!");
}
 
Console.WriteLine("Введите пятизначное число:");
int num = int.Parse(Console.ReadLine()!);
CheckPalindromicNumber(num);

// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

using System;
 
class Program
{
 
    static void Main(string[] args)
    {
        Console.WriteLine("Введите число: ");
        int num = int.Parse(Console.ReadLine());
        for (int i = 1; i <= num; i++)
            Console.WriteLine("{0}^2 = {1}", i, i*i);
        Console.ReadKey(true);
    }
}

// Задача 21. Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

Console.WriteLine("Введите координаты точки А: ");
Console.Write("X = ");
double x1 = Convert.ToDouble(Console.ReadLine()); 
Console.Write("Y = ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Z = ");
double z1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координаты точки B: ");
Console.Write("X = ");
double x2 = Convert.ToDouble(Console.ReadLine()); 
Console.Write("Y = ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Z = ");
double z2 = Convert.ToDouble(Console.ReadLine());

double result = Math.Sqrt(Math.Pow((x1 - x2), 2)
              + Math.Pow((y1 - y2), 2)
              + Math.Pow((z1 - z2), 2));

Console.WriteLine($"Расстояние между точками A и B = {result:F}");

