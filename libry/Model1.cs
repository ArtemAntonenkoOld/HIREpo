namespace libry
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<tbAdress> tbAdresses { get; set; }
        public virtual DbSet<tbBank> tbBanks { get; set; }
        public virtual DbSet<tbComin> tbComins { get; set; }
        public virtual DbSet<tbCurrency> tbCurrencies { get; set; }
        public virtual DbSet<tbCurrencyRate> tbCurrencyRates { get; set; }
        public virtual DbSet<tbExpodenture> tbExpodentures { get; set; }
        public virtual DbSet<tbFromWho> tbFromWhoes { get; set; }
        public virtual DbSet<tbIncome> tbIncomes { get; set; }
        public virtual DbSet<tbNew> tbNews { get; set; }
        public virtual DbSet<tbOperation> tbOperations { get; set; }
        public virtual DbSet<tbOperationComin> tbOperationComins { get; set; }
        public virtual DbSet<tbOperationDetail> tbOperationDetails { get; set; }
        public virtual DbSet<tbRate> tbRates { get; set; }
        public virtual DbSet<tbRssUser> tbRssUsers { get; set; }
        public virtual DbSet<tbRssUserNew> tbRssUserNews { get; set; }
        public virtual DbSet<tbSystemComin> tbSystemComins { get; set; }
        public virtual DbSet<tbUser> tbUsers { get; set; }
        public virtual DbSet<tbUserComin> tbUserComins { get; set; }
        public virtual DbSet<tbVideo> tbVideos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tbAdress>()
                .Property(e => e.cAdressVal)
                .IsUnicode(false);

            modelBuilder.Entity<tbAdress>()
                .Property(e => e.cStreet)
                .IsUnicode(false);

            modelBuilder.Entity<tbAdress>()
                .Property(e => e.cCity)
                .IsUnicode(false);

            modelBuilder.Entity<tbAdress>()
                .Property(e => e.cCountry)
                .IsUnicode(false);

            modelBuilder.Entity<tbAdress>()
                .Property(e => e.cLongitude)
                .IsUnicode(false);

            modelBuilder.Entity<tbAdress>()
                .Property(e => e.cLatitude)
                .IsUnicode(false);

            modelBuilder.Entity<tbAdress>()
                .HasMany(e => e.tbComins)
                .WithOptional(e => e.tbAdress)
                .HasForeignKey(e => e.cIdAdress);

            modelBuilder.Entity<tbAdress>()
                .HasMany(e => e.tbRssUsers)
                .WithOptional(e => e.tbAdress)
                .HasForeignKey(e => e.cMail);

            modelBuilder.Entity<tbBank>()
                .Property(e => e.cName)
                .IsUnicode(false);

            modelBuilder.Entity<tbBank>()
                .HasMany(e => e.tbAdresses)
                .WithRequired(e => e.tbBank)
                .HasForeignKey(e => e.cIdBank)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbBank>()
                .HasMany(e => e.tbComins)
                .WithRequired(e => e.tbBank)
                .HasForeignKey(e => e.cIdBank)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbBank>()
                .HasMany(e => e.tbCurrencyRates)
                .WithRequired(e => e.tbBank)
                .HasForeignKey(e => e.cIdBank)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbComin>()
                .Property(e => e.cDecription)
                .IsUnicode(false);

            modelBuilder.Entity<tbCurrency>()
                .Property(e => e.cCurrencyLong)
                .IsUnicode(false);

            modelBuilder.Entity<tbCurrency>()
                .Property(e => e.cCurrencyShort)
                .IsUnicode(false);

            modelBuilder.Entity<tbCurrency>()
                .HasMany(e => e.tbCurrencyRates)
                .WithRequired(e => e.tbCurrency)
                .HasForeignKey(e => e.cIdCurrency)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbExpodenture>()
                .Property(e => e.cSume)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tbExpodenture>()
                .Property(e => e.cCurrency)
                .IsUnicode(false);

            modelBuilder.Entity<tbFromWho>()
                .Property(e => e.cName)
                .IsUnicode(false);

            modelBuilder.Entity<tbFromWho>()
                .HasMany(e => e.tbSystemComins)
                .WithRequired(e => e.tbFromWho)
                .HasForeignKey(e => e.cFromWho)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbFromWho>()
                .HasMany(e => e.tbUserComins)
                .WithRequired(e => e.tbFromWho)
                .HasForeignKey(e => e.cFromWho)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbIncome>()
                .Property(e => e.cSume)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tbIncome>()
                .Property(e => e.cCurrency)
                .IsUnicode(false);

            modelBuilder.Entity<tbNew>()
                .Property(e => e.cDescription)
                .IsUnicode(false);

            modelBuilder.Entity<tbNew>()
                .HasMany(e => e.tbRssUserNews)
                .WithRequired(e => e.tbNew)
                .HasForeignKey(e => e.cIdNews)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbNew>()
                .HasMany(e => e.tbVideos)
                .WithRequired(e => e.tbNew)
                .HasForeignKey(e => e.cIdNews)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbOperation>()
                .HasMany(e => e.tbOperationDetails)
                .WithRequired(e => e.tbOperation)
                .HasForeignKey(e => e.cIdOperation)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbOperation>()
                .HasMany(e => e.tbOperationComins)
                .WithRequired(e => e.tbOperation)
                .HasForeignKey(e => e.cIdOperation)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbOperationComin>()
                .Property(e => e.cDescription)
                .IsUnicode(false);

            modelBuilder.Entity<tbOperationDetail>()
                .Property(e => e.cParams)
                .IsUnicode(false);

            modelBuilder.Entity<tbRate>()
                .Property(e => e.cRate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tbRate>()
                .HasMany(e => e.tbCurrencyRates)
                .WithRequired(e => e.tbRate)
                .HasForeignKey(e => e.cIdRate)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbRssUser>()
                .HasMany(e => e.tbRssUserNews)
                .WithRequired(e => e.tbRssUser)
                .HasForeignKey(e => e.cIdUser)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbUser>()
                .Property(e => e.cName)
                .IsUnicode(false);

            modelBuilder.Entity<tbUser>()
                .HasMany(e => e.tbComins)
                .WithRequired(e => e.tbUser)
                .HasForeignKey(e => e.cIdUser)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbUser>()
                .HasMany(e => e.tbExpodentures)
                .WithRequired(e => e.tbUser)
                .HasForeignKey(e => e.cIdUser)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbUser>()
                .HasMany(e => e.tbFromWhoes)
                .WithRequired(e => e.tbUser)
                .HasForeignKey(e => e.cUserId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbUser>()
                .HasMany(e => e.tbIncomes)
                .WithRequired(e => e.tbUser)
                .HasForeignKey(e => e.cIdUser)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbUser>()
                .HasMany(e => e.tbUserComins)
                .WithRequired(e => e.tbUser)
                .HasForeignKey(e => e.cIdUser)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbUserComin>()
                .Property(e => e.cDescription)
                .IsUnicode(false);

            modelBuilder.Entity<tbVideo>()
                .Property(e => e.cSource)
                .IsUnicode(false);
        }
    }
}
