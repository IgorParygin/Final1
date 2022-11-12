string[] array = new string[5] {"hello", "2", "world", ":-)"};
string[] mass = new string[array.Length];

void Arrayless3(string[] array, string[] mass)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
    if(array[i].Length <= 3)
        {
        mass[count] = array[i];
        count++;
        }
    }
}
