public class Solution {
    public string MergeAlternately(string word1, string word2) {
        /*for(int i = 0; (i < word1.Length || i < word2.Length); i++)
        {
            if(i < word1.Length)
                {r.Append(word1[i]);}
            if(i < word2.Length)
                {r.Append(word2[i]);}
           
        }*/
        var r = string.Concat(word1.Zip(word2, (c1, c2) => c1.ToString() + c2.ToString()));
        if (word2.Length != word1.Length)
        {
            var remaining = word1.Length > word2.Length ? word1.Substring(word2.Length) : word2.Substring(word1.Length);
     return (r + remaining);
 }
return r;
    }
}