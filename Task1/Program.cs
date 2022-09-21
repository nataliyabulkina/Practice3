/*
Задача 1
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Не использовать строки!
14212 -> нет
12821 -> да
23432 -> да
*/

Console.WriteLine("Введите число");
var number = Console.ReadLine();
if (number.Reverse().SequenceEqual(number))
{
Console.WriteLine("Палиндром");
}
else
{
  Console.WriteLine("Число не является палиндромом");  
}
