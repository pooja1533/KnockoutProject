using DataModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryInterface
{
    public interface IHotelRepository
    {
        long AddHotel(Hotel hotel);
        List<Hotel> ListofHotels();
        Hotel GetHotelData(int id);
        bool DeleteHotel(int id);
        long UpdateHotel(Hotel hotel);
        List<Hotel> GetAllHotels();
        long BookHotel(HotelBooking hotelBooking);
        List<HotelBooking> GetBookedHotel();
        List<Hotel> GetBookedHotelForCity(int cityId, DateTime startDate, DateTime endDate);
        bool DeleteBooking(int id);
        HotelBooking GetHotelBookingData(int id);
        long EditHotelBooking(HotelBooking hotelBooking);
    }
}
