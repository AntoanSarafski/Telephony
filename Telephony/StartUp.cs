using System;
using Telephony.Core;
using Telephony.Core.Interfaces;
using Telephony.Models;
using Telephony.Models.Interaces;

namespace Telephony
{
    class StartUp
    {
        static void Main(string[] args)
        {
            IEngine engine = new Engine();
            engine.Run();
        }
    }
}
