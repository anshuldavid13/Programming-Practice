// https://leetcode.com/problems/count-and-say/

class Solution {
    public String countAndSay(int n) {
        if(n==1) return "1";
        
        String op=new String("1");
        for(int i=2; i<=n;i++)
        {
           op= sayStr(op); 
        }
        return op;
        
       /* int x=1;
        String op=new String("1");
        
        while(x<n)
        {
            
            int sum=0, num=0;
            int fin=1;
           for(int i=0;i<op.length();i++)
           {
               num = Integer.parseInt(op.charAt(i));
               sum++;
               
               for(int j=i+1;j<op.length();j++)
               {
                   
               }
                fin= sum*10+n;
               
           } 
        } */
    }
    
    public String sayStr(String s) {   //111221
        if(s=="1")
            return "11";
         
        String op=new String();
        int sum=0;
        
        for(int i=0;i<s.length();i++)
           {
            char num = s.charAt(i);
            sum=1;
            int j=i+1;
            while(j<s.length() && s.charAt(i)==s.charAt(j))
            {
                sum++;
                j++;
            }
            op = op+Integer.toString(sum)+num;
           if(sum >1) i=j-1;
        }
      return op;
        
    }
}
