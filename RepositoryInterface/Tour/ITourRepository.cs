using DataModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryInterface
{
    public interface ITourRepository
    {
        long AddSightSeen(SightSeen sightSeen);
        List<SightSeen> GetListOfSightSeen();
        SightSeen GetSightSeenDetail(int id);
        List<City> GetCities();
        long EditSightSeen(SightSeen sightSeen);
        bool DeleteSightSeen(int id);
        List<SightSeen> GetSightSeenForCity(int id);
    }
}
