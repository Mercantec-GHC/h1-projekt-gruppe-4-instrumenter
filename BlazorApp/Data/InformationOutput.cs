using System;

namespace JamJunkie
{
    public class BuyOffer
    {
        MakeOffer OfferMade;
        public void OfferToBuy()
        {
            Console.WriteLine("View some of the specialities to this product");
        }
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
