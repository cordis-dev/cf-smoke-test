namespace ConsoleApp6
{
    internal class CA1853
    {
        public void Positive()
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            var key = "1";
            if (dict.ContainsKey(key))
            {
                dict.Remove(key);
            }
        }

        public void Negative()
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            var key = "1";
            if (dict.ContainsKey(key))
            {
                System.Console.WriteLine("EXISTS");
                dict.Remove(key);
            }
        }   
    }
}
