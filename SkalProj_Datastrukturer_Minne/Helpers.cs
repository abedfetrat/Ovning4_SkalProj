namespace SkalProj_Datastrukturer_Minne;

public class Helpers
{
    // Hjälp metod för att skriva ut kön
    public static void PrintQueue(Queue<string> theQueue)
    {
        foreach (string item in theQueue)
        {
            Console.WriteLine(item);
        }
    }

    // Helper metod för att skriva ut stacken av string
    public static void PrintStack(Stack<string> theStack)
    {
        foreach (string item in theStack)
        {
            Console.WriteLine(item);
        }
    }
    // Helper metod för att kolla om en input är en parantes av sorten nedan
    public static bool IsParanthese(char letter)
    {
        List<char> possibleMatches = ['(', ')', '{', '}', '[', ']'];
        return possibleMatches.Contains(letter);
    }
}
