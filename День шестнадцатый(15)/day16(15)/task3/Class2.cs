using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{

    using System;

    public static class MyDictionaryExtensions
    {
        public static KeyValuePair<TKey, TValue>[] GetArray<TKey, TValue>(this MyDictionary<TKey, TValue> dictionary)
        {
            KeyValuePair<TKey, TValue>[] array = new KeyValuePair<TKey, TValue>[dictionary.Count];
            int i = 0;
            foreach (KeyValuePair<TKey, TValue> pair in dictionary)
            {
                array[i++] = pair;
            }
            return array;
        }
    }


}
