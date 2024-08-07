// https://leetcode.com/problems/isomorphic-strings/submissions/1221140079

public class Solution {
    public bool IsIsomorphic(string s, string t) {
        char[] charArrayS = s.ToCharArray();
        char[] charArrayT = t.ToCharArray();

        Dictionary<char, char> charCount = new Dictionary<char, char>();
        char c = 'a';
        for(int i = 0; i < charArrayS.Length; i++)
        {
            if(charCount.ContainsKey(charArrayS[i]) 
            && charCount.TryGetValue(charArrayS[i], out c))
            {
                if(c != charArrayT[i])
                {
                    return false;
                }
            }
            else if(!charCount.ContainsValue(charArrayT[i]))
            {
                charCount.Add(charArrayS[i], charArrayT[i]);
            }
            else
            {
                return false;
            }
        }
        return true;
    }
}