﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DReservation.Models.Domain
{
    public class WorkPeriod
    {
        public int StartHour { get; set; }

        public int EndHour { get; set; }

        public int LunchStartHour { get; set; }

        public int LunchEndHour { get; set; }
    }
}