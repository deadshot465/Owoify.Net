using System.Collections.Generic;
using System.Linq;
// ReSharper disable InconsistentNaming

namespace Owoify
{
    internal static partial class Utility
    {
        internal static IEnumerable<T> InterleaveArrays<T>(IEnumerable<T> a, IEnumerable<T> b)
        {
            var arr = new List<T>();
            var observed = a.ToList();
            var other = b.ToList();

            while (observed.Any())
            {
                arr.Add(observed[0]);
                observed.RemoveAt(0);
                var temp = observed;
                observed = other;
                other = temp;
            }

            if (other.Count > 0)
                arr = arr.Concat(other).ToList();
            return arr;
        }
    }
}
