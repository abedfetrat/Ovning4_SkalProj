

namespace SkalProj_Datastrukturer_Minne;

public class Helpers
{
    public static void PrintQueue(Queue<string> theQueue)
    {
        foreach (string item in theQueue)
        {
            Console.WriteLine(item);
        }
    }

    public static void PrintStack(Stack<string> theStack)
    {
        foreach (string item in theStack)
        {
            Console.WriteLine(item);
        }
    }

    public static bool IsParanthese(char letter)
    {
        List<char> possibleMatches = ['(', ')', '{', '}', '[', ']'];
        return possibleMatches.Contains(letter);
    }

    internal static bool IsOpeningParanthesis(char p)
    {
        return p == '(' || p == '{' || p == '[';
    }

    internal static bool IsParanthesisPair(char p1, char p2)
    {
        return (p1 == '(' && p2 == ')') || (p1 == '{' && p2 == '}') || (p1 == '[' && p2 == ']');
    }
}
