using Sas.Restaurant.Business.Services.Base;
using Sas.Restaurant.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sas.Restaurant.Business.Services
{
    public interface IKullaniciService : IBaseService<Kullanici>
    {
        Kullanici KullaniciKontrol(string kullaniciAdi, string parola);
    }
}
