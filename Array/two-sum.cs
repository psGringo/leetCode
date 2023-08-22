// https://leetcode.com/problems/two-sum/
public class Solution {
    public class TwoSum
    {
        public int[] TwoSum(int[] nums, int target) {        
            var dict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (dict.ContainsKey(nums[i]))
                    return new int[] { i, dict[nums[i]] };

                int diff = target - nums[i];

                dict.Add(diff, i);
            }

            return null;
        }
    }
}