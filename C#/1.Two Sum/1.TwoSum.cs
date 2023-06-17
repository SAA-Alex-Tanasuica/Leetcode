public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        for(int index = 0; index < nums.Length - 1; index++)
        {
            for(int i = index + 1; i < nums.Length; i++)
            {
                if(nums[index] + nums[i] == target)
                {
                    Console.WriteLine($"{index},{i}");
                    return new[] { index, i };
                }
            }
        }
        return nums;
    }
}