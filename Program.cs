// Task 41

Console.WriteLine("Task 41. Creating an array of M numbers (inputted by the user), outputting amount of numbers, which are greater than 0");
Console.Write("Enter your numbers (divided by a space): ");
int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int count = 0;
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > 0)
    {
        count++;
    }
}
 
Console.WriteLine($"Amount of elements > 0: {count}");

