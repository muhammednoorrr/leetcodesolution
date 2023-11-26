public class Solution {
    public IList<int> FindWordsContaining(string[] words, char x) {
        var rs = new List<int>();
for (int i = 0; i < words.Length; i++)
{
    if (words[i].IndexOf(x) > -1) rs.Add(i);
}
return rs;
    }
}