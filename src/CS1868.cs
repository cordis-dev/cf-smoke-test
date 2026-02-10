using System.Collections.Generic;

public class CS1868
{
    public void Run(ISet<string> set)
    {
        if (!set.Contains("Hello World"))
        {
            set.Add("Hello World");
        }
    }
}
