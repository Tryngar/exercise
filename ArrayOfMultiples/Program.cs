// https://edabit.com/challenge/2QvnWexKoLfcJkSsc
//Array of Multiples
// Create a function that takes two numbers as arguments (num, length) and returns an array of multiples of num until the array length reaches length.
//
// Examples
// ArrayOfMultiples(7, 5) ➞ [7, 14, 21, 28, 35]
//
// ArrayOfMultiples(12, 10) ➞ [12, 24, 36, 48, 60, 72, 84, 96, 108, 120]
//
// ArrayOfMultiples(17, 6) ➞ [17, 34, 51, 68, 85, 102]
// Notes
// Notice that num is also included in the returned array.

internal class Program
{
    public static void Main(string[] args)
    {
        int[] x = ArrayOfMultiples(7, 5);
        int[] y = ArrayOfMultiples(12, 10);
        int[] z = ArrayOfMultiples(17, 6);

        foreach (int i in z)
        {
            Console.WriteLine(i);
        }
    }

    public static int[] ArrayOfMultiples(int num, int length)
    {
        int[] result = new int[length];

        for (int i = 1; i <= length; i++)
        {
            result[i - 1] = num * i;
        }
        return result;
    }
}
