//  https://leetcode.com/problems/verifying-an-alien-dictionary/

public class Solution {
    
    Dictionary<char,int> dict;
    
    public bool IsAlienSorted(string[] words, string order) {
            
        dict = new Dictionary<char,int>();
        int k=-1;
        foreach(char a in order)
            dict.Add(a,++k);
        
        if(words.Count() == 1)
            return true;
        
        for(int i=0;i<words.Count()-1;i++)
        {
            if(!comp(words[i],words[i+1]))
                return false;
        }
        
        return true;
        
    }
    
    public bool comp(string wMin, string wMax) 
    {
        if(dict[wMin[0]]<dict[wMax[0]])
            return true;
        
        int k = wMax.Length;
        for(int i=0;i<wMin.Length;i++)
        {
            if(i > k-1)
                return false;
            
            if(dict[wMin[i]]>dict[wMax[i]])
                 return false;
            
            if(dict[wMin[i]]<dict[wMax[i]])
                 return true;
            
        }
        return true;
    }
}
