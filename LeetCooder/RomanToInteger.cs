using System.Globalization;

namespace LeetCooder;

public static class RomanToInteger
{
    public static Dictionary<string, int> Tabuada { get; set; } = new Dictionary<string, int>
    {
        {"I", 1},
        {"V", 5},
        {"X", 10},
        {"L", 50},
        {"C", 100},
        {"D", 500},
        {"M", 1000},
    };

    public static int ExecuteRomanToInteger(this string s)
    {
        int numero = 0;

        for (int i = 0; i < s.Length; i++)
        {
            var tabuadaResult = Tabuada.GetValueOrDefault(s[i].ToString());

            // 4 -> IV
            if (i != 0 && s[i].ToString() == "V" && s[i - 1].ToString() == "I")
            {
                numero += 3;
                continue;
            }

            // 9 -> IX
            else if (i != 0 && s[i].ToString() == "X" && s[i - 1].ToString() == "I")
            {
                numero += 8;
                continue;
            }

            // 40 -> XL
            else if (i != 0 && s[i].ToString() == "L" && s[i - 1].ToString() == "X")
            {
                numero += 30;
                continue;
            }

            // 90 -> XC
            else if (i != 0 && s[i].ToString() == "C" && s[i - 1].ToString() == "X")
            {
                numero += 80;
                continue;
            }

            // 400 -> CD
            else if (i != 0 && s[i].ToString() == "D" && s[i - 1].ToString() == "C")
            {
                numero += 300;
                continue;
            }

            // 900 -> CM 
            else if (i != 0 && s[i].ToString() == "M" && s[i - 1].ToString() == "C")
            {
                numero += 800;
                continue;
            }

            numero += tabuadaResult;
        }

        return numero;
    }
}