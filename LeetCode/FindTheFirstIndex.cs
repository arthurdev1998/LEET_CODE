using System.Text;

namespace LeetCode;

public static class FindTheFirstIndex
{
    public static int StrStr(this string haystack, string needle)
    {
        if (needle.Length > haystack.Length)
        {
            return -1;
        }

        for (int i = 0; i < haystack.Length; i++)
        {
            var j = 0;
            var k = i;
            if (haystack[i] == needle[0])
            {
                if (i + needle.Length > haystack.Length)
                {
                    return -1;
                }

                var comparerer = new StringBuilder();
                while (j < needle.Length)
                {
                    comparerer.Append(haystack[k]);
                    k++;
                    j++;
                }

                if (comparerer.ToString() == needle)
                {
                    return i;
                }
            }
        }

        return -1;
    }
}