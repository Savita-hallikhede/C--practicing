using System;

public class ArrayClass1
{
    public static void Main(string[] args)
    {
        // Input array size
        Console.WriteLine("Enter n:");
        int n = Convert.ToInt32(Console.ReadLine());

        // Create array
        int[] array = new int[n];

        // Input array elements
        Console.WriteLine("Enter numbers:");

        for (int i = 0; i < n; i++)
        {
            array[i] = Convert.ToInt32(Console.ReadLine());
        }

        // Display original array
        Console.WriteLine("\nOriginal Array:");

        int index = 0;

        foreach (int value in array)
        {
            Console.WriteLine("Element[{0}] = {1}", index, value);
            index++;
        }

        // Get array length
        int length = array.Length;

        Console.WriteLine("\nArray Length: " + length);

        // Sort array
        Array.Sort(array);

        Console.WriteLine("\nSorted Array:");

        foreach (int value in array)
        {
            Console.Write(value + " ");
        }

        // Reverse array
        Array.Reverse(array);

        Console.WriteLine("\n\nReversed Array:");

        foreach (int value in array)
        {
            Console.Write(value + " ");
        }

        Console.ReadLine();
    }
}