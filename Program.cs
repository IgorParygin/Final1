string[] array = new string[4] {"hello", "2", "world", ":-)"};
string[] mass = new string[array.Length];

void Arrayless3(string[] array1, string[] Array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        Array2[count] = array1[i];
        count++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
Arrayless3(array, mass);
PrintArray(mass);