public class Solution
{
    const string Delimiter = "%%";
    const string Empty_List = "%_";

    public string Encode(IList<string> strs)
    {
        if (strs.Count == 0)
        {
            return Empty_List;
        }

        string result = string.Empty;
        int count = 0;

        foreach (string item in strs)
        {
            if (count > 0)
            {
                result += Delimiter + item;
            } else
            {
                result += item;
            }

            count++;
        }

        return result;
    }

    public List<string> Decode(string s)
    {
        if (s == Empty_List)
        {
            return new List<string>();
        }

        List<string> result = new List<string>();

        foreach (string item in s.Split(separator: Delimiter))
        {
            result.Add(item);
        }

        return result;
    }
}
