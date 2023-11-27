using System;

namespace JamJunkie
{
    public class InstrumentInventory
    {
        private List<Instrument> instruments;

        public InstrumentInventory()
        {
            instruments = new List<Instrument>();

            // Pre-made instruments
            instruments.Add(new Instrument
            {
                Type = Instrument.InstrumentType.Guitar,
                Brand = "Fender",
                Year = 2020,
                Colour = "Sunburst",
                Material = "Maple",
                CountryOfOrigin = "USA",
                Price = 1500,
                ProductName = "Stratocaster",
                ItemDescription = "Classic electric guitar",
                ItemCondition = "Excellent"
            });

            instruments.Add(new Instrument
            {
                Type = Instrument.InstrumentType.Piano,
                Brand = "Yamaha",
                Year = 2019,
                Colour = "Black",
                Material = "Wood",
                CountryOfOrigin = "Japan",
                Price = 3000,
                ProductName = "Digital Piano",
                ItemDescription = "High-quality digital piano",
                ItemCondition = "Good"
            });

            instruments.Add(new Instrument
            {
                Type = Instrument.InstrumentType.Violin,
                Brand = "Stradivarius",
                Year = 1750,
                Colour = "Brown",
                Material = "Wood",
                CountryOfOrigin = "Italy",
                Price = 20000,
                ProductName = "Antique Violin",
                ItemDescription = "Historical Stradivarius violin",
                ItemCondition = "Fair"
            });
        }

        public void AddInstrument(Instrument instrument)
        {
            instruments.Add(instrument);
        }

        public List<Instrument> GetAllInstruments()
        {
            return instruments;
        }
    }
}