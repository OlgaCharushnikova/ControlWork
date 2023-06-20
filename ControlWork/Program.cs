void Array(string[] array, int l)
{
    for (int i = 0; i < l; i++)
    {
        Console.WriteLine("Введите элемент массива: ");
        array[i] = Console.ReadLine();
    }
}

void PrintArray1(string[] array, int l)
{
    Console.Write("[");
    for (int j = 0; j < l; j++)
    {
        Console.Write($"{array[j]}");
        if (j < l - 1)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
}

void SearchElementsOfArray(string[] array1, string[] array2, int l)
{
    int count = 0;
    int j = 0;
    for (int i = 0; i < l; i++)
    { 
        if (array1[i].Length <= 3)
        {
        array2[j] = array1[i];
        j++;
        count++;
        }
    }
    Console.Write("[");
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array2[i]}");
        if (i < count - 1)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
}

Console.WriteLine("Введите количество элементов массива: ");
int x = Convert.ToInt32(Console.ReadLine());
string[] array1 = new string[x];
string[] array2 = new string[x];
Array(array1, x);
Console.WriteLine(" ");
Console.WriteLine(" ");
Console.WriteLine("Первоначальный массив: ");
PrintArray1(array1, x);
Console.WriteLine(" ");
Console.WriteLine(" ");
Console.WriteLine("Новый массив: ");
SearchElementsOfArray(array1, array2, x);