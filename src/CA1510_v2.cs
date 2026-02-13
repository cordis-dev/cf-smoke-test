using System;

namespace StyleCopAnalyzers.CLI.tests
{
    internal class CA1510_v2
    {
        public void M(string arg)
        {
            ArgumentNullException.ThrowIfNull(arg);
        }
    }
}
