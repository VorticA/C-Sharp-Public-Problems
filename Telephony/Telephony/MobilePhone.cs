using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telephony
{
    public class MobilePhone : ICallable, IBrowsable
    {
        private string model;

        public string Model { get => this.model; set => this.model=value; }

        public MobilePhone(string model)
        {
            this.Model = model;
        }

        public void Call(string number)
        {
            if (!number.All(char.IsDigit)) throw new InvalidPhoneNumberException("Invalid number!");
            Console.WriteLine("Calling... " + number);
        }
        public void Browse(string website)
        {
            if (website.Any(char.IsNumber)) throw new InvalidWebsiteException("Invalid URL!");
            Console.WriteLine("Browsing: " + website);
        }
    }
}
