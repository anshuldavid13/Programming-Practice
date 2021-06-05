/*https://leetcode.com/problems/find-the-town-judge/*/

public class Solution {
    public int FindJudge(int n, int[][] trust) {
        
        var tr= new List<int>[n+1];
        
        for(int i=0;i<n;i++)
            tr[i] = new List<int>();
        
      /*  if(trust.GetLength(0) == 0 && n!=1)
            return -1; */
     
        for(int i=0;i<trust.GetLength(0);i++)
        { 
            tr[trust[i][0]-1].Add(trust[i][1]-1);
           // Console.WriteLine(i+" "+trust[i][0]+" "+trust[i][1]);
        }
        
     /*   for(int i=0;i<n;i++)
         {
            Console.Write("i="+i+" ");  
            foreach(int k in tr[i])
                Console.Write(k+" ");     
             Console.WriteLine();
         } */
        
       
         for(int i=0;i<n;i++)
         {
              int y=0;
           if(tr[i].Count==0)
           {
               for(int j=0;j<n;j++)
               {
                   if(!tr[j].Contains(i) && j!=i)
                   {
                        y=1;
                       break;                      
                   }
               }
               if(y==0)
                 return i+1;
           }
         }
        return -1;
    }
    
}