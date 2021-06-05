/* https://leetcode.com/problems/unique-email-addresses/ */

public class Solution {
    public int NumUniqueEmails(string[] emails) {
        
        HashSet<String> fms = new HashSet<String>();
        
        foreach(string t in emails)
        {
            string e =t;
            Console.WriteLine(e+" ");
            
            int at = e.IndexOf("@");
            int pl = e.IndexOf("+");
            
            if(pl >= 0 && pl < at)
               e= e.Remove(pl,at-pl);
            
            while(e.IndexOf(".") >= 0 && e.IndexOf(".") < e.IndexOf("@"))
               e= e.Remove(e.IndexOf("."),1); 
            
             Console.Write(e);
            
            fms.Add(e);
        }
        return fms.Count();
        
    }
}
