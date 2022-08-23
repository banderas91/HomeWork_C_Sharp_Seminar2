// Задача 1: Напишите программу, которая принимает на вход случайно сгенерированное трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

int start = 100;
int stop = 999;

int value = new Random().Next(start, stop + 1);
Console.WriteLine(value);

int digit_second = (value % 100) / 10;

Console.WriteLine(digit_second);