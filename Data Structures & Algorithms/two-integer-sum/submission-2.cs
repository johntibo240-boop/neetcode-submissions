public class Solution {
    public int[] TwoSum(int[] nums, int target) 
    {
      Dictionary<int, int> seen = new();
      for(int i = 0; i < nums.Length;i++)
      {
        int complement = target - nums[i];
        if(seen.ContainsKey(complement))
        {
            int otherindex = seen[complement];
            return new int[]{otherindex , i};
        }
        seen.Add(nums[i], i);
      }
      return new int[]{-1,-1};
    }
}
