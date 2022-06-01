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
    public class GarsonManager : BaseManager<Garson>, IGarsonService
    {
        public GarsonManager(IUnitOfWork uow) : base(uow)
        {

        }
    }
}