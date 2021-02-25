using System;
using System.Linq.Expressions;

namespace AOTLinq
{
    public static partial class AotEnumerableInstanceExtensions
    {
        public static partial AotEnumerableInstance<TOut> Select<TIn, TOut>(this AotEnumerableInstance<TIn> instance, Expression<Func<TIn, TOut>> exprFunc);

        public static partial T[] ToArray<T>(this AotEnumerableInstance<T> instance);

        // Dummy area

        public static partial AotEnumerableInstance<TOut> Select<TIn, TOut>(this AotEnumerableInstance<TIn> instance, Expression<Func<TIn, TOut>> exprFunc)
        {
            return default;
        }

        public static partial T[] ToArray<T>(this AotEnumerableInstance<T> instance)
        {
            return Array.Empty<T>();
        }
    }
}
