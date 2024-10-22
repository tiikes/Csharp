namespace Exercise007
{
    using System;
    using System.Collections.Generic;
    public class VehicleRegistry
    {
        private Dictionary<LicensePlate, string> owners;
        public VehicleRegistry()
        {
            this.owners = new Dictionary<LicensePlate, string>();
        }
 
        public bool Add(LicensePlate licensePlate, string owner)
        {
            if (!this.owners.ContainsKey(licensePlate))
            {
                this.owners.Add(licensePlate, owner);
                return true;
            }
            else
            {
                return false;
            }
        }
        public string Get(LicensePlate licensePlate)
        {
            if (this.owners.ContainsKey(licensePlate))
            {
                return this.owners[licensePlate];
            }
            else
            {
                return "License plate Not found in registry!";
            }
        }
 
        public bool Remove(LicensePlate licensePlate)
        {
            if (this.owners.ContainsKey(licensePlate))
            {
                this.owners.Remove(licensePlate);
                return true;
            }
            else
            {
                return false;
            }
        }
 
        public void PrintLicensePlates()
        {
            foreach (KeyValuePair<LicensePlate, string> item in this.owners)
            {
                Console.WriteLine(item.Key);
            }
        }
 
        public void PrintOwners()
        {
            List<string> already = new List<string>();
 
            foreach (KeyValuePair<LicensePlate, string> item in this.owners)
            {
                if (!already.Contains(item.Value))
                {
                    Console.WriteLine(item.Value);
                }
                already.Add(item.Value);
            }
        }
    }
}
