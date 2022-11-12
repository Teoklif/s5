Console.Clear();
Console.Write("Enter your array's size:");
int size = int.Parse(Console.ReadLine());
int[] myArray = CreateRandomArray(size, -100, 100);
ShowArray(myArray);

int sum = 0;


for (int i = 0; i < myArray.Length; i++)
{
    if (myArray[i] % 2 == 1)
        sum += myArray[i];

}

Console.Write($"{sum}");
int[] CreateRandomArray(int N, int start, int end)
{
    int[] RandomArray = new int[N];
    for (int i = 0; i < N; i++)
    {
        RandomArray[i] = new Random().Next(start, end + 1);
    }
    return RandomArray;
}
void ShowArray(int[] array)
{
    Console.WriteLine($"[ {String.Join(", ", array)} ] => ");
}
