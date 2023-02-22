using Core.Constants;
using DataModel.ServiceModel;
using Microsoft.AspNetCore.Mvc;
using Nancy.Json;
using ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViewModels;

namespace KnockoutProject
{
    public class TourController : Controller
    {
        private ILocationService LocationService { get; set; }
        private IHotelService HotelService { get; set; }
        private ITourService TourService { get; set; }
        public TourController (ILocationService locationService,IHotelService hotelService,ITourService tourService)
        {
            this.LocationService = locationService;
            this.HotelService = hotelService;
            this.TourService = tourService;
        }
        public IActionResult AddTour()
        {
            return View();
        }
        [HttpPost]
        public JsonResult GetCityName(string Prefix)
        {
            List<CityDO> cities = LocationService.GetAllCitiesStartWithPrefix(Prefix);
            return Json(cities);
        }
        [HttpPost]
        public JsonResult GetSightSeenForCity(TourBookingViewModel tourBookingViewModel)
        {
            List<SightSeenDO> sightSeens = new List<SightSeenDO>();
            if (tourBookingViewModel.CityId > 0)
            {
                sightSeens = TourService.GetSightSeenForCity(tourBookingViewModel.CityId);

            }
            return Json(sightSeens);
        }
        [HttpPost]
        public JsonResult GetBookedHotelForCity(TourBookingViewModel tourBookingViewModel)
        {
            TourBookingDO tourBooking = new TourBookingDO();
            tourBooking.CityId = tourBookingViewModel.CityId;
            tourBooking.StartDate = tourBookingViewModel.StartDate;
            tourBooking.EndDate = tourBookingViewModel.EndDate;

            List<HotelDO> hotels = HotelService.GetBookedHotelForCity(tourBooking);
            return Json(hotels);
        }
        public ActionResult ListOfSightSeen()
        {
            return View();
        }
        public JsonResult GetListOfSightSeen()
        {
            List<SightSeenDO> sightSeens = new List<SightSeenDO>();
            sightSeens = TourService.GetListOfSightSeen();
            return Json(sightSeens);
        }
        public ActionResult AddSightSeen()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddSightSeen([FromBody]SightSeenViewModel sightSeenViewModel)
        {
            BaseModel baseModel = new BaseModel();
            SightSeenDO sightSeen = new SightSeenDO();
            sightSeen.Name = sightSeenViewModel.Name;
            sightSeen.SightseenName = sightSeenViewModel.SightseenName;
            sightSeen.Description = sightSeenViewModel.Description;
            sightSeen.CityId = sightSeenViewModel.CityId;
            bool result = TourService.AddSightSeen(sightSeen);
            if (result)
            {
                baseModel.IsError = false;
                baseModel.RedirectUrl = Url.Action(ActionNames.ListOfSightSeen, ControllerNames.Tour);
            }
            else
            {
                baseModel.IsError = true;
                baseModel.ErrorMessage = "Something went wrong";
            }
            return Json(baseModel);
        }
        public ActionResult EditSightSeen(int id)
        {
            if (id > 0)
            {
                SightSeenDO sightSeen = new SightSeenDO();
                sightSeen = TourService.GetSightSeenDetail(id);
                sightSeen.Cities = GetCities();
                var serializer = new JavaScriptSerializer();
                ViewBag.selectedSightSeen = serializer.Serialize(sightSeen);
            }
            return View();
        }
        public List<CityDO> GetCities()
        {
            List<CityDO> cities = TourService.GetCities();
            return cities;
        }
        [HttpPost]
        public ActionResult EditSightSeen(SightSeenViewModel sightSeenViewModel)
        {
            BaseModel baseModel = new BaseModel();
            if (sightSeenViewModel.Id > 0)
            {
                SightSeenDO sightSeen = new SightSeenDO();
                sightSeen.Id = sightSeenViewModel.Id;
                sightSeen.Name = sightSeenViewModel.SightseenName;
                sightSeen.Description = sightSeenViewModel.Description;
                sightSeen.CityId = sightSeenViewModel.CityId;
                bool result = TourService.EditSightSeen(sightSeen);
                if (result)
                {
                    baseModel.IsError = false;
                    baseModel.RedirectUrl = Url.Action(ActionNames.ListOfSightSeen, ControllerNames.Tour);
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
        public ActionResult DeleteSightSeen(int id)
        {
            BaseModel baseModel = new BaseModel();
            if (id > 0)
            {
                bool result = false;
                result = TourService.DeleteSightSeen(id);
                if (result)
                {
                    baseModel.IsError = false;
                    baseModel.RedirectUrl = Url.Action(ActionNames.ListOfSightSeen, ControllerNames.Tour);
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
