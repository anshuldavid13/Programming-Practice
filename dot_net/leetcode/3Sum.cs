public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
       
        List<IList<int>> fin = new List<IList<int>>();
        List<int> hs = new List<int>(nums);
        hs.Sort();
      
        for(int i=0;i<hs.Count-2;i++)
        {
            for(int j=i+1;j<hs.Count-1;j++)
            {
                int k = hs.LastIndexOf(0-hs[i]-hs[j]);
                if(k > j)                   
                    fin.Add(new List<int>(){hs[i], hs[j], hs[k]});
                           
                while((j+1)<hs.Count-1 && hs[j] == hs[j+1])
                j++;
                
            }
            while((i+1)<hs.Count-2 && hs[i] == hs[i+1])
                i++;
        }
        
        return fin;
    }
}
