namespace Storage
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
 
    public class StorageFacility
    {
        // Referenssit:
        public Dictionary<string, List<string>> dictionary;
 
        // Rakentaja
        public StorageFacility()
        {
            this.dictionary = new Dictionary<string, List<string>>();
        }
 
        // Jos dictionary ei vielä sisällä string unitia niin lisätään dictionaryyn
        // ja määritellään dictionaryn valuelle uusi lista uudelle keylle
        public void Add(string unit, string item) 
        {
            if (!this.dictionary.ContainsKey(unit))
            {
                this.dictionary.Add(unit, new List<string>());
            }
        // Lisätään string items tämän dictionary keyn listaan
            List<string> items = this.dictionary[unit];
            items.Add(item);
        }
 
        // Returnaa listan Keyn "storageUnit"
        public List<string> Contents(string storageUnit)
        {
            return this.dictionary[storageUnit];  
        }
 
        // Poistaa "storageUnit" Keyn Value listasta "item" valuen
        public void Remove(string storageUnit, string item)
        {
            dictionary[storageUnit].Remove(item);
        
            // Jos Key "storageUnit"in listan count on 0 eli tyhjä niin poistaa myös Keyn!
            if(dictionary[storageUnit].Count == 0)
            {
                dictionary.Remove(storageUnit);
            }
        }
 
        // Tekee uuden listan dictionaryn Key arvoista ja returnaa keyListin
        public List<string> StorageUnits()
        {
            List<string> keyList = new List<string>(this.dictionary.Keys);
            return keyList;
        }
    }
}