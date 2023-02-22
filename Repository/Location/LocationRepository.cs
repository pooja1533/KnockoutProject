using DataModel.Models;
using RepositoryInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class LocationRepository : ILocationRepository
    {
        private IBaseRepository baseRepository;
        public LocationRepository(IBaseRepository BaseRepository)
        {
            this.baseRepository = BaseRepository;
        }
        public List<Country> GetCountries()
        {
            List<Country> countries = new List<Country>();
            countries = baseRepository.GetContext().Countries.Where(x=>x.IsDeleted==false).ToList();
            return countries;
        }
        public List<State> GetStates(int countryId)
        {
            List<State> states = new List<State>();
            states = baseRepository.GetContext().States.Where(x=>x.Country_Id==countryId).ToList();
            return states;
        }
        public List<City> GetCities(int stateId)
        {
            List<City> cities = new List<City>();
            cities = baseRepository.GetContext().cities.Where(x => x.State_Id == stateId).ToList();
            return cities;
        }
        public List<City> GetAllCitiesStartWithPrefix(string Prefix)
        {
            List<City> cities = new List<City>();
            cities = baseRepository.GetContext().cities.Where(x=>x.Name.StartsWith(Prefix)).ToList();
            return cities;
        }
    }
}
