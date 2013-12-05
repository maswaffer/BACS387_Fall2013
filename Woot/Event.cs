using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Woot
{
   public class Event
    {
        public static object Tools;
        public static object Daily;
        public DateTime EndDate { get; set; }
        public Guid Id { get; set; }
        public string Site { get; set; }
        public DateTime StartDate { get; set; }
        public string Title { get; set; }
        public string Type { get; set; }
        public List<Offer> Offers { get; set; }

        //public void one();


        public object StartDates()
        {
            throw new NotImplementedException();
        }
    }
}
