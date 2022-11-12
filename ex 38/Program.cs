Console.Clear();
Console.Write("Enter your array's size:");
int size = int.Parse(Console.ReadLine());
int[] myArray = CreateRandomArray(size, -100, 100);
ShowArray(myArray);

int max = 0;
int min = 0;
for (int j = 0; j < size; j++)

{
    if (myArray[max] < myArray[j])
    {
        max = j;
    }

    if (myArray[min] > myArray[j])
    {
        min = j;
    }

}





Console.WriteLine($"max = {myArray[max]}, min = {myArray[min]} => max-min={myArray[max]-myArray[min]}");

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