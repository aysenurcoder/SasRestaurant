﻿using Sas.Restaurant.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sas.Restaurant.Components.CallerId
{
    public class CallerIdEventArgs:EventArgs
    {
        public Telefon Telefon { get; set; }
    }
}
