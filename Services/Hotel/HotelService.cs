using DataModel.Models;
using DataModel.ServiceModel;
using DataModel.ServiceModel.Converter;
using RepositoryInterface;
using ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class HotelService:IHotelService
    {
        private IHotelRepository hotelRepository;

        public HotelService(IHotelRepository HotelRepository)
        {
            this.hotelRepository = HotelRepository;
        }
        public List<HotelDO> ListofHotels()
        {
            List<Hotel> hotels = new List<Hotel>();
            List<HotelDO> hotellist = new List<HotelDO>();
            hotels = hotelRepository.ListofHotels();
            if (hotels.Count > 0)
            {
                foreach(var item in hotels)
                {
                    hotellist.Add(HotelConverter.ConvertHotelDetail(item));
                }
            }
            return hotellist;
        }
        public bool AddHotel(HotelDO hotel)
        {
            Hotel hoteldata = new Hotel();
            bool result = false;
            hoteldata.Name = hotel.Name;
            hoteldata.Address1 = hotel.Address1;
            hoteldata.Address2 = hotel.Address2;
            hoteldata.Address3 = hotel.Address3;
            hoteldata.Star = hotel.Star;
            hoteldata.CityId = hotel.CityId;
            hoteldata.StateId = hotel.StateId;
            hoteldata.CountryId = hotel.CountryId;
            hoteldata.Email = hotel.Email;
            hoteldata.Website = hotel.Website;
            hoteldata.Pincode = hotel.Pincode;
            long Id = hotelRepository.AddHotel(hoteldata);
            if (Id > 0)
                result = true;
            return result;
        }
        public bool UpdateHotel(HotelDO hotel)
        {
            Hotel hoteldata = new Hotel();
            bool result = false;
            hoteldata.Id = hotel.Id;
            hoteldata.Name = hotel.Name;
            hoteldata.Address1 = hotel.Address1;
            hoteldata.Address2 = hotel.Address2;
            hoteldata.Address3 = hotel.Address3;
            hoteldata.Star = hotel.Star;
            hoteldata.CityId = hotel.CityId;
            hoteldata.StateId = hotel.StateId;
            hoteldata.CountryId = hotel.CountryId;
            hoteldata.Email = hotel.Email;
            hoteldata.Website = hotel.Website;
            hoteldata.Pincode = hotel.Pincode;
            long Id = hotelRepository.UpdateHotel(hoteldata);
            if (Id > 0)
                result = true;
            return result;
        }
        public HotelDO GetHotelData(int id)
        {
            HotelDO hoteldata = new HotelDO();
            Hotel hotel = new Hotel();
            hotel = hotelRepository.GetHotelData(id);
            if (hotel != null)
            {
                hoteldata = HotelConverter.ConvertHotelDetail(hotel);
            }
            return hoteldata;
        }

        public bool DeleteHotel(int id)
        {
            bool result = hotelRepository.DeleteHotel(id);
            return result;
        }
        public List<HotelDO> GetAllHotels()
        {
            List<Hotel> hotels = new List<Hotel>();
            List<HotelDO> hotelsData = new List<HotelDO>();
            hotels = hotelRepository.GetAllHotels();
            if (hotels.Count > 0)
            {
                foreach(var hotel in hotels)
                {
                    hotelsData.Add(HotelConverter.ConvertHotelDetail(hotel));

                }
            }
            return hotelsData;
        }

        public bool BookHotel(HotelBookingDO hotelBooking)
        {
            HotelBooking hotelBookingData = new HotelBooking();
            bool result = false;
            hotelBookingData.HotelId = hotelBooking.HotelId;
            hotelBookingData.FromDate = hotelBooking.StartDate;
            hotelBookingData.ToDate = hotelBooking.EndDate;
            long Id = hotelRepository.BookHotel(hotelBookingData);
            if (Id > 0)
                result = true;
            return result;
        }
        public bool DeleteBooking(int id)
        {
            bool result = hotelRepository.DeleteBooking(id);
            return result;
        }
        public List<HotelBookingDO> GetBookedHotel()
        {
            List<HotelBooking> hotelBookings = new List<HotelBooking>();
            List<HotelBookingDO> hotellist = new List<HotelBookingDO>();
            hotelBookings = hotelRepository.GetBookedHotel();
            if (hotelBookings.Count > 0)
            {
                foreach (var item in hotelBookings)
                {
                    hotellist.Add(HotelConverter.ConvertBookedHotelDetail(item));
                }
            }
            return hotellist;
        }

        public List<HotelDO> GetBookedHotelForCity(TourBookingDO tourBooking)
        {
            List<Hotel> hotels = new List<Hotel>();
            List<HotelDO> hotellist = new List<HotelDO>();
            int cityId = tourBooking.CityId;
            DateTime startDate = tourBooking.StartDate;
            DateTime endDate = tourBooking.EndDate;
            hotels = hotelRepository.GetBookedHotelForCity(cityId, startDate, endDate);
            if (hotels.Count > 0)
            {
                foreach(var item in hotels)
                {

                    hotellist.Add(HotelConverter.ConvertHotelDetail(item));
                }
            }
            return hotellist;
        }

        public HotelBookingDO GetHotelBookingData(int id)
        {
            HotelBookingDO hotelBookingDO = new HotelBookingDO();
            HotelBooking hotelBooking = new HotelBooking();
            hotelBooking = hotelRepository.GetHotelBookingData(id);
            if(hotelBooking != null)
            {
                hotelBookingDO = HotelBookingConverter.ConvertHotelBookingData(hotelBooking);
            }
            return hotelBookingDO;
        }
        public bool EditHotelBooking(HotelBookingDO hotelBookingDO)
        {
            HotelBooking hotelBooking = new HotelBooking();
            hotelBooking.Id = hotelBookingDO.Id;
            hotelBooking.HotelId = hotelBookingDO.HotelId;
            hotelBooking.FromDate = hotelBookingDO.StartDate;
            hotelBooking.ToDate = hotelBookingDO.EndDate;
            long Id = hotelRepository.EditHotelBooking(hotelBooking);
            if (Id > 0)
                return true;
            else
                return false;
        }
    }
}
