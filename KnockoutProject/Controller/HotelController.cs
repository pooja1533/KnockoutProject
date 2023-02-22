using Core.Constants;
using DataModel.ServiceModel;
using Microsoft.AspNetCore.Mvc;
using Nancy.Json;
using ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using ViewModels;

namespace KnockoutProject
{
    public class HotelController : Controller
    {
        private ILocationService LocationService { get; set; }
        private IHotelService HotelService { get; set; }
        public HotelController(ILocationService locationService,IHotelService hotelService)
        {
            this.LocationService = locationService;
            this.HotelService = hotelService;
        }
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult ListofHotels()
        {
            List<HotelDO> hotels = new List<HotelDO>();
            hotels = HotelService.ListofHotels();
            return Json(hotels);
        }
        static string UppercaseFirst(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }
            char[] a = s.ToCharArray();
            a[0] = char.ToUpper(a[0]);
            return new string(a);
        }
        public IActionResult AddHotel()
        {
            HotelViewModel hotelViewModel = new HotelViewModel();
            
            return View();
        }
        [HttpPost]
        public ActionResult AddHotel([FromBody]HotelViewModel  hotelViewModel)
        {
            BaseModel model = new BaseModel();
            HotelDO hotel = new HotelDO();
            hotel.Name= hotelViewModel.Name.ToUpper();
            hotel.Address1 = hotelViewModel.Address1;
            hotel.Address2 = hotelViewModel.Address2;
            hotel.Address3 = hotelViewModel.Address3;
            hotel.Star = hotelViewModel.StarId;
            hotel.CityId = hotelViewModel.CityId;
            hotel.StateId = hotelViewModel.StateId;
            hotel.CountryId = hotelViewModel.CountryId;
            hotel.Email = hotelViewModel.Email;
            hotel.Website = hotelViewModel.Website;
            hotel.Pincode = System.Convert.ToInt32(hotelViewModel.Pincode);

            bool result = HotelService.AddHotel(hotel);
            if (result)
            {
                model.IsError = false;
                model.RedirectUrl = Url.Action(ActionNames.Index, ControllerNames.Hotel);
            }
            else
            {
                model.IsError = true;
                model.ErrorMessage = "UserName or Password wrong";
            }
            return Json(model);

        }
        public List<CountryDO> GetCounries()
        {
            List<CountryDO> countries = new List<CountryDO>();
            countries= LocationService.GetCountries();
            return countries;
        }
        [ActionName("GetStates")]
        public List<StateDO> GetStates(int countryId)
        {
            List<StateDO> states = new List<StateDO>();
            states = LocationService.GetStates(countryId);
            return states;

        }
        public List<CityDO> GetCities(int stateId)
        {
            List<CityDO> cities = new List<CityDO>();
            cities = LocationService.GetCities(stateId);
            return cities;
        }
        public static string GetEnumDescription(Enum value)
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());

            DescriptionAttribute[] attributes =
                (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);

            if (attributes != null && attributes.Length > 0)
                return attributes[0].Description;
            else
                return value.ToString();
        }
        public List<StarModel> GetStars()
        {
            HotelViewModel hotelViewModel = new HotelViewModel();
            hotelViewModel.Stars = new List<StarModel>();
            foreach (Star star in Enum.GetValues(typeof(Star)))
            {
                var description = GetEnumDescription(star);
                hotelViewModel.Stars.Add(new StarModel() { Star = star, Id = (int)star, Description = description });
            }
            return hotelViewModel.Stars;
        }
        public ActionResult Delete(int id)
        {
            if (id > 0)
            {
                HotelDO hotel = new HotelDO();
                hotel = HotelService.GetHotelData(id);
                //List<StateDO> states = new List<StateDO>();
                hotel.Country = GetCounries();
                //hotel.Stars = GetStars();
                hotel.States = GetStates(hotel.CountryId);
                hotel.City = GetCities(hotel.StateId);
                List<StarModel> stars = GetStars();
                hotel.Stars = new List<Stars>();

                foreach (var star in stars)
                {
                    hotel.Stars.Add(new DataModel.ServiceModel.Stars { Id=star.Id,Description=star.Description});
                }
                var serializer = new JavaScriptSerializer();
                ViewBag.SelectedHotel = serializer.Serialize(hotel);
            }
            return View();
        }
        [HttpPost]
        public ActionResult DeleteHotel(int id)
        {
            BaseModel baseModel = new BaseModel();
            if (id > 0)
            {
                bool result = HotelService.DeleteHotel(id);
                if (result)
                {
                    baseModel.IsError = false;
                    baseModel.RedirectUrl = Url.Action(ActionNames.Index, ControllerNames.Hotel);
                }
                else
                {
                    baseModel.IsError = true;
                    baseModel.RedirectUrl = Url.Action(ActionNames.Index, ControllerNames.Hotel);

                }
            }
            return Json(baseModel);
        }
        public ActionResult Edit(int id)
        {
            if (id > 0)
            {
                HotelDO hotel = new HotelDO();
                hotel = HotelService.GetHotelData(id);
                hotel.Country = GetCounries();
                hotel.States = GetStates(hotel.CountryId);
                hotel.City = GetCities(hotel.StateId);
                List<StarModel> stars = GetStars();
                hotel.Stars = new List<Stars>();

                foreach (var star in stars)
                {
                    hotel.Stars.Add(new DataModel.ServiceModel.Stars { Id = star.Id, Description = star.Description });
                }
                var serializer = new JavaScriptSerializer();
                ViewBag.SelectedHotel = serializer.Serialize(hotel);
            }
            return View();
        }
        [HttpPost]
        public ActionResult Edit(HotelViewModel hotelViewModel)
        {
            BaseModel model = new BaseModel();
            HotelDO hotel = new HotelDO();
            hotel.Id = hotelViewModel.Id;
            hotel.Name = hotelViewModel.Name;
            hotel.Address1 = hotelViewModel.Address1;
            hotel.Address2 = hotelViewModel.Address2;
            hotel.Address3 = hotelViewModel.Address3;
            hotel.Star = hotelViewModel.StarId;
            hotel.CityId = hotelViewModel.CityId;
            hotel.StateId = hotelViewModel.StateId;
            hotel.CountryId = hotelViewModel.CountryId;
            hotel.Email = hotelViewModel.Email;
            hotel.Website = hotelViewModel.Website;
            hotel.Pincode = System.Convert.ToInt32(hotelViewModel.Pincode);

            bool result = HotelService.UpdateHotel(hotel);
            if (result)
            {
                model.IsError = false;
                model.RedirectUrl= Url.Action(ActionNames.Index, ControllerNames.Hotel);
            }
            else
            {
                model.IsError = true;
            }
            return Json(model);
        }
        public List<HotelBookingDO> GetBookedHotels()
        {
            List<HotelBookingDO> hotelBookings = new List<HotelBookingDO>();
            hotelBookings = HotelService.GetBookedHotel();
            for(var i = 0; i < hotelBookings.Count; i++)
            {
                DateTime startTimeFormate = hotelBookings[i].StartDate; // This  is utc date time
                TimeZoneInfo systemTimeZone = TimeZoneInfo.Local;

                DateTime localDateTime = TimeZoneInfo.ConvertTimeFromUtc(startTimeFormate, systemTimeZone);
                hotelBookings[i].StartDate = localDateTime;
                hotelBookings[i].FromDate = hotelBookings[i].StartDate.ToString("dd-MM-yyyy HH:mm:ss");

                DateTime endTimeFormate = hotelBookings[i].EndDate; // This  is utc date time
                TimeZoneInfo systemTimeZoneLocal = TimeZoneInfo.Local;

                DateTime localDateTimeForEndDate = TimeZoneInfo.ConvertTimeFromUtc(endTimeFormate, systemTimeZoneLocal);
                hotelBookings[i].EndDate = localDateTimeForEndDate;
                hotelBookings[i].ToDate = hotelBookings[i].EndDate.ToString("dd-MM-yyyy HH:mm:ss");
            }
            return hotelBookings;
        }
        public ActionResult BookHotel()
        {
            
            return View();
        }
        [HttpPost]
        public ActionResult BookHotel(HotelBookingViewModel hotelBookingViewModel)
        {
            BaseModel baseModel = new BaseModel();
            if (hotelBookingViewModel.HotelId > 0)
            {
                HotelBookingDO hotelBooking = new HotelBookingDO();
                hotelBooking.HotelId = hotelBookingViewModel.HotelId;
                hotelBooking.StartDate = hotelBookingViewModel.StartDate;
                hotelBooking.EndDate = hotelBookingViewModel.EndDate;

                TimeSpan time = DateTime.Now.TimeOfDay;
                var hour = time.Hours;
                var minute = time.Minutes;
                var second = time.Seconds;

                DateTime date = (DateTime)hotelBooking.StartDate;
                DateTime fdate = date.Add(new TimeSpan(hour, minute, second));
                DateTime startutcdate = TimeZoneInfo.ConvertTimeToUtc(fdate);
                hotelBooking.StartDate = startutcdate;

                DateTime toDate = (DateTime)hotelBooking.EndDate;
                DateTime tdate = toDate.Add(new TimeSpan(hour, minute, second));
                DateTime endutcdate = TimeZoneInfo.ConvertTimeToUtc(tdate);
                hotelBooking.EndDate = endutcdate;

                bool result = HotelService.BookHotel(hotelBooking);
                if (result)
                {
                    baseModel.IsError = false;
                    baseModel.RedirectUrl = Url.Action(ActionNames.BookHotel, ControllerNames.Hotel);
                }
                else
                {
                    baseModel.IsError = true;
                    baseModel.ErrorMessage = "Something went wrong";
                }
            }
            return Json(baseModel);
        }
        [HttpPost]
        public JsonResult GetHotelName(string Prefix)
        {
            List<HotelDO> hotels =HotelService.GetAllHotels();
            Prefix = Prefix.ToUpper();
            var hotelList = (from hotel in hotels
                             where hotel.Name.StartsWith(Prefix)
                             select new HotelDO{Name= hotel.Name ,Id=hotel.Id});
            return Json(hotelList);
        }
        [HttpPost]
        public ActionResult DeleteBooking(int id)
        {
            BaseModel baseModel = new BaseModel();
            if (id > 0)
            {
                bool result = false;
                result = HotelService.DeleteBooking(id);
                if (result)
                {
                    baseModel.IsError = false;
                    baseModel.RedirectUrl = Url.Action(ActionNames.BookHotel, ControllerNames.Hotel);
                }
                else
                {
                    baseModel.IsError = true;
                    baseModel.ErrorMessage = "Something went wrong";
                }
            }
            return Json(baseModel);
        }
        [HttpGet]
        public ActionResult EditBooking(int id)
        {
            if (id > 0)
            {
                HotelBookingDO hotelBooking = new HotelBookingDO();
                hotelBooking = HotelService.GetHotelBookingData(id);
                hotelBooking.hotels = HotelService.ListofHotels();
                
                    DateTime startTimeFormate = hotelBooking.StartDate; // This  is utc date time
                    TimeZoneInfo systemTimeZone = TimeZoneInfo.Local;

                    DateTime localDateTime = TimeZoneInfo.ConvertTimeFromUtc(startTimeFormate, systemTimeZone);
                hotelBooking.StartDate = localDateTime;
                hotelBooking.FromDate = hotelBooking.StartDate.ToString("MM/dd/yyyy");

                    DateTime endTimeFormate = hotelBooking.EndDate; // This  is utc date time
                    TimeZoneInfo systemTimeZoneLocal = TimeZoneInfo.Local;

                    DateTime localDateTimeForEndDate = TimeZoneInfo.ConvertTimeFromUtc(endTimeFormate, systemTimeZoneLocal);
                hotelBooking.EndDate = localDateTimeForEndDate;
                hotelBooking.ToDate = hotelBooking.EndDate.ToString("MM/dd/yyyy");
                
                var serializer = new JavaScriptSerializer();
                ViewBag.selectedBooking= serializer.Serialize(hotelBooking);
            }
            return View();
        }
        [HttpPost]
        public ActionResult EditHotelBooking(HotelBookingViewModel hotelBookingViewModel)
        {
            BaseModel baseModel = new BaseModel();
            if (hotelBookingViewModel.Id > 0)
            {
                HotelBookingDO hotelBookingDO = new HotelBookingDO();
                hotelBookingDO.Id = hotelBookingViewModel.Id;
                hotelBookingDO.HotelId = hotelBookingViewModel.HotelId;
                hotelBookingDO.StartDate = hotelBookingViewModel.StartDate;
                hotelBookingDO.EndDate = hotelBookingViewModel.EndDate;

                TimeSpan time = DateTime.Now.TimeOfDay;
                var hour = time.Hours;
                var minute = time.Minutes;
                var second = time.Seconds;

                DateTime date = (DateTime)hotelBookingDO.StartDate;
                DateTime fdate = date.Add(new TimeSpan(hour, minute, second));
                DateTime startutcdate = TimeZoneInfo.ConvertTimeToUtc(fdate);
                hotelBookingDO.StartDate = startutcdate;

                DateTime toDate = (DateTime)hotelBookingDO.EndDate;
                DateTime tdate = toDate.Add(new TimeSpan(hour, minute, second));
                DateTime endutcdate = TimeZoneInfo.ConvertTimeToUtc(tdate);
                hotelBookingDO.EndDate = endutcdate;

                bool result = HotelService.EditHotelBooking(hotelBookingDO);
                if (result)
                {
                    baseModel.IsError = false;
                    baseModel.RedirectUrl = Url.Action(ActionNames.BookHotel, ControllerNames.Hotel);
                }
                else
                {
                    baseModel.IsError = true;
                    baseModel.ErrorMessage = "Something went wrong";
                }
            }
            return Json(baseModel);
        }
    }
}
