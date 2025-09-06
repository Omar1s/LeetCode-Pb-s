public class Solution {
    public bool ContainsDuplicate(int[] nums) {
            int maxV=-1;
             HashSet<int> sol = new HashSet<int>();
            

        for(int i=0;i<nums.Length;i++){
            sol.Add(nums[i]);
        }
                 return (!(nums.Length==sol.Count));

    }
}