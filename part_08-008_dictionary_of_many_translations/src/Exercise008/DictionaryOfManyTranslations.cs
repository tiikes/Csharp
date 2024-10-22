namespace Exercise008
{
    using System;
    using System.Collections.Generic;
    public class DictionaryOfManyTranslations
    {
        private Dictionary<string, List<string>> wordDictionary;
        public DictionaryOfManyTranslations()
        {
            this.wordDictionary = new Dictionary<string, List<string>>();
        }
 
        public void Add(string word, string translation)
        {
            if (!this.wordDictionary.ContainsKey(word))
            {
                this.wordDictionary.Add(word, new List<string>());
            }
            this.wordDictionary[word].Add(translation);
        }
 
        public List<string> Translate(string word)
        {
            if (!this.wordDictionary.ContainsKey(word))
            {
                this.wordDictionary.Add(word, new List<string>());
            }
            return this.wordDictionary[word];
        }
 
        public void Remove(string word)
        {
            this.wordDictionary.Remove(word);
        }
    }
}
