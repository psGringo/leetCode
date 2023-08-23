public class Solution {
    public bool ContainsDuplicate(int[] nums) {        
        Array.Sort(nums);

        for (int i = 0; i < nums.Length - 1; i++) {
            if (nums[i] == nums[i+1])
              return true;
        }  
             
        return false;
    }
}

public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        
        HashSet<int> set = new HashSet<int>();

        for (int i = 0; i < nums.Length; i++) {
            if (set.Contains(nums[i]))
              return true;
              
            set.Add(nums[i]);
        }  
             
        return false;
    }
}