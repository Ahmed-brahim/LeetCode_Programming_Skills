public class Solution {
    public bool RepeatedSubstringPattern(string s) {
        string? sub = new string(string.Empty);
        if (s.Length == 1)
        {
            return false;
        }
        for (int i = (s.Length / 2); i >= 1; i--)
        {
            if (s.Substring(0, i) == s.Substring(i, i))
            {
                sub = s.Substring(0, i);
                if (sub == string.Empty)
                {
                    return false;
                }

                if (s.Length % sub.Length != 0)
                {
                    continue;
                }

                for (int j = 0; j <= (s.Length - sub.Length); j += sub.Length)
                {
                    if (sub != s.Substring(j, sub.Length))
                        return false;
                }

                return true;
            }
        }
        return false;
    }
}