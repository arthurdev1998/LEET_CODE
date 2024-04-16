namespace LeetCooder;

public static class MySqrt
{
    public static int ExecuteMySqrt(this int x)
    {
        var count = 0;

        while (count <= x)
        {
            var result = (double)(count * count);
            var resultProx = (double)(count + 1) * (count + 1);

            if (Math.Floor((double)result) == x)
                break;

            if (x > result && x < resultProx)
                return count;

            count++;
        }

        return count;
    }
}