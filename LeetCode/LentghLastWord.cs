namespace LeetCode;

public static class LentghLastWord
{
    public static int Execute(this string src)
    {
        /* com Linq*/

        // var obj = src.Trim();
        // var splits = obj.Split(" ").Count();
        // var objectSplit = obj.Split(" ")[splits - 1];
        // return 1;

        var count = 0;
        for (int i = src.Length - 1; i >= 0; i--)
        {
            if (src[i].ToString() == " " && count == 0)
                continue;

            if (src[i].ToString() != " ")
            {
                count++;
                continue;
            }
            
            break;

        }

        return count;
    }
}