﻿// https://edabit.com/challenge/6qFnpAhd3kdmYcNG2
//Return the Index of All Capital Letters
// Create a function that takes a single string as argument and returns an ordered array containing the indices of all capital letters in the string.
//
// Examples
// IndexOfCapitals("eDaBiT") ➞ [1, 3, 5]
//
// IndexOfCapitals("eQuINoX") ➞ [1, 3, 4, 6]
//
// IndexOfCapitals("determine") ➞ []
//
// IndexOfCapitals("STRIKE") ➞ [0, 1, 2, 3, 4, 5]
//
// IndexOfCapitals("sUn") ➞ [1]
// Notes
// Return an empty array if no uppercase letters are found in the string.
// Special characters ($#@%) and numbers will be included in some test cases.
// Assume all words do not have duplicate letters.

public class Program
{
    public static void Main(string[] args)
    {
        List<int> a = IndexOfCapitals("eDaBiT");
        List<int> b = IndexOfCapitals("eQuINoX");
        List<int> c = IndexOfCapitals("determine");
        List<int> d = IndexOfCapitals("STRIKE");
        List<int> e = IndexOfCapitals("sUn");
        foreach (int i in e)
        {
            Console.Write(i + " ");
        }

    }

    public static List<int> IndexOfCapitals(string s)
    {
        List<int> indices = new List<int>();
        // int[] indices = new int[s.Length];
        // int arrayPosition = 0;

        for (int i = 0; i < s.Length; i++)
        {
            if (char.IsUpper(s[i]))
            {
                indices.Add(i);
                // indices[arrayPosition] = i;
                // arrayPosition++;
            }
        }
        return indices;
    }
}
