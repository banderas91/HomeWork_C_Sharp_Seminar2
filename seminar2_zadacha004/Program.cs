// Задача 4:
// Напишите программу, которая принимает на вход случайно сгенерированное число (от 1 до 1 000 000) и проверяет, кратно ли оно одновременно 7 и 23.



int start = 1;
int stop = 1000000;

int value = new Random().Next(start, stop + 1);
Console.WriteLine(value);


if (value % 7 == 0 && value % 23 == 0) 
{
    Console.WriteLine("кратно");
}
else
{
    
   Console.WriteLine("НЕ кратно");
}

