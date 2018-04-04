using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WindowsFormsApp1.modele
{
    public partial class LCBDContext : DbContext
    {
        public virtual DbSet<Activite> Activite { get; set; }
        public virtual DbSet<Adresse> Adresse { get; set; }
        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<Droit> Droit { get; set; }
        public virtual DbSet<Etat> Etat { get; set; }
        public virtual DbSet<Lc> Lc { get; set; }
        public virtual DbSet<Modele> Modele { get; set; }
        public virtual DbSet<Statut> Statut { get; set; }
        public virtual DbSet<TypeStatut> TypeStatut { get; set; }
        public virtual DbSet<Utilisateur> Utilisateur { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(@"Server=lcbd.database.windows.net;Database=LCBD;Trusted_Connection=False;Encrypt=True;User=lcbd;Password=Azerty77");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Activite>(entity =>
            {
                entity.HasKey(e => e.IdActivite);

                entity.Property(e => e.IdActivite).HasColumnName("id_activite");

                entity.Property(e => e.LibelleActivite)
                    .IsRequired()
                    .HasColumnName("libelle_activite")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Adresse>(entity =>
            {
                entity.HasKey(e => e.IdAdresse);

                entity.Property(e => e.IdAdresse).HasColumnName("id_adresse");

                entity.Property(e => e.CodePostal)
                    .HasColumnName("code_postal")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Complements)
                    .HasColumnName("complements")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Indice)
                    .HasColumnName("indice")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Numero)
                    .IsRequired()
                    .HasColumnName("numero")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Ville)
                    .IsRequired()
                    .HasColumnName("ville")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Voie)
                    .IsRequired()
                    .HasColumnName("voie")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Client>(entity =>
            {
                entity.HasKey(e => e.IdClient);

                entity.Property(e => e.IdClient).HasColumnName("id_client");

                entity.Property(e => e.Ca).HasColumnName("CA");

                entity.Property(e => e.DateImmatriculation)
                    .HasColumnName("date_immatriculation")
                    .HasColumnType("date");

                entity.Property(e => e.Effectifs).HasColumnName("effectifs");

                entity.Property(e => e.Ess).HasColumnName("ESS");

                entity.Property(e => e.FonctionReferent)
                    .IsRequired()
                    .HasColumnName("fonction_referent")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FormeJuridique)
                    .IsRequired()
                    .HasColumnName("forme_juridique")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdActivite).HasColumnName("id_activite");

                entity.Property(e => e.IdAdresse).HasColumnName("id_adresse");

                entity.Property(e => e.IdStatut).HasColumnName("id_statut");

                entity.Property(e => e.LieuImmatriculation)
                    .HasColumnName("lieu_immatriculation")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NomReferent)
                    .IsRequired()
                    .HasColumnName("nom_referent")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrganisationComptable)
                    .IsRequired()
                    .HasColumnName("organisation_comptable")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PrenomReferent)
                    .IsRequired()
                    .HasColumnName("prenom_referent")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RaisonSociale)
                    .IsRequired()
                    .HasColumnName("raison_sociale")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SexeReferent)
                    .IsRequired()
                    .HasColumnName("sexe_referent")
                    .HasColumnType("char(1)");

                entity.Property(e => e.Siret)
                    .IsRequired()
                    .HasColumnName("siret")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SiteWeb)
                    .HasColumnName("site_web")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TelFix)
                    .HasColumnName("tel_fix")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TelPortable)
                    .HasColumnName("tel_portable")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.VolumeAnnuel).HasColumnName("volume_annuel");

                entity.HasOne(d => d.IdActiviteNavigation)
                    .WithMany(p => p.Client)
                    .HasForeignKey(d => d.IdActivite)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Client_Activite");

                entity.HasOne(d => d.IdAdresseNavigation)
                    .WithMany(p => p.Client)
                    .HasForeignKey(d => d.IdAdresse)
                    .HasConstraintName("FK_Client_Adresse");

                entity.HasOne(d => d.IdStatutNavigation)
                    .WithMany(p => p.Client)
                    .HasForeignKey(d => d.IdStatut)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Client_Statut");
            });

            modelBuilder.Entity<Droit>(entity =>
            {
                entity.HasKey(e => e.IdDroit);

                entity.Property(e => e.IdDroit).HasColumnName("id_droit");

                entity.Property(e => e.Permission)
                    .IsRequired()
                    .HasColumnName("permission")
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Etat>(entity =>
            {
                entity.HasKey(e => e.IdEtat);

                entity.Property(e => e.IdEtat).HasColumnName("id_etat");

                entity.Property(e => e.LibelleEtat)
                    .IsRequired()
                    .HasColumnName("libelle_etat")
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Lc>(entity =>
            {
                entity.HasKey(e => e.IdLc);

                entity.ToTable("LC");

                entity.Property(e => e.IdLc).HasColumnName("id_lc");

                entity.Property(e => e.CheminLc)
                    .HasColumnName("chemin_lc")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DateDebut)
                    .HasColumnName("date_debut")
                    .HasColumnType("date");

                entity.Property(e => e.DateFin)
                    .HasColumnName("date_fin")
                    .HasColumnType("date");

                entity.Property(e => e.DateLc)
                    .HasColumnName("date_lc")
                    .HasColumnType("date");

                entity.Property(e => e.IdClient).HasColumnName("id_client");

                entity.Property(e => e.IdModele).HasColumnName("id_modele");

                entity.HasOne(d => d.IdClientNavigation)
                    .WithMany(p => p.Lc)
                    .HasForeignKey(d => d.IdClient)
                    .HasConstraintName("FK_LC_client");

                entity.HasOne(d => d.IdModeleNavigation)
                    .WithMany(p => p.Lc)
                    .HasForeignKey(d => d.IdModele)
                    .HasConstraintName("FK_LC_modele");
            });

            modelBuilder.Entity<Modele>(entity =>
            {
                entity.HasKey(e => e.IdModele);

                entity.Property(e => e.IdModele).HasColumnName("id_modele");

                entity.Property(e => e.CheminModele)
                    .HasColumnName("chemin_modele")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.NomFichier)
                    .HasColumnName("nom_fichier")
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Statut>(entity =>
            {
                entity.HasKey(e => e.IdStatut);

                entity.Property(e => e.IdStatut)
                    .HasColumnName("id_statut")
                    .ValueGeneratedNever();

                entity.Property(e => e.IdTypestatut).HasColumnName("id_typestatut");

                entity.Property(e => e.Libelle)
                    .IsRequired()
                    .HasColumnName("libelle")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdTypestatutNavigation)
                    .WithMany(p => p.Statut)
                    .HasForeignKey(d => d.IdTypestatut)
                    .HasConstraintName("FK_Statut_TypeStatut");
            });

            modelBuilder.Entity<TypeStatut>(entity =>
            {
                entity.HasKey(e => e.IdTypeStatut);

                entity.Property(e => e.IdTypeStatut)
                    .HasColumnName("id_typeStatut")
                    .ValueGeneratedNever();

                entity.Property(e => e.Libelle)
                    .IsRequired()
                    .HasColumnName("libelle")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Utilisateur>(entity =>
            {
                entity.HasKey(e => e.IdUtilisateur);

                entity.Property(e => e.IdUtilisateur).HasColumnName("id_utilisateur");

                entity.Property(e => e.EmailUtilisateur)
                    .IsRequired()
                    .HasColumnName("email_utilisateur")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdDroit).HasColumnName("id_droit");

                entity.Property(e => e.MdpUtilisateur)
                    .HasColumnName("mdp_utilisateur")
                    .HasColumnType("nchar(10)");

                entity.Property(e => e.NomUtilisateur)
                    .IsRequired()
                    .HasColumnName("nom_utilisateur")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PrenomUtilisateur)
                    .IsRequired()
                    .HasColumnName("prenom_utilisateur")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdDroitNavigation)
                    .WithMany(p => p.Utilisateur)
                    .HasForeignKey(d => d.IdDroit)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Utilisateur_id_droit");
            });
        }
    }
}
