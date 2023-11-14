using System;

namespace Objects
{
    public class itemForSale
    { 
        public string SellerName {get;set;}
        public string ProductName {get;set;}
        public string Phone {get;set;}
        public string Email {get;set;}
        public double Price {get;set;}

        public itemForSale() { }

        public itemForSale(string sellerName, string productName, string phone, string email, string address, int price)
        {
            SellerName = sellerName;
            ProductName = productName;
            Phone = phone;
            Email = email;
            Price = price;
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
    class Program
    {
        static void Main()
        {
            itemForSale John = new itemForSale
            {
                SellerName = "John",
                ProductName = "big guitar!!",
                Phone = "+45 12 34 56 78",
                Email = "john@gmail.com",
                Price = 200
            };
            John.PhoneCall();
            John.SendMail();
        }
    }
}
