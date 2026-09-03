using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_Advanced_C__01.Q20CacheStorge
{
    internal class Cache<Tkey, TValue>
    {
       private Dictionary<Tkey, CacheItem<TValue>> items = new Dictionary<Tkey, CacheItem<TValue>>();

        public void Add(Tkey key, TValue value, TimeSpan exercise)
        {
           var item = new CacheItem<TValue>
            {
                Value = value,
               Expiration = DateTime.Now.Add(exercise)
            };
            items[key] = item;
        }

        public TValue Get(Tkey key)
        { 
            if (!items.TryGetValue(key, out var item))
            {
                return  default(TValue)!;
            }

            if (DateTime.UtcNow >= item.Expiration)
            {
                items.Remove(key);
                return default;
            }
            return item.Value;
        }
         
        public void remove(Tkey key)
        {
            items.Remove(key);
        }
        public bool contains(Tkey key) 
        {
            if (!items.TryGetValue(key, out var item))
            {
                return false;
            }
           return items.ContainsKey(key); 
        }
    }
}
