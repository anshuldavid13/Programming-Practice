/* https://leetcode.com/problems/last-stone-weight/ */

public class Solution {
    public int LastStoneWeight(int[] stones) {
        
        if(stones.Length == 1)
        {
            return stones[0];
        }
        Array.Sort(stones);
        while(stones[stones.Length-2] != 0)
        {
            int i= stones.Length-1;
            if(stones[i] == stones[i-1])
            {
                stones[i]=0;
                stones[i-1]=0;
            }
            else if(stones[i-1] < stones[i])
            {
                stones[i] = stones[i] - stones[i-1];
                stones[i-1] = 0;
            }
            Array.Sort(stones);
        }        
        return stones[stones.Length-1];
    }
}
