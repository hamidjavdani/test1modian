using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace SM2.Models;

public partial class MunicipalityDbContext : DbContext
{
    public MunicipalityDbContext()
    {
    }

    public MunicipalityDbContext(DbContextOptions<MunicipalityDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TblKarbariArse> TblKarbariArses { get; set; }

    public virtual DbSet<TblKarbariayan> TblKarbariayans { get; set; }

    public virtual DbSet<TblKarbaribaft> TblKarbaribafts { get; set; }

    public virtual DbSet<TblKarbaribarmelk> TblKarbaribarmelks { get; set; }

    public virtual DbSet<TblKarbaripahnebaft> TblKarbaripahnebafts { get; set; }

    public virtual DbSet<TblKarbaripahnebandi> TblKarbaripahnebandis { get; set; }

    public virtual DbSet<TblKarbaripahnebandiZ> TblKarbaripahnebandiZs { get; set; }

    public virtual DbSet<TblKarbaritafsili79> TblKarbaritafsili79s { get; set; }

    public virtual DbSet<TblKarbaritarhejame95> TblKarbaritarhejame95s { get; set; }

    public virtual DbSet<TblKarshena> TblKarshenas { get; set; }

    public virtual DbSet<TblMadeSadM8> TblMadeSadM8s { get; set; }

    public virtual DbSet<TblMarhalesakhtemani> TblMarhalesakhtemanis { get; set; }

    public virtual DbSet<TblPetehadiyeh> TblPetehadiyehs { get; set; }

    public virtual DbSet<TblPetehadiyeh1403> TblPetehadiyeh1403s { get; set; }

    public virtual DbSet<TblPsenfete> TblPsenfetes { get; set; }

    public virtual DbSet<TblPsenfete1403> TblPsenfete1403s { get; set; }

    public virtual DbSet<TblSazman> TblSazmen { get; set; }

    public virtual DbSet<TblSendSm> TblSendSms { get; set; }

    public virtual DbSet<TblSenfavarez> TblSenfavarezs { get; set; }

    public virtual DbSet<TblShoabaza> TblShoabazas { get; set; }

    public virtual DbSet<TblStateActive> TblStateActives { get; set; }

    public virtual DbSet<TblStateparvandeh> TblStateparvandehs { get; set; }

    public virtual DbSet<TblTypeahmiyat> TblTypeahmiyats { get; set; }

    public virtual DbSet<TblTypeeskelet> TblTypeeskelets { get; set; }

    public virtual DbSet<TblTypeestefade> TblTypeestefades { get; set; }

    public virtual DbSet<TblTypenama> TblTypenamas { get; set; }

    public virtual DbSet<TblTypepishamadegi> TblTypepishamadegis { get; set; }

    public virtual DbSet<TblTypesaghf> TblTypesaghfs { get; set; }

    public virtual DbSet<TblTypetabagheh> TblTypetabaghehs { get; set; }

    public virtual DbSet<TblZaribF> TblZaribFs { get; set; }

    public virtual DbSet<TblZaribI> TblZaribIs { get; set; }

    public virtual DbSet<TblZaribK> TblZaribKs { get; set; }

    public virtual DbSet<TblZaribM> TblZaribMs { get; set; }

    public virtual DbSet<TblZaribU> TblZaribUs { get; set; }

    public virtual DbSet<TblZaribW> TblZaribWs { get; set; }

    public virtual DbSet<TblZaribZ> TblZaribZs { get; set; }

    public virtual DbSet<TblZaribarseP> TblZaribarsePs { get; set; }

    public virtual DbSet<TblZaribarseP1> TblZaribarseP1s { get; set; }

    public virtual DbSet<TblZaribayanP2> TblZaribayanP2s { get; set; }

    public virtual DbSet<Tblactivem1402> Tblactivem1402s { get; set; }

    public virtual DbSet<Tblactivep> Tblactiveps { get; set; }

    public virtual DbSet<Tblamarsruz> Tblamarsruzs { get; set; }

    public virtual DbSet<Tblamarsruzn> Tblamarsruzns { get; set; }

    public virtual DbSet<Tblavarez> Tblavarezs { get; set; }

    public virtual DbSet<Tblavarezstamin> Tblavarezstamins { get; set; }

    public virtual DbSet<Tblayantemp> Tblayantemps { get; set; }

    public virtual DbSet<Tblayantemptd> Tblayantemptds { get; set; }

    public virtual DbSet<Tblayantemptm> Tblayantemptms { get; set; }

    public virtual DbSet<Tblbasecategory> Tblbasecategories { get; set; }

    public virtual DbSet<Tblbasecategorytemp> Tblbasecategorytemps { get; set; }

    public virtual DbSet<Tblbasek1> Tblbasek1s { get; set; }

    public virtual DbSet<Tblbasep1> Tblbasep1s { get; set; }

    public virtual DbSet<Tblbodhehtemp> Tblbodhehtemps { get; set; }

    public virtual DbSet<Tblbtemp> Tblbtemps { get; set; }

    public virtual DbSet<Tblbtemp1400> Tblbtemp1400s { get; set; }

    public virtual DbSet<Tblbtemp14001> Tblbtemp14001s { get; set; }

    public virtual DbSet<Tblbudjeh> Tblbudjehs { get; set; }

    public virtual DbSet<Tblbudjeh0> Tblbudjeh0s { get; set; }

    public virtual DbSet<Tblbudjeh1> Tblbudjeh1s { get; set; }

    public virtual DbSet<Tblbudjeh2> Tblbudjeh2s { get; set; }

    public virtual DbSet<Tblbudjeh3> Tblbudjeh3s { get; set; }

    public virtual DbSet<Tblbudjeh31> Tblbudjeh31s { get; set; }

    public virtual DbSet<Tblbudjeh32> Tblbudjeh32s { get; set; }

    public virtual DbSet<Tblbudjeh33> Tblbudjeh33s { get; set; }

    public virtual DbSet<Tblbudjeh34> Tblbudjeh34s { get; set; }

    public virtual DbSet<Tblbudjeh35> Tblbudjeh35s { get; set; }

    public virtual DbSet<Tblbudjeh36> Tblbudjeh36s { get; set; }

    public virtual DbSet<Tblbudjeh37> Tblbudjeh37s { get; set; }

    public virtual DbSet<Tblbudjeh38> Tblbudjeh38s { get; set; }

    public virtual DbSet<Tblbudjeh39> Tblbudjeh39s { get; set; }

    public virtual DbSet<Tblbudjeh4> Tblbudjeh4s { get; set; }

    public virtual DbSet<Tblbudjeh40> Tblbudjeh40s { get; set; }

    public virtual DbSet<Tblbudjehtemp> Tblbudjehtemps { get; set; }

    public virtual DbSet<Tblbudjehtemp1> Tblbudjehtemp1s { get; set; }

    public virtual DbSet<Tblbuluk1401> Tblbuluk1401s { get; set; }

    public virtual DbSet<Tblbuluk1402> Tblbuluk1402s { get; set; }

    public virtual DbSet<Tblbuluk1403> Tblbuluk1403s { get; set; }

    public virtual DbSet<Tblbuluknesbat> Tblbuluknesbats { get; set; }

    public virtual DbSet<Tblcodebaft> Tblcodebafts { get; set; }

    public virtual DbSet<Tblcodebaftt> Tblcodebaftts { get; set; }

    public virtual DbSet<Tblcodejg> Tblcodejgs { get; set; }

    public virtual DbSet<Tblcounteruser> Tblcounterusers { get; set; }

    public virtual DbSet<Tbldaramad1402> Tbldaramad1402s { get; set; }

    public virtual DbSet<Tbldaramad1402n> Tbldaramad1402ns { get; set; }

    public virtual DbSet<Tbldaramadbaft> Tbldaramadbafts { get; set; }

    public virtual DbSet<Tbldaramadbank> Tbldaramadbanks { get; set; }

    public virtual DbSet<Tbldarkhast> Tbldarkhasts { get; set; }

    public virtual DbSet<Tbldarkhastmelk> Tbldarkhastmelks { get; set; }

    public virtual DbSet<Tbldatecode> Tbldatecodes { get; set; }

    public virtual DbSet<Tblfish> Tblfishes { get; set; }

    public virtual DbSet<Tblfish1> Tblfishs { get; set; }

    public virtual DbSet<Tblhesab> Tblhesabs { get; set; }

    public virtual DbSet<Tblhesab0> Tblhesab0s { get; set; }

    public virtual DbSet<Tblitemdaramad> Tblitemdaramads { get; set; }

    public virtual DbSet<Tblitemdaramad1400> Tblitemdaramad1400s { get; set; }

    public virtual DbSet<Tblitemdaramad1401> Tblitemdaramad1401s { get; set; }

    public virtual DbSet<Tblitemdaramad1402> Tblitemdaramad1402s { get; set; }

    public virtual DbSet<Tblitemdaramad1403> Tblitemdaramad1403s { get; set; }

    public virtual DbSet<Tblitemdaramad1404> Tblitemdaramad1404s { get; set; }

    public virtual DbSet<Tblitemdaramadmain> Tblitemdaramadmains { get; set; }

    public virtual DbSet<Tblitemdaramadtafsil> Tblitemdaramadtafsils { get; set; }

    public virtual DbSet<Tblitemdaramadtafsiln> Tblitemdaramadtafsilns { get; set; }

    public virtual DbSet<Tblitemhesab> Tblitemhesabs { get; set; }

    public virtual DbSet<Tbllistshobeh> Tbllistshobehs { get; set; }

    public virtual DbSet<Tblmah> Tblmahs { get; set; }

    public virtual DbSet<Tblmainsazman> Tblmainsazmen { get; set; }

    public virtual DbSet<Tblmoghayerat> Tblmoghayerats { get; set; }

    public virtual DbSet<Tblmohasebat> Tblmohasebats { get; set; }

    public virtual DbSet<Tblmohasebatdt2> Tblmohasebatdt2s { get; set; }

    public virtual DbSet<Tblmohasebats1> Tblmohasebats1s { get; set; }

    public virtual DbSet<Tblmohasebats2> Tblmohasebats2s { get; set; }

    public virtual DbSet<Tblmohasebatspardakht> Tblmohasebatspardakhts { get; set; }

    public virtual DbSet<Tblonvantafkik> Tblonvantafkiks { get; set; }

    public virtual DbSet<Tblpardakht> Tblpardakhts { get; set; }

    public virtual DbSet<Tblpardakhthazfi> Tblpardakhthazfis { get; set; }

    public virtual DbSet<Tblpardakhtprint> Tblpardakhtprints { get; set; }

    public virtual DbSet<Tblpardakhttemp> Tblpardakhttemps { get; set; }

    public virtual DbSet<Tblpardakhttemp0> Tblpardakhttemp0s { get; set; }

    public virtual DbSet<Tblrelationcode> Tblrelationcodes { get; set; }

    public virtual DbSet<Tblsanad> Tblsanads { get; set; }

    public virtual DbSet<Tblsenf1403temp> Tblsenf1403temps { get; set; }

    public virtual DbSet<Tblsetpass> Tblsetpasses { get; set; }

    public virtual DbSet<Tblshobeh> Tblshobehs { get; set; }

    public virtual DbSet<Tblstateparvandeh1> Tblstateparvandehs1 { get; set; }

    public virtual DbSet<Tblstatevahed> Tblstatevaheds { get; set; }

    public virtual DbSet<Tbltbb> Tbltbbs { get; set; }

    public virtual DbSet<Tbltbb2> Tbltbb2s { get; set; }

    public virtual DbSet<TbltempPar> TbltempPars { get; set; }

    public virtual DbSet<TbltempReportM> TbltempReportMs { get; set; }

    public virtual DbSet<Tbltempcode> Tbltempcodes { get; set; }

    public virtual DbSet<Tbltempm> Tbltempms { get; set; }

    public virtual DbSet<Tbltempray1> Tbltempray1s { get; set; }

    public virtual DbSet<Tbltempray1b> Tbltempray1bs { get; set; }

    public virtual DbSet<Tbltempray2> Tbltempray2s { get; set; }

    public virtual DbSet<Tbltempray2b> Tbltempray2bs { get; set; }

    public virtual DbSet<Tbltempray3> Tbltempray3s { get; set; }

    public virtual DbSet<Tbltempray3b> Tbltempray3bs { get; set; }

    public virtual DbSet<Tbltempshobeh> Tbltempshobehs { get; set; }

    public virtual DbSet<Tbltypefish> Tbltypefishes { get; set; }

    public virtual DbSet<Tbltypehesab> Tbltypehesabs { get; set; }

    public virtual DbSet<Typesanad> Typesanads { get; set; }

    public virtual DbSet<ViewPardakhtMn> ViewPardakhtMns { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=MunicipalityDb;User ID=system99;Password=1122;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
       

        modelBuilder.Entity<TblKarbariArse>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_karbariArse");

            entity.Property(e => e.Titel).HasMaxLength(50);
        });

