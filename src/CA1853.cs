namespace ConsoleApp6
{
    internal class CA1853
    {
        public void Positive()
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            var key = "1";
            if (dict.ContainsKey(key)) // OK TO REPORT
            {
                dict.Remove(key);
            }
        }

        public void Negative()
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            var key = "1";
            if (dict.ContainsKey(key)) // SHOULD NOT BE REPORTED
            {
				dict.Remove(key);
                System.Console.WriteLine("EXISTS");
            }
        }   
    }
}
