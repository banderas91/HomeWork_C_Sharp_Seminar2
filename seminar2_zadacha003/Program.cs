// Задача 3: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Введите цифру "); 
int day = Convert.ToInt32(Console.ReadLine());

if (day == 6 || day == 7)
{
    Console.WriteLine("Это выходной");
}
else if (day >= 1 && day <= 5)
{
    Console.WriteLine("Не выходной");
}
else
{
    Console.WriteLine("Такого дня нет");
}