// Написать программу масштабирования фигуры
int[,] ScaleFactor(int[,] array, int k)
{
    int len = array.GetLength(0);
    for(int i = 0; i < len; i++)
    {
        int lenj = array.GetLength(1);
        for(int j = 0; j < lenj; j++)
        {
            array[i,j] = array[i,j] * k;
        }
    }
    return array;
}

void PrintArr2(int[,] array)
{
int len = array.GetLength(0);
    for(int i = 0; i < len; i++)
    {   
        Console.Write("(");
        int lenj = array.GetLength(1);
        for(int j = 0; j < lenj; j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.Write(")");
    }
}
Console.WriteLine("Введите количество вершины фигуры фигуры");
int n = int.Parse(Console.ReadLine() ?? "0");
int[,] koordinates = new int[n , 2];

for(int i = 0; i < n; i++)
{   
    Console.WriteLine($"Введите координаты для {i+1} вершины");
    for(int j = 0; j < 2; j++)
    {
        koordinates[i,j] = int.Parse(Console.ReadLine() ?? "0");
    }
}
Console.WriteLine("Введите коэффициент k");
int k = int.Parse(Console.ReadLine() ?? "0");
PrintArr2(koordinates);


ScaleFactor(koordinates, k);
Console.WriteLine();
PrintArr2(koordinates);