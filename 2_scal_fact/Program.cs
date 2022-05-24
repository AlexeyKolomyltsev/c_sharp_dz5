// Написать программу масштабирования фигуры

int[][] ScaleFactor(int[][] array, int k)  /// метод преобразования координат
{
    int len = array.Length;
    for(int i = 0; i < len; i++)
    {
        int lenj = array[i].Length;
        for(int j = 0; j < lenj; j++)
        {
            array[i][j] = array[i][j]  * k;
        }
    }
    return array;
}

void PrintArr2(int[][] array)   /// метод вывода массива в консоль
{
int len = array.Length;
    for(int i = 0; i < len; i++)
    {   
        Console.Write("(");
        int lenj = array[i].Length;
        for(int j = 0; j < lenj; j++)
        {
            Console.Write(array[i][j] + " ");
        }
        Console.Write(")");
    }
}

Console.WriteLine("Введите количество вершин фигуры"); //Задаем количество точек
int n = int.Parse(Console.ReadLine() ?? "0");
int[][] koordinates = new int[n][];

for(int i = 0; i < n; i++)                                     //Заполняем массив координат
{   
    koordinates[i] = new int[2];
    Console.WriteLine($"Введите координаты для {i+1} вершины");
    for(int j = 0; j < 2; j++)
    {
        koordinates[i][j] = int.Parse(Console.ReadLine() ?? "0");
    }
}


PrintArr2(koordinates);                        // Вывести массив в консоль
Console.WriteLine();
Console.WriteLine("Введите коэффициент k");
int k = int.Parse(Console.ReadLine() ?? "0");
ScaleFactor(koordinates, k);                   // Преобразовть массив                    

PrintArr2(koordinates);                        // Вывести получившийся массив в консоль