using System;
using System.Collections.Generic;
using System.Text;
using Telephony.Core.Interfaces;
using Telephony.IO;
using Telephony.IO.Interfaces;
using Telephony.Models;
using Telephony.Models.Interaces;

namespace Telephony.Core
{
    public class Engine : IEngine
    {
        private IReader reader;
        private IWriter writer;

        public Engine(IReader reader, IWriter writer)
        {
            this.reader = new ConsoleReader();
            this.writer = new ConsoleWriter();
        }

        public void Run()
        {
            string[] phoneNumbers = reader.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            string[] urls = reader.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

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
                    writer.WriteLine(callable.Call(phoneNumber));
                }

                catch (ArgumentException ex)
                {
                    writer.WriteLine(ex.Message);
                }
            }

            IBrowsable browsable = new Smartphone();

            foreach (var url in urls)
            {

                try
                {
                    writer.WriteLine(browsable.Browse(url));
                }

                catch (ArgumentException ex)
                {
                    writer.WriteLine(ex.Message);
                }
            }
        }
    }
}
