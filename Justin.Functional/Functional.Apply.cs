using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Justin.Functional
{
    /// <summary>
    /// 部分应用
    /// </summary>
    static partial class Functional
    {
        public static Func<R> 
            Apply<T, R>(this Func<T, R> fn, T arg1)
        {
            return () => fn(arg1);
        }
        public static Func<T2, R> 
            Apply<T1, T2, R>(this Func<T1, T2, R> fn, T1 arg1)
        {
            return (arg2) => fn(arg1, arg2);
        }
        public static Func<T2, T3, R>
            Apply<T1, T2, T3, R>(this Func<T1, T2, T3, R> fn, T1 arg1)
        {
            return (arg2, arg3) => fn(arg1, arg2, arg3);
        }
        public static Func<T2, T3, T4, R>
            Apply<T1, T2, T3, T4, R>(this Func<T1, T2, T3, T4, R> fn, T1 arg1)
        {
            return (arg2, arg3, arg4) => fn(arg1, arg2, arg3, arg4);
        }
        public static Func<T2, T3, T4, T5, R>
            Apply<T1, T2, T3, T4, T5, R>(this Func<T1, T2, T3, T4, T5, R> fn, T1 arg1)
        {
            return (arg2, arg3, arg4, arg5) => fn(arg1, arg2, arg3, arg4, arg5);
        }
        public static Func<T2, T3, T4, T5, T6, R>
            Apply<T1, T2, T3, T4, T5, T6, R>(this Func<T1, T2, T3, T4, T5, T6, R> fn, T1 arg1)
        {
            return (arg2, arg3, arg4, arg5, arg6) => fn(arg1, arg2, arg3, arg4, arg5, arg6);
        }
        public static Func<T2, T3, T4, T5, T6, T7, R>
            Apply<T1, T2, T3, T4, T5, T6, T7, R>(this Func<T1, T2, T3, T4, T5, T6, T7, R> fn, T1 arg1)
        {
            return (arg2, arg3, arg4, arg5, arg6, arg7) => fn(arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        }

        public static Action
            Apply<T>(this Action<T> fn, T arg1)
        {
            return () => fn(arg1);
        }
        public static Action<T2>
            Apply<T1, T2>(this Action<T1, T2> fn, T1 arg1)
        {
            return (arg2) => fn(arg1, arg2);
        }
        public static Action<T2, T3>
            Apply<T1, T2, T3>(this Action<T1, T2, T3> fn, T1 arg1)
        {
            return (arg2, arg3) => fn(arg1, arg2, arg3);
        }
        public static Action<T2, T3, T4>
            Apply<T1, T2, T3, T4>(this Action<T1, T2, T3, T4> fn, T1 arg1)
        {
            return (arg2, arg3, arg4) => fn(arg1, arg2, arg3, arg4);
        }
        public static Action<T2, T3, T4, T5>
            Apply<T1, T2, T3, T4, T5>(this Action<T1, T2, T3, T4, T5> fn, T1 arg1)
        {
            return (arg2, arg3, arg4, arg5) => fn(arg1, arg2, arg3, arg4, arg5);
        }
        public static Action<T2, T3, T4, T5, T6>
            Apply<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> fn, T1 arg1)
        {
            return (arg2, arg3, arg4, arg5, arg6) => fn(arg1, arg2, arg3, arg4, arg5, arg6);
        }
        public static Action<T2, T3, T4, T5, T6, T7>
            Apply<T1, T2, T3, T4, T5, T6, T7>(this Action<T1, T2, T3, T4, T5, T6, T7> fn, T1 arg1)
        {
            return (arg2, arg3, arg4, arg5, arg6, arg7) => fn(arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        }
    }
}
