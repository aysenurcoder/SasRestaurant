﻿using Sas.Restaurant.Business.Services.Base;
using Sas.Restaurant.Entities.Dtos;
using Sas.Restaurant.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sas.Restaurant.Business.Services
{
    public interface IOdemeHareketService : IBaseService<OdemeHareket>
    {
        IEnumerable<OdemeHareket> OdemeHareketListesiGetir(DateTime baslangicTarihi, DateTime bitisTarihi);
        List<HaftalikKazancDto> HaftalikKazanciGetir();
        List<AylikKazancDto> AylikKazanciGetir();
        List<YillikKazancDto> YillikKazanciGetir();
    }
}
