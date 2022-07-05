using System.Collections.Generic;

namespace SqlParser.ClickHouse
{
    public class Dictionary<T>
    {
        private HashSet<T> container = new HashSet<T>();

        public void insert(T t)
        {
            container.Add(t);
        }
        public bool count(T t)
        {
            return container.Contains(t);
        }
    }
}
