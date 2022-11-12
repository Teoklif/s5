Console.Clear();
Console.Write("Enter your array's length:");
int length = int.Parse(Console.ReadLine());
int[] array = GetArray(length, 100, 1000);

Console.WriteLine($"[ {String.Join(", ", array)} ] ");

int[] GetArray(int size, int minValue, int maxValue)
{
    int a = 0;
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue);

        if (result[i] % 2 == 0)
        {
            a++;
        }
    }
    Console.WriteLine(a);
    return result;
}


