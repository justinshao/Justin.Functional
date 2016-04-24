using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Justin.Functional
{
    /// <summary>
    /// 柯里化
    /// </summary>
    static partial class Functional
    {
        public static Func<T1, Func<T2, TR>> 
            Curry<T1, T2, TR>(this Func<T1, T2, TR> func)
        {
            return p1 => p2 => func(p1, p2);
        }
        public static Func<T1, Func<T2, Func<T3, TR>>> 
            Curry<T1, T2, T3, TR>(this Func<T1, T2, T3, TR> func)
        {
            return p1 => p2 => p3 => func(p1, p2, p3);
        }
        public static Func<T1, Func<T2, Func<T3, Func<T4, TR>>>> 
            Curry<T1, T2, T3, T4, TR>(this Func<T1, T2, T3, T4, TR> func)
        {
            return p1 => p2 => p3 => p4 => func(p1, p2, p3, p4);
        }
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, TR>>>>> 
            Curry<T1, T2, T3, T4, T5, TR>(this Func<T1, T2, T3, T4, T5, TR> func)
        {
            return p1 => p2 => p3 => p4 => p5 => func(p1, p2, p3, p4, p5);
        }
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, TR>>>>>> 
            Curry<T1, T2, T3, T4, T5, T6, TR>(this Func<T1, T2, T3, T4, T5, T6, TR> func)
        {
            return p1 => p2 => p3 => p4 => p5 => p6 => func(p1, p2, p3, p4, p5, p6);
        }
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, TR>>>>>>>
            Curry<T1, T2, T3, T4, T5, T6, T7, TR>(this Func<T1, T2, T3, T4, T5, T6, T7, TR> func)
        {
            return p1 => p2 => p3 => p4 => p5 => p6 => p7 => func(p1, p2, p3, p4, p5, p6, p7);
        }

        public static Func<T1, Action<T2>>
            Curry<T1, T2>(this Action<T1, T2> action)
        {
            return p1 => p2 => action(p1, p2);
        }
        public static Func<T1, Func<T2, Action<T3>>>
            Curry<T1, T2, T3>(this Action<T1, T2, T3> action)
        {
            return p1 => p2 => p3 => action(p1, p2, p3);
        }
        public static Func<T1, Func<T2, Func<T3, Action<T4>>>>
            Curry<T1, T2, T3, T4>(this Action<T1, T2, T3, T4> action)
        {
            return p1 => p2 => p3 => p4 => action(p1, p2, p3, p4);
        }
        public static Func<T1, Func<T2, Func<T3, Func<T4, Action<T5>>>>>
            Curry<T1, T2, T3, T4, T5>(this Action<T1, T2, T3, T4, T5> action)
        {
            return p1 => p2 => p3 => p4 => p5 => action(p1, p2, p3, p4, p5);
        }
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Action<T6>>>>>>
            Curry<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> action)
        {
            return p1 => p2 => p3 => p4 => p5 => p6 => action(p1, p2, p3, p4, p5, p6);
        }
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Action<T7>>>>>>>
            Curry<T1, T2, T3, T4, T5, T6, T7>(this Action<T1, T2, T3, T4, T5, T6, T7> action)
        {
            return p1 => p2 => p3 => p4 => p5 => p6 => p7 => action(p1, p2, p3, p4, p5, p6, p7);
        }
        
        public static Func<T1, T2, TR> 
            Uncurry<T1, T2, TR>(this Func<T1, Func<T2, TR>> func)
        {
            return (p1, p2) => func(p1)(p2);
        }
        public static Func<T1, T2, T3, TR>
            Uncurry<T1, T2, T3, TR>(this Func<T1, Func<T2, Func<T3, TR>>> func)
        {
            return (p1, p2, p3) => func(p1)(p2)(p3);
        }
        public static Func<T1, T2, T3, T4, TR>
            Uncurry<T1, T2, T3, T4, TR>(this Func<T1, Func<T2, Func<T3, Func<T4, TR>>>> func)
        {
            return (p1, p2, p3, p4) => func(p1)(p2)(p3)(p4);
        }
        public static Func<T1, T2, T3, T4, T5, TR>
            Uncurry<T1, T2, T3, T4, T5, TR>(this Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, TR>>>>> func)
        {
            return (p1, p2, p3, p4, p5) => func(p1)(p2)(p3)(p4)(p5);
        }
        public static Func<T1, T2, T3, T4, T5, T6, TR>
            Uncurry<T1, T2, T3, T4, T5, T6, TR>(this Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, TR>>>>>> func)
        {
            return (p1, p2, p3, p4, p5, p6) => func(p1)(p2)(p3)(p4)(p5)(p6);
        }
        public static Func<T1, T2, T3, T4, T5, T6, T7, TR>
            Uncurry<T1, T2, T3, T4, T5, T6, T7, TR>(this Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, TR>>>>>>> func)
        {
            return (p1, p2, p3, p4, p5, p6, P7) => func(p1)(p2)(p3)(p4)(p5)(p6)(P7);
        }

        public static Action<T1, T2>
            Uncurry<T1, T2>(this Func<T1, Action<T2>> func)
        {
            return (p1, p2) => func(p1)(p2);
        }
        public static Action<T1, T2, T3>
            Uncurry<T1, T2, T3>(this Func<T1, Func<T2, Action<T3>>> func)
        {
            return (p1, p2, p3) => func(p1)(p2)(p3);
        }
        public static Action<T1, T2, T3, T4>
            Uncurry<T1, T2, T3, T4>(this Func<T1, Func<T2, Func<T3, Action<T4>>>> func)
        {
            return (p1, p2, p3, p4) => func(p1)(p2)(p3)(p4);
        }
        public static Action<T1, T2, T3, T4, T5>
            Uncurry<T1, T2, T3, T4, T5>(this Func<T1, Func<T2, Func<T3, Func<T4, Action<T5>>>>> func)
        {
            return (p1, p2, p3, p4, p5) => func(p1)(p2)(p3)(p4)(p5);
        }
        public static Action<T1, T2, T3, T4, T5, T6>
            Uncurry<T1, T2, T3, T4, T5, T6>(this Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Action<T6>>>>>> func)
        {
            return (p1, p2, p3, p4, p5, P6) => func(p1)(p2)(p3)(p4)(p5)(P6);
        }
        public static Action<T1, T2, T3, T4, T5, T6, T7>
            Uncurry<T1, T2, T3, T4, T5, T6, T7>(this Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Action<T7>>>>>>> func)
        {
            return (p1, p2, p3, p4, p5, p6, p7) => func(p1)(p2)(p3)(p4)(p5)(p6)(p7);
        }
    }
}
