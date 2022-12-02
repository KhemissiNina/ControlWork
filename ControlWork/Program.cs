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

string [] NewStringArray (string[]array)
{
	string [] newArray = new string [array.Length];
	int k=0;
	for (int i=0; i<array.Length;i++)
{
	if (array[i].Length<=3)
	{
		newArray[k]=array[i];
		k++;
	}
}return newArray;
}

Console.Clear();

Console.WriteLine("Введите количество строк в создаваемом массиве:");
int number=int.Parse(Console.ReadLine());

string [] wordsArray = new string [number];

StringArray(wordsArray);
Console.WriteLine("Созданный массив:");
PrintArray(wordsArray);
Console.WriteLine("Массив со строками меньше 3 символов:");
PrintArray(NewStringArray(wordsArray));