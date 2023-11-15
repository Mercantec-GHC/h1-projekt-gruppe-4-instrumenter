using System;

namespace JamJunkie
{
    public class Instrument
    {
        public enum InstrumentType
        {
            Guitar,
            Bass,
            Violin,
            Flute,
            Piano,
            Drums
        }

        public InstrumentType Type { get; set; }
        public string Brand { get; set; }
        public int Year { get; set; }
        public string Colour { get; set; }
        public string Material { get; set; }
        public string CountryOfOrigin { get; set; }
        public double Price { get; set; }
        public string ProductName { get; set; }
        public string ItemDescription { get; set; }
        public string ItemCondition { get; set; }
    }
}