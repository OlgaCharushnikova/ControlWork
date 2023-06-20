void Array(string[] array, int l)
{
    for (int i = 0; i < l; i++)
    {
        Console.WriteLine("Введите элемент массива: ");
        array[i] = Console.ReadLine();
    }
}
