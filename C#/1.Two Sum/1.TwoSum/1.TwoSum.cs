namespace Leetcode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 2, 7, 11, 15 };
            int target = 9;

            Solution solution = new Solution();
            var arr = solution.TwoSum(nums, target);
            Console.WriteLine($"{arr[0]}, {arr[1]}");
        }
    }


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

}