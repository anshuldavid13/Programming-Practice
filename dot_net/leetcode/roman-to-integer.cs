// https://leetcode.com/problems/roman-to-integer/

public class Solution {
    public int RomanToInt(string s) {
        
        IDictionary<char,int> nn = new Dictionary<char,int>();        
        nn.Add('I',1);
        nn.Add('V',5);
        nn.Add('X',10);
        nn.Add('L',50);
        nn.Add('C',100);
        nn.Add('D',500);
        nn.Add('M',1000);
        
        int fullC=0;
        int tem=0,i1;
        
        for(int i=0;i<s.Length;i++)
        {
            char a = s[i];
            i1= nn[a];            
            
            if((i+1)<s.Length && i1<nn[s[i+1]])
            {
                tem = nn[s[i+1]] - i1;
                i++;
            }
            else
                tem= i1;
            
            fullC = fullC+tem;
        }
        return fullC;
    }
}
