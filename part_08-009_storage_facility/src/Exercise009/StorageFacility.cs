namespace Exercise009
{
    using System;
    using System.Collections.Generic;
    public class StorageFacility
    {
        private Dictionary<string, List<string>> storage;
        public StorageFacility()
        {
            this.storage = new Dictionary<string, List<string>>();
        }
 
        public void Add(string unit, string item)
        {
            if (!this.storage.ContainsKey(unit))
            {
                this.storage.Add(unit, new List<string>());
            }
            this.storage[unit].Add(item);
        }
 
        public List<string> Contents(string storageUnit)
        {
            if (!this.storage.ContainsKey(storageUnit))
            {
                this.storage.Add(storageUnit, new List<string>());
            }
            return this.storage[storageUnit];
        }
 
        public void Remove(string storageUnit, string item)
        {
            this.storage[storageUnit].Remove(item);
            if (this.storage[storageUnit].Count == 0)
            {
                this.storage.Remove(storageUnit);
            }
        }
 
        public List<string> StorageUnits()
        {
            List<string> listUnits = new List<string>();
            Dictionary<string, List<string>>.KeyCollection keys = this.storage.Keys;
            foreach (string storages in keys)
            {
                listUnits.Add(storages);
            }
            return listUnits;
        }
    }
}