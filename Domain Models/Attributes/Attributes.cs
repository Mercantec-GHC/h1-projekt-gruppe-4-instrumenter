using System;
namespace Objects
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
    }
}