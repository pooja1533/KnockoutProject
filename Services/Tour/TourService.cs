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
    public class TourService : ITourService
    {
        private ITourRepository tourRepository;

        public TourService(ITourRepository TourRepository)
        {
            this.tourRepository = TourRepository;
        }
        public bool AddSightSeen(SightSeenDO sightSeen)
        {
            SightSeen sightseen = new SightSeen();
            bool result = false;
            sightseen.Name = sightSeen.SightseenName;
            sightseen.Description = sightSeen.Description;
            sightseen.CityId = sightSeen.CityId;
            long Id = tourRepository.AddSightSeen(sightseen);
            if (Id > 0)
                result = true;
            return result;
        }

        public bool EditSightSeen(SightSeenDO sightSeen)
        {
            SightSeen sighteenData = new SightSeen();
            sighteenData.Id = sightSeen.Id;
            sighteenData.CityId = sightSeen.CityId;
            sighteenData.Name = sightSeen.Name;
            sighteenData.Description = sightSeen.Description;
            long Id = tourRepository.EditSightSeen(sighteenData);
            if (Id > 0)
                return true;
            else
                return false;
        }
        public bool DeleteSightSeen(int id)
        {
            bool result = tourRepository.DeleteSightSeen(id);
            return result;
        }
        public List<CityDO> GetCities()
        {
            List<CityDO> citiesDO = new List<CityDO>();
            List<City> cities = new List<City>();
            cities = tourRepository.GetCities();
            if (cities.Count > 0)
            {
                foreach(var item in cities)
                {
                    citiesDO.Add(LocationConveter.ConvertCity(item));
                }
            }
            return citiesDO;
        }

        public List<SightSeenDO> GetListOfSightSeen()
        {
            List<SightSeen> sightSeens = new List<SightSeen>();
            List<SightSeenDO> sightseenList = new List<SightSeenDO>();
            sightSeens = tourRepository.GetListOfSightSeen();
            if (sightSeens.Count > 0)
            {
                foreach(var item in sightSeens)
                {
                    sightseenList.Add(SightSeenConverter.ConverSightSeenDetail(item));
                }
            }
            return sightseenList;
        }

        public SightSeenDO GetSightSeenDetail(int id)
        {
            SightSeenDO sightSeenDO = new SightSeenDO();
            SightSeen sightSeen = new SightSeen();
            sightSeen = tourRepository.GetSightSeenDetail(id);
            if (sightSeen != null)
            {
                sightSeenDO = SightSeenConverter.ConverSightSeenDetail(sightSeen);
            }
            return sightSeenDO;
        }

        public List<SightSeenDO> GetSightSeenForCity(int id)
        {
            List<SightSeen> sightSeens = new List<SightSeen>();
            List<SightSeenDO> sightSeenDO = new List<SightSeenDO>();
            sightSeens = tourRepository.GetSightSeenForCity(id);
            if (sightSeens.Count > 0)
            {
                foreach(var item in sightSeens)
                {
                    sightSeenDO.Add(SightSeenConverter.ConverSightSeenDetail(item));
                }
            }
            return sightSeenDO;
        }
    }
}
