// https://leetcode.com/problems/word-pattern/

class Solution {
    public boolean wordPattern(String pattern, String s) {
        
        HashMap<Character , String > patt = new HashMap <Character,  String>();
        String[] sent = s.split(" ");
        Character t;
        if(pattern.length() != sent.length)
            return false;
        
        for(int i=0;i<pattern.length();i++)
        {
            t= pattern.charAt(i);
            if(patt.containsKey(t))
            {
                if(!sent[i].equals(patt.get(t)))
                    return false;
            }
            else if(patt.containsValue(sent[i]))
            {
               for(Map.Entry<Character, String> m : patt.entrySet())
               {
                   if(m.getValue().equals(sent[i]))
                       if(Character.compare(m.getKey(),t) !=0 )
                           return false;
               }
            }
            else
                patt.put(t,sent[i]);
        }
        return true;
    }
}
