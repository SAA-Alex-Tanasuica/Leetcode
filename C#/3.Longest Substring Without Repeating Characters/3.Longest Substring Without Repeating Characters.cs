public class Solution {
    public int LengthOfLongestSubstring(string s) {
        var longestSubstring = "";
        var maxLength = -1;

        if(s.Length == 0)
        {
            return 0;
        }
        if(s.Length == 1)
        {
            return 1;
        }
        foreach(char c in s)
        {
            var current = c + "";

            if(longestSubstring.Contains(current))
            {
                longestSubstring = longestSubstring.Substring(longestSubstring.IndexOf(current) + 1);
            }
            longestSubstring = longestSubstring + c;
            maxLength = Math.Max(maxLength, longestSubstring.Length);
        }
        return maxLength;
    }
}