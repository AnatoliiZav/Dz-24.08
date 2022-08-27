// Напишите программу, которая найдет точку пересечения 2 прямых, заданных уравнениями
//   y = k1*x +b1 и y = k2*x +b2 Значения k1, b1, k2, b2 задаются пользователем


void intersection(double k1, double b1, double k2, double b2)
{
    double x = (b2-b1) / (k1-k2);
    double y = k1*x +b1;
    Console.WriteLine($"({x};{y})");
}

Console.WriteLine("Ввведите число k1:  ");
double num1 =  double.Parse(Console.ReadLine());
Console.WriteLine("Ввведите число b1:  ");
double num2 =  double.Parse(Console.ReadLine());
Console.WriteLine("Ввведите число k2:  ");
double num3 =  double.Parse(Console.ReadLine());
Console.WriteLine("Ввведите число b2:  ");
double num4 =  double.Parse(Console.ReadLine());

intersection(num1,num2,num3,num4);
