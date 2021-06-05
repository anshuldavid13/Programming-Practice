// https://leetcode.com/problems/fruit-into-baskets/

public class Solution {
    public int TotalFruit(int[] tree) {
  
        int x=tree[0],y=-1,z=1,loc=-1;
        int maxC=0;
                
        for(int i=1;i<tree.Length;i++)
        {
            if(tree[i] != x && y == -1)
            {
                y= tree[i];           
                z++;
            }
            else if(tree[i]==x || tree[i]==y)
                z++;
            else 
            {
                Console.Write(" x"+x+" y"+y+" z"+z);
                x=tree[i-1];
                y=tree[i];
                for(int j=i-1;tree[j]==x; j--)
                {
                    loc=j;
                }
                if(z> maxC)
                    maxC=z;                
                Console.WriteLine(" i"+i+" loc"+loc+" maxC"+z);
                z=i-loc+1; 
            }                
        }
        
        return (maxC>z?maxC:z);        
    }
}
