using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomThreadSafety
{
    internal static class CustomRandom
    {
        [ThreadStatic]
        private static Random? _local;

        private static Random Instance => _local ??= new Random();

        internal static int Next() => Instance.Next();
    }
}
