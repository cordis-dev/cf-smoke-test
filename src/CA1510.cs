using System;

namespace StyleCopAnalyzers.CLI.tests
{
    internal class CA1510
    {
        public void M(string arg)
        {
            if (arg is null)
                throw new ArgumentNullException(nameof(arg));
        }
    }
}
