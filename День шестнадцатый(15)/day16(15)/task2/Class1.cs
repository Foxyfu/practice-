using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    using System.Collections.Generic;

    class MyDictionary<TKey, TValue>
    {
        private Dictionary<TKey, TValue> _dictionary = new Dictionary<TKey, TValue>();

        public void Add(TKey key, TValue value)
        {
            _dictionary.Add(key, value);
        }

        public TValue this[TKey key]
        {
            get { return _dictionary[key]; }
            set { _dictionary[key] = value; }
        }

        public int Count
        {
            get { return _dictionary.Count; }
        }
    }
}
