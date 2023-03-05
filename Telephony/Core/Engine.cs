using System;
using System.Collections.Generic;
using System.Text;
using Telephony.Core.Interfaces;
using Telephony.Models;
using Telephony.Models.Interaces;

namespace Telephony.Core
{
    public class Engine : IEngine
    {
        public void Run()
        {
            string[] phoneNumbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            string[] urls = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            ICallable callable;

            foreach (var phoneNumber in phoneNumbers)
            {


                if (phoneNumber.Length == 10)
                {
                    callable = new Smartphone();

                }
                else
                {
                    callable = new StationaryPhone();
                }

                try
                {
                    Console.WriteLine(callable.Call(phoneNumber));
                }

                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            IBrowsable browsable = new Smartphone();

            foreach (var url in urls)
            {

                try
                {
                    Console.WriteLine(browsable.Browse(url));
                }

                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
