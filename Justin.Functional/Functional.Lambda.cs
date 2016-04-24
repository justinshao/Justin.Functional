using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Justin.Functional
{
    /// <summary>
    /// Lambda
    /// </summary>
    static partial class Functional
    {
        public static Func<T1, TR> 
            Lambda<T1, TR>(Func<T1, TR> func) { return func; }
        public static Func<T1, T2, TR> 
            Lambda<T1, T2, TR>(Func<T1, T2, TR> func) { return func; }
        public static Func<T1, T2, T3, TR> 
            Lambda<T1, T2, T3, TR>(Func<T1, T2, T3, TR> func) { return func; }
        public static Func<T1, T2, T3, T4, TR> 
            Lambda<T1, T2, T3, T4, TR>(Func<T1, T2, T3, T4, TR> func) { return func; }
        public static Func<T1, T2, T3, T4, T5, TR> 
            Lambda<T1, T2, T3, T4, T5, TR>(Func<T1, T2, T3, T4, T5, TR> func) { return func; }
        public static Func<T1, T2, T3, T4, T5, T6, TR> 
            Lambda<T1, T2, T3, T4, T5, T6, TR>(Func<T1, T2, T3, T4, T5, T6, TR> func) { return func; }
        public static Func<T1, T2, T3, T4, T5, T6, T7, TR> 
            Lambda<T1, T2, T3, T4, T5, T6, T7, TR>(Func<T1, T2, T3, T4, T5, T6, T7, TR> func) { return func; }

        public static Action<T1>
            Lambda<T1>(Action<T1> action)
        { return action; }
        public static Action<T1, T2>
            Lambda<T1, T2>(Action<T1, T2> action)
        { return action; }
        public static Action<T1, T2, T3>
            Lambda<T1, T2, T3>(Action<T1, T2, T3> action)
        { return action; }
        public static Action<T1, T2, T3, T4>
            Lambda<T1, T2, T3, T4>(Action<T1, T2, T3, T4> action)
        { return action; }
        public static Action<T1, T2, T3, T4, T5>
            Lambda<T1, T2, T3, T4, T5>(Action<T1, T2, T3, T4, T5> action)
        { return action; }
        public static Action<T1, T2, T3, T4, T5, T6>
            Lambda<T1, T2, T3, T4, T5, T6>(Action<T1, T2, T3, T4, T5, T6> action)
        { return action; }
        public static Action<T1, T2, T3, T4, T5, T6, T7>
            Lambda<T1, T2, T3, T4, T5, T6, T7>(Action<T1, T2, T3, T4, T5, T6, T7> action)
        { return action; }
        
        public static Func<T1, Func<T2, TR>>
            Lambda<T1, T2, TR>(Func<T1, Func<T2, TR>> func)
        { return func; }
        public static Func<T1, Func<T2, Func<T3, TR>>>
            Lambda<T1, T2, T3, TR>(Func<T1, Func<T2, Func<T3, TR>>> func)
        { return func; }
        public static Func<T1, Func<T2, Func<T3, Func<T4, TR>>>>
            Lambda<T1, T2, T3, T4, TR>(Func<T1, Func<T2, Func<T3, Func<T4, TR>>>> func)
        { return func; }
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, TR>>>>>
            Lambda<T1, T2, T3, T4, T5, TR>(Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, TR>>>>> func)
        { return func; }
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, TR>>>>>>
            Lambda<T1, T2, T3, T4, T5, T6, TR>(Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, TR>>>>>> func)
        { return func; }
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, TR>>>>>>>
            Lambda<T1, T2, T3, T4, T5, T6, T7, TR>(Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, TR>>>>>>> func)
        { return func; }

        public static Func<T1, Action<T2>>
            Lambda<T1, T2>(Func<T1, Action<T2>> func)
        { return func; }
        public static Func<T1, Func<T2, Action<T3>>>
            Lambda<T1, T2, T3>(Func<T1, Func<T2, Action<T3>>> func)
        { return func; }
        public static Func<T1, Func<T2, Func<T3, Action<T4>>>>
            Lambda<T1, T2, T3, T4>(Func<T1, Func<T2, Func<T3, Action<T4>>>> func)
        { return func; }
        public static Func<T1, Func<T2, Func<T3, Func<T4, Action<T5>>>>>
            Lambda<T1, T2, T3, T4, T5>(Func<T1, Func<T2, Func<T3, Func<T4, Action<T5>>>>> func)
        { return func; }
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Action<T6>>>>>>
            Lambda<T1, T2, T3, T4, T5, T6>(Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Action<T6>>>>>> func)
        { return func; }
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Action<T7>>>>>>>
            Lambda<T1, T2, T3, T4, T5, T6, T7>(Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Action<T7>>>>>>> func)
        { return func; }
    }
}
