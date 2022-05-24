// Написать программу масштабирования фигуры

void PrintArr(int[] array)  ///метод печати в консоль
{
    int len = array.Length;
    for (int i = 0; i < len; i++)
    {
        if (i % 2 == 0) Console.Write($"({array[i]},");
        else Console.Write($"{array[i]})");
    }
    Console.WriteLine();
}

int[] Scale(int[] array, int k)  ///метод масштабирования
{
    int len = array.Length;
    for (int i = 0; i < len; i++)
    {
        array[i] *= k;
    }
    return array;
}

Console.WriteLine("Введите количество вершин фигуры"); //Задаем количество точек
int n = int.Parse(Console.ReadLine() ?? "0");
int[] koordinates = new int[n * 2];
for (int i = 0; i < n * 2; i++)   ///Заполняем массив
{
    Console.Write($"Введите координату для {i / 2 + 1} вершины = ");
    koordinates[i] = int.Parse(Console.ReadLine() ?? "0");
}

PrintArr(koordinates);

Console.Write("Введите коэффициент k ");
int koef = int.Parse(Console.ReadLine() ?? "0");

Scale(koordinates, koef);
PrintArr(koordinates);