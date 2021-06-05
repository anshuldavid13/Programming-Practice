// https://leetcode.com/problems/jump-game/

public class Solution {
    public bool CanJump(int[] nums) {
        
        // return recurJump(nums,0,nums.Length-1,nums[0]) ;  
        
       int i=0;
int maxreach=0;
while(i<nums.Length && i<=maxreach)
{
maxreach=(i+nums[i]>maxreach)?i+nums[i]:maxreach;
i++;
}
return i==nums.Length;
            
    }
    
    public bool recurJump(int[] nums,int curr,int end, int val){
        
        if(curr == end)
        {
            Console.WriteLine(" curr"+curr+" end"+end+" val"+val);
            return true;
        }
        if(val>0 && curr<end)
        {        
        if(curr+val <= end)
            return (recurJump(nums,curr+val,end,nums[curr+val]) || recurJump(nums,curr,end,val-1));
            else
                  return recurJump(nums,curr,end,val-1);
        }
        
        return false;
        
    }
    
}

