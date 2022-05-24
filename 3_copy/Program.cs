// Написать программу копирования массива
int[] CopyArr(int[] array)
{   
    int len = array.Length;
    int[] arr_new = new int[len];
    for(int i=0; i < len; i++)
    {
        arr_new[i] = array[i];
    }
    return array;
}


Console.WriteLine("Введите количество элеметов массива");
int n = int.Parse(Console.ReadLine() ?? "0");
int[] array = new int[n];
for(int i = 0; i < n; i++)
{   
    Console.WriteLine($"Введите {i} элемет массива");
    array[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine(String.Join( " ", array));
int[] a = CopyArr(array);
Console.WriteLine(String.Join(" ", a));