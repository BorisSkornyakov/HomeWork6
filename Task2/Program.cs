// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// Например b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double DataEntry(string message)                                                        //Метод ввода данных
{
    System.Console.Write(message);
    return Convert.ToDouble(Console.ReadLine());
}

double CoordinateIntersectionPointAxisX(double k1, double k2, double b1, double b2)     //Метод определения координаты точки пересечения
{                                                                                       //по оси Х
    return (b2-b1)/(k1 - k2);
}

double CoordinateIntersectionPointAxisY(double k1, double b1, double x)                 //Метод определения координаты точки пересечения
{                                                                                       //по оси Y
    return k1 * x + b1;
}

double b1 = DataEntry("Введите коэффициент b1 ");
double k1 = DataEntry("Введите коэффициент k1 ");
double b2 = DataEntry("Введите коэффициент b2 ");
double k2 = DataEntry("Введите коэффициент k2 ");
double coordinateX = CoordinateIntersectionPointAxisX(k1, k2, b1, b2);
double coordinateY = CoordinateIntersectionPointAxisY(k1, b1, coordinateX);
System.Console.WriteLine($"Координаты точки пересечения прямых ({coordinateX}; {coordinateY})");