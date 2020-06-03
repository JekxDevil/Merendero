using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merendero
{
    public class ClsBooking
    {
        #region FIELDS
        public int Id { get; private set; }
        public string Bar { get; private set; }
        public string Client { get; private set; }
        public int Product { get; private set; }
        public DateTime Timestamp { get; private set; }
        #endregion

        #region CONTRUCTORS
        /// <summary>
        /// Contructor - used when getting bookings from database
        /// </summary>
        /// <param name="_id">id in int per copy</param>
        /// <param name="_bar">bar in string per copy</param>
        /// <param name="_client">client in string per copy</param>
        /// <param name="_product">product id in int per copy</param>
        /// <param name="_timestamp">timestamp object</param>
        public ClsBooking(int _id, string _bar, string _client, int _product, DateTime _timestamp)
        {
            Id = _id;
            Bar = _bar;
            Client = _client;
            Product = _product;
            Timestamp = _timestamp;
        }

        /// <summary>
        /// Contructor - used when create object bookings to insert into database
        /// </summary>
        /// <param name="_client">client name in string per copy</param>
        /// <param name="_product">product key in int per copy</param>
        public ClsBooking(string _client, int _product)
        {
            Client = _client;
            Product = _product;
            Timestamp = DateTime.Now;
        }
        #endregion
    }
}
