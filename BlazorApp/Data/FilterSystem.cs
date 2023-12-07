using System;
using System.Diagnostics.Metrics;
using BlazorApp.Model;

namespace JamJunkie
{
    public class Filter
    {
        ItemForSale itemForSale;
        public void FilterInstrument()
        {
            Console.WriteLine(itemForSale);
        }
    }
}
