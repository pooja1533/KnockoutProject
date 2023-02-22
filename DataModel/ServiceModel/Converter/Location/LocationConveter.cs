using DataModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel.ServiceModel.Converter
{
    public class LocationConveter
    {
        public static CountryDO ConvertCountry(Country country)
        {
            if (country != null)
            {
                return new CountryDO
                {
                    Id = country.Id,
                    Name = country.Name
                };
            }
            else
            {
                return new CountryDO();
            }

        }
        public static CityDO ConvertCity(City city)
        {
            if(city != null)
            {
                return new CityDO
                {
                    Id = city.Id,
                    Name = city.Name,
                    State_Id = city.State_Id
                };
            }
            else
            {
                return new CityDO();
            }
        }
        public static StateDO ConvertState(State state)
        {
            if(state != null)
            {
                return new StateDO
                {
                    Id = state.Id,
                    Name = state.Name,
                    Country_Id = state.Country_Id
                };
            }
            else
            {
                return new StateDO();
            }
        }
    }
}
