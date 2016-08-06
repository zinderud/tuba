using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Dene.Models.Mapping;

namespace Dene.Models
{
    public partial class MUHASEBEContext : DbContext
    {
        static MUHASEBEContext()
        {
            Database.SetInitializer<MUHASEBEContext>(null);
        }

        public MUHASEBEContext()
            : base("Name=MUHASEBEContext")
        {
        }

        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<TBL_BANKA> TBL_BANKA { get; set; }
        public DbSet<TBL_BANKA_BAKIYE> TBL_BANKA_BAKIYE { get; set; }
        public DbSet<TBL_DEPO> TBL_DEPO { get; set; }
        public DbSet<TBL_DEPO_ISLEM> TBL_DEPO_ISLEM { get; set; }
        public DbSet<TBL_DEPO_TRANSFER> TBL_DEPO_TRANSFER { get; set; }
        public DbSet<TBL_FATURA> TBL_FATURA { get; set; }
        public DbSet<TBL_FATURA_TURU> TBL_FATURA_TURU { get; set; }
        public DbSet<TBL_FIS> TBL_FIS { get; set; }
        public DbSet<TBL_GIDER> TBL_GIDER { get; set; }
        public DbSet<TBL_GIDER_BAKIYE> TBL_GIDER_BAKIYE { get; set; }
        public DbSet<TBL_KASA> TBL_KASA { get; set; }
        public DbSet<TBL_KASA_BAKIYE> TBL_KASA_BAKIYE { get; set; }
        public DbSet<TBL_KDV> TBL_KDV { get; set; }
        public DbSet<TBL_ODEME> TBL_ODEME { get; set; }
        public DbSet<TBL_ODEME_TIPI> TBL_ODEME_TIPI { get; set; }
        public DbSet<TBL_ODEME_TURU> TBL_ODEME_TURU { get; set; }
        public DbSet<TBL_PARA_TIPI> TBL_PARA_TIPI { get; set; }
        public DbSet<TBL_PERSONEL> TBL_PERSONEL { get; set; }
        public DbSet<TBL_SIRKET> TBL_SIRKET { get; set; }
        public DbSet<TBL_SIRKET_BAKIYE> TBL_SIRKET_BAKIYE { get; set; }
        public DbSet<TBL_SIRKET_GRUB> TBL_SIRKET_GRUB { get; set; }
        public DbSet<TBL_SIRKET_SINIF> TBL_SIRKET_SINIF { get; set; }
        public DbSet<TBL_SIRKET_TIPI> TBL_SIRKET_TIPI { get; set; }
        public DbSet<TBL_SPARIS> TBL_SPARIS { get; set; }
        public DbSet<TBL_SPARIS_TURU> TBL_SPARIS_TURU { get; set; }
        public DbSet<TBL_URUN> TBL_URUN { get; set; }
        public DbSet<TBL_URUN_BIRIM> TBL_URUN_BIRIM { get; set; }
        public DbSet<TBL_URUN_CINSI> TBL_URUN_CINSI { get; set; }
        public DbSet<TBL_URUN_FATURA> TBL_URUN_FATURA { get; set; }
        public DbSet<TBL_URUN_MARKA> TBL_URUN_MARKA { get; set; }
        public DbSet<TBL_URUN_SPARIS> TBL_URUN_SPARIS { get; set; }
        public DbSet<TBL_URUN_STOK> TBL_URUN_STOK { get; set; }
        public DbSet<TBL_URUN_TIPI> TBL_URUN_TIPI { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new sysdiagramMap());
            modelBuilder.Configurations.Add(new TBL_BANKAMap());
            modelBuilder.Configurations.Add(new TBL_BANKA_BAKIYEMap());
            modelBuilder.Configurations.Add(new TBL_DEPOMap());
            modelBuilder.Configurations.Add(new TBL_DEPO_ISLEMMap());
            modelBuilder.Configurations.Add(new TBL_DEPO_TRANSFERMap());
            modelBuilder.Configurations.Add(new TBL_FATURAMap());
            modelBuilder.Configurations.Add(new TBL_FATURA_TURUMap());
            modelBuilder.Configurations.Add(new TBL_FISMap());
            modelBuilder.Configurations.Add(new TBL_GIDERMap());
            modelBuilder.Configurations.Add(new TBL_GIDER_BAKIYEMap());
            modelBuilder.Configurations.Add(new TBL_KASAMap());
            modelBuilder.Configurations.Add(new TBL_KASA_BAKIYEMap());
            modelBuilder.Configurations.Add(new TBL_KDVMap());
            modelBuilder.Configurations.Add(new TBL_ODEMEMap());
            modelBuilder.Configurations.Add(new TBL_ODEME_TIPIMap());
            modelBuilder.Configurations.Add(new TBL_ODEME_TURUMap());
            modelBuilder.Configurations.Add(new TBL_PARA_TIPIMap());
            modelBuilder.Configurations.Add(new TBL_PERSONELMap());
            modelBuilder.Configurations.Add(new TBL_SIRKETMap());
            modelBuilder.Configurations.Add(new TBL_SIRKET_BAKIYEMap());
            modelBuilder.Configurations.Add(new TBL_SIRKET_GRUBMap());
            modelBuilder.Configurations.Add(new TBL_SIRKET_SINIFMap());
            modelBuilder.Configurations.Add(new TBL_SIRKET_TIPIMap());
            modelBuilder.Configurations.Add(new TBL_SPARISMap());
            modelBuilder.Configurations.Add(new TBL_SPARIS_TURUMap());
            modelBuilder.Configurations.Add(new TBL_URUNMap());
            modelBuilder.Configurations.Add(new TBL_URUN_BIRIMMap());
            modelBuilder.Configurations.Add(new TBL_URUN_CINSIMap());
            modelBuilder.Configurations.Add(new TBL_URUN_FATURAMap());
            modelBuilder.Configurations.Add(new TBL_URUN_MARKAMap());
            modelBuilder.Configurations.Add(new TBL_URUN_SPARISMap());
            modelBuilder.Configurations.Add(new TBL_URUN_STOKMap());
            modelBuilder.Configurations.Add(new TBL_URUN_TIPIMap());
        }
    }
}
