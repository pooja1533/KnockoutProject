using DataModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel.ServiceModel.Converter
{
    public class HotelBookingConverter
    {
        public static HotelBookingDO ConvertHotelBookingData(HotelBooking hotelBooking)
        {
            if (hotelBooking != null)
            {
                return new HotelBookingDO
                {

                    Id = hotelBooking.Id,
                    HotelId = hotelBooking.HotelId,
                    StartDate = hotelBooking.FromDate,
                    EndDate = hotelBooking.ToDate,
                    HotelName=hotelBooking.HotelName
                };
            }
            else
            {
                return new HotelBookingDO();
            }
        }
    }
}
