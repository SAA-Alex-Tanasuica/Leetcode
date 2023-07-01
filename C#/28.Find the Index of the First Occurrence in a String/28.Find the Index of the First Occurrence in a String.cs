public class Solution {
    public int StrStr(string haystack, string needle) {
        int needleLength = needle.Length;
        int haystackLength = haystack.Length;

        for(int i = 0; i <= haystackLength - needleLength; i++)
        {
            if(needle == haystack.Substring(i, needleLength))
            {
                return i;
            }
        }

        return -1;
    }
}