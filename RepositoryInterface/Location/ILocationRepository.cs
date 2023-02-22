using DataModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryInterface
{
    public interface ILocationRepository
    {
        List<Country> GetCountries();
        List<State> GetStates(int countryId);
        List<City> GetCities(int stateId);
        List<City> GetAllCitiesStartWithPrefix(string Prefix);
    }
}
