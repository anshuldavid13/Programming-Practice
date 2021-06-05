/* https://leetcode.com/problems/count-primes/ */

class Solution {
    LinkedList<Integer> prime = new LinkedList<Integer>();
    
    public int countPrimes(int n) {
        
        if(n==0)       
            return 0;
        if(n==1)
            return 0;
        if(n==2)
            return 0;
        
        int count=1;
        //HashMap<Integer,Integer> prime = new HashMap<Integer,Integer>();
        
        prime.add(2);
        
        for (int i=3;i<n;i++)
        {
            count= count+isPrime(i);
        }
        return count;
        
    }
    
    public int isPrime(int n)
    {
       
        for(int i : prime)
        {
            if(n%i==0)
                return 0;
        }
        prime.add(n);
        return 1;
    }
}
