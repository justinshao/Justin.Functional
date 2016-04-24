using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Justin.Functional
{
    /// <summary>
    /// 记忆
    /// </summary>
    static partial class Functional
    {
        public static Func<T1, TR> 
            Memorize<T1, TR>(this Func<T1, TR> func)
        {
            var memory = new Dictionary<T1, TR>();

            return (p1) =>
            {
                if (!memory.ContainsKey(p1))
                    memory[p1] = func(p1);
                return memory[p1];
            };
        }
        public static Func<T1, T2, TR> 
            Memorize<T1, T2, TR>(this Func<T1, T2, TR> func)
        {
            var memory = new Dictionary<Tuple<T1, T2>, TR>();

            return (p1, p2) =>
            {
                var p = Tuple.Create(p1, p2);
                if (!memory.ContainsKey(p))
                    memory[p] = func(p1, p2);
                return memory[p];
            };
        }
        public static Func<T1, T2, T3, TR> 
            Memorize<T1, T2, T3, TR>(this Func<T1, T2, T3, TR> func)
        {
            var memory = new Dictionary<Tuple<T1, T2, T3>, TR>();

            return (p1, p2, p3) =>
            {
                var p = Tuple.Create(p1, p2, p3);
                if (!memory.ContainsKey(p))
                    memory[p] = func(p1, p2, p3);
                return memory[p];
            };
        }
        public static Func<T1, T2, T3, T4, TR> 
            Memorize<T1, T2, T3, T4, TR>(this Func<T1, T2, T3, T4, TR> func)
        {
            var memory = new Dictionary<Tuple<T1, T2, T3, T4>, TR>();

            return (p1, p2, p3, p4) =>
            {
                var p = Tuple.Create(p1, p2, p3, p4);
                if (!memory.ContainsKey(p))
                    memory[p] = func(p1, p2, p3, p4);
                return memory[p];
            };
        }
        public static Func<T1, T2, T3, T4, T5, TR>
            Memorize<T1, T2, T3, T4, T5, TR>(this Func<T1, T2, T3, T4, T5, TR> func)
        {
            var memory = new Dictionary<Tuple<T1, T2, T3, T4, T5>, TR>();

            return (p1, p2, p3, p4, p5) =>
            {
                var p = Tuple.Create(p1, p2, p3, p4, p5);
                if (!memory.ContainsKey(p))
                    memory[p] = func(p1, p2, p3, p4, p5);
                return memory[p];
            };
        }
        public static Func<T1, T2, T3, T4, T5, T6, TR>
            Memorize<T1, T2, T3, T4, T5, T6, TR>(this Func<T1, T2, T3, T4, T5, T6, TR> func)
        {
            var memory = new Dictionary<Tuple<T1, T2, T3, T4, T5, T6>, TR>();

            return (p1, p2, p3, p4, p5, p6) =>
            {
                var p = Tuple.Create(p1, p2, p3, p4, p5, p6);
                if (!memory.ContainsKey(p))
                    memory[p] = func(p1, p2, p3, p4, p5, p6);
                return memory[p];
            };
        }
        public static Func<T1, T2, T3, T4, T5, T6, T7, TR>
            Memorize<T1, T2, T3, T4, T5, T6, T7, TR>(this Func<T1, T2, T3, T4, T5, T6, T7, TR> func)
        {
            var memory = new Dictionary<Tuple<T1, T2, T3, T4, T5, T6, T7>, TR>();

            return (p1, p2, p3, p4, p5, p6, p7) =>
            {
                var p = Tuple.Create(p1, p2, p3, p4, p5, p6, p7);
                if (!memory.ContainsKey(p))
                    memory[p] = func(p1, p2, p3, p4, p5, p6, p7);
                return memory[p];
            };
        }
    }
}
