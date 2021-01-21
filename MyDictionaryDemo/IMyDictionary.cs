namespace MyDictionaryDemo
{
    internal interface IMyDictionary<TKey,TValue>
    {
        void Add(TKey key, TValue value);
        TValue GetValueByKey(TKey key);
    }
}