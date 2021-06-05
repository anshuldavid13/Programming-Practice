public class Solution {
    public string RemoveDuplicates(string s) {
        
        Stack<char> st= new Stack<char>();
        string t= "";
        
        if(s.Length == 0)
            return s;
        
        st.Push(s[0]);
        
        for(int i=1;i<s.Length;i++)
        {
            Console.Write(s[i]+" ");
            if(st.Count>0 && st.Peek() == s[i])
            {
                char p = st.Pop();
                continue;
            }
            else
            {
                st.Push(s[i]);
            }
        }
        
        while(st.Count > 0)
        {
            t = st.Pop()+t;
        }
        
        return t;
    }
}
