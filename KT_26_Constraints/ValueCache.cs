namespace KT_26_Constraints
{
    public class ValueCache<T> where T : struct
    {
        private T? _cachedValue;

        public void Set(T value)
        {
            _cachedValue = value;
        }

        public bool TryGet(out T? value)
        {
            if (_cachedValue == null)
            {
                value = null;
                return false;
            }

            value = _cachedValue.Value;
            return true;
        }
    }
}