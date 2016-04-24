using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Justin.Functional
{
    /// <summary>
    /// 参数逆序
    /// </summary>
    static partial class Functional
    {
        public static Func<T2, Func<T1, TR>> 
            Swap<T1, T2, TR>(this Func<T1, Func<T2, TR>> fn)
        {
            return arg2 => arg1 => fn(arg1)(arg2);
        }
        public static Func<T3, Func<T2, Func<T1, TR>>>
            Swap<T1, T2, T3, TR>(this Func<T1, Func<T2, Func<T3, TR>>> fn)
        {
            return arg3 => arg2 => arg1 => fn(arg1)(arg2)(arg3);
        }
        public static Func<T4, Func<T3, Func<T2, Func<T1, TR>>>>
            Swap<T1, T2, T3, T4, TR>(this Func<T1, Func<T2, Func<T3, Func<T4, TR>>>> fn)
        {
            return arg4 => arg3 => arg2 => arg1 => fn(arg1)(arg2)(arg3)(arg4);
        }
        public static Func<T5, Func<T4, Func<T3, Func<T2, Func<T1, TR>>>>>
            Swap<T1, T2, T3, T4, T5, TR>(this Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, TR>>>>> fn)
        {
            return arg5 => arg4 => arg3 => arg2 => arg1 => fn(arg1)(arg2)(arg3)(arg4)(arg5);
        }
        public static Func<T6, Func<T5, Func<T4, Func<T3, Func<T2, Func<T1, TR>>>>>>
            Swap<T1, T2, T3, T4, T5, T6, TR>(this Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, TR>>>>>> fn)
        {
            return arg6 => arg5 => arg4 => arg3 => arg2 => arg1 => fn(arg1)(arg2)(arg3)(arg4)(arg5)(arg6);
        }
        public static Func<T7, Func<T6, Func<T5, Func<T4, Func<T3, Func<T2, Func<T1, TR>>>>>>>
            Swap<T1, T2, T3, T4, T5, T6, T7, TR>(this Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, TR>>>>>>> fn)
        {
            return arg7 => arg6 => arg5 => arg4 => arg3 => arg2 => arg1 => fn(arg1)(arg2)(arg3)(arg4)(arg5)(arg6)(arg7);
        }

        public static Func<T2, Action<T1>>
            Swap<T1, T2>(this Func<T1, Action<T2>> fn)
        {
            return arg2 => arg1 => fn(arg1)(arg2);
        }
        public static Func<T3, Func<T2, Action<T1>>>
            Swap<T1, T2, T3>(this Func<T1, Func<T2, Action<T3>>> fn)
        {
            return arg3 => arg2 => arg1 => fn(arg1)(arg2)(arg3);
        }
        public static Func<T4, Func<T3, Func<T2, Action<T1>>>>
            Swap<T1, T2, T3, T4>(this Func<T1, Func<T2, Func<T3, Action<T4>>>> fn)
        {
            return arg4 => arg3 => arg2 => arg1 => fn(arg1)(arg2)(arg3)(arg4);
        }
        public static Func<T5, Func<T4, Func<T3, Func<T2, Action<T1>>>>>
            Swap<T1, T2, T3, T4, T5>(this Func<T1, Func<T2, Func<T3, Func<T4, Action<T5>>>>> fn)
        {
            return arg5 => arg4 => arg3 => arg2 => arg1 => fn(arg1)(arg2)(arg3)(arg4)(arg5);
        }
        public static Func<T6, Func<T5, Func<T4, Func<T3, Func<T2, Action<T1>>>>>>
            Swap<T1, T2, T3, T4, T5, T6>(this Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Action<T6>>>>>> fn)
        {
            return arg6 => arg5 => arg4 => arg3 => arg2 => arg1 => fn(arg1)(arg2)(arg3)(arg4)(arg5)(arg6);
        }
        public static Func<T7, Func<T6, Func<T5, Func<T4, Func<T3, Func<T2, Action<T1>>>>>>>
            Swap<T1, T2, T3, T4, T5, T6, T7>(this Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Action<T7>>>>>>> fn)
        {
            return arg7 => arg6 => arg5 => arg4 => arg3 => arg2 => arg1 => fn(arg1)(arg2)(arg3)(arg4)(arg5)(arg6)(arg7);
        }

        public static Func<T2, T1, R> 
            Swap<T1, T2, R>(this Func<T1, T2, R> fn)
        {
            return (arg2, arg1) => fn(arg1, arg2);
        }
        public static Func<T3, T2, T1, R> 
            Swap<T1, T2, T3, R>(this Func<T1, T2, T3, R> fn)
        {
            return (arg3, arg2, arg1) => fn(arg1, arg2, arg3);
        }
        public static Func<T4, T3, T2, T1, R> 
            Swap<T1, T2, T3, T4, R>(this Func<T1, T2, T3, T4, R> fn)
        {
            return (arg4, arg3, arg2, arg1) => fn(arg1, arg2, arg3, arg4);
        }
        public static Func<T5, T4, T3, T2, T1, R> 
            Swap<T1, T2, T3, T4, T5, R>(this Func<T1, T2, T3, T4, T5, R> fn)
        {
            return (arg5, arg4, arg3, arg2, arg1) => fn(arg1, arg2, arg3, arg4, arg5);
        }
        public static Func<T6, T5, T4, T3, T2, T1, R> 
            Swap<T1, T2, T3, T4, T5, T6, R>(this Func<T1, T2, T3, T4, T5, T6, R> fn)
        {
            return (arg6, arg5, arg4, arg3, arg2, arg1) => fn(arg1, arg2, arg3, arg4, arg5, arg6);
        }
        public static Func<T7, T6, T5, T4, T3, T2, T1, R> 
            Swap<T1, T2, T3, T4, T5, T6, T7, R>(this Func<T1, T2, T3, T4, T5, T6, T7, R> fn)
        {
            return (arg7, arg6, arg5, arg4, arg3, arg2, arg1) => fn(arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        }

        public static Action<T2, T1> 
            Swap<T1, T2>(this Action<T1, T2> fn)
        {
            return (arg2, arg1) => fn(arg1, arg2);
        }
        public static Action<T3, T2, T1> 
            Swap<T1, T2, T3>(this Action<T1, T2, T3> fn)
        {
            return (arg3, arg2, arg1) => fn(arg1, arg2, arg3);
        }
        public static Action<T4, T3, T2, T1> 
            Swap<T1, T2, T3, T4>(this Action<T1, T2, T3, T4> fn)
        {
            return (arg4, arg3, arg2, arg1) => fn(arg1, arg2, arg3, arg4);
        }
        public static Action<T5, T4, T3, T2, T1> 
            Swap<T1, T2, T3, T4, T5>(this Action<T1, T2, T3, T4, T5> fn)
        {
            return (arg5, arg4, arg3, arg2, arg1) => fn(arg1, arg2, arg3, arg4, arg5);
        }
        public static Action<T6, T5, T4, T3, T2, T1> 
            Swap<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> fn)
        {
            return (arg6, arg5, arg4, arg3, arg2, arg1) => fn(arg1, arg2, arg3, arg4, arg5, arg6);
        }
        public static Action<T7, T6, T5, T4, T3, T2, T1> 
            Swap<T1, T2, T3, T4, T5, T6, T7>(this Action<T1, T2, T3, T4, T5, T6, T7> fn)
        {
            return (arg7, arg6, arg5, arg4, arg3, arg2, arg1) => fn(arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        }
    }
}
