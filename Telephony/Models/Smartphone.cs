using System;
using System.Collections.Generic;
using System.Text;
using Telephony.Models.Interaces;

namespace Telephony.Models
{
    public class Smartphone : ICallable, IBrowsable
    {
        public string Browse(string url)
        {
            throw new NotImplementedException();
        }

        public string Call(string phoneNumber)
        {
            throw new NotImplementedException();
        }
    }
}
