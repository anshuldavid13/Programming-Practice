// https://leetcode.com/problems/intersection-of-two-arrays/

public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) {
        
        var n1 = new HashSet<int>();
        for(int i=0;i<nums1.Count();i++)
        {
            n1.Add(nums1[i]);
        }
        
        var n2  = new HashSet<int>();
        
       
        for(int j=0;j<nums2.Count();j++)
        {
            if(n1.Contains(nums2[j]))
                n2.Add(nums2[j]);
        }
        
         int k =0;
        var fin  = new int[n2.Count()];
        foreach(int x in n2)
        {
            fin[k]=x;
            k++;
        }
        
        return fin;
        
    }
}
