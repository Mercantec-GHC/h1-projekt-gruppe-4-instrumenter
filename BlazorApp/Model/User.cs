using System;

namespace JamJunkie
{
    public class ItemForSale
    { 
        public string Phone {get;set;}
        public string Email {get;set;}
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
    class Users
    {
        static void Main()
        {
            ItemForSale John = new ItemForSale
            {
                UserName = "John",
                Phone = "+45 12 34 56 78",
                Email = "john@gmail.com",
            };
            John.PhoneCall();
            John.SendMail();
        }
    }
}
