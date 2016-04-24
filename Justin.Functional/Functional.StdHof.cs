using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Justin.Functional
{
    /// <summary>
    /// 标准高阶函数
    /// </summary>
    static partial class Functional
    {
        public static IEnumerable<R> Map<T, R>(Func<T, R> fn, IEnumerable<T> list)
        {
            foreach (var item in list)
            {
                yield return fn(item);
            }
        }
        public static IEnumerable<T> Filter<T>(Predicate<T> predicate, IEnumerable<T> list)
        {
            foreach (var item in list)
            {
                if (predicate(item))
                    yield return item;
            }
        }
        public static R FoldL<T, R>(Func<R, T, R> accumulator, R initVal, IEnumerable<T> list)
        {
            // 防止每次递归调用都创建 TailedSequence<T> 对象做了，优化处理
            TailedSequence<T> _list = list as TailedSequence<T>;
            _list = _list ?? new TailedSequence<T>(list);
            
            if (list == TailedSequence<T>.Empty)
                return initVal;

            return FoldL(accumulator, accumulator(initVal, _list.Head), _list.Tail);
        }
        public static R FoldR<T, R>(Func<T, R, R> accumulator, R initVal, IEnumerable<T> list)
        {
            // 防止每次递归调用都创建 TailedSequence<T> 对象，做了优化处理
            TailedSequence<T> _list = list as TailedSequence<T>;
            _list = _list ?? new TailedSequence<T>(list);

            if (list == TailedSequence<T>.Empty)
                return initVal;

            return accumulator(_list.Head, FoldR(accumulator, initVal, _list.Tail));
        }
        
        public static Func<Func<T, R>, IEnumerable<T>, IEnumerable<R>> MapFn<T, R>()
        {
            return Map;
        }
        public static Func<Predicate<T>, IEnumerable<T>, IEnumerable<T>> FilterFn<T>()
        {
            return Filter;
        }
        public static Func<Func<R, T, R>, R, IEnumerable<T>, R> FoldLFn<T, R>()
        {
            return FoldL;
        }
        public static Func<Func<T, R, R>, R, IEnumerable<T>, R> FoldRFn<T, R>()
        {
            return FoldR;
        }
    }
}
