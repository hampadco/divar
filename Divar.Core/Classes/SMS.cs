using System;
using System.Collections.Generic;
using System.Text;
using Kavenegar;

namespace Divar.Core.Classes
{
    public class SMS
    {
        public void Send(string To, string Body)
        {
            var sender = "10004346";
            var receptor = To;
            var message = Body;
            var api = new KavenegarApi("74774D6F6A6D346D2F5279755241674E49735750424655794E6952636F503735");
            api.Send(sender, receptor, message);
        }
    }
}
