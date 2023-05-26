// Задача 43: Напишите программу, которая 
//найдёт точку пересечения двух прямых, заданных
// уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются 
// пользователем.

//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Дано два уравнения y = k1 * x + b1, y = k2 * x + b2 ");
double b1 = Prompt("Введите значение b1: ");
double k1 = Prompt("Введите значение k1: ");
double b2 = Prompt("Введите значение b2: ");
double k2 = Prompt("Введите значение k2: ");
PointCoordinate(b1, k1, b2, k2);


double Prompt(string messege)

{
    Console.Write(messege);
    int coordinate = int.Parse(Console.ReadLine());
    double number = Convert.ToDouble(coordinate);
    return number;
}

void PointCoordinate(double b1, double k1, double b2, double k2)
{
    double coordX = (b1-b2)/(k2-k1);
    double coordY = k1*((b1-b2)/(k2-k1)) + b1;
    Console.WriteLine($"Точка пересечения двух прямых имеет координаты: ({coordX}; {coordY})");
}