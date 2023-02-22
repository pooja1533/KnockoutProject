using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel.ServiceModel
{
    public class SightSeenDO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int CityId { get; set; }
        public string SightseenName { get; set; }
        public List<CityDO> Cities { get; set; }
    }
}
