using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Telephony.Models.Interaces;

namespace Telephony.Models
{
    public class Smartphone : ICallable, IBrowsable
    {

        public string Call(string phoneNumber)
        {
            if (!ValidatePhoneNumber(phoneNumber))
            {
                throw new ArgumentException("Invalid number!");
            }
            return $"Calling... {phoneNumber}";
        }

        public string Browse(string url)
        {
            throw new NotImplementedException();
        }

        private bool ValidatePhoneNumber(string phoneNumber)
            => phoneNumber.All(c => Char.IsDigit(c));

        private bool ValidateUrl(string url)
            => url.All(c => Char.IsLetter(c));
    }
}
