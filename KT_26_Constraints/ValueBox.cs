namespace KT_26_Constraints
{
    public class ValueBox<T> where T : struct
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