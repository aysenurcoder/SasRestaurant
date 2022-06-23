using Sas.Restaurant.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sas.Restaurant.DataAccess.Mappings
{
    public class MusteriMap:EntityTypeConfiguration<Musteri>
    {
        public MusteriMap()
        {
            Property(c => c.Adi).HasMaxLength(50);
            Property(c => c.Soyadi).HasMaxLength(50);
            Property(C => C.KartNo).HasMaxLength(20);
            Property(C => C.Sirket).HasMaxLength(100);

            ToTable("Musteriler");
            Property(c => c.Sirket).HasColumnName("Sirket");
            Property(c => c.Adi).HasColumnName("Adi");
            Property(c => c.Soyadi).HasColumnName("Soyadi");
            Property(c => c.KartNo).HasColumnName("KartNo");
            Property(c => c.MusteriTip).HasColumnName("MusteriTip");
  
        }
    }

}
