using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merendero
{
    public class ClsBooking
    {
        public int Id { get; private set; }
        public string Bar { get; private set; }
        public string Client { get; private set; }
        public int Product { get; private set; }
        public DateTime Timestamp { get; private set; }

        public ClsBooking(int _id, string _bar, string _client, int _product)
        {
            Id = _id;
            Bar = _bar;
            Client = _client;
            Product = _product;
            Timestamp = DateTime.Now;
        }
    }
}
