public class Solution {
    public void Rotate(int[][] a) {
        
        int n = a[0].Length-1;
        Console.Write(" n"+n);
       int temp=0;
       
        
        for(int i=0;i<=n;i++)
            for(int j=0;j<=n && i+j!=n;j++)
            {
                Console.Write(" "+i+j+"=="+(n-j)+(n-i));
                temp = a[i][j];
                a[i][j]=a[n-j][n-i];
                a[n-j][n-i] = temp;
            }
        Console.WriteLine();
         for(int i=0;i<=n/2;i++)
         {            
            for(int j=0;j<=n;j++)
            {
                Console.Write(" "+i+j+"=="+(n-i)+(j));
                temp = a[i][j];
                a[i][j]=a[n-i][j];
                a[n-i][j] = temp;
            } 
             
         }
    }
}
