/* https://leetcode.com/problems/longest-word-in-dictionary/ */

public class Solution {
    public string LongestWord(string[] words) {
        
        Array.Sort(words);
        var verif = new HashSet<string>();
        string max="";
        
        foreach(string w in words)
        {
            int l= w.Length;
            if(l==1 || verif.Contains(w.Substring(0,l-1)))
            {
                if(max.Length < l)
                    max = w;
                verif.Add(w);
            }
        }
        return max;
    }
}
