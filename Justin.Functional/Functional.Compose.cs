using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Justin.Functional
{
    /// <summary>
    /// 组合
    /// </summary>
    static partial class Functional
    {
        public static Func<TSource, TTarget> 
            Compose<TSource, TIntermediate, TTarget>
            (this Func<TSource, TIntermediate> first, Func<TIntermediate, TTarget> next)
        {
            return srcVal => next(first(srcVal));
        }
        public static Func<TSource1, TSource2, TTarget> 
            Compose<TSource1, TSource2, TIntermediate, TTarget>
            (this Func<TSource1, TSource2, TIntermediate> first, Func<TIntermediate, TTarget> next)
        {
            return (srcVal1, srcVal2) => next(first(srcVal1, srcVal2));
        }
        public static Func<TSource1, TSource2, TSource3, TTarget>
            Compose<TSource1, TSource2, TSource3, TIntermediate, TTarget>
            (this Func<TSource1, TSource2, TSource3, TIntermediate> first, Func<TIntermediate, TTarget> next)
        {
            return (srcVal1, srcVal2, srcVal3) => next(first(srcVal1, srcVal2, srcVal3));
        }
        public static Func<TSource1, TSource2, TSource3, TSource4, TTarget>
            Compose<TSource1, TSource2, TSource3, TSource4, TIntermediate, TTarget>
            (this Func<TSource1, TSource2, TSource3, TSource4, TIntermediate> first, Func<TIntermediate, TTarget> next)
        {
            return (srcVal1, srcVal2, srcVal3, srcVal4) => next(first(srcVal1, srcVal2, srcVal3, srcVal4));
        }
        public static Func<TSource1, TSource2, TSource3, TSource4, TSource5, TTarget>
            Compose<TSource1, TSource2, TSource3, TSource4, TSource5, TIntermediate, TTarget>
            (this Func<TSource1, TSource2, TSource3, TSource4, TSource5, TIntermediate> first, Func<TIntermediate, TTarget> next)
        {
            return (srcVal1, srcVal2, srcVal3, srcVal4, srcVal5) => next(first(srcVal1, srcVal2, srcVal3, srcVal4, srcVal5));
        }
        public static Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TTarget>
            Compose<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TIntermediate, TTarget>
            (this Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TIntermediate> first, Func<TIntermediate, TTarget> next)
        {
            return (srcVal1, srcVal2, srcVal3, srcVal4, srcVal5, srcVal6) => next(first(srcVal1, srcVal2, srcVal3, srcVal4, srcVal5, srcVal6));
        }
        public static Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TTarget>
            Compose<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TIntermediate, TTarget>
            (this Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TIntermediate> first, Func<TIntermediate, TTarget> next)
        {
            return (srcVal1, srcVal2, srcVal3, srcVal4, srcVal5, srcVal6, srcVal7) => 
                next(first(srcVal1, srcVal2, srcVal3, srcVal4, srcVal5, srcVal6, srcVal7));
        }

        public static Action<TSource> 
            Compose<TSource, TIntermediate>
            (this Func<TSource, TIntermediate> first, Action<TIntermediate> next)
        {
            return (srcVal) => next(first(srcVal));
        }
        public static Action<TSource1, TSource2>
            Compose<TSource1, TSource2, TIntermediate>
            (this Func<TSource1, TSource2, TIntermediate> first, Action<TIntermediate> next)
        {
            return (srcVal1, srcVal2) => next(first(srcVal1, srcVal2));
        }
        public static Action<TSource1, TSource2, TSource3>
            Compose<TSource1, TSource2, TSource3, TIntermediate>
            (this Func<TSource1, TSource2, TSource3, TIntermediate> first, Action<TIntermediate> next)
        {
            return (srcVal1, srcVal2, srcVal3) => next(first(srcVal1, srcVal2, srcVal3));
        }
        public static Action<TSource1, TSource2, TSource3, TSource4>
            Compose<TSource1, TSource2, TSource3, TSource4, TIntermediate>
            (this Func<TSource1, TSource2, TSource3, TSource4, TIntermediate> first, Action<TIntermediate> next)
        {
            return (srcVal1, srcVal2, srcVal3, srcVal4) => next(first(srcVal1, srcVal2, srcVal3, srcVal4));
        }
        public static Action<TSource1, TSource2, TSource3, TSource4, TSource5>
            Compose<TSource1, TSource2, TSource3, TSource4, TSource5, TIntermediate>
            (this Func<TSource1, TSource2, TSource3, TSource4, TSource5, TIntermediate> first, Action<TIntermediate> next)
        {
            return (srcVal1, srcVal2, srcVal3, srcVal4, srcVal5) => next(first(srcVal1, srcVal2, srcVal3, srcVal4, srcVal5));
        }
        public static Action<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6>
            Compose<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TIntermediate>
            (this Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TIntermediate> first, Action<TIntermediate> next)
        {
            return (srcVal1, srcVal2, srcVal3, srcVal4, srcVal5, srcVal6) => next(first(srcVal1, srcVal2, srcVal3, srcVal4, srcVal5, srcVal6));
        }
        public static Action<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7>
            Compose<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TIntermediate>
            (this Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TIntermediate> first, Action<TIntermediate> next)
        {
            return (srcVal1, srcVal2, srcVal3, srcVal4, srcVal5, srcVal6, srcVal7) => next(first(srcVal1, srcVal2, srcVal3, srcVal4, srcVal5, srcVal6, srcVal7));
        }
    }
}
