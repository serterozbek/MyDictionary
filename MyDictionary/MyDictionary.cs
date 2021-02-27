using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<T1,T2>
    {
        T1[] keyItems;
        T2[] valueItems;
        public MyDictionary()
        {
            keyItems = new T1[0];
            valueItems = new T2[0];
        }
        public void Add (T1 itemkey, T2 itemvalue)
        {
            T1[] tempArrayKey = keyItems;
            T2[] tempArrayValue = valueItems;

            keyItems = new T1[keyItems.Length + 1];
            valueItems = new T2[valueItems.Length + 1];

            for(int i = 0; i < tempArrayKey.Length; i++)
            {
                keyItems[i] = tempArrayKey[i];
            }

            for(int i = 0; i < tempArrayValue.Length; i++)
            {
                valueItems[i] = tempArrayValue[i];
            }

            keyItems[keyItems.Length - 1] = itemkey;
            valueItems[valueItems.Length - 1] = itemvalue;
        }
    }
}
