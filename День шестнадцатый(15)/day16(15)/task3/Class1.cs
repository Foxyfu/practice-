using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    using System.Collections;
    using System.Collections.Generic;

    public class MyDictionary<TKey, TValue> : IEnumerable<KeyValuePair<TKey, TValue>>
    {
        private Dictionary<TKey, TValue> dict = new Dictionary<TKey, TValue>();

        public void Add(TKey key, TValue value)
        {
            dict.Add(key, value);
        }

        public TValue this[TKey key]
        {
            get
            {
                return dict[key];
            }
            set
            {
                dict[key] = value;
            }
        }

        public int Count
        {
            get
            {
                return dict.Count;
            }
        }

        public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
        {
            return dict.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return dict.GetEnumerator();
        }
    }

}
