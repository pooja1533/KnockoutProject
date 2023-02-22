using DataModel.ServiceModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceInterfaces
{
    public interface ITourService
    {
        bool AddSightSeen(SightSeenDO sightSeen);
        List<SightSeenDO> GetListOfSightSeen();
        SightSeenDO GetSightSeenDetail(int id);
        List<CityDO> GetCities();
        bool EditSightSeen(SightSeenDO sightSeen);
        bool DeleteSightSeen(int id);
        List<SightSeenDO> GetSightSeenForCity(int id);
    }
}
