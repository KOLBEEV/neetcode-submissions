public class Solution
{
    public List<List<string>> GroupAnagrams(string[] strs)
    {
        Dictionary<string, List<string>> groups = new Dictionary<string, List<string>>();

        foreach (string str in strs)
        {
            string key = string.Join("", str.Order());

            if (groups.ContainsKey(key))
            {
                groups[key].Add(str);
                continue;
            }

            groups[key] = [str];
        }

        List<string> keys = groups.Keys.OrderBy(key => groups[key].Count).ToList();
        List<List<string>> result = new List<List<string>>();

        foreach (string key in keys)
        {
            result.Add(groups[key]);
        }

        return result;
    }
}