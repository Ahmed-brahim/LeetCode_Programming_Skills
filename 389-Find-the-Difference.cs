public class Solution {
    public char FindTheDifference(string s, string t)
    {
            int[] CharNum = new int[26];
            if(s.Length == 0)
            {
                return t[0];
            }
            foreach (var c in s)
            {
               CharNum[c - 'a']++;
            }
            foreach (var c in t)
            {
                CharNum[c - 'a']++;
            }
            int i = 0;
            foreach(var c in CharNum)
            {
                if (c % 2 != 0)
                    return (char)('a' + i);
                i++;
            }
            return (char)(0);
        }
}

