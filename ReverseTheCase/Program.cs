// https://edabit.com/challenge/99oN5igrbXddAjHEL
//Reverse the Case
// Given a string, create a function to reverse the case. All lower-cased letters should be upper-cased, and vice versa.
//
// Examples
// ReverseCase("Happy Birthday") ➞ "hAPPY bIRTHDAY"
//
// ReverseCase("MANY THANKS") ➞ "many thanks"
//
// ReverseCase("sPoNtAnEoUs") ➞ "SpOnTaNeOuS"
//
internal class Program
{
    private static void Main(string[] args)
    {
        ReverseeCase("Happy Birthday");
        ReverseeCase("MANY THANKS");
        ReverseeCase("sPoNtAnEooUs");
    }



    public static void ReverseeCase(string toReverse)
    {
        char[] chars = toReverse.ToArray();

        foreach (char c in chars)
        {
            if (char.IsUpper(c))
            {
                Console.Write(char.ToLower(c));
            }
            else
            {
                Console.Write(char.ToUpper(c));
                // char.ToUpper(c);
            }
        }
        Console.WriteLine();

    }
}
