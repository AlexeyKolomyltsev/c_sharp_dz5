// Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы
Console.WriteLine("Найти точку пересечения двух прямых y = k1 * x + b1, y = k2 * x + b2");
Console.WriteLine("Введите коэффициенты b1, k1, b2 и k2:");
float b1 = float.Parse(Console.ReadLine() ?? "0");
float k1 = float.Parse(Console.ReadLine() ?? "0");
float b2 = float.Parse(Console.ReadLine() ?? "0");
float k2 = float.Parse(Console.ReadLine() ?? "0");
Console.Write($"Получившиеся уравнения : y = {k1}x + {b1} и y = {k2}x + {b2} ");
if (b1 == b2 && k1 == k2) Console.WriteLine("совпадают.");
else if (k1 == k2) Console.WriteLine("параллельны.");
else
{
    float x, y;
    x = (b2 - b1) / (k1 - k2);
    y = k1 * x + b1;
    Console.WriteLine($"имеют точку пересечения с координатами ({x}, {y}).");
}