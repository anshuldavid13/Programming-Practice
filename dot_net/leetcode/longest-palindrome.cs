// https://leetcode.com/problems/longest-palindrome/

public class Solution {
    public int LongestPalindrome(string s) {
        
        var ch = new Dictionary<char,int>();
        
        for(int i=0;i<s.Length;i++)
        {
            if(ch.ContainsKey(s[i]))
                ch[s[i]]=ch[s[i]]+1;
            else
                ch.Add(s[i],1);
        }
        
        int max=0;
        int rem = 0;
        foreach(KeyValuePair<char,int> e in ch)
        {
            max = max + e.Value/2;
            rem = rem + e.Value%2;
        }
        max = max*2;
        if(rem >0)
            max++;
        
        return max;
        
    }
}
