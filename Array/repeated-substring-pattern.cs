// https://leetcode.com/problems/repeated-substring-pattern/
public class Solution {
    public bool RepeatedSubstringPattern(string s) {

            int minSubstrLength = 1;
            int maxSubstrLength = s.Length / 2;
            StringBuilder sb = new StringBuilder();

            for (int i = minSubstrLength; i <= maxSubstrLength; i++)
            {                
                int substrLength = i;
                string substr = s.Substring(0, substrLength);

                int nTimesRepeat = s.Length / substrLength;             

                sb.Clear();
                for (int j = 0; j < nTimesRepeat; j++)                
                  sb.Append(substr);
                                
                if (s.Equals(sb.ToString()))
                    return true;
            }

            return false;
    }
}