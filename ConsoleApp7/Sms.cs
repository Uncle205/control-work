using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace ConsoleApp7
{
    class Sms
    {
        public void Prog(string[] args)
        {
            // Find your Account Sid and Token at twilio.com/console
            const string accountSid = "ACfa1dc641f65b4553982e12d1ed28e783";
            const string authToken = "c266720aff16179a2a2faeb59cf99696";

            TwilioClient.Init(accountSid, authToken);
            Random random = new Random { };
            var message = MessageResource.Create(
                from: new Twilio.Types.PhoneNumber("+18508426542"),
                to: new Twilio.Types.PhoneNumber("+7012125093")
            );


            Console.WriteLine(message.Sid);
        }
        public void SendMessage(string[] args)
        {
            void Send()
            {

            }
        }
    }
}
