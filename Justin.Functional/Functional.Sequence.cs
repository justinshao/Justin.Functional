using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Justin.Functional
{
    static partial class Functional
    {
        public static IEnumerable<T> Sequence<T>(Func<T, T> next, T startVal, Func<T, bool> end = null)
        {
            if (next == null)
                yield break;

            yield return startVal;

            T val = startVal;
            while(end == null || !end(val = next(val)))
            {
                yield return val;
            }
        }
    }
}
