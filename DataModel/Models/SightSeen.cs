using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel.Models
{
    public partial class SightSeen
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set;}
        public int CityId { get; set; }
        [NotMapped]
        public string CityName { get; set; }
    }
}
