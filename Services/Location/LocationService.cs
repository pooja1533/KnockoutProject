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
    public class LocationService : ILocationService
    {
        private ILocationRepository locationRepository;

        public LocationService(ILocationRepository LocationRepository)
        {
            this.locationRepository = LocationRepository;
        }

        public List<CityDO> GetCities(int stateId)
        {
            List<CityDO> cities = new List<CityDO>();
            List<City> citylist = new List<City>();
            citylist = locationRepository.GetCities(stateId);
            if (citylist.Count > 0)
            {
                foreach (City city in citylist)
                {
                    cities.Add(LocationConveter.ConvertCity(city));
                }
            }
            return cities;
        }
        public List<CityDO> GetAllCitiesStartWithPrefix(string Prefix)
        {
            List<CityDO> cities = new List<CityDO>();
            List<City> cityList = new List<City>();
            cityList = locationRepository.GetAllCitiesStartWithPrefix(Prefix);
            if (cityList.Count > 0)
            {
                foreach(City city in cityList)
                {
                    cities.Add(LocationConveter.ConvertCity(city));
                }
            }
            return cities;
        }
        public List<CountryDO> GetCountries()
        {
            List<CountryDO> countries = new List<CountryDO>();
            List<Country> countryList = new List<Country>();
            countryList = locationRepository.GetCountries();
            if (countryList.Count > 0)
            {
                foreach(Country country in countryList)
                {
                    countries.Add(LocationConveter.ConvertCountry(country));
                }
            }
            return countries;
        }
        public List<StateDO> GetStates(int countryId)
        {
            List<StateDO> states = new List<StateDO>();
            List<State> stateList = new List<State>();
            stateList = locationRepository.GetStates(countryId);
            if (stateList.Count > 0)
            {
                foreach (State state in stateList)
                {
                    states.Add(LocationConveter.ConvertState(state));
                }
            }
            return states;
        }
    }
}
