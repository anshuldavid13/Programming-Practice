// https://leetcode.com/problems/maximum-subarray/

public class Solution {
    public int MaxSubArray(int[] nums) {
        
        int max=nums[0];
        
        if(nums.Count() ==1)
            return max;
        
        int i=0;
        for(i=0;i<nums.Count()-1;i++)
        {
            int ct=nums[i];
            if(max < ct)
                max= ct;
            for(int j=i+1;j<nums.Count();j++)
            {
                if(max < ct+nums[j])
                {
                    max=ct+nums[j];                   
                }
                 ct=ct+nums[j];
            }
            if(max < ct)
                max= ct;
        }
        if(max < nums[i])
                max= nums[i];
        return max;
    }
}
