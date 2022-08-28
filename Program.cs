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

// Task 43
Console.WriteLine();
Console.WriteLine("Aiming to find the crossing point of two lines");
Console.WriteLine("Please, enter b1 value:");
double b1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Please, enter k1 value:");
double k1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Please, enter b2 value:");
double b2 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Please, enter k2 value:");
double k2 = double.Parse(Console.ReadLine()!);

    double x = (b2 - b1)/(k1 - k2);
    double y = k1 * x + b1;
    Console.WriteLine($"The crossing is located at coordinates {x}, {y}");