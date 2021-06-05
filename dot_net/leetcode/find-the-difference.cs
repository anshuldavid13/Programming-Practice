// https://leetcode.com/problems/find-the-difference/

public class Solution {
    public char FindTheDifference(string s, string t) {
        
        var sc= new Dictionary<char,int>();
        var tc= new Dictionary<char,int>();
        
        foreach(char c in s)
        {
            if(sc.ContainsKey(c))
                sc[c] = sc[c]+1;
            else
                sc.Add(c,1);
        }

        foreach(char x in t)
        {
            if(tc.ContainsKey(x))
                tc[x] = tc[x]+1;
            else
                tc.Add(x,1);
        }
        
        foreach(var i in tc)
        {
            if(!sc.ContainsKey(i.Key))
                return i.Key;
            if(sc[i.Key] != tc[i.Key])
                return i.Key;
        }
        
        return ' ';
    }
}
