using System;
using Telephony.Models;
using Telephony.Models.Interaces;

namespace Telephony
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string[] phoneNumbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            string[] urls = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            foreach (var phoneNumber in phoneNumbers)
            {

                ICallable phone;
                if (phoneNumber.Length == 10)
                {
                    phone = new Smartphone();
                    
                }
                else
                {
                    phone = new StationaryPhone();
                }

                try
                {
                    Console.WriteLine(phone.Call(phoneNumber));
                }

                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
