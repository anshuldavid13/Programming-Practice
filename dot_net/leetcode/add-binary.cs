// https://leetcode.com/problems/add-binary/

public class Solution {
    public string AddBinary(string a, string b) {
        
        int[] a1;
        int[] b1;
        string c="";
        
        if(a.Length <= b.Length)
        {
            a1 = new int[a.Length];
            b1 = new int[b.Length];
            
            for(int i=a.Length-1;i>=0;i--)
                 a1[a.Length-1-i] = (int)Char.GetNumericValue(a[i]);
            for(int j=b.Length-1;j>=0;j--)
                 b1[b.Length-1-j] = (int)Char.GetNumericValue(b[j]);   
        }
        else
        {
            a1 = new int[b.Length];
            b1 = new int[a.Length];
            
            for(int i=a.Length-1;i>=0;i--)
                 b1[a.Length-1-i] = (int)Char.GetNumericValue(a[i]);
            for(int j=b.Length-1;j>=0;j--)
                 a1[b.Length-1-j] = (int)Char.GetNumericValue(b[j]);   
        }
        
        int k=0;
        int sum=0,rem=0;
        for(k=0;k<a1.Length;k++)
        {
            sum = a1[k]+b1[k]+rem;
            Console.Write(" a1[k]"+a1[k]+" b1[k]"+b1[k]+" ");
            if(sum <= 1)
            {
                c=sum+c;
                rem=0;
            }
            else if(sum==2)
            {
                c="0"+c;
                rem=1;
            }
            else if(sum==3)
            {
                c="1"+c;
                rem=1;
            }  
            Console.WriteLine(sum+" c"+c+" rem"+rem);
        }
        
        while(k<b1.Length)
        {
             sum = b1[k]+rem;
            if(sum <= 1)
            {
                c=sum+c;
                rem=0;
            }
            else if(sum==2)
            {
                c="0"+c;
                rem=1;
            }
            k++;
        }
        
        if(rem == 1)
            c="1"+c;    
        
        return c;
    }
}
