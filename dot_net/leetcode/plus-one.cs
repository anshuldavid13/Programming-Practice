// https://leetcode.com/problems/plus-one/

public class Solution {
    public int[] PlusOne(int[] digits) {
        
        
        int rem = 1; int mod=0, i= digits.Length-1;
        do
        {
            digits[i] = (digits[i]+rem)%10;
            rem = (digits[i]+rem)%10;           
            i--;
        }while(rem == 1 && i> -1);
        
        if(i==-1 && rem ==1)
        {
            int[] newD = new int[digits.Length+1];
            newD[0]=1;
            for(int k=1;k<newD.Length;k++)
                newD[k]=digits[k-1];
            
            return newD;
            
        }
        return digits;
        
    }
}
