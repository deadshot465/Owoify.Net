using System.Collections.Generic;

namespace Owoify
{
    internal static partial class Utility
    {
        internal static IEnumerable<T> InterleaveArrays<T>(IEnumerable<T> a, IEnumerable<T> b)
        {
            var arr = new List<T>();
            var observed = a.GetEnumerator();
            var other = b.GetEnumerator();

            while (observed.MoveNext())
            {
                arr.Add(observed.Current);
                (observed, other) = (other, observed);
            }

            while (other.MoveNext())
                arr.Add(other.Current);
            return arr;
        }
    }
}
