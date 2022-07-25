using Sas.Restaurant.Business.Services.Base;
using Sas.Restaurant.Entities.Dtos;
using Sas.Restaurant.Entities.Dtos.Mutfak;
using Sas.Restaurant.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Sas.Restaurant.Business.Services
{
    public interface IAdisyonService : IBaseService<Adisyon>
    {
        AdisyonToplamDto AdisyonToplamGetir();
        List<AdisyonHareketDto> AdisyonHareketGetir(DateTime tarih1, DateTime tarih2);
        List<MutfakAdisyonHareketDto> MutfakAdisyonHareketGetir(Guid[] adisyonListe);
        List<MutfakUrunHareketDto> MutfakUrunHareketGetir(Expression<Func<UrunHareket,bool>> filter =null);
        List<MutfakEkMalzemeDto> MutfakEkMalzemeHareketGetir(Guid urunHareketId);

    }
}
