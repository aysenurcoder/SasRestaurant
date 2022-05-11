﻿using Sas.Restaurant.Business.Managers.Base;
using Sas.Restaurant.Business.Services;
using Sas.Restaurant.DataAccess.UnitOfWork;
using Sas.Restaurant.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sas.Restaurant.Business.Managers
{
    public class EkMalzemeManager : BaseManager<EkMalzeme>, IEkMalzemeService
    {
        public EkMalzemeManager(IUnitOfWork _uow) : base(_uow)
        {
        }
    }
}
