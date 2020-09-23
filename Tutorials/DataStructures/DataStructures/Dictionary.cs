using System;
using System.Text;

// namespace DataStructures
// {
// 
//     struct KeyValue<KeyType, ValueType>
//     {
//         public readonly KeyType Key;
//         public readonly ValueType Value;
// 
// 
//         public KeyValue(KeyType key, ValueType value)
//         {
//             Key = key;
//             Value = value;
//         }
//     }
// 
//     class Dictionary<KeyType, ValueType>
//     {
//         int storedValues = 0;
// 
//         KeyValue<KeyType, ValueType>[] kvs = new KeyValue<KeyType, ValueType>[0];
// 
//         public ValueType this[KeyType key]
//         {
//             get => GetValueAtKey(key);
//             set => AddOrReplaceKeyValue(new KeyValue<KeyType, ValueType>(key, value));
//         }
// 
//         public ValueType GetValueAtKey(KeyType key)
//         {
//             for (int i = 0; i < storedValues; i++)
//             {
//                 if (key.Equals(kvs[i].Key))
//                 {
//                     return kvs[i].Value;
//                 }
//             }
// 
//             throw new System.Collections.Generic.KeyNotFoundException();
//         }
// 
//         public void AddOrReplaceKeyValue(KeyValue<KeyType, ValueType> newKeyValue)
//         {
//             bool foundMatchingKey = false;
// 
//             for (int i = 0; i < storedValues; i++)
//             {
//                 if (newKeyValue.Key.Equals(kvs[i].Key))
//                 {
//                     foundMatchingKey = true;
//                     kvs[i] = newKeyValue;
//                 }
//             }
// 
//             if (!foundMatchingKey)
//             {
//                 ArrayUtils.GrowIfNeeded(ref kvs, storedValues);
// 
//                 kvs[storedValues++] = newKeyValue;
//             }
//         }
//     }
// }
