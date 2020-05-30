using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merendero
{
    public class ClsClient : ClsAccount
    {
        public List<ClsBooking> ListBookings { get; private set; }

        public ClsClient(string _name, string _password) : base(_name, _password, ClsAccount.EnType.CLIENT)
        {
            //fill with products on database
            ListBookings = GetBookings();
        }

        private List<ClsBooking> GetBookings()
        {
            List<ClsBooking> list = new List<ClsBooking>();



            return list;
        }
    }
}
