using Sas.Restaurant.DataAccess.Dals.Base;
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
    public class EkMalzemeHareketDal:Repository<EkMalzemeHareket>,IEkMalzemeHareketDal
    {
        public EkMalzemeHareketDal(DbContext context) : base(context)
        {

        }
    }
}
