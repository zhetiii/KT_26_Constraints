namespace KT_26_Constraints
{
    public class ReferenceBox<T> where T : class
    {
        private T? _item;

        public bool IsEmpty => _item == null;

        public void Set(T item)
        {
            _item = item;
        }

        public T? Get()
        {
            return _item;
        }
    }
}