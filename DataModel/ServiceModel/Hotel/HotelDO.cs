using Core.Constants;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel.ServiceModel
{
    public class HotelDO
    {
        [Key]
        public long Id { get; set; }
        public string Name { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public int Star { get; set; }
        public int CityId { get; set; }
        public int StateId { get; set; }
        public int CountryId { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public int Pincode { get; set; }
        [NotMapped]
        public string CityName { get; set; }
        [NotMapped]
        public string StateName { get; set; }
        [NotMapped]
        public string CountryName { get; set; }
        [NotMapped]
        public List<StateDO> States { get; set; }
        [NotMapped]
        public List<CityDO> City { get; set; }
        [NotMapped]
        public List<CountryDO> Country { get; set; }
        [NotMapped]
        public List<Stars> Stars { get; set; }
    }
    public class Stars
    {
        public Star Star { get; set; }
        public int Id { get; set; }
        public string Description { get; set; }
    }
}
