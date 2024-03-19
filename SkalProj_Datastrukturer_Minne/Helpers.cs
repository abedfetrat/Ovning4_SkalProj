namespace SkalProj_Datastrukturer_Minne;

public class Helpers
{
    public static bool IsParanthese(char letter)
    {
        List<char> possibleMatches = ['(', ')', '{', '}', '[', ']'];
        return possibleMatches.Contains(letter);
    }

    
}
