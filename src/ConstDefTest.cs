using System;

namespace StyleCopAnalyzers.CLI.tests
{
    internal class ConstDefTest
    {
        public string GetIconKeyByTypeName(string typeName)
        {
#if LINUX
        return typeName;
#else
            return $"{typeName.ToLowerInvariant()}.png";
#endif
        }

        public void Test()
        {

            Console.WriteLine("Test");
        }
    }
}
