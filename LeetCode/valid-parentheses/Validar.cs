using System.Text;

namespace valid_parentheses;

public static class Validar
{
    public static bool IsValid(this string s)
    {
        Dictionary<char, int> parenthesesOpen = new Dictionary<char, int>()
        {
            {'[', 1},
            {'(', 2},
            {'{', 3},
        };

        Dictionary<char, int> parenthesesClose = new Dictionary<char, int>()
        {
            {']', 1},
            {')', 2},
            {'}', 3},
        };

        ICollection<int> result = new List<int>();
        ICollection<int> Invertresult = new List<int>();

        for (int i = 0; i < s.Length; i++)
        {
            var srcOpen = parenthesesOpen.FirstOrDefault(x => x.Key == s[i]);
            if (srcOpen.Value != default)
            {
                result.Add(srcOpen.Value);
                continue;
            }

            var srcClose = parenthesesClose.FirstOrDefault(x => x.Key == s[i]);
            if (srcClose.Value != default)
                Invertresult.Add(srcClose.Value);
        }

        return Enumerable.SequenceEqual(result, Invertresult);
    }
}