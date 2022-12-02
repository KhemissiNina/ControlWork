string [] StringArray(string[]array)
{
for (int i=0; i<array.Length;i++)
{
    Console.WriteLine($"Введите значение {i+1}-ой строки:");
    array[i]=Console.ReadLine();
}
Console.WriteLine();
return array;
}

void PrintArray(string [] array)
{
	
     for (int i=0; i<array.Length;i++)
{
     Console.WriteLine($"{array[i]}");
     }
    Console.WriteLine();
}
Console.Clear();

Console.WriteLine("Введите количество строк в создаваемом массиве:");
int number=int.Parse(Console.ReadLine());

string [] wordsArray = new string [number];
