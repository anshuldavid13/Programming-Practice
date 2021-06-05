// https://leetcode.com/problems/valid-parentheses/

public class Solution {
    public bool IsValid(string s) {
        Stack<char> st = new Stack<char>();
        
        for(int i=0;i<s.Length;i++)
        {
            if(s[i] == '(' || s[i] == '{' || s[i] == '[')
            {
                st.Push(s[i]);
            }
            else if(st.Count == 0)
            {
                return false;
            }
            else if(s[i] == ')')
            {
                if(st.Pop() != '(')
                    return false;
                    
            }
            else if(s[i] == '}')
            {
                if(st.Pop() != '{')
                    return false;
            }
            else if(s[i] == ']')
            {
                if(st.Pop() != '[')
                    return false;
            }
        }
        
        if(st.Count > 0)
            return false;
        
        return true;
    }
}
