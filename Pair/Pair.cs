namespace PairClass
{
    public class Pair<TKey, TValue>
    {
        private TKey _key;
        private TValue _value;

        public TKey Key
        {
            get { return _key; }
        }
        public TValue Value
        {
            get { return _value; }
        }
        public Pair(TKey key, TValue value)
        {
            _key = key;
            _value = value;
        }
    }
}
