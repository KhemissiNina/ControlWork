string [] StringArray(string[]array)
{
for (int i=0; i<array.Length;i++)
{
    Console.WriteLine($"Введите {i+1}-ую строку:");
    array[i]=Console.ReadLine();
}
Console.WriteLine();
return array;
}

Console.Clear();

Console.WriteLine("Введите количество строк в создаваемом массиве:");
int number=int.Parse(Console.ReadLine());

string [] wordsArray = new string [number];