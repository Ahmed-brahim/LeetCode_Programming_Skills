public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length)
        {
            return false;
        }
        int[] charnum = new int[26];
        int i = 0;
        foreach(char c in s)
        {
            charnum[c - 'a']++;
        }
        i = 0;
        foreach(char c in t)
        {
            charnum[c - 'a']--;
        }
        foreach(int n in charnum)
        {
            if(n != 0)
            {
                return false;
            }
        }
        return true;
    }
}