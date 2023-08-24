// https://leetcode.com/problems/missing-number
public class Solution {
    public int MissingNumber(int[] nums) {
                    
    int[] arr = new int[nums.Length + 1];

    for (int i = 0; i < nums.Length; i++) {
       arr[nums[i]] = 1; 
    }
    
    for(int i=0; i< arr.Length; i++)
    {
      if(arr[i] == 0)        
        return i;
        
    }
    
      return 0;    
  }
}