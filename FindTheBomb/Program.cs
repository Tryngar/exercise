// https://edabit.com/challenge/JYEufqRvkusjr5R58
//Find the Bomb
// Create a function that finds the word "bomb" in the given string (not case sensitive). If found, return "Duck!!!", otherwise, return "There is no bomb, relax.".
//
// Examples
// Bomb("There is a bomb.") ➞ "Duck!!!"
//
// Bomb("Hey, did you think there is a bomb?") ➞ "Duck!!!"
//
// Bomb("This goes boom!!!") ➞ "There is no bomb, relax."
// Notes
// "bomb" may appear in different cases (i.e. uppercase, lowercase, mixed).
//
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(Bomb("There is a bomb."));
        Console.WriteLine(Bomb("Hey, did you  think there is a bomb?"));
        Console.WriteLine(Bomb("This goes boom!!!"));
    }

    public static string Bomb(string s)
    {
        s = s.ToLower();
        if (s.Contains("bomb"))
        {
            return "Duck!!!";
        }
        else
        {
            return "There is no bomb, relax.";
        }

    }
}


