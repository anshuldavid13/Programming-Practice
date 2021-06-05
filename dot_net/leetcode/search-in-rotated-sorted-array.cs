// https://leetcode.com/problems/search-in-rotated-sorted-array

class Solution {
    public int search(int[] nums, int key) {
        int pivot=-1;
        for(int i=0;i<nums.length-1;i++)
            if(nums[i]>nums[i+1])
            {
                pivot=i+1;
                break;
            }
        if(pivot>0)
        {
            if(key>=nums[0] && key<=nums[pivot-1])
                return BS(nums,0,pivot-1,key);
            else
                return BS(nums,pivot,nums.length-1,key);
        }
        else
            return BS(nums,0,nums.length-1,key);
            
    }
    
    public int BS(int[] arr,int s,int e, int key)
    {
        int m;
        
        if(s<=e)
            m=(s+e)/2;
        else
            return -1;
        
        if(arr[m]== key)
            return m;
        
        if(key<arr[m])
            return BS(arr,s,m-1,key);
        else
            return BS(arr,m+1,e,key);
        
    
    }
}
