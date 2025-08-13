// https://edabit.com/challenge/Q7g8sfg7DJq6CyMMu
// Equality Check
// In this challenge, you must verify the equality of two different values given the parameters a and b.
//
// Both the value and type of the parameters need to be equal. The possible types of the given parameters are:
//
// Numbers
// Strings
// Booleans (false or true)
// What have you learned so far that will permit you to do two different checks (value and type) with a single statement?
//
// Implement a function that returns true if the parameters are equal, and false if they are not.
//
// Examples
// CheckEquality(1, true) ➞ false
// A number and a boolean: the value and type are different.
//
// CheckEquality(0, "0") ➞ false
// A number and a string: the type is different.
//
// CheckEquality(1,  1) ➞ true
// A number and a number: the type and value are equal.

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(CheckEquality(1, true));
        Console.WriteLine(CheckEquality(0, '0'));
        Console.WriteLine(CheckEquality(1, 1));
    }

    public static bool CheckEquality(object a, object b)
    {
        if (a.GetType().Equals(b.GetType()))
        {
            if (a.Equals(b))
            {
                return true;
            }
        }
        return false;
    }
}
