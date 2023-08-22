public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
      // make a copy of nums1
      int[] nums1copy = new int[m];
      for (int i1 = 0; i1 < m; i1++) {
        nums1copy[i1] = nums1[i1]; 
      }

      int i = 0;
      int j = 0;
      int k = 0;

      while (i < m || j < n) {        
        // intersection
        if (i < m && j < n) {
          if (nums1copy[i] < nums2[j]) {
            nums1[k++] = nums1copy[i++];
          }
          else if (nums1copy[i] > nums2[j]) {
            nums1[k++] = nums2[j++];
          }
          else {
            nums1[k++] = nums1copy[i++];
            nums1[k++] = nums2[j++];          
          }
        } 
        // rest nums1copy
        else if (i < m)        
         nums1[k++] = nums1copy[i++];
        // rest nums2
        else if (j < n)                 
         nums1[k++] = nums2[j++];
                        
 
       //if (i >= m && j >= n)
       //   break; 
      };                      
    }
   
}