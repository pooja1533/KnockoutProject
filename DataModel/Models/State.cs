using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel.Models
{
    public partial class State
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Country_Id { get; set; }
    }
}
