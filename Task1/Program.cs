// Напишите программу, которая принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа

Console.Clear();

Console.WriteLine("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

int num1 = num / 100 * 100;
int num2 = num % 10;
int res = (num - num1 - num2) / 10;

Console.WriteLine($"Вторая цифра числа {num} - {res}");
