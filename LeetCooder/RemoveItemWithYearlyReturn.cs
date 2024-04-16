namespace LeetCooder;

public static class RemoveItemWithYearlyReturn
{
    public static int[] RemoveElementWithYeldReturn(this int[] nums, int val)
    {
        return RemoveElementWithYield(nums, val).ToArray();
    }

    private static IEnumerable<int> RemoveElementWithYield(int[] nums, int val)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != val)
                yield return nums[i];
        }
    }
}