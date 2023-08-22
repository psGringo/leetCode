// https://leetcode.com/problems/plus-one/submissions/
public class Solution {
public int[] PlusOne(int[] digits)
        {
            int[] toadd = new int[digits.Length];
            toadd[toadd.Length - 1] = 1;
            var numbers = new Stack<int>();            
            
            int inMemory = 0;
            for (int i = digits.Length - 1; i >=0; i--)
            {                
                int number = digits[i] + toadd[i] + inMemory;
                if (number > 9)
                {
                    string numberStr = number.ToString();                    
                    inMemory = numberStr[0] - '0';
                    numbers.Push(numberStr[1] - '0');
                }
                else
                {
                    inMemory = 0;
                    numbers.Push(number);                    
                }
            }

            if (inMemory > 0)
              numbers.Push(inMemory);

            int[] res = new int[numbers.Count];
            int j = 0;

            while (numbers.Count > 0)
            {

                var number = numbers.Pop();
                res[j] = number;
                j++;                
            }


            return res;
        }
}