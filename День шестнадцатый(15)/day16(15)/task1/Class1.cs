using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    using System;
    using System.Collections.Generic;

    class MyList<T>
    {
        private List<T> _list = new List<T>();

        public void Add(T item)
        {
            _list.Add(item);
        }

        public T this[int index]
        {
            get { return _list[index]; }
            set { _list[index] = value; }
        }

        public int Count
        {
            get { return _list.Count; }
        }
    }

}
