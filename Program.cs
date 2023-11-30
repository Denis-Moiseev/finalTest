string[] array = { "Hello", "2", "world", ":-)" };

int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        count++;
    }
}

string[] newArray = new string[count];
int index = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        newArray[index] = array[i];
        index++;
    }
}

Console.Write("[");
for (int i = 0; i < newArray.Length; i++)
{
    Console.Write("\"" + newArray[i] + "\"");
    if (i < newArray.Length - 1)
    {
        Console.Write(", ");
    }
}
Console.WriteLine("]");