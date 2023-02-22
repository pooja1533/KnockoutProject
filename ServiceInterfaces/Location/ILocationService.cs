using DataModel.ServiceModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceInterfaces
{
    public interface ILocationService
    {
        List<CountryDO> GetCountries();
        List<StateDO> GetStates(int countryId);
        List<CityDO> GetCities(int stateId);
        List<CityDO> GetAllCitiesStartWithPrefix(string Prefix);
    }
}
