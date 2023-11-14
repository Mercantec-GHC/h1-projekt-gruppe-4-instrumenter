using System;

namespace JamJunkie
{
    public class itemSpecifics
    {
        public enum Instrument
        {
            Guitar,
            Piano,
            Bass,
            Drums,
            Violin,
            Flute
        }

        public int Year;
        public string Colour;
        public string Material;
        public string CountryOfOrigin;
        public double Price { get; set; }
        public string ProductName { get; set; }
        public string ItemDescription { get; set; }
        public string ItemCondition { get; set; }
    }
}