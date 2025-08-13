
// https://edabit.com/challenge/2QvnWexKoLfcJkSsc

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
