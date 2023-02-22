using DataModel.Models;
using RepositoryInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class HotelRepository : IHotelRepository
    {
        private IBaseRepository baseRepository;
        public HotelRepository(IBaseRepository BaseRepository)
        {
            this.baseRepository = BaseRepository;
        }
        public long AddHotel(Hotel hotel)
        {
            bool result = false;
            var context = baseRepository.GetContext();
            baseRepository.Add<Hotel>(hotel);
            baseRepository.Commit();
            return hotel.Id;
        }
        public long UpdateHotel(Hotel hotel)
        {
            //var data = baseRepository.GetContext().Hotel.Where(x => x.Id == hotel.Id).FirstOrDefault();
            baseRepository.Update<Hotel>(hotel);
            baseRepository.Commit();
            return hotel.Id;
        }
        public bool DeleteHotel(int id)
        {
            bool result = false;
            if (id > 0)
            {
                var context = baseRepository.GetContext();
                var data = context.Hotel.Where(x => x.Id==id).FirstOrDefault();
                if (data != null)
                {
                    baseRepository.Delete<Hotel>(data);
                    baseRepository.Commit();
                    result = true;
                }
            }
            return result;
        }

        public Hotel GetHotelData(int id)
        {
            Hotel hotelinfo = new Hotel();
            var context = baseRepository.GetContext();
            hotelinfo = (from hotel in context.Hotel
                      join country in context.Countries on hotel.CountryId equals country.Id
                      join state in context.States on hotel.StateId equals state.Id
                      join city in context.cities on hotel.CityId equals city.Id
                      where(hotel.Id==id)
                      select new Hotel
                      {
                          Id = hotel.Id,
                          Name = hotel.Name,
                          Address1 = hotel.Address1,
                          Address2 = hotel.Address2,
                          Address3 = hotel.Address3,
                          Star = hotel.Star,
                          CityName = city.Name,
                          StateName = state.Name,
                          CountryName = country.Name,
                          CityId = hotel.CityId,
                          StateId = hotel.StateId,
                          CountryId = hotel.CountryId,
                          Email = hotel.Email,
                          Website = hotel.Website,
                          Pincode = hotel.Pincode
                      }).FirstOrDefault();
            return hotelinfo;
        }
        public List<Hotel> GetAllHotels()
        {
            var context = baseRepository.GetContext();
            List<Hotel> hotels = context.Hotel.ToList();
            return hotels;
        }
        public List<Hotel> ListofHotels()
        {
            List<Hotel> hotels = new List<Hotel>();
            var context = baseRepository.GetContext();
            //hotels = baseRepository.GetContext().Hotel.OrderByDescending(x => x.Id).ToList();
            hotels=(from hotel in context.Hotel
             join country in context.Countries on hotel.CountryId equals country.Id
             join state in context.States on hotel.StateId equals state.Id
             join city in context.cities on hotel.CityId equals city.Id
             select new Hotel
             {
                 Id=hotel.Id,
                 Name=hotel.Name,
                 Address1=hotel.Address1,
                 Address2=hotel.Address2,
                 Address3=hotel.Address3,
                 Star=hotel.Star,
                 CityName=city.Name,
                 StateName=state.Name,
                 CountryName=country.Name,
                 CityId=hotel.CityId,
                 StateId=hotel.StateId,
                 CountryId=hotel.CountryId,
                 Email=hotel.Email,
                 Website=hotel.Website,
                 Pincode=hotel.Pincode
             }).ToList();
            return hotels;
        }

        public long BookHotel(HotelBooking hotelBooking)
        {
            bool result = false;
            var context = baseRepository.GetContext();
            baseRepository.Add<HotelBooking>(hotelBooking);
            baseRepository.Commit();
            return hotelBooking.Id;
        }

        public List<HotelBooking> GetBookedHotel()
        {
            List<HotelBooking> hotels = new List<HotelBooking>();
            var context = baseRepository.GetContext();
            //hotels = baseRepository.GetContext().Hotel.OrderByDescending(x => x.Id).ToList();
            hotels = (from hotelbooking in context.HotelBooking
                      join hotel in context.Hotel on hotelbooking.HotelId equals hotel.Id
                      select new HotelBooking
                      {
                          Id = hotelbooking.Id,
                          HotelId = hotelbooking.HotelId,
                          FromDate = hotelbooking.FromDate,
                          ToDate = hotelbooking.ToDate,
                         HotelName= hotel.Name
                      }).ToList();
            return hotels;
        }

        public List<Hotel> GetBookedHotelForCity(int cityId, DateTime startDate, DateTime endDate)
        {
            List<Hotel> hotels = new List<Hotel>();
            var context = baseRepository.GetContext();
            DateTime? startDateUTC = null;
            DateTime? endDateUTC = null;
            DateTime fdate = startDate;
            string fromdate = fdate.ToString("yyyy-MM-dd 00:00:00.000");
            startDate = System.Convert.ToDateTime(fromdate);
            startDateUTC = startDate;
            startDateUTC = startDateUTC.Value;

            DateTime tdate = endDate;
            string todate = tdate.ToString("yyyy-MM-dd 00:00:00.000");
            endDate = System.Convert.ToDateTime(todate);
            endDateUTC = endDate;
            endDateUTC = endDateUTC.Value;

            hotels = (from hotelBooking in context.HotelBooking
                      join hotel in context.Hotel on hotelBooking.HotelId equals hotel.Id
                      where hotel.CityId == cityId
                      select new Hotel
                      {
                          Id = hotel.Id,
                          Name = hotel.Name,
                          StartDate=hotelBooking.FromDate,
                          EndDate=hotelBooking.ToDate
                      }).ToList();
            foreach(var item in hotels)
            {
                DateTime startTimeFormate = item.StartDate; // This  is utc date time
                TimeZoneInfo systemTimeZone = TimeZoneInfo.Local;

                DateTime localDateTime = TimeZoneInfo.ConvertTimeFromUtc(startTimeFormate, systemTimeZone);
                item.StartDate = localDateTime;

                DateTime endTimeFormate = item.EndDate; // This  is utc date time
                TimeZoneInfo endsystemTimeZone = TimeZoneInfo.Local;

                DateTime localendDateTime = TimeZoneInfo.ConvertTimeFromUtc(endTimeFormate, endsystemTimeZone);
                item.EndDate = localendDateTime;
            }
            if (hotels.Count > 0)
            {
                hotels = hotels.Where(x=>x.StartDate.Date<= startDateUTC.Value.Date && x.EndDate.Date>= startDateUTC.Value.Date && x.StartDate.Date<=endDateUTC.Value.Date && x.EndDate.Date>=endDateUTC.Value.Date).ToList();
                //hotels = hotels.Where(x => x.StartDate.Date >= startDateUTC.Value.Date).ToList();
                //hotels = hotels.Where(x => x.StartDate.Date >= startDateUTC.Value.Date && x.EndDate.Date >= startDateUTC.Value.Date && x.StartDate.Date <= endDateUTC.Value.Date && x.EndDate.Date <= endDateUTC.Value.Date).ToList();

            }
            return hotels;
        }

        public bool DeleteBooking(int id)
        {
            bool result = false;
            if (id > 0)
            {
                var context = baseRepository.GetContext();
                var data = context.HotelBooking.Where(x => x.Id == id).FirstOrDefault();
                if (data != null)
                {
                    baseRepository.Delete<HotelBooking>(data);
                    baseRepository.Commit();
                    result = true;
                }
            }
            return result;
        }

        public HotelBooking GetHotelBookingData(int id)
        {
            HotelBooking hotelBooking = new HotelBooking();
            var context = baseRepository.GetContext();
            hotelBooking = (from hotelbookingdata in context.HotelBooking
                            join hotel in context.Hotel on hotelbookingdata.HotelId equals hotel.Id
                            where(hotelbookingdata.Id==id)
                            select new HotelBooking
                            {
                                Id = hotelbookingdata.Id,
                                FromDate= hotelbookingdata.FromDate,
                                ToDate= hotelbookingdata.ToDate,
                                HotelId= hotelbookingdata.HotelId,
                                HotelName=hotel.Name,
                            }).FirstOrDefault();
            return hotelBooking;
        }
        public long EditHotelBooking(HotelBooking hotelBooking)
        {
            baseRepository.Update<HotelBooking>(hotelBooking);
            baseRepository.Commit();
            return hotelBooking.Id;
        }
    }
}
