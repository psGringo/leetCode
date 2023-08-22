// not solved
// https://leetcode.com/problems/remove-element/description/
public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int i = 0; // reading index
        int j = 0; // writing index
        bool needSwap = false;

        while (i < nums.Length) {
           
           // write
           if (needSwap && nums[i] != val) {
               int temp = nums[j];
               nums[j] = nums[i];
               nums[i] = temp;

               Console.WriteLine(" SWAP ");
               Console.WriteLine(i);           
               Console.WriteLine(j);               
               Console.WriteLine(" ");
               needSwap = false;
           } else j = i;

           Console.WriteLine(i);           
           Console.WriteLine(j);
           Console.WriteLine(nums[i]); 
           Console.WriteLine(" ");
                                            
           // point to the writing index           
           if (!needSwap && nums[i] == val ) {                         
               j = i;
               needSwap = true;
           }
           
           i++;
        }

        int k = 0;
        i = 0;
        while (i < nums.Length) {         

          if (nums[i] != val)
            k++;

          i++;
        }

        return k;            
    }
}