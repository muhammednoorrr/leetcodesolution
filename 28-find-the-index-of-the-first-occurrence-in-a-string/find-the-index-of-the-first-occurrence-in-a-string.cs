public class Solution {
    public int StrStr(string haystack, string needle) {
        var needleLenght = needle.Length;
        for (int i = 0; i < haystack.Length ; i++)
        {
            if (haystack.Length - i < needleLenght)
            {
                return -1;
            }
            var matchCount = 0;
            var j = 0;
            var initialIndex = i;
            if (haystack[i] == needle[j])
            {
                var k = i;
                for (j = 0; j < needle.Length; j++)
                {
                    if (needle[j] == haystack[k])
                    {
                        k++;
                        matchCount++;
                    }

                    if (needleLenght == matchCount)
                    {
                        return initialIndex;
                    }
                    
                }
            }
        }

        return -1;
    }
}