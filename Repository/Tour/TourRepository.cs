using DataModel.Models;
using RepositoryInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class TourRepository : ITourRepository
    {
        private IBaseRepository baseRepository;
        public TourRepository(IBaseRepository BaseRepostiory)
        {
            this.baseRepository = BaseRepostiory;
        }
        public long AddSightSeen(SightSeen sightSeen)
        {
            baseRepository.Add<SightSeen>(sightSeen);
            baseRepository.Commit();
            return sightSeen.Id;
        }

        public long EditSightSeen(SightSeen sightSeen)
        {
            baseRepository.Update<SightSeen>(sightSeen);
            baseRepository.Commit();
            return sightSeen.Id;
        }
        public bool DeleteSightSeen(int id)
        {
            bool result = false;
            if (id > 0)
            {
                var context = baseRepository.GetContext();
                var data = context.SightSeen.Where(x => x.Id == id).FirstOrDefault();
                if (data != null)
                {
                    baseRepository.Delete<SightSeen>(data);
                    baseRepository.Commit();
                    result = true;
                }
            }
            return result;
        }
        public List<City> GetCities()
        {
            List<City> cities = new List<City>();
            var context=  baseRepository.GetContext();
            cities = context.cities.ToList();
            return cities;
        }

        public List<SightSeen> GetListOfSightSeen()
        {
            List<SightSeen> sightSeens = new List<SightSeen>();
            var context = baseRepository.GetContext();
            sightSeens = (from sightseen in context.SightSeen
                          join city in context.cities on sightseen.CityId equals city.Id
                          select new SightSeen
                          {
                              Id=sightseen.Id,
                              Name = sightseen.Name,
                              Description=sightseen.Description,
                              CityName=city.Name
                          }).ToList();
            return sightSeens;
        }

        public SightSeen GetSightSeenDetail(int id)
        {
            SightSeen sightSeen = new SightSeen();
            var context = baseRepository.GetContext();
            sightSeen = (from sightseen in context.SightSeen
                         join city in context.cities on sightseen.CityId equals city.Id
                         where (sightseen.Id == id)
                         select new SightSeen
                         {
                             Name= sightseen.Name,
                             CityId= sightseen.CityId,
                             CityName=city.Name,
                             Id= sightseen.Id,
                             Description=sightseen.Description,
                         }).FirstOrDefault();
            return sightSeen;
        }

        public List<SightSeen> GetSightSeenForCity(int id)
        {
            List<SightSeen> sightSeens = new List<SightSeen>();
            var context = baseRepository.GetContext();
            sightSeens = (from sightseen in context.SightSeen where
                          sightseen.CityId == id
                          select new SightSeen
                          {
                              Id = sightseen.Id,
                              Name=sightseen.Name,
                              Description=sightseen.Description
                          }).ToList();
            return sightSeens;
        }
    }
}
