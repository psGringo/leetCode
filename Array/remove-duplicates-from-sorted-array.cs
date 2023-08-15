// https://leetcode.com/problems/remove-duplicates-from-sorted-array/

public class Solution {
        
    public int RemoveDuplicates(int[] nums) {
        int i = 0; 
        int j = 0;
        
		int k = 0;
        if (nums.Length > 0)        
          k = 1;

        while (i <= nums.Length - 1) {
          
          while (j <= nums.Length - 1) {

              if (j != i && nums[j] != nums[i] && (i != nums.Length - 1)) {
                nums[i + 1] = nums[j];
                k++;
                break;
              }

              j++;
          }

          Console.Write(i);

          i++;
        }

        return k;
    }
}