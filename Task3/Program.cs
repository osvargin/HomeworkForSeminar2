// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным

Console.Clear();

Console.Write("Введи число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num == 6 || num == 7) Console.WriteLine("Выходной день");
else if (num < 1 || num > 7) Console.WriteLine("Введенное число не соответсвует дню недели");
else Console.WriteLine("Будний день");