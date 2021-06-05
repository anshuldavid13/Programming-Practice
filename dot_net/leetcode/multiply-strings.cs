// https://leetcode.com/problems/multiply-strings/

public class Solution {
    public string Multiply(string num1, string num2) {
        
        //int t= Convert.ToInt32(num1) * Convert.ToInt32(num2);
        //return t.ToString();
        
        int rem=0,k=-1,t,p;
        
        int[] sb = new int[num1.Length+num2.Length];
        
        for(int i=sb.Length-1;i>=0;i--)
            sb[i] = 0;
        
        StringBuilder n1 = new StringBuilder(num1);
        StringBuilder n2 = new StringBuilder(num2);
        
        for(int i=0;i<=num1.Length-1;i++)
           n1[i] = num1[num1.Length-1-i];
        
        for(int i=0;i<=num2.Length-1;i++)
            n2[i] = num2[num2.Length-1-i];
        
        int c1=0,c2=0;
        for(int i=0;i<=num2.Length-1;i++)
        {                       
            rem=0;
            k++;
            for(int j=0;j<=num1.Length-1;j++)
            {
                Console.Write(" n2[i]"+n2[i]+" n1[j]"+n1[j]);
                t= (int)(((Char.GetNumericValue(n2[i]) * Char.GetNumericValue(n1[j]))+rem)%10);
                rem= (int)(((Char.GetNumericValue(n2[i]) * Char.GetNumericValue(n1[j]))+rem)/10);
                
                p = (int)((sb[k+j]+t)%10);
                rem = (int)(rem+((sb[k+j]+t)/10));
                 sb[k+j] = p;    
                
                Console.WriteLine(" i"+i+" j"+j+" t"+t+" p"+p+" rem"+rem+" k"+k+" sb[k+j]"+sb[k+j]);
                c1++;
            }
            
            if(rem>0)
            {sb[k+c1]=rem;
            rem=0;}
            c2++;
            
             Console.Write(" c1="+c1);
            c1=0;
            
        }
        Console.WriteLine(" k+c2="+k+c2);
         if(rem>0)
                sb[k+c2-1]=rem;
        
        
         StringBuilder op = new StringBuilder(sb.Length);
        
        for(int i=sb.Length-1;i>=0;i--)
            op.Append(sb[i]);
        
        
         int g=0;
         while(g<op.Length && op[g]=='0')
        {
             Console.Write(" op="+op +" "+op.Length);
            op.Remove(g,1);
             Console.Write(" g="+g);             
        }
        
        
        return (op.ToString()=="")?"0":op.ToString();
    }
}
