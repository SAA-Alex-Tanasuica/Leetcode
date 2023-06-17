public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        int index = 0;
        for (int i = index + 1; i < nums.Length; i++)
        {
            if (nums[index] + nums[i] == target)
            {
                return new[] { index, i };
            }
            index++;
        }
        return nums;
    }
}