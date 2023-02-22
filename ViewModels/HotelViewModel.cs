using Core.Constants;
using DataModel.ServiceModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
    public class HotelViewModel
    {
        //[Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public int StarId { get; set; }
       public int CityId { get; set; }
        public int StateId { get; set; }
        public int CountryId { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public string Pincode { get; set; }
        public List<StarModel> Stars { get; set; }
        
       
    }
    public class StarModel
    {
        public Star Star { get; set; }
        public int Id { get; set; }
        public string Description { get; set; }
    }
}
