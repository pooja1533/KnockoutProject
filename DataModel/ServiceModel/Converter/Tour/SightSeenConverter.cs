using DataModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel.ServiceModel.Converter
{
    public class SightSeenConverter
    {
        public static SightSeenDO ConverSightSeenDetail(SightSeen sightSeen)
        {
            if (sightSeen != null)
            {
                return new SightSeenDO
                {
                    CityId = sightSeen.CityId,
                    SightseenName = sightSeen.Name,
                    Description = sightSeen.Description,
                    Name=sightSeen.CityName,
                    Id=sightSeen.Id
                };
            }
            else
            {
                return new SightSeenDO();
            }
        }
    }
}
