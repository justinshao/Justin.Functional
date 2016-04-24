using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Justin.Functional
{
    public interface IRange<T> : IEnumerable<T>
    {
        bool Contains(T val);
    }

    public class Range<T> : IRange<T>
    {
        private T start;
        private T end;
        private Comparison<T> compare;
        private IEnumerable<T> sequence;

        public Range(T start, T end, Func<T, T> next)
            : this(start, end, next, DefaultCompare) { }
        public Range(T start, T end, Func<T, T> next, Comparison<T> compare)
        {
            this.start = start;
            this.end = end;
            this.compare = compare;
            this.sequence = Functional.Sequence(next, start, (val) => compare(val, end) > 0);
        }

        private static int DefaultCompare(T one, T other)
        {
            return Comparer<T>.Default.Compare(one, other);
        }

        public bool Contains(T val)
        {
            return compare(val, start) >= 0 && compare(val, end) <= 0;
        }
        public IEnumerator<T> GetEnumerator()
        {
            return sequence.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<T>)this).GetEnumerator();
        }
    }

    public static class Range
    {
        public static Range<byte> Create(byte start, byte end)
        {
            return new Range<byte>(start, end, (i) => checked(++i));
        }
        public static Range<byte> Create(byte start, byte end, Func<byte, byte> next)
        {
            return new Range<byte>(start, end, next);
        }
        public static Range<sbyte> Create(sbyte start, sbyte end)
        {
            return new Range<sbyte>(start, end, (i) => checked(++i));
        }
        public static Range<sbyte> Create(sbyte start, sbyte end, Func<sbyte, sbyte> next)
        {
            return new Range<sbyte>(start, end, next);
        }
        public static Range<char> Create(char start, char end)
        {
            return new Range<char>(start, end, (c) => checked(++c));
        }
        public static Range<char> Create(char start, char end, Func<char, char> next)
        {
            return new Range<char>(start, end, next);
        }
        public static Range<short> Create(short start, short end)
        {
            return new Range<short>(start, end, (i) => checked(++i));
        }
        public static Range<short> Create(short start, short end, Func<short, short> next)
        {
            return new Range<short>(start, end, next);
        }
        public static Range<ushort> Create(ushort start, ushort end)
        {
            return new Range<ushort>(start, end, (i) => checked(++i));
        }
        public static Range<ushort> Create(ushort start, ushort end, Func<ushort, ushort> next)
        {
            return new Range<ushort>(start, end, next);
        }
        public static Range<int> Create(int start, int end)
        {
            return new Range<int>(start, end, (i) => checked(++i));
        }
        public static Range<int> Create(int start, int end, Func<int, int> next)
        {
            return new Range<int>(start, end, next);
        }
        public static Range<uint> Create(uint start, uint end)
        {
            return new Range<uint>(start, end, (i) => checked(++i));
        }
        public static Range<uint> Create(uint start, uint end, Func<uint, uint> next)
        {
            return new Range<uint>(start, end, next);
        }
        public static Range<long> Create(long start, long end)
        {
            return new Range<long>(start, end, (i) => checked(++i));
        }
        public static Range<long> Create(long start, long end, Func<long, long> next)
        {
            return new Range<long>(start, end, next);
        }
        public static Range<ulong> Create(ulong start, ulong end)
        {
            return new Range<ulong>(start, end, (i) => checked(++i));
        }
        public static Range<ulong> Create(ulong start, ulong end, Func<ulong, ulong> next)
        {
            return new Range<ulong>(start, end, next);
        }
        public static Range<DateTime> Create(DateTime start, DateTime end, Func<DateTime, DateTime> next)
        {
            return new Range<DateTime>(start, end, next);
        }
    }
}
