using System.Runtime.InteropServices.WindowsRuntime;

namespace MyList
{
    internal class MyList<T>
    {
        private T[] _items;

        public MyList()
        {
            _items = new T[0];
        }

        public int Count => _items.Length;

        public void Add(T item)
        {
            IncreaseArraySize();

            _items[^1] = item;
        }

        private void IncreaseArraySize()
        {
            T[] tempList = _items;
            _items = new T[tempList.Length + 1];

            for (int i = 0; i < tempList.Length; i++)
            {
                _items[i] = tempList[i];
            }
        }

        public T[] GetAll() => _items;
    }
}