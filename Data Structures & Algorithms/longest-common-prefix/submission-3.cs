public class Solution 
{
    public string LongestCommonPrefix(string[] strs) 
    {
       string prefix = strs[0];
       for(int i = 1; i < strs.Length; i++)
       {
            int length = Math.Min(prefix.Length, strs[i].Length);
            int j = 0;
            for(; j < length; j++)
            {          
                if(prefix[j] != strs[i][j])
                {
                    prefix = prefix.Substring(0, j);
                    break;
                }
            }
            prefix = prefix.Substring(0, j);

       }
       return prefix;
    }
}