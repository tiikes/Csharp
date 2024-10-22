namespace Exercise002
{
    
    using System.Collections.Generic;
    public class Abbreviations
    {
        private Dictionary<string, string> dict;
 
        public Abbreviations()
        {
            this.dict = new Dictionary<string, string>();
        }
 
        public void AddAbbreviation(string abbreviation, string explanation)
        {
            this.dict.Add(abbreviation, explanation);
        }
 
        public bool HasAbbreviation(string abbreviation)
        {
            if (this.dict.ContainsKey(abbreviation))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
 
        public string FindExplanationFor(string abbreviation)
        {
            if (HasAbbreviation(abbreviation))
            {
                return this.dict[abbreviation];
            }
            else
            {
                return "not found";
            }
        }
    }
}