using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Justin.Functional
{
    public sealed class Option<T>
    {
        private readonly T value;
        private readonly bool hasValue;

        private static readonly Option<T> None = new Option<T>();

        private Option() { hasValue = false; }
        public Option(T value)
        {
            this.value = value;
            this.hasValue = true;
        }

        public bool HasValue
        {
            get { return hasValue; }
        }
        public bool IsSome
        {
            get { return hasValue; }
        }
        public bool IsNone
        {
            get { return !hasValue; }
        }

        public static bool operator ==(Option<T> a, Option<T> b)
        {
            return (a.hasValue == b.hasValue) &&
                EqualityComparer<T>.Default.Equals(a.value, b.value);
        }
        public static bool operator !=(Option<T> a, Option<T> b)
        {
            return !(a == b);
        }
        public static implicit operator Option<T>(Option none)
        {
            return Option<T>.None;
        }

        public override bool Equals(object obj)
        {
            if (obj is Option)
                return !hasValue;

            Option<T> _obj = obj as Option<T>;

            if (_obj == null)
                return false;

            return (this == _obj);
        }
        public override int GetHashCode()
        {
            int hashCode = hasValue.GetHashCode();
            if (hasValue)
                hashCode = hashCode ^ value.GetHashCode();

            return hashCode;
        }
    }

    public sealed class Option
    {
        public static readonly Option None = new Option();

        private Option() { }

        public static Option<T> Some<T>(T value)
        {
            return new Option<T>(value);
        }
    }

    public static class OptionExtensions
    {
        public static Option<T> ToOption<T>(this T value)
        {
            return Option.Some(value);
        }

        public static Option<T> ToNotNullOption<T>(this T value) where T : class
        {
            return value == null ? Option.None : Option.Some(value);
        }
    }
}
