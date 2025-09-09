public class Solution {
public bool IsAnagram(string s, string t)
{
    if (s.Length != t.Length) return false;

    Dictionary<char, int> count = new Dictionary<char, int>();

    foreach (char c in s)
    {
        if (!count.ContainsKey(c)) count[c] = 0;
        count[c]++;
    }

    foreach (char c in t)
    {
        if (!count.ContainsKey(c)) return false;
        count[c]--;
        if (count[c] < 0) return false;
    }

    return true;
}

    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        IList<IList<string>> sol = new List<IList<string>>();
        for (int i = 0; i < strs.Length; i++)
        {
            IList<string> temp = new List<string>();
            if (strs[i] != "-1")
            {
                temp.Add(strs[i]);
            }
            else
            {
                continue;
            }

            for (int j = 0; j < strs.Length; j++)
            {
          
                if (i != j)
                {
    if(IsAnagram(strs[i], strs[j])) {
        temp.Add(strs[j]);
        strs[j] = "-1";
    }
                }
            }
            strs[i] = "-1";
            sol.Add(temp);
        }
        return sol;

    }
}