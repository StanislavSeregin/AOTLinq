using System;
using System.Collections.Generic;
using System.Text;

namespace AOTLinq
{
    public ref partial struct AotEnumerableEnumerator<T>
    {
        public T Current { get; private set; }

        public AotEnumerableEnumerator<T> GetEnumerator() => this;

        public partial bool MoveNext();
    }

    public ref partial struct AotEnumerableEnumerator<T>
    {
        public AotEnumerableEnumerator(string _)
        {
            Current = default;
        }

        public partial bool MoveNext()
        {
            return false;
        }
    }
}
