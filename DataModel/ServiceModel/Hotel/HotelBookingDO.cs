using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel.ServiceModel
{
   public class HotelBookingDO
    {
        public int Id { get; set; }
        public long HotelId { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string FromDate { get; set; }
        public string ToDate { get; set; }
        [NotMapped]
        public List<HotelDO> hotels { get; set; }
        public string HotelName { get; set; }
    }
}
