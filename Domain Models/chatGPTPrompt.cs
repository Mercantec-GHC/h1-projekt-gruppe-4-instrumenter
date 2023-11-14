using System;
using System.Collections.Generic;

namespace JamJunkie
{
    public class ItemForSale
    {
        public string Phone { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }

        public ItemForSale() { }

        public ItemForSale(string userName, string phone, string email)
        {
            UserName = userName;
            Phone = phone;
            Email = email;
        }

        public void PhoneCall()
        {
            Console.WriteLine("You have called the seller.");
        }

        public void SendMail()
        {
            Console.WriteLine("You have sent an email to the seller.");
        }
    }

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

        // Implement other methods for filtering instruments based on user preferences
    }

    class Program
    {
        static void Main()
        {
            // Usage examples
            InstrumentInventory inventory = new InstrumentInventory();

            // Get all instruments
            List<Instrument> allInstruments = inventory.GetAllInstruments();
            foreach (Instrument inst in allInstruments)
            {
                Console.WriteLine($"Instrument: {inst.ProductName}, Type: {inst.Type}, Price: {inst.Price}");
            }
        }
    }
}
