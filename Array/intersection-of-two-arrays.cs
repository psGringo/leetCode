// https://leetcode.com/problems/intersection-of-two-arrays
public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) {

       var set = new HashSet<int>();
       for (int i = 0; i < nums1.Length; i++) {
         set.Add(nums1[i]); 
       }

       var resSet = new HashSet<int>();
       for (int i = 0; i < nums2.Length; i++) {
         if (set.Contains(nums2[i]))
         resSet.Add(nums2[i]);
       }

      return resSet.ToArray();                
    }
}