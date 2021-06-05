// https://leetcode.com/problems/license-key-formatting/

public class Solution {
    public string LicenseKeyFormatting(string s, int k) {
                
        int j=0;
        string ot= "";
        for(int i= s.Length-1 ; i>=0 ; i--)
        {
            if(s[i] == '-')
                continue;
            
            if(j==k)
            {
                ot = s[i] +"-" +  ot;
                j=0;
            }
            else
            {
                ot = s[i] + ot;
            }
            j++;
        }
        return ot.ToUpper();
        
    }
}
