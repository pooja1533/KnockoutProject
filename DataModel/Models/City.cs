using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel.Models
{
    public partial class City
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int State_Id { get; set; }
    }
}
