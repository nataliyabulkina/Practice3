﻿/* Задача 3

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/
int Prompt(string message) 
{     System.Console.Write(message);     
return Convert.ToInt32(Console.ReadLine()); 
} 
void Square(int number) 
{     int index = 1;     
while (index <= number)     
{         
    System.Console.WriteLine($"Квадрат числа {index} это {index * index}");
        index++;
}
}
int number = Prompt("Введите число:");
Square(number);
