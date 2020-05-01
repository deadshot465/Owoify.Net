using System.Collections.Generic;
using System.Linq;

namespace Owoify
{
    internal static partial class Utility
    {
        internal static IList<T> InterleaveArrays<T>(IList<T> a, IList<T> b)
        {
            var arr = new List<T>();
            var observed = a;
            var other = b;
            IList<T> temp = null;

            while (observed.Count > 0)
            {
                arr.Add(observed[0]);
                observed.RemoveAt(0);
                temp = observed;
                observed = other;
                other = temp;
            }

            if (other.Count > 0)
                arr.Concat(other);
            return arr;
        }
    }
}
