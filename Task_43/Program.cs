// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных 
// уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


Console.WriteLine("Введите коэффициенты линейных функций: ");
double k1 = ReadDub("k1 = ");
double b1 = ReadDub("b1 = ");
double k2 = ReadDub("k2 = ");
double b2 = ReadDub("b2 = ");

if( k1 == k2)
{
    Console.WriteLine("Функции не пересекаются");
}
double x = Math.Round((b2 - b1) / (k1 - k2), 2);
double y = Math.Round((k1 * x + b1), 2);

Console.Write($"x = {x}  y = {y} ");

double ReadDub(string message)
{
    Console.Write(message);
    return Math.Round(Convert.ToDouble(Console.ReadLine()), 2);
}
