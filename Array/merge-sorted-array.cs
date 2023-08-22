public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
      
      int j = 0;
      int i = m;
      while (j < n) {       
       nums1[i] = nums2[j];
       i++;
       j++;
      }   

      Array.Sort(nums1);        
    }
}