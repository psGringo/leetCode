// https://leetcode.com/problems/majority-element/
// https://en.wikipedia.org/wiki/Boyer%E2%80%93Moore_majority_vote_algorithm
public class Solution {
    public int MajorityElement(int[] nums) {                
        int majority = nums[0];
        int count = 0;

        for (int i = 0; i < nums.Length; i++) {
            if (count == 0)
               majority = nums[i];                     
            
            if (majority == nums[i])
              count++;
            else count--; 
        }

        return majority;        
    }
}