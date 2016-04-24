using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Justin.Functional
{
    /// <summary>
    /// 惰性求值
    /// </summary>
    static partial class Functional
    {
        public static Func<TR> 
            Lazy<TR>(this Func<TR> func)
        {
            var lazy = new Lazy<TR>(func);
            return () => lazy.Value;
        }
        public static Func<T1, TR> 
            Lazy<T1, TR>(this Func<T1, TR> func)
        {
            Lazy<TR> lazy = null;
            return (p1) =>
            {
                if (lazy == null)
                    lazy = new Lazy<TR>(() => func(p1));
                return lazy.Value;
            };
        }
        public static Func<T1, T2, TR> 
            Lazy<T1, T2, TR>(this Func<T1, T2, TR> func)
        {
            Lazy<TR> lazy = null;
            return (p1, p2) =>
            {
                if (lazy == null)
                    lazy = new Lazy<TR>(() => func(p1, p2));
                return lazy.Value;
            };
        }
        public static Func<T1, T2, T3, TR> 
            Lazy<T1, T2, T3, TR>(this Func<T1, T2, T3, TR> func)
        {
            Lazy<TR> lazy = null;
            return (p1, p2, p3) =>
            {
                if (lazy == null)
                    lazy = new Lazy<TR>(() => func(p1, p2, p3));
                return lazy.Value;
            };
        }
        public static Func<T1, T2, T3, T4, TR>
            Lazy<T1, T2, T3, T4, TR>(this Func<T1, T2, T3, T4, TR> func)
        {
            Lazy<TR> lazy = null;
            return (p1, p2, p3, p4) =>
            {
                if (lazy == null)
                    lazy = new Lazy<TR>(() => func(p1, p2, p3, p4));
                return lazy.Value;
            };
        }
        public static Func<T1, T2, T3, T4, T5, TR>
            Lazy<T1, T2, T3, T4, T5, TR>(this Func<T1, T2, T3, T4, T5, TR> func)
        {
            Lazy<TR> lazy = null;
            return (p1, p2, p3, p4, p5) =>
            {
                if (lazy == null)
                    lazy = new Lazy<TR>(() => func(p1, p2, p3, p4, p5));
                return lazy.Value;
            };
        }
        public static Func<T1, T2, T3, T4, T5, T6, TR>
            Lazy<T1, T2, T3, T4, T5, T6, TR>(this Func<T1, T2, T3, T4, T5, T6, TR> func)
        {
            Lazy<TR> lazy = null;
            return (p1, p2, p3, p4, p5, p6) =>
            {
                if (lazy == null)
                    lazy = new Lazy<TR>(() => func(p1, p2, p3, p4, p5, p6));
                return lazy.Value;
            };
        }
        public static Func<T1, T2, T3, T4, T5, T6, T7, TR>
            Lazy<T1, T2, T3, T4, T5, T6, T7, TR>(this Func<T1, T2, T3, T4, T5, T6, T7, TR> func)
        {
            Lazy<TR> lazy = null;
            return (p1, p2, p3, p4, p5, p6, p7) =>
            {
                if (lazy == null)
                    lazy = new Lazy<TR>(() => func(p1, p2, p3, p4, p5, p6, p7));
                return lazy.Value;
            };
        }
    }
}
