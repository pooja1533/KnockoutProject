﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel.ServiceModel
{
    public class TourBookingDO
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int CityId { get; set; }
    }
}
