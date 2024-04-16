namespace LeetCooder;

public static class SearchInsertPosition
{
    public static int SearchInsert(this int[] nums, int target)
    {
        var count = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == target)
                return i;
            
            else if(target < nums[i] )
            {
                return i;
            }

            count++;
        }

        return count;
    }
}