        modelBuilder.Entity<TblKarbariayan>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_karbariayan");

            entity.Property(e => e.Titel).HasMaxLength(50);
        });

        modelBuilder.Entity<TblKarbaribaft>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_karbaribaft");

            entity.Property(e => e.Titel).HasMaxLength(50);
        });

        modelBuilder.Entity<TblKarbaribarmelk>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tbl_karb__3214EC0736735E1F");

            entity.ToTable("tbl_karbaribarmelk");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Titel).HasMaxLength(50);
        });

        modelBuilder.Entity<TblKarbaripahnebaft>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_karbaripahnebaft");

            entity.Property(e => e.Titel).HasMaxLength(50);
        });

        modelBuilder.Entity<TblKarbaripahnebandi>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_karbaripahnebandi");

            entity.Property(e => e.Titel).HasMaxLength(50);
        });

        modelBuilder.Entity<TblKarbaripahnebandiZ>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_karbaripahnebandiZ");

            entity.Property(e => e.Titel).HasMaxLength(50);
        });

        modelBuilder.Entity<TblKarbaritafsili79>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_karbaritafsili79");

            entity.Property(e => e.Titel).HasMaxLength(50);
        });

        modelBuilder.Entity<TblKarbaritarhejame95>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_karbaritarhejame95");

            entity.Property(e => e.Titel).HasMaxLength(50);
        });

        modelBuilder.Entity<TblKarshena>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_karshenas");

            entity.Property(e => e.Titel).HasMaxLength(50);
            entity.Property(e => e.Typemantagheh).HasColumnName("typemantagheh");
        });

        modelBuilder.Entity<TblMadeSadM8>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblMadeSadM8");

            entity.Property(e => e.Avarez1402).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Avarez1403).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Codegozaresh)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("codegozaresh");
            entity.Property(e => e.Codemadesad)
                .HasMaxLength(50)
                .HasColumnName("codemadesad");
            entity.Property(e => e.Codemelk)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("codemelk");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.Idkarbar).HasColumnName("idkarbar");
        });

        modelBuilder.Entity<TblMarhalesakhtemani>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_marhalesakhtemani");

            entity.Property(e => e.Titel).HasMaxLength(50);
        });

        modelBuilder.Entity<TblPetehadiyeh>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblPetehadiyeh");

            entity.Property(e => e.Codeetehadiyeh).HasColumnName("codeetehadiyeh");
            entity.Property(e => e.Mablagh).HasColumnName("mablagh");
        });

        modelBuilder.Entity<TblPetehadiyeh1403>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblPetehadiyeh1403");

            entity.Property(e => e.Codeetehadiyeh).HasColumnName("codeetehadiyeh");
            entity.Property(e => e.Mablagh).HasColumnName("mablagh");
        });

        modelBuilder.Entity<TblPsenfete>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblPsenfete");

            entity.Property(e => e.Codeetehadiyeh).HasColumnName("codeetehadiyeh");
            entity.Property(e => e.Codesnef).HasColumnName("codesnef");
            entity.Property(e => e.Mablagh).HasColumnName("mablagh");
        });

        modelBuilder.Entity<TblPsenfete1403>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblPsenfete1403");

            entity.Property(e => e.Codeetehadiyeh).HasColumnName("codeetehadiyeh");
            entity.Property(e => e.Codesnef).HasColumnName("codesnef");
            entity.Property(e => e.Mablagh).HasColumnName("mablagh");
        });

        modelBuilder.Entity<TblSazman>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_sazman");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name).HasColumnName("name");
        });

        modelBuilder.Entity<TblSendSm>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblSendSMS");

            entity.Property(e => e.Codekarbar).HasColumnName("codekarbar");
            entity.Property(e => e.Date)
                .HasMaxLength(50)
                .HasColumnName("date");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.Mablagh)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("mablagh");
            entity.Property(e => e.Mobile)
                .HasMaxLength(50)
                .HasColumnName("mobile");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.Shenasehghabz)
                .HasMaxLength(50)
                .HasColumnName("shenasehghabz");
            entity.Property(e => e.Shenasehpardakht)
                .HasMaxLength(50)
                .HasColumnName("shenasehpardakht");
            entity.Property(e => e.Typeghabz).HasColumnName("typeghabz");
            entity.Property(e => e.Typemantagheh).HasColumnName("typemantagheh");
        });

        modelBuilder.Entity<TblSenfavarez>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_senfavarez");

            entity.Property(e => e.Avarez).HasColumnName("avarez");
            entity.Property(e => e.Etehadiyeh).HasColumnName("etehadiyeh");
            entity.Property(e => e.Sal).HasColumnName("sal");
            entity.Property(e => e.Senf).HasColumnName("senf");
        });

        modelBuilder.Entity<TblShoabaza>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_shoabaza");

            entity.Property(e => e.Idazadadgostari).HasColumnName("idazadadgostari");
            entity.Property(e => e.Idazakeshvari).HasColumnName("idazakeshvari");
            entity.Property(e => e.Idazashora).HasColumnName("idazashora");
            entity.Property(e => e.Idshobeh).HasColumnName("idshobeh");
        });

        modelBuilder.Entity<TblStateActive>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_stateActive");

            entity.Property(e => e.Id)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.Idtruefalae).HasColumnName("idtruefalae");
            entity.Property(e => e.State).HasColumnName("state");
            entity.Property(e => e.Typemantagheh).HasColumnName("typemantagheh");
        });

        modelBuilder.Entity<TblStateparvandeh>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_stateparvandeh");

            entity.Property(e => e.Codemadesad)
                .HasMaxLength(50)
                .HasColumnName("codemadesad");
            entity.Property(e => e.Codeparvandeh)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("codeparvandeh");
            entity.Property(e => e.Date).HasMaxLength(50);
            entity.Property(e => e.Id).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Idkarbar).HasColumnName("idkarbar");
            entity.Property(e => e.State).HasColumnName("state");
        });

        modelBuilder.Entity<TblTypeahmiyat>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_typeahmiyat");

            entity.Property(e => e.Titel).HasMaxLength(50);
        });

        modelBuilder.Entity<TblTypeeskelet>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_typeeskelet");

            entity.Property(e => e.Titel).HasMaxLength(50);
        });

        modelBuilder.Entity<TblTypeestefade>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_typeestefade");

            entity.Property(e => e.Titel).HasMaxLength(50);
            entity.Property(e => e.Type).HasColumnName("type");
        });

        modelBuilder.Entity<TblTypenama>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_typenama");

            entity.Property(e => e.Titel).HasMaxLength(50);
        });

        modelBuilder.Entity<TblTypepishamadegi>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_typepishamadegi");

            entity.Property(e => e.Titel).HasMaxLength(50);
        });

        modelBuilder.Entity<TblTypesaghf>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_typesaghf");

            entity.Property(e => e.Titel).HasMaxLength(50);
        });

        modelBuilder.Entity<TblTypetabagheh>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_typetabagheh");

            entity.Property(e => e.Titel).HasMaxLength(50);
        });

        modelBuilder.Entity<TblZaribF>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_zarib(f)");

            entity.Property(e => e.Idkarbari).HasColumnName("idkarbari");
            entity.Property(e => e.Idrow).HasColumnName("idrow");
            entity.Property(e => e.Sal).HasColumnName("sal");
            entity.Property(e => e.Typetabagheh).HasColumnName("typetabagheh");
            entity.Property(e => e.Zarib).HasColumnName("zarib");
        });

        modelBuilder.Entity<TblZaribI>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_zarib(I)");

            entity.Property(e => e.Idbuluk).HasColumnName("idbuluk");
            entity.Property(e => e.Idrow).HasColumnName("idrow");
            entity.Property(e => e.Sal)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("sal");
            entity.Property(e => e.Zarib).HasColumnName("zarib");
        });

        modelBuilder.Entity<TblZaribK>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_zarib(k)");

            entity.Property(e => e.Idg).HasColumnName("idg");
            entity.Property(e => e.Idkarbari).HasColumnName("idkarbari");
            entity.Property(e => e.Idrow).HasColumnName("idrow");
            entity.Property(e => e.Sal).HasColumnName("sal");
            entity.Property(e => e.Typedarkhast).HasColumnName("typedarkhast");
            entity.Property(e => e.Typemasahat).HasColumnName("typemasahat");
            entity.Property(e => e.Typezarib).HasColumnName("typezarib");
            entity.Property(e => e.Zarib).HasColumnName("zarib");
        });

        modelBuilder.Entity<TblZaribM>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_zarib(m)");

            entity.Property(e => e.Idbuluk).HasColumnName("idbuluk");
            entity.Property(e => e.Idrow).HasColumnName("idrow");
            entity.Property(e => e.Sal).HasColumnName("sal");
            entity.Property(e => e.Zarib).HasColumnName("zarib");
        });

        modelBuilder.Entity<TblZaribU>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_zarib(u)");

            entity.Property(e => e.Idkarbari).HasColumnName("idkarbari");
            entity.Property(e => e.Idrow).HasColumnName("idrow");
            entity.Property(e => e.Sal)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("sal");
            entity.Property(e => e.Zarib).HasColumnName("zarib");
        });

        modelBuilder.Entity<TblZaribW>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_zarib(w)");

            entity.Property(e => e.Idrow).HasColumnName("idrow");
            entity.Property(e => e.Idtarakom).HasColumnName("idtarakom");
            entity.Property(e => e.Sal).HasColumnName("sal");
            entity.Property(e => e.Typetabagheh).HasColumnName("typetabagheh");
            entity.Property(e => e.Zarib).HasColumnName("zarib");
        });

        modelBuilder.Entity<TblZaribZ>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_zarib(z)");

            entity.Property(e => e.Idkarbari).HasColumnName("idkarbari");
            entity.Property(e => e.Idmabar).HasColumnName("idmabar");
            entity.Property(e => e.Idrow).HasColumnName("idrow");
            entity.Property(e => e.Sal).HasColumnName("sal");
            entity.Property(e => e.Zarib).HasColumnName("zarib");
        });

        modelBuilder.Entity<TblZaribarseP>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_zaribarse(p)");

            entity.Property(e => e.Idbuluk).HasColumnName("idbuluk");
            entity.Property(e => e.Idgm).HasColumnName("idgm");
            entity.Property(e => e.Idgtd).HasColumnName("idgtd");
            entity.Property(e => e.Idgtm).HasColumnName("idgtm");
            entity.Property(e => e.Idkarbari).HasColumnName("idkarbari");
            entity.Property(e => e.Idrow).HasColumnName("idrow");
            entity.Property(e => e.Sal).HasColumnName("sal");
            entity.Property(e => e.Zarib).HasColumnName("zarib");
        });

        modelBuilder.Entity<TblZaribarseP1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_zaribarse(p1)");

            entity.Property(e => e.Idkarbari).HasColumnName("idkarbari");
            entity.Property(e => e.Idrow).HasColumnName("idrow");
            entity.Property(e => e.Sal).HasColumnName("sal");
            entity.Property(e => e.Zarib).HasColumnName("zarib");
        });

        modelBuilder.Entity<TblZaribayanP2>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_zaribayan(p2)");

            entity.Property(e => e.Idkarbari).HasColumnName("idkarbari");
            entity.Property(e => e.Idrow).HasColumnName("idrow");
            entity.Property(e => e.Sal).HasColumnName("sal");
            entity.Property(e => e.Typeeskelt).HasColumnName("typeeskelt");
            entity.Property(e => e.Zarib).HasColumnName("zarib");
        });

        modelBuilder.Entity<Tblactivem1402>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblactivem1402");

            entity.Property(e => e.Codebazdid)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("codebazdid");
            entity.Property(e => e.Falag).HasColumnName("falag");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.Sal).HasColumnName("sal");
            entity.Property(e => e.Takhfiftamdid).HasColumnName("takhfiftamdid");
            entity.Property(e => e.Tavarom).HasColumnName("tavarom");
            entity.Property(e => e.Tozihat).HasColumnName("tozihat");
            entity.Property(e => e.Typemantagheh).HasColumnName("typemantagheh");
        });

        modelBuilder.Entity<Tblactivep>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblactivep");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.State).HasColumnName("state");
        });

        modelBuilder.Entity<Tblamarsruz>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblamarsruz");

            entity.Property(e => e.Baft1)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("baft1");
            entity.Property(e => e.Baft2)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("baft2");
            entity.Property(e => e.Check1)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("check1");
            entity.Property(e => e.Check2)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("check2");
            entity.Property(e => e.Check3)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("check3");
            entity.Property(e => e.D0)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("d0");
            entity.Property(e => e.D1)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("d1");
            entity.Property(e => e.D2)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("d2");
            entity.Property(e => e.D3)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("d3");
            entity.Property(e => e.D31)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("d31");
            entity.Property(e => e.D32)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("d32");
            entity.Property(e => e.D33)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("d33");
            entity.Property(e => e.D34)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("d34");
            entity.Property(e => e.D35)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("d35");
            entity.Property(e => e.D36)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("d36");
            entity.Property(e => e.D37)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("d37");
            entity.Property(e => e.D38)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("d38");
            entity.Property(e => e.D39)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("d39");
            entity.Property(e => e.D4)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("d4");
            entity.Property(e => e.D40)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("d40");
            entity.Property(e => e.D5)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("d5");
            entity.Property(e => e.D6)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("d6");
            entity.Property(e => e.M1).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.M2).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Sumcheck)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("sumcheck");
        });

        modelBuilder.Entity<Tblamarsruzn>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblamarsruzn");

            entity.Property(e => e.Baft1)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("baft1");
            entity.Property(e => e.Baft2)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("baft2");
            entity.Property(e => e.Check1)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("check1");
            entity.Property(e => e.Check2)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("check2");
            entity.Property(e => e.Check3)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("check3");
            entity.Property(e => e.D0)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("d0");
            entity.Property(e => e.D1)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("d1");
            entity.Property(e => e.D2)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("d2");
            entity.Property(e => e.D3)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("d3");
            entity.Property(e => e.D31)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("d31");
            entity.Property(e => e.D32)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("d32");
            entity.Property(e => e.D33)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("d33");
            entity.Property(e => e.D34)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("d34");
            entity.Property(e => e.D35)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("d35");
            entity.Property(e => e.D36)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("d36");
            entity.Property(e => e.D37)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("d37");
            entity.Property(e => e.D38)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("d38");
            entity.Property(e => e.D39)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("d39");
            entity.Property(e => e.D4)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("d4");
            entity.Property(e => e.D40)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("d40");
            entity.Property(e => e.D5)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("d5");
            entity.Property(e => e.D6)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("d6");
            entity.Property(e => e.Idmah).HasColumnName("idmah");
            entity.Property(e => e.M1).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.M2).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Onvanmah)
                .HasMaxLength(50)
                .HasColumnName("onvanmah");
            entity.Property(e => e.Sal)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("sal");
            entity.Property(e => e.Sumcheck)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("sumcheck");
        });

        modelBuilder.Entity<Tblavarez>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblavarezs");

            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.Avarez)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("avarez");
            entity.Property(e => e.Avarez0)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("avarez0");
            entity.Property(e => e.Avarez1)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("avarez1");
            entity.Property(e => e.Codebazdid)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("codebazdid");
            entity.Property(e => e.Codedarkhast)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("codedarkhast");
            entity.Property(e => e.Codeitem0).HasColumnName("codeitem0");
            entity.Property(e => e.Codeitem1).HasColumnName("codeitem1");
            entity.Property(e => e.Datetaeidk)
                .HasMaxLength(50)
                .HasColumnName("datetaeidk");
            entity.Property(e => e.Datetaeidm)
                .HasMaxLength(50)
                .HasColumnName("datetaeidm");
            entity.Property(e => e.Datetaeidmain)
                .HasMaxLength(50)
                .HasColumnName("datetaeidmain");
            entity.Property(e => e.Furmula).HasColumnName("furmula");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Idkarbarsk).HasColumnName("idkarbarsk");
            entity.Property(e => e.Idkarbarsm).HasColumnName("idkarbarsm");
            entity.Property(e => e.Idkarbarsmain).HasColumnName("idkarbarsmain");
            entity.Property(e => e.Idtaeidk).HasColumnName("idtaeidk");
            entity.Property(e => e.Idtaeidm).HasColumnName("idtaeidm");
            entity.Property(e => e.Idtaeidmain).HasColumnName("idtaeidmain");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.Nameitem0).HasColumnName("nameitem0");
            entity.Property(e => e.Namitem1).HasColumnName("namitem1");
            entity.Property(e => e.Timestaeidk)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("timestaeidk");
            entity.Property(e => e.Timestaeidm)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("timestaeidm");
            entity.Property(e => e.Timestaeidmain)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("timestaeidmain");
        });

        modelBuilder.Entity<Tblavarezstamin>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblavarezstamin");

            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.Avarez)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("avarez");
            entity.Property(e => e.Avarez0)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("avarez0");
            entity.Property(e => e.Avarez1)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("avarez1");
            entity.Property(e => e.Codebazdid)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("codebazdid");
            entity.Property(e => e.Codedarkhast)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("codedarkhast");
            entity.Property(e => e.Codeitem0).HasColumnName("codeitem0");
            entity.Property(e => e.Codeitem1).HasColumnName("codeitem1");
            entity.Property(e => e.Datetaeidk)
                .HasMaxLength(50)
                .HasColumnName("datetaeidk");
            entity.Property(e => e.Datetaeidm)
                .HasMaxLength(50)
                .HasColumnName("datetaeidm");
            entity.Property(e => e.Datetaeidmain)
                .HasMaxLength(50)
                .HasColumnName("datetaeidmain");
            entity.Property(e => e.Furmula).HasColumnName("furmula");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Idkarbarsk).HasColumnName("idkarbarsk");
            entity.Property(e => e.Idkarbarsm).HasColumnName("idkarbarsm");
            entity.Property(e => e.Idkarbarsmain).HasColumnName("idkarbarsmain");
            entity.Property(e => e.Idtaeidk).HasColumnName("idtaeidk");
            entity.Property(e => e.Idtaeidm).HasColumnName("idtaeidm");
            entity.Property(e => e.Idtaeidmain).HasColumnName("idtaeidmain");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.Nameitem0).HasColumnName("nameitem0");
            entity.Property(e => e.Namitem1).HasColumnName("namitem1");
            entity.Property(e => e.Timestaeidk)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("timestaeidk");
            entity.Property(e => e.Timestaeidm)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("timestaeidm");
            entity.Property(e => e.Timestaeidmain)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("timestaeidmain");
        });

        modelBuilder.Entity<Tblayantemp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblayantemp");

            entity.HasIndex(e => e.Idkarbar, "IX_tblayantemp");

            entity.HasIndex(e => e.Idkarbar, "IX_tblayantemp_1");

            entity.Property(e => e.Idkarbar).HasColumnName("idkarbar");
            entity.Property(e => e.Masahat)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("masahat");
            entity.Property(e => e.Masahattariz)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("masahattariz");
            entity.Property(e => e.Masahattarizp)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("masahattarizp");
        });

        modelBuilder.Entity<Tblayantemptd>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblayantemptd");

            entity.HasIndex(e => e.Idkarbar, "IX_tblayantemptd");

            entity.HasIndex(e => e.Idkarbar, "IX_tblayantemptd_1");

            entity.Property(e => e.Idkarbar).HasColumnName("idkarbar");
            entity.Property(e => e.Masahat)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("masahat");
            entity.Property(e => e.Masahattariz)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("masahattariz");
            entity.Property(e => e.Masahattarizp)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("masahattarizp");
        });

        modelBuilder.Entity<Tblayantemptm>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblayantemptm");

            entity.HasIndex(e => e.Idkarbar, "IX_tblayantemptm");

            entity.HasIndex(e => e.Idkarbar, "IX_tblayantemptm_1");

            entity.Property(e => e.Idkarbar).HasColumnName("idkarbar");
            entity.Property(e => e.Masahat)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("masahat");
            entity.Property(e => e.Masahattariz)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("masahattariz");
            entity.Property(e => e.Masahattarizp)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("masahattarizp");
        });

        modelBuilder.Entity<Tblbasecategory>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblbasecategory");

            entity.Property(e => e.Idbuluk).HasColumnName("idbuluk");
            entity.Property(e => e.Idcategory).HasColumnName("idcategory");
            entity.Property(e => e.Karbari).HasColumnName("karbari");
            entity.Property(e => e.Sal)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sal");
        });

        modelBuilder.Entity<Tblbasecategorytemp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblbasecategorytemp");

            entity.Property(e => e.Idbuluk).HasColumnName("idbuluk");
            entity.Property(e => e.Idcategory).HasColumnName("idcategory");
            entity.Property(e => e.Karbari).HasColumnName("karbari");
        });

        modelBuilder.Entity<Tblbasek1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblbasek1");

            entity.Property(e => e.Az).HasColumnName("az");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Idmabar).HasColumnName("idmabar");
            entity.Property(e => e.Karbari).HasColumnName("karbari");
            entity.Property(e => e.Ta).HasColumnName("ta");
            entity.Property(e => e.Zarib).HasColumnName("zarib");
        });

        modelBuilder.Entity<Tblbasep1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblbasep1");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Karbari).HasColumnName("karbari");
            entity.Property(e => e.Sal)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sal");
            entity.Property(e => e.Zarib).HasColumnName("zarib");
        });

        modelBuilder.Entity<Tblbodhehtemp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblbodhehtemp");

            entity.Property(e => e.C1).HasColumnName("c1");
            entity.Property(e => e.C2).HasColumnName("c2");
            entity.Property(e => e.C3).HasColumnName("c3");
            entity.Property(e => e.C4).HasColumnName("c4");
            entity.Property(e => e.C5).HasColumnName("c5");
            entity.Property(e => e.C6)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("c6");
            entity.Property(e => e.Cg8)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("cg8");
            entity.Property(e => e.Cn7)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("cn7");
            entity.Property(e => e.Code).HasColumnName("code");
            entity.Property(e => e.Onvan).HasColumnName("onvan");
        });

        modelBuilder.Entity<Tblbtemp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblbtemp");

            entity.Property(e => e.Armestan)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("armestan");
            entity.Property(e => e.Atash)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("atash");
            entity.Property(e => e.Code).HasColumnName("code");
            entity.Property(e => e.Farhangi)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("farhangi");
            entity.Property(e => e.Fava)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("fava");
            entity.Property(e => e.Fazasabz)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("fazasabz");
            entity.Property(e => e.Mablagh1)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("mablagh1");
            entity.Property(e => e.Mablagh13)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("mablagh13");
            entity.Property(e => e.Mablagh2)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("mablagh2");
            entity.Property(e => e.Markazi)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("markazi");
            entity.Property(e => e.Mayadin)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("mayadin");
            entity.Property(e => e.Omran)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("omran");
            entity.Property(e => e.Pasmand)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("pasmand");
            entity.Property(e => e.Taxi)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("taxi");
            entity.Property(e => e.Terafik)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("terafik");
        });

        modelBuilder.Entity<Tblbtemp1400>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblbtemp1400");

            entity.Property(e => e.B1)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("b1");
            entity.Property(e => e.B2)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("b2");
            entity.Property(e => e.Code).HasColumnName("code");
        });

        modelBuilder.Entity<Tblbtemp14001>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblbtemp14001");

            entity.Property(e => e.B1)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("b1");
            entity.Property(e => e.B2)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("b2");
            entity.Property(e => e.Code).HasColumnName("code");
        });

        modelBuilder.Entity<Tblbudjeh>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblbudjeh");

            entity.Property(e => e.Budjeh)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("budjeh");
            entity.Property(e => e.Budjehg)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("budjehg");
            entity.Property(e => e.Codeitem).HasColumnName("codeitem");
            entity.Property(e => e.Idsazman).HasColumnName("idsazman");
            entity.Property(e => e.Sal).HasColumnName("sal");
            entity.Property(e => e.Typebudjeh).HasColumnName("typebudjeh");
        });

        modelBuilder.Entity<Tblbudjeh0>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblbudjeh0");

            entity.Property(e => e.Budjeh)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("budjeh");
            entity.Property(e => e.Code).HasColumnName("code");
        });

        modelBuilder.Entity<Tblbudjeh1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblbudjeh1");

            entity.Property(e => e.Budjeh)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("budjeh");
            entity.Property(e => e.Code).HasColumnName("code");
        });

        modelBuilder.Entity<Tblbudjeh2>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblbudjeh2");

            entity.Property(e => e.Budjeh)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("budjeh");
            entity.Property(e => e.Code).HasColumnName("code");
        });

        modelBuilder.Entity<Tblbudjeh3>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblbudjeh3");

            entity.Property(e => e.Budjeh)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("budjeh");
            entity.Property(e => e.Code).HasColumnName("code");
        });

        modelBuilder.Entity<Tblbudjeh31>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblbudjeh31");

            entity.Property(e => e.Budjeh)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("budjeh");
            entity.Property(e => e.Code).HasColumnName("code");
        });

        modelBuilder.Entity<Tblbudjeh32>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblbudjeh32");

            entity.Property(e => e.Budjeh)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("budjeh");
            entity.Property(e => e.Code).HasColumnName("code");
        });

        modelBuilder.Entity<Tblbudjeh33>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblbudjeh33");

            entity.Property(e => e.Budjeh)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("budjeh");
            entity.Property(e => e.Code).HasColumnName("code");
        });

        modelBuilder.Entity<Tblbudjeh34>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblbudjeh34");

            entity.Property(e => e.Budjeh)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("budjeh");
            entity.Property(e => e.Code).HasColumnName("code");
        });

        modelBuilder.Entity<Tblbudjeh35>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblbudjeh35");

            entity.Property(e => e.Budjeh)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("budjeh");
            entity.Property(e => e.Code).HasColumnName("code");
        });

        modelBuilder.Entity<Tblbudjeh36>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblbudjeh36");

            entity.Property(e => e.Budjeh)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("budjeh");
            entity.Property(e => e.Code).HasColumnName("code");
        });

        modelBuilder.Entity<Tblbudjeh37>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblbudjeh37");

            entity.Property(e => e.Budjeh)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("budjeh");
            entity.Property(e => e.Code).HasColumnName("code");
        });

        modelBuilder.Entity<Tblbudjeh38>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblbudjeh38");

            entity.Property(e => e.Budjeh)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("budjeh");
            entity.Property(e => e.Code).HasColumnName("code");
        });

        modelBuilder.Entity<Tblbudjeh39>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblbudjeh39");

            entity.Property(e => e.Budjeh)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("budjeh");
            entity.Property(e => e.Code).HasColumnName("code");
        });

        modelBuilder.Entity<Tblbudjeh4>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblbudjeh4");

            entity.Property(e => e.Budjeh)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("budjeh");
            entity.Property(e => e.Code).HasColumnName("code");
        });

        modelBuilder.Entity<Tblbudjeh40>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblbudjeh40");

            entity.Property(e => e.Budjeh)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("budjeh");
            entity.Property(e => e.Code).HasColumnName("code");
        });

        modelBuilder.Entity<Tblbudjehtemp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblbudjehtemp");

            entity.Property(e => e.Budjeh)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("budjeh");
            entity.Property(e => e.Budjehg)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("budjehg");
            entity.Property(e => e.Codeitem).HasColumnName("codeitem");
        });

        modelBuilder.Entity<Tblbudjehtemp1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblbudjehtemp1");

            entity.Property(e => e.Budjeh)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("budjeh");
            entity.Property(e => e.Codeitem).HasColumnName("codeitem");
        });

        modelBuilder.Entity<Tblbuluk1401>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblbuluk1401");

            entity.Property(e => e.Buluk).HasColumnName("buluk");
            entity.Property(e => e.Karbari).HasColumnName("karbari");
            entity.Property(e => e.Mablagh)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("mablagh");
        });

        modelBuilder.Entity<Tblbuluk1402>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblbuluk1402");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.M1)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("m1");
            entity.Property(e => e.M2)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("m2");
            entity.Property(e => e.M3)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("m3");
        });

        modelBuilder.Entity<Tblbuluk1403>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblbuluk1403");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.M1)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("m1");
            entity.Property(e => e.M2)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("m2");
            entity.Property(e => e.M3)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("m3");
        });

        modelBuilder.Entity<Tblbuluknesbat>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblbuluknesbat");

            entity.Property(e => e.Id1398).HasColumnName("id1398");
            entity.Property(e => e.Id1399).HasColumnName("id1399");
            entity.Property(e => e.Id1400).HasColumnName("id1400");
            entity.Property(e => e.Id1401).HasColumnName("id1401");
        });

        modelBuilder.Entity<Tblcodebaft>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblcodebaft");

            entity.Property(e => e.Block).HasColumnName("block");
            entity.Property(e => e.Hozehg).HasColumnName("hozehg");
            entity.Property(e => e.Hozehj).HasColumnName("hozehj");
            entity.Property(e => e.Mantaghehg).HasColumnName("mantaghehg");
            entity.Property(e => e.Mantaghehj).HasColumnName("mantaghehj");
        });

        modelBuilder.Entity<Tblcodebaftt>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblcodebaftt");

            entity.Property(e => e.Block).HasColumnName("block");
            entity.Property(e => e.Hozehg).HasColumnName("hozehg");
            entity.Property(e => e.Hozehj).HasColumnName("hozehj");
            entity.Property(e => e.Mantaghehg).HasColumnName("mantaghehg");
            entity.Property(e => e.Mantaghehj).HasColumnName("mantaghehj");
        });

        modelBuilder.Entity<Tblcodejg>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblcodejg");

            entity.Property(e => e.Codeg).HasColumnName("codeg");
            entity.Property(e => e.Codegsub)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("codegsub");
            entity.Property(e => e.Codej).HasColumnName("codej");
        });

        modelBuilder.Entity<Tblcounteruser>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblcounteruser");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.Iduser).HasColumnName("iduser");
        });

        modelBuilder.Entity<Tbldaramad1402>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbldaramad1402");

            entity.Property(e => e.Date)
                .HasMaxLength(50)
                .HasColumnName("date");
        });

        modelBuilder.Entity<Tbldaramad1402n>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbldaramad1402n");

            entity.Property(e => e.Date)
                .HasMaxLength(50)
                .HasColumnName("date");
        });

        modelBuilder.Entity<Tbldaramadbaft>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbldaramadbaft");

            entity.Property(e => e.M1)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("m1");
            entity.Property(e => e.M2)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("m2");
            entity.Property(e => e.P1)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("p1");
            entity.Property(e => e.P2)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("p2");
        });

        modelBuilder.Entity<Tbldaramadbank>(entity =>
        {
            entity.ToTable("tbldaramadbank");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.Date)
                .HasMaxLength(50)
                .HasColumnName("date");
            entity.Property(e => e.Idhesab).HasColumnName("idhesab");
            entity.Property(e => e.Idkarbar).HasColumnName("idkarbar");
            entity.Property(e => e.Mablagh)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("mablagh");
            entity.Property(e => e.Typemantagheh).HasColumnName("typemantagheh");
        });

        modelBuilder.Entity<Tbldarkhast>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbldarkhast");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Tbldarkhastmelk>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbldarkhastmelk");

            entity.Property(e => e.Codedarkhast)
                .ValueGeneratedOnAdd()
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("codedarkhast");
            entity.Property(e => e.Codemadesad).HasColumnName("codemadesad");
            entity.Property(e => e.Codemelk)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("codemelk");
            entity.Property(e => e.Datesabt)
                .HasMaxLength(50)
                .HasColumnName("datesabt");
            entity.Property(e => e.Flaghazfed).HasColumnName("flaghazfed");
            entity.Property(e => e.Idkarbar).HasColumnName("idkarbar");
            entity.Property(e => e.Molahezat).HasColumnName("molahezat");
            entity.Property(e => e.Shgovahei).HasColumnName("shgovahei");
            entity.Property(e => e.Shparvaneh).HasColumnName("shparvaneh");
            entity.Property(e => e.Shpayankar).HasColumnName("shpayankar");
            entity.Property(e => e.Statedarkhast).HasColumnName("statedarkhast");
            entity.Property(e => e.Statevahed).HasColumnName("statevahed");
            entity.Property(e => e.Timesabt).HasColumnName("timesabt");
            entity.Property(e => e.Typedarkhast).HasColumnName("typedarkhast");
            entity.Property(e => e.Typemantagheh).HasColumnName("typemantagheh");
        });

        modelBuilder.Entity<Tbldatecode>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbldatecode");

            entity.Property(e => e.Code).HasColumnName("code");
            entity.Property(e => e.Date)
                .HasMaxLength(50)
                .HasColumnName("date");
            entity.Property(e => e.Typeman).HasColumnName("typeman");
        });

        modelBuilder.Entity<Tblfish>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblfish");

            entity.Property(e => e.Adress).HasColumnName("adress");
            entity.Property(e => e.Codeitem).HasColumnName("codeitem");
            entity.Property(e => e.Codeparvandeh)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("codeparvandeh");
            entity.Property(e => e.Datefish)
                .HasMaxLength(50)
                .HasColumnName("datefish");
            entity.Property(e => e.Datepardakht)
                .HasMaxLength(50)
                .HasColumnName("datepardakht");
            entity.Property(e => e.Hesab).HasColumnName("hesab");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.Idkarbar).HasColumnName("idkarbar");
            entity.Property(e => e.Mablaghfish)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("mablaghfish");
            entity.Property(e => e.Malek).HasColumnName("malek");
            entity.Property(e => e.Shenasehghabz)
                .HasMaxLength(13)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("shenasehghabz");
            entity.Property(e => e.Shenasehpardakht)
                .HasMaxLength(13)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("shenasehpardakht");
            entity.Property(e => e.State).HasColumnName("state");
            entity.Property(e => e.Typefish).HasColumnName("typefish");
            entity.Property(e => e.Typemantagheh).HasColumnName("typemantagheh");
        });

        modelBuilder.Entity<Tblfish1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblfishs");

            entity.Property(e => e.Address).HasColumnName("address");
            entity.Property(e => e.Baft).HasColumnName("baft");
            entity.Property(e => e.Codeitem).HasColumnName("codeitem");
            entity.Property(e => e.Codeparvandeh)
                .HasMaxLength(50)
                .HasColumnName("codeparvandeh");
            entity.Property(e => e.Datepardakht)
                .HasMaxLength(50)
                .HasColumnName("datepardakht");
            entity.Property(e => e.Idhesab).HasColumnName("idhesab");
            entity.Property(e => e.Idkarbar).HasColumnName("idkarbar");
            entity.Property(e => e.Idrow)
                .ValueGeneratedOnAdd()
                .HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Malek).HasColumnName("malek");
            entity.Property(e => e.Pardakhti)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("pardakhti");
            entity.Property(e => e.Shenasehghabz)
                .HasMaxLength(50)
                .HasColumnName("shenasehghabz");
            entity.Property(e => e.Shenasehpardakht)
                .HasMaxLength(13)
                .IsFixedLength()
                .HasColumnName("shenasehpardakht");
            entity.Property(e => e.Shomarehdarkhast)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("shomarehdarkhast");
            entity.Property(e => e.Shomarehsanad)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("shomarehsanad");
            entity.Property(e => e.Typedarkhast).HasColumnName("typedarkhast");
            entity.Property(e => e.Typehesab).HasColumnName("typehesab");
            entity.Property(e => e.Typemantagheh).HasColumnName("typemantagheh");
            entity.Property(e => e.Typepardakht).HasColumnName("typepardakht");
        });

        modelBuilder.Entity<Tblhesab>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblhesab");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Idsazman).HasColumnName("idsazman");
            entity.Property(e => e.Onvanhesab).HasColumnName("onvanhesab");
            entity.Property(e => e.Shomarehhesab)
                .HasMaxLength(15)
                .IsFixedLength()
                .HasColumnName("shomarehhesab");
            entity.Property(e => e.Typehesab).HasColumnName("typehesab");
        });

        modelBuilder.Entity<Tblhesab0>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblhesab0");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Idsazman).HasColumnName("idsazman");
            entity.Property(e => e.Onvanhesab).HasColumnName("onvanhesab");
            entity.Property(e => e.Shomarehhesab)
                .HasMaxLength(15)
                .IsFixedLength()
                .HasColumnName("shomarehhesab");
            entity.Property(e => e.Typehesab).HasColumnName("typehesab");
        });

        modelBuilder.Entity<Tblitemdaramad>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblitemdaramad");

            entity.Property(e => e.CodeItem).HasColumnName("code_item");
            entity.Property(e => e.NameItem).HasColumnName("name_item");
        });

        modelBuilder.Entity<Tblitemdaramad1400>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblitemdaramad1400");

            entity.Property(e => e.CodeItem).HasColumnName("code_item");
            entity.Property(e => e.NameItem).HasColumnName("name_item");
        });

        modelBuilder.Entity<Tblitemdaramad1401>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblitemdaramad1401");

            entity.Property(e => e.CodeItem).HasColumnName("code_item");
            entity.Property(e => e.NameItem).HasColumnName("name_item");
        });

        modelBuilder.Entity<Tblitemdaramad1402>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblitemdaramad1402");

            entity.Property(e => e.CodeItem).HasColumnName("code_item");
            entity.Property(e => e.NameItem).HasColumnName("name_item");
        });

        modelBuilder.Entity<Tblitemdaramad1403>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblitemdaramad1403");

            entity.Property(e => e.CodeItem).HasColumnName("code_item");
            entity.Property(e => e.NameItem).HasColumnName("name_item");
        });

        modelBuilder.Entity<Tblitemdaramad1404>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblitemdaramad1404");

            entity.Property(e => e.CodeItem).HasColumnName("code_item");
            entity.Property(e => e.NameItem).HasColumnName("name_item");
        });

        modelBuilder.Entity<Tblitemdaramadmain>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblitemdaramadmain");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Nameitem).HasColumnName("nameitem");
        });

        modelBuilder.Entity<Tblitemdaramadtafsil>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblitemdaramadtafsil");

            entity.Property(e => e.CodeItem).HasColumnName("code_item");
            entity.Property(e => e.Idkarbari).HasColumnName("idkarbari");
            entity.Property(e => e.Idmaintbl).HasColumnName("idmaintbl");
            entity.Property(e => e.NameItem).HasColumnName("name_item");
        });

        modelBuilder.Entity<Tblitemdaramadtafsiln>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblitemdaramadtafsiln");

            entity.Property(e => e.CodeItem).HasColumnName("code_item");
            entity.Property(e => e.Idavarez).HasColumnName("idavarez");
            entity.Property(e => e.Idkarbari).HasColumnName("idkarbari");
            entity.Property(e => e.NameItem).HasColumnName("name_item");
        });

        modelBuilder.Entity<Tblitemhesab>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblitemhesab");

            entity.Property(e => e.Codeitem).HasColumnName("codeitem");
            entity.Property(e => e.Idhesab).HasColumnName("idhesab");
            entity.Property(e => e.Typesazman).HasColumnName("typesazman");
        });

        modelBuilder.Entity<Tbllistshobeh>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbllistshobeh");

            entity.Property(e => e.CodeMadeSad).HasMaxLength(50);
            entity.Property(e => e.CodeNosazi).HasMaxLength(50);
            entity.Property(e => e.Idshobeh).HasColumnName("idshobeh");
        });

        modelBuilder.Entity<Tblmah>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblmah");

            entity.Property(e => e.Id)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(20)
                .IsFixedLength()
                .HasColumnName("name");
        });

        modelBuilder.Entity<Tblmainsazman>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblmainsazman");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name).HasColumnName("name");
        });

        modelBuilder.Entity<Tblmoghayerat>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblmoghayerat");

            entity.Property(e => e.Codemelk)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("codemelk");
            entity.Property(e => e.Datebazdid)
                .HasMaxLength(50)
                .HasColumnName("datebazdid");
            entity.Property(e => e.Tozihat)
                .HasColumnType("ntext")
                .HasColumnName("tozihat");
            entity.Property(e => e.Typemantagheh).HasColumnName("typemantagheh");
            entity.Property(e => e.Typetakhlof).HasColumnName("typetakhlof");
        });

        modelBuilder.Entity<Tblmohasebat>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblmohasebats");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Idkarbars).HasColumnName("idkarbars");
        });

        modelBuilder.Entity<Tblmohasebatdt2>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblmohasebatdt2");

            entity.Property(e => e.DataColumn10).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DataColumn11).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DataColumn12).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DataColumn13).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DataColumn2).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DataColumn3).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DataColumn4).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DataColumn5).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DataColumn6).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DataColumn7).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DataColumn8).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DataColumn9).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Idkarbari).HasColumnName("idkarbari");
            entity.Property(e => e.Idkarbars).HasColumnName("idkarbars");
        });

        modelBuilder.Entity<Tblmohasebats1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblmohasebats1");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Idkarbars).HasColumnName("idkarbars");
        });

        modelBuilder.Entity<Tblmohasebats2>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblmohasebats2");

            entity.Property(e => e.Codebazdid).HasColumnName("codebazdid");
            entity.Property(e => e.Codeparvandeh).HasColumnName("codeparvandeh");
            entity.Property(e => e.Datetaeid).HasColumnName("datetaeid");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Idkarbars).HasColumnName("idkarbars");
            entity.Property(e => e.Idtaeid).HasColumnName("idtaeid");
        });

        modelBuilder.Entity<Tblmohasebatspardakht>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblmohasebatspardakht");

            entity.Property(e => e.Codebazdid).HasColumnName("codebazdid");
            entity.Property(e => e.Codeparvandeh).HasColumnName("codeparvandeh");
            entity.Property(e => e.Datetaeid).HasColumnName("datetaeid");
            entity.Property(e => e.Datetaeidp).HasColumnName("datetaeidp");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Idkarbars).HasColumnName("idkarbars");
            entity.Property(e => e.Idtaeidm).HasColumnName("idtaeidm");
            entity.Property(e => e.Idtaeidp).HasColumnName("idtaeidp");
        });

        modelBuilder.Entity<Tblonvantafkik>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblonvantafkik");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Onvan)
                .HasMaxLength(50)
                .HasColumnName("onvan");
        });

        modelBuilder.Entity<Tblpardakht>(entity =>
        {
            entity.HasKey(e => e.Idrow);
            entity.ToTable("tblpardakht");

            entity.HasIndex(e => e.Typepardakht, "IX_tblpardakht");

            entity.HasIndex(e => e.Codeitem, "IX_tblpardakht_1");

            entity.Property(e => e.Address).HasColumnName("address");
            entity.Property(e => e.Baft).HasColumnName("baft");
            entity.Property(e => e.Codeitem).HasColumnName("codeitem");
            entity.Property(e => e.Codemeli)
                .HasMaxLength(20)
                .HasColumnName("codemeli");
            entity.Property(e => e.Codeparvandeh)
                .HasMaxLength(50)
                .HasColumnName("codeparvandeh");
            entity.Property(e => e.Datepardakht)
                .HasMaxLength(50)
                .HasColumnName("datepardakht");
            entity.Property(e => e.Idhesab).HasColumnName("idhesab");
            entity.Property(e => e.Idkarbar).HasColumnName("idkarbar");
            entity.Property(e => e.Idrow)
                .ValueGeneratedOnAdd()
                .HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Malek).HasColumnName("malek");
            entity.Property(e => e.Pardakhti)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("pardakhti");
            entity.Property(e => e.Shenasehghabz)
                .HasMaxLength(50)
                .HasColumnName("shenasehghabz");
            entity.Property(e => e.Shenasehpardakht)
                .HasMaxLength(13)
                .IsFixedLength()
                .HasColumnName("shenasehpardakht");
            entity.Property(e => e.Shomarehdarkhast)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("shomarehdarkhast");
            entity.Property(e => e.Shomarehsanad)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("shomarehsanad");
            entity.Property(e => e.Shomarepeygiri)
                .HasMaxLength(50)
                .HasColumnName("shomarepeygiri");
            entity.Property(e => e.State).HasColumnName("state");
            entity.Property(e => e.Typedarkhast).HasColumnName("typedarkhast");
            entity.Property(e => e.Typehesab).HasColumnName("typehesab");
            entity.Property(e => e.Typemantagheh).HasColumnName("typemantagheh");
            entity.Property(e => e.Typepardakht).HasColumnName("typepardakht");
        });

        modelBuilder.Entity<Tblpardakhthazfi>(entity =>
        {
            entity.HasKey(e => e.Idrow);

            entity.ToTable("tblpardakhthazfi");

            entity.Property(e => e.Idrow)
                .ValueGeneratedOnAdd()
                .HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Address).HasColumnName("address");
            entity.Property(e => e.Codeitem).HasColumnName("codeitem");
            entity.Property(e => e.Codeparvandeh)
                .HasMaxLength(50)
                .HasColumnName("codeparvandeh");
            entity.Property(e => e.Datepardakht)
                .HasMaxLength(50)
                .HasColumnName("datepardakht");
            entity.Property(e => e.Idhesab).HasColumnName("idhesab");
            entity.Property(e => e.Idkarbar).HasColumnName("idkarbar");
            entity.Property(e => e.Malek).HasColumnName("malek");
            entity.Property(e => e.Pardakhti)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("pardakhti");
            entity.Property(e => e.Shenasehghabz)
                .HasMaxLength(50)
                .HasColumnName("shenasehghabz");
            entity.Property(e => e.Shenasehpardakht)
                .HasMaxLength(13)
                .IsFixedLength()
                .HasColumnName("shenasehpardakht");
            entity.Property(e => e.Shomarehdarkhast)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("shomarehdarkhast");
            entity.Property(e => e.Shomarehsanad)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("shomarehsanad");
            entity.Property(e => e.Typedarkhast).HasColumnName("typedarkhast");
            entity.Property(e => e.Typehesab).HasColumnName("typehesab");
            entity.Property(e => e.Typemantagheh).HasColumnName("typemantagheh");
            entity.Property(e => e.Typepardakht).HasColumnName("typepardakht");
        });

        modelBuilder.Entity<Tblpardakhtprint>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblpardakhtprint");

            entity.Property(e => e.Codeitem).HasColumnName("codeitem");
            entity.Property(e => e.Codeparvandeh)
                .HasMaxLength(50)
                .HasColumnName("codeparvandeh");
            entity.Property(e => e.Datepardakht)
                .HasMaxLength(50)
                .HasColumnName("datepardakht");
            entity.Property(e => e.Hesab)
                .HasMaxLength(50)
                .HasColumnName("hesab");
            entity.Property(e => e.Idkarbar).HasColumnName("idkarbar");
            entity.Property(e => e.Malek).HasColumnName("malek");
            entity.Property(e => e.Onvanepardakht)
                .HasMaxLength(50)
                .HasColumnName("onvanepardakht");
            entity.Property(e => e.Onvanitem).HasColumnName("onvanitem");
            entity.Property(e => e.Pardakhti)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("pardakhti");
            entity.Property(e => e.Shenasehghabz)
                .HasMaxLength(50)
                .HasColumnName("shenasehghabz");
        });

        modelBuilder.Entity<Tblpardakhttemp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblpardakhttemp");

            entity.Property(e => e.Codeg).HasColumnName("codeg");
            entity.Property(e => e.Codej).HasColumnName("codej");
            entity.Property(e => e.Codem)
                .HasMaxLength(50)
                .HasColumnName("codem");
            entity.Property(e => e.Codep)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("codep");
            entity.Property(e => e.Date)
                .HasMaxLength(50)
                .HasColumnName("date");
            entity.Property(e => e.Pardakhti)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("pardakhti");
            entity.Property(e => e.Shcheck)
                .HasMaxLength(50)
                .HasColumnName("shcheck");
            entity.Property(e => e.Shenaseh)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("shenaseh");
            entity.Property(e => e.Shenasehfish)
                .HasMaxLength(15)
                .IsFixedLength()
                .HasColumnName("shenasehfish");
        });

        modelBuilder.Entity<Tblpardakhttemp0>(entity =>
        {
            entity.HasKey(e => e.Idrow);

            entity.ToTable("tblpardakhttemp0");

            entity.Property(e => e.Idrow)
                .ValueGeneratedOnAdd()
                .HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Address).HasColumnName("address");
            entity.Property(e => e.Codeitem).HasColumnName("codeitem");
            entity.Property(e => e.Codeparvandeh)
                .HasMaxLength(50)
                .HasColumnName("codeparvandeh");
            entity.Property(e => e.Datepardakht)
                .HasMaxLength(50)
                .HasColumnName("datepardakht");
            entity.Property(e => e.Idhesab).HasColumnName("idhesab");
            entity.Property(e => e.Idkarbar).HasColumnName("idkarbar");
            entity.Property(e => e.Malek).HasColumnName("malek");
            entity.Property(e => e.Pardakhti)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("pardakhti");
            entity.Property(e => e.Pardakhties)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("pardakhties");
            entity.Property(e => e.Pardakhtig)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("pardakhtig");
            entity.Property(e => e.Pardakhtitah)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("pardakhtitah");
            entity.Property(e => e.Shenasehghabz)
                .HasMaxLength(50)
                .HasColumnName("shenasehghabz");
            entity.Property(e => e.Shenasehpardakht)
                .HasMaxLength(13)
                .IsFixedLength()
                .HasColumnName("shenasehpardakht");
            entity.Property(e => e.Shomarehdarkhast)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("shomarehdarkhast");
            entity.Property(e => e.Shomarehsanad)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("shomarehsanad");
            entity.Property(e => e.Typedarkhast).HasColumnName("typedarkhast");
            entity.Property(e => e.Typehesab).HasColumnName("typehesab");
            entity.Property(e => e.Typemantagheh).HasColumnName("typemantagheh");
            entity.Property(e => e.Typepardakht).HasColumnName("typepardakht");
        });

        modelBuilder.Entity<Tblrelationcode>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblrelationcode");

            entity.Property(e => e.Codeghadim).HasColumnName("codeghadim");
            entity.Property(e => e.Codejadid).HasColumnName("codejadid");
        });

        modelBuilder.Entity<Tblsanad>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblsanads");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Onvan)
                .HasMaxLength(50)
                .HasColumnName("onvan");
        });

        modelBuilder.Entity<Tblsenf1403temp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblsenf1403temp");

            entity.Property(e => e.Codee).HasColumnName("codee");
            entity.Property(e => e.P)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("p");
            entity.Property(e => e.Senf).HasColumnName("senf");
        });

        modelBuilder.Entity<Tblsetpass>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblsetpass");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.Iduser).HasColumnName("iduser");
            entity.Property(e => e.Pass)
                .HasMaxLength(150)
                .HasColumnName("pass");
        });

        modelBuilder.Entity<Tblshobeh>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblshobeh");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Tblstateparvandeh1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblstateparvandeh");

            entity.Property(e => e.Cnblock)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("cnblock");
            entity.Property(e => e.Cnhozeh)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("cnhozeh");
            entity.Property(e => e.Cnmantagheh)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("cnmantagheh");
            entity.Property(e => e.Cnmelk)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("cnmelk");
            entity.Property(e => e.Codemadesad)
                .HasMaxLength(50)
                .HasColumnName("codemadesad");
            entity.Property(e => e.Datesabt)
                .HasMaxLength(50)
                .HasColumnName("datesabt");
            entity.Property(e => e.Id)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.Idkarbar).HasColumnName("idkarbar");
            entity.Property(e => e.Tozihat)
                .HasColumnType("ntext")
                .HasColumnName("tozihat");
        });

        modelBuilder.Entity<Tblstatevahed>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblstatevahed");

            entity.Property(e => e.Des).HasColumnName("des");
            entity.Property(e => e.State).HasMaxLength(50);
        });

        modelBuilder.Entity<Tbltbb>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbltbb");

            entity.Property(e => e.B)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("b");
            entity.Property(e => e.Id).HasColumnName("id");
        });

        modelBuilder.Entity<Tbltbb2>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbltbb2");

            entity.Property(e => e.B)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("b");
            entity.Property(e => e.Id).HasColumnName("id");
        });

        modelBuilder.Entity<TbltempPar>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbltempPar");

            entity.Property(e => e.Codedarkhast)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("codedarkhast");
            entity.Property(e => e.Idmantagheh).HasColumnName("idmantagheh");
            entity.Property(e => e.Sal)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("sal");
        });

        modelBuilder.Entity<TbltempReportM>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbltempReportM");

            entity.Property(e => e.Id1).HasColumnName("id1");
            entity.Property(e => e.Id10)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("id10");
            entity.Property(e => e.Id2)
                .HasMaxLength(150)
                .HasColumnName("id2");
            entity.Property(e => e.Id3)
                .HasMaxLength(150)
                .HasColumnName("id3");
            entity.Property(e => e.Id4)
                .HasMaxLength(150)
                .HasColumnName("id4");
            entity.Property(e => e.Id5)
                .HasMaxLength(350)
                .HasColumnName("id5");
            entity.Property(e => e.Id6).HasColumnName("id6");
            entity.Property(e => e.Id7)
                .HasMaxLength(50)
                .HasColumnName("id7");
            entity.Property(e => e.Id8)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("id8");
            entity.Property(e => e.Id9).HasColumnName("id9");
            entity.Property(e => e.Idkarbar)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("idkarbar");
        });

        modelBuilder.Entity<Tbltempcode>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbltempcode");

            entity.Property(e => e.Codeparvandeh)
                .HasMaxLength(50)
                .HasColumnName("codeparvandeh");
        });

        modelBuilder.Entity<Tbltempm>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbltempm");

            entity.Property(e => e.Idb).HasColumnName("idb");
            entity.Property(e => e.Maabar).HasColumnName("maabar");
            entity.Property(e => e.P).HasColumnName("p");
            entity.Property(e => e.Typem).HasColumnName("typem");
            entity.Property(e => e.Zarib).HasColumnName("zarib");
        });

        modelBuilder.Entity<Tbltempray1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbltempray1");

            entity.Property(e => e.Coden)
                .HasMaxLength(50)
                .HasColumnName("coden");
            entity.Property(e => e.Id)
                .HasMaxLength(50)
                .HasColumnName("id");
        });

        modelBuilder.Entity<Tbltempray1b>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbltempray1b");

            entity.Property(e => e.Coden)
                .HasMaxLength(50)
                .HasColumnName("coden");
            entity.Property(e => e.Id)
                .HasMaxLength(50)
                .HasColumnName("id");
        });

        modelBuilder.Entity<Tbltempray2>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbltempray2");

            entity.Property(e => e.Coden)
                .HasMaxLength(50)
                .HasColumnName("coden");
            entity.Property(e => e.Id)
                .HasMaxLength(50)
                .HasColumnName("id");
        });

        modelBuilder.Entity<Tbltempray2b>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbltempray2b");

            entity.Property(e => e.Coden)
                .HasMaxLength(50)
                .HasColumnName("coden");
            entity.Property(e => e.Id)
                .HasMaxLength(50)
                .HasColumnName("id");
        });

        modelBuilder.Entity<Tbltempray3>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbltempray3");

            entity.Property(e => e.Coden)
                .HasMaxLength(50)
                .HasColumnName("coden");
            entity.Property(e => e.Id)
                .HasMaxLength(50)
                .HasColumnName("id");
        });

        modelBuilder.Entity<Tbltempray3b>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbltempray3b");

            entity.Property(e => e.Coden)
                .HasMaxLength(50)
                .HasColumnName("coden");
            entity.Property(e => e.Id)
                .HasMaxLength(50)
                .HasColumnName("id");
        });

        modelBuilder.Entity<Tbltempshobeh>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbltempshobeh");

            entity.Property(e => e.CodeMadeSad).HasMaxLength(50);
            entity.Property(e => e.CodeNosazi)
                .HasMaxLength(20)
                .IsFixedLength();
            entity.Property(e => e.Malek).HasMaxLength(450);
            entity.Property(e => e.Radif)
                .ValueGeneratedOnAdd()
                .HasColumnType("decimal(18, 0)");
        });

        modelBuilder.Entity<Tbltypefish>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbltypefish");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name).HasColumnName("name");
        });

        modelBuilder.Entity<Tbltypehesab>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbltypehesab");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Typesanad>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("typesanad");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Onvan)
                .HasMaxLength(50)
                .HasColumnName("onvan");
        });

        modelBuilder.Entity<ViewPardakhtMn>(entity =>
        {
            entity
                .HasKey(e => e.Idrow);
                

            entity.Property(e => e.Codeitem).HasColumnName("codeitem");
            entity.Property(e => e.Codemeli)
                .HasMaxLength(20)
                .HasColumnName("codemeli");
            entity.Property(e => e.Datepardakht)
                .HasMaxLength(50)
                .HasColumnName("datepardakht");
            entity.Property(e => e.Idrow)
                .ValueGeneratedOnAdd()
                .HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Malek).HasColumnName("malek");
            entity.Property(e => e.Onvanitem).HasColumnName("onvanitem");
            entity.Property(e => e.Pardakhti)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("pardakhti");
            entity.Property(e => e.Shenasehghabz)
                .HasMaxLength(50)
                .HasColumnName("shenasehghabz");
            entity.Property(e => e.Shomarepeygiri)
                .HasMaxLength(50)
                .HasColumnName("shomarepeygiri");
            entity.Property(e => e.State).HasColumnName("state");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
