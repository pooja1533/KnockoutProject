using DataModel.ServiceModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceInterfaces
{
    public interface IHotelService
    {
         bool AddHotel(HotelDO hotel);
        List<HotelDO> ListofHotels();
        HotelDO GetHotelData(int id);
        bool DeleteHotel(int id);
        bool UpdateHotel(HotelDO hotel);
        List<HotelDO> GetAllHotels();
        bool BookHotel(HotelBookingDO hotelBooking);
        List<HotelBookingDO> GetBookedHotel();
        List<HotelDO> GetBookedHotelForCity(TourBookingDO tourBooking);
        bool DeleteBooking(int id);
        HotelBookingDO GetHotelBookingData(int id);
        bool EditHotelBooking(HotelBookingDO hotelBookingDO);
    }
}
