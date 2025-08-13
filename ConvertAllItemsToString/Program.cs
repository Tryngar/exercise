//https://edabit.com/challenge/hqTYj7NbLnCcjxryi
//Convert All Array Items to String
// Create a function that takes an array of integers and strings, converts integers to strings, and returns the array as a string array.
//
// Examples
// ParseArray([1, 2, "a", "b"]) ➞ ["1", "2", "a", "b"]
//
// ParseArray(["abc", 123, "def", 456]) ➞ ["abc", "123", "def", "456"]
//
// ParseArray([1, 2, 3, 17, 24, 3, "a", "123b"]) ➞ ["1", "2", "3", "17", "24", "3", "a", "123b"]
//
// ParseArray([]) ➞ []

public class Program
{
    public static void Main(string[] args)
    {
        // string[] s = ParseArray([1, 2, "a", "b"]);
        // string[] s = ParseArray(["abc", 123, "def", 456]);
        string[] s = ParseArray([1, 2, 3, 17, 24, 3, "a", "123b"]);
        foreach (string x in s)
        {
            Console.Write(x);
            Console.WriteLine(x.GetType());
        }
    }

    public static string[] ParseArray(object[] arr)
    {
        string[] s = new string[arr.Length];
        int i = 0;

        foreach (object o in arr)
        {
            s[i] = o.ToString();
            i++;
        }
        return s;

    }
}

