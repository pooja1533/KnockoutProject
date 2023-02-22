using DataModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel.ServiceModel.Converter
{
    public class HotelConverter
    {
        public static HotelBookingDO ConvertBookedHotelDetail(HotelBooking hotelBooking)
        {
            if(hotelBooking != null)
            {
                return new HotelBookingDO
                {
                    Id = hotelBooking.Id,
                    Name = hotelBooking.HotelName,
                    HotelId = hotelBooking.HotelId,
                    StartDate = hotelBooking.FromDate,
                    EndDate = hotelBooking.ToDate,
                };
            }
            else
            {
                return new HotelBookingDO();
            }
        }
        public static HotelDO ConvertHotelDetail(Hotel hotel)
        {
            if (hotel != null)
            {
                return new HotelDO
                {
                    Id = hotel.Id,
                    Name = hotel.Name,
                    Address1 = hotel.Address1,
                    Address2=hotel.Address2,
                    Address3=hotel.Address3,
                    Star=hotel.Star,
                    CityId=hotel.CityId,
                    StateId=hotel.StateId,
                    CountryId=hotel.CountryId,
                    Email=hotel.Email,
                    Website=hotel.Website,
                    Pincode=hotel.Pincode,
                    CityName=hotel.CityName,
                    StateName=hotel.StateName,
                    CountryName=hotel.CountryName,
                };
            }
            else
            {
                return new HotelDO();
            }
        }
    }
}
