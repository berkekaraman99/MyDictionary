using System;
using System.Collections.Generic;
using System.Text;

namespace DictionaryGeneric
{
    class MyDictionary<K,V>
    {
        K[] Key;
        V[] Value;
        
        public MyDictionary()
        {
            Key = new K[0];
            Value = new V[0];
        }

        public void Add(K item1, V item2)
        {
            K[] tempKey = Key;
            V[] tempValue = Value;
            Key = new K[Key.Length + 1];
            Value = new V[Value.Length + 1];

            for (int i = 0; i < tempKey.Length; i++)
            {
                Key[i] = tempKey[i];
                Value[i] = tempValue[i];
            }
            Key[Key.Length - 1] = item1;
            Value[Value.Length - 1] = item2;
        }

        public int Count
        {
            get { return Key.Length; }
        }

        public void List()
        {
            for (int i = 0; i < Key.Length; i++)
            {
                Console.WriteLine(Key[i] + "  " + Value[i]);
            }
        }
    }
}
