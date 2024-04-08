Console.Clear();
Console.WriteLine("Введите элементы массива через пробел:");
string input = Console.ReadLine()!;

string[] inputArray = input.Split(' ');

int count = 0;
foreach (string str in inputArray)
{
    if (str.Length <= 3)
    {
        count++;
    }
}

string[] resultArray = new string[count];

int index = 0;
foreach (string str in inputArray)
{
    if (str.Length <= 3)
    {
        resultArray[index++] = str;
    }
}
Console.WriteLine("Результат:");
Console.Write("[");
for (int i = 0; i < resultArray.Length; i++)
{
    Console.Write(resultArray[i]);
    if (i < resultArray.Length - 1)
    {
        Console.Write(" ");
    }
}
Console.Write("]");