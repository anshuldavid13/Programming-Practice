/* https://leetcode.com/problems/count-primes/ */

class Solution {
    
    public int countPrimes(int n) {
        
        if(n==0)       
            return 0;
        if(n==1)
            return 0;
        if(n==2)
            return 0;
                
        var prime = new boolean[n];
        int count = 0;
        
        for (int i=2;i<n;i++)
        {
           if(!prime[i])
           {
               count++;
           // System.out.print(i+" ");
           }
            else
                continue;
            
           for (int j=2;(i*j)<n;j++)
           {
               prime[i*j] = true;
           }
        }
        return count;
        
    }
    
   /* public int isPrime(int n)
    {
       
        for(int i : prime)
        {
            if(i > Math.sqrt(n))
                break;
            
            if(n%i==0)
                return 0;
            
        }
        prime.add(n);
        return 1;
    } */
}
