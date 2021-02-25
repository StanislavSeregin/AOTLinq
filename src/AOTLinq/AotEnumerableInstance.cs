using System;
using System.Collections.Generic;
using System.Text;

namespace AOTLinq
{
    public partial struct AotEnumerableInstance<T>
    {
        public partial AotEnumerableEnumerator<T> GetEnumerator();
    }

    // Dummy

    public partial struct AotEnumerableInstance<T>
    {
        public partial AotEnumerableEnumerator<T> GetEnumerator()
        {
            return default;
        }
    }
}
