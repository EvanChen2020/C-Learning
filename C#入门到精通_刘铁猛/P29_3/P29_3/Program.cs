using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P29_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = { 1, 2, 3, 4, 5 };
            ArrayList nums2 = new ArrayList { 1, 2, 3, 4, 5 };
            var nums3 = new ReadOnlyCollection(nums1);
            Console.WriteLine(Sum(nums1));
            Console.WriteLine(Sum(nums2));

            var roc = new ReadOnlyCollection(nums1);
            foreach (var n in roc)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine(Sum(nums3));
        }

       // static int Sum(ICollection nums)

        //接口隔离原则，调用者绝不多要。
             static int Sum(IEnumerable nums)
        {
            int sum = 0;
            foreach (var n in nums)
            {
                sum += (int)n;
            }

            return sum;
        }
    }

    class ReadOnlyCollection : IEnumerable
    {
        private int[] _array;

        public ReadOnlyCollection(int[] array)
        {
            _array = array;
            
        }

        public IEnumerator GetEnumerator()
        {
            return new Enumerator(this);
        }

        public class Enumerator : IEnumerator
        {
            private ReadOnlyCollection _collection;
            private int _head;


            public Enumerator(ReadOnlyCollection collection)
            {
                _collection = collection;
                _head = -1;
            }
            public object Current
            {
                get
                {
                    object o = _collection._array[_head];
                    return o;
                }
            }

            public bool MoveNext()
            {
                if (++_head<_collection._array.Length)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public void Reset()
            {
                _head = -1;
            }
        }
    }
}
