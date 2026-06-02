public class Solution {
    public bool IsAnagram(string s, string t) 
    {
        int[] result = new int[26];
        if(s.Length != t.Length)
            return false;        

        for(int i = 0; i < t.Length ; i++)
        {
            result[s[i] - 'a']++;
            result[t[i] - 'a']--;
        }

        foreach(var i in result)
        {
            if(i != 0)
                return false;
        }
        return true;
    }
}
