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
