// Написать программу копирования массива
int[] CopyArr(int[] array)          // метод копирования
{   
    int len = array.Length;
    int[] arr_new = new int[len];
    for(int i=0; i < len; i++)
    {
        arr_new[i] = array[i];
    }
    return arr_new;
}


Console.WriteLine("Введите количество элеметов массива");
int n = int.Parse(Console.ReadLine() ?? "0");
int[] array = new int[n];
for(int i = 0; i < n; i++)  ///заполняем массив
{   
    Console.WriteLine($"Введите {i} элемет массива");
    array[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine(String.Join( " ", array));  //вывод массива в консоль

int[] a = CopyArr(array);                      //инициализация нового массива через метод копирования
Console.WriteLine(String.Join(" ", a));        //вывод нового массива в консоль