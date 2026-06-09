public class Solution {
    public int MajorityElement(int[] nums) 
    {
        Dictionary<int,int> count = new();
        foreach(var i in nums)
        {
            if(!count.ContainsKey(i))
                count[i] = 0;

            count[i]++;
            if(count[i] > nums.Length / 2)
                return i;
        }
        return -1;
    }
}