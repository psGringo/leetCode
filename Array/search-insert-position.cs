// https://leetcode.com/problems/search-insert-position/
public class Solution {
    public int SearchInsert(int[] nums, int target) {
      int l = 0;
      int r = nums.Length - 1;

      while (l <= r) {
        int mid = (l + r) / 2;
        if (target < nums[mid])
          r = mid - 1;
        else if (target > nums[mid])
          l = mid + 1;
        else return mid;    
      }

      return l;        
    }
}