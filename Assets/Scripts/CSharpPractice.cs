using System.Collections.Generic;

public class CsharpPractice
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    private Dictionary<string,string>localization = new Dictionary<string, string>()
    {
        {"Apple", "蘋果"},
        {"Banana","香蕉" },
    };
    public string GetLocalizationText(string key)
    {
        var value = localization[key];
        return value;
    }
}
