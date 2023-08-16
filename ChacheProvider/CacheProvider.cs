using CustomLinkedList;

namespace ChacheProvider
{
    public class CacheProvider<T>
    {
        private readonly IDictionary<string, CustomNode<T>> cache;
        private readonly CustomLinkedList<T> list;
        private readonly int size;
        private int count;

        public CacheProvider(int size = 4)
        {
            cache = new Dictionary<string, CustomNode<T>>(size);
            list = new CustomLinkedList<T>();

            count = 0;
            this.size = size;
        }

        public T this[string key]
        {
            get => GetValue(key);
        }

        public void Add(string key, T value)
        {
            if (cache.ContainsKey(key))
            {
                throw new ArgumentException(nameof(key));
            }

            if (count == size && count != 0)
            {
                list.Remove(list.First);
                count--;
            }

            var resultNode = list.Add(new CustomNode<T> { Value = value });

            cache.Add(key, resultNode);
            count++;
        }

        public T GetValue(string key)
        {
            if (!cache.TryGetValue(key, out var item))
            {
                throw new ArgumentException(nameof(key));
            }

            if (count > 1)
            {
                list.Add(item);
                list.Remove(item);
            }

            return item.Value;
        }
    }
}