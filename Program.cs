string[] arrayOld = new string[4] {"hello", "2", "world", ":-)"};
string[] arrayNew = new string[arrayOld.Length];

void SearchingInArray(string[] arrayOld, string[] arrayNew)
{
    int temp = 0;
    for (int i = 0; i < arrayOld.Length; i++)
    {
    if(arrayOld[i].Length <= 3)
        {
        arrayNew[temp] = arrayOld[i];
        temp++;
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

SearchingInArray(arrayOld, arrayNew);
PrintArray(arrayNew);