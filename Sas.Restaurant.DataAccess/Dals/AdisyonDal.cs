﻿using Sas.Restaurant.DataAccess.Dals.Base;
using Sas.Restaurant.DataAccess.Interfaces;
using Sas.Restaurant.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sas.Restaurant.DataAccess.Dals
{
    public class AdisyonDal: Repository<Adisyon>, IAdisyonDal
    {
        public AdisyonDal(DbContext context) : base(context)
        {

        }
    }
}
