using Sas.Restaurant.Core.Functions;
using Sas.Restaurant.DataAccess.Contexts.Restaurtant;
using Sas.Restaurant.DataAccess.Dals;
using Sas.Restaurant.DataAccess.Dals.Base;
using Sas.Restaurant.DataAccess.Functions;
using Sas.Restaurant.DataAccess.Interfaces;
using Sas.Restaurant.DataAccess.Interfaces.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sas.Restaurant.DataAccess.UnitOfWork
{
    public class RestaurantUnitOfWork : IUnitOfWork
    {
        private readonly RestaurantContext _context;
        public IUrunDal UrunDal { get; set; }
        public ITanimDal TanimDal { get; set; }
        public IPorsiyonDal PorsiyonDal { get; set; }
        public IEkMalzemeDal EkMalzemeDal { get; set; }
        public IMusteriDal MusteriDal { get; set; }
        public ITelefonDal TelefonDal { get; set; }
        public IAdresDal AdresDal { get; set; }
        public IAdisyonDal AdisyonDal { get; set; }
        public IEkMalzemeHareketDal EkMalzemeHareketDal { get; set; }
        public IPersonelDal GarsonDal { get; set; }
        public IMasaDal MasaDal { get; set; }
        public IUrunHareketDal UrunHareketDal { get; set; }
        public IOdemeTuruDal OdemeTuruDal { get; set; }
        public IOdemeHareketDal OdemeHareketDal { get; set; }
        public IUrunNotDal UrunNotDal { get; set; }
        public IAramaKaydiDal AramaKaydiDal { get; set; }
        public IKullaniciDal KullaniciDal { get; set; }


        public RestaurantUnitOfWork(String connectionString=null)
        {
            if (connectionString==null)
            {
                _context = new RestaurantContext(ConnectionStringInfo.Get());
            }
            else
            {
                _context = new RestaurantContext(connectionString);
            }
       
            UrunDal = new UrunDal(_context);
            TanimDal = new TanimDal(_context);
            EkMalzemeDal = new EkMalzemeDal(_context);
            PorsiyonDal = new PorsiyonDal(_context);
            MusteriDal = new MusteriDal(_context);
            TelefonDal = new TelefonDal(_context);
            AdresDal = new AdresDal(_context);
            AdisyonDal = new AdisyonDal(_context);
            EkMalzemeHareketDal = new EkMalzemeHareketDal(_context);
            GarsonDal = new PersonelDal(_context);
            MasaDal = new MasaDal(_context);
            UrunHareketDal = new UrunHareketDal(_context);
            OdemeTuruDal = new OdemeTuruDal(_context);
            OdemeHareketDal = new OdemeHareketDal(_context);
            UrunNotDal = new UrunNotDal(_context);
            AramaKaydiDal = new AramaKaydiDal(_context);
            KullaniciDal = new KullaniciDal(_context);

        }
        private bool disposedValue;

        public bool Commit()
        {
            try
            {
                EntityBaseInfo.Add(_context);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        public void DetectChanges()
        {
            _context.ChangeTracker.DetectChanges();
        }

        public bool HasChanges()
        {
            return _context.ChangeTracker.HasChanges();
        }

        IRepository<TEntity> IUnitOfWork.Dal<TEntity>()
        {
            return new Repository<TEntity>(_context);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects)
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                disposedValue = true;
            }
        }

        // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        // ~RestaurantUnitOfWork()
        // {
        //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
