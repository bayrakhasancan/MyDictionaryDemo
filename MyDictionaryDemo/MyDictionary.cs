using System;

namespace MyDictionaryDemo
{
    class MyDictionary<TKey, TValue> : IMyDictionary<TKey, TValue>
    {
        TKey[] keys;
        TKey[] tmpKeys;
        TValue[] values;
        TValue[] tmpValues;
        int count;

        public MyDictionary()
        {
            keys = new TKey[0];
            values = new TValue[0];
            count = 0;
        }

        public void Add(TKey key, TValue value)
        {
            for (int i = 0; i <= keys.GetUpperBound(0); i++)
            {
                if (keys[i].Equals(key))
                {
                    throw new Exception(message: "You can't add the " + key + " as a key , already exist");
                }
            }

            tmpKeys = keys;
            tmpValues = values;

            keys = new TKey[count + 1];
            values = new TValue[count + 1];

            for (int i = 0; i < keys.GetUpperBound(0); i++)
            {
                keys[i] = tmpKeys[i];
                values[i] = tmpValues[i];
            }

            keys[count] = key;
            values[count] = value;

            count++;
        }

        public TValue GetValueByKey(TKey key)
        {
            for (int i = 0; i < count; i++)
            {
                if (keys[i].Equals(key))
                {
                    return values[i];
                }
            }

            return default(TValue);
        }

        public TKey[] Keys { get { return keys; } }
        public TValue[] Values { get { return values; } }
        public int Count { get { return count; } }
    }
}