// https://leetcode.com/problems/missing-number
public class Solution {
    

    public int MissingNumber(int[] nums) {
        
		// to add many cases here, not submitting        
		 
        int min = nums[0];
        int max = nums[0];
        var set = new HashSet<int>();
        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] < min) {
                min = nums[i];
            }

            if (nums[i] > max) {
                max = nums[i];
            }                        

            set.Add(nums[i]);
        }
         
        for (int num = min; num <= max; num++) {
          if (!set.Contains(num))
            return num;
        }

        return ++max; // not clear from conditions of the task        
    }
}