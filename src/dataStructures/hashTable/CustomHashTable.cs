using System;

namespace src.dataStructures.hashTable
{
    public class CustomHashTable<T>
    {
        private Item[] _array = new Item[10];
        public void Add(long key, T value)
        {
            var item = new Item { Key = key, Value = value };
            var index = GetHashCode(key);
            AddToArray(item, index);
        }

        private void AddToArray(Item headItem, long index)
        {
            if (_array[index] == null)
                _array[index] = headItem;
            else
                AddAsAdjacent((Item)_array[index], headItem);
        }

        private void AddAsAdjacent(Item item, Item itemToAdd)
        {
            if (item.LinkedItem == null)
                item.LinkedItem = itemToAdd;
            else
                AddAsAdjacent(item.LinkedItem, itemToAdd);
        }

        public T Search(long key)
        {
            long index = GetHashCode(key);
            var headItem = (Item)_array[index];
            if(headItem == null)
                return default(T);
            if (headItem != null && headItem.Key.Equals(key))
                return (T)headItem.Value;
            return (T)SearchAdjacents(headItem.LinkedItem, key);
        }

        private object SearchAdjacents(Item parentItem, object key)
        {
            if (parentItem.Key.Equals(key))
                return parentItem.Value;

            return SearchAdjacents(parentItem.LinkedItem, key);
        }

        private long GetHashCode(long key) => key % _array.LongLength;


        private class Item
        {
            public long Key { get; set; }
            public Object Value { get; set; }
            public Item LinkedItem { get; set; }
        }
    }
}