namespace LeetCooder;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

public static class RemoveItem
{
    public static int RemoveElement(this int[] nums, int val)
    {
        var result = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != val)
            {
                nums[result] = nums[i];
                result++;
            }
        }

        return result;
    }
}