using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Justin.Functional
{
    public class TailedSequence<T> : IEnumerable<T>
    {
        public static readonly TailedSequence<T> Empty =
            new TailedSequence<T>(itr: null);

        private TailedEnumerator _itr;
        private T _head = default(T);

        public TailedSequence(IEnumerable<T> sequence) :
            this(new TailedEnumerator(sequence.GetEnumerator())) { }
        private TailedSequence(TailedEnumerator itr)
        {
            this.Swap(itr);
        }

        public T Head
        {
            get
            {
                return _head;
            }
        }
        public TailedSequence<T> Tail
        {
            get
            {
                return _itr != null ? Swap(_itr) : Empty;
            }
        }

        internal TailedSequence<T> Swap(TailedEnumerator itr)
        {
            _itr = itr;
            if (_itr == null)
            {
                return Empty;
            }

            if (!_itr.MoveNext())
            {
                return Empty;
            }
            _head = _itr.Current;
            
            return this;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return _itr;
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<T>)this).GetEnumerator();
        }

        internal class TailedEnumerator : IEnumerator<T>
        {
            private IEnumerator<T> itr;

            public TailedEnumerator(IEnumerator<T> itr)
            {
                this.itr = itr;
            }

            public T Current
            {
                get
                {
                    return itr.Current;
                }
            }
            object IEnumerator.Current
            {
                get
                {
                    return this.Current;
                }
            }

            public void Dispose() { }
            public bool MoveNext()
            {
                return itr.MoveNext();
            }
            public void Reset()
            {
                throw new NotSupportedException("枚举器不支持重置操作.");
            }
        }
    }
}
