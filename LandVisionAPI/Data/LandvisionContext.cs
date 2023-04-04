using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace LandVisionAPI.Data
{
    public class LandvisionContext : DbContext
    {
        public LandvisionContext(DbContextOptions<LandvisionContext> opt) : base(opt)
        {


        }
        

        #region DbSet
        public DbSet<TypeUser>? TypeUsers { get; set; }
        public DbSet<User>? Users { get; set; }
        public DbSet<Account>? Accounts{ get; set; }
        public DbSet<Role>? Roles { get; set; }
        public DbSet<TypeUserRole>? TypeUserRoles { get; set; }
        #endregion
        public DbSet<Region> Regions { get; set; }
        public DbSet<Area> Areas { get; set; }
        public DbSet<Ward> Wards { get; set; }
        public DbSet<RealEstate> RealEstates { get; set; }
        public DbSet<RealEstateType> RealEstateTypes { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<PostType> PostTypes { get; set; }
     




        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TypeUser>(e =>
            {
                e.ToTable("TypeUser");
                e.HasKey(typeuser => typeuser.TypeUserId);
                e.Property(typeuser => typeuser.Name).IsRequired().HasMaxLength(100);
            });

            modelBuilder.Entity<User>(e =>
            {
                e.ToTable("User");
                e.HasKey(user => user.UserId);
                e.HasOne(s => s.TypeUser)
                   .WithMany(g => g.Users)
                   .HasForeignKey(s => s.TypeUserId);

                e.HasOne(user => user.Account)
                .WithOne(account => account.User)
                .HasForeignKey<Account>(account => account.UserId);


                e.Property(user => user.Name).IsRequired().HasMaxLength(100);
                e.Property(user => user.Description).HasMaxLength(256);
                e.Property(user => user.CreatedAt).HasDefaultValueSql("getutcdate()");
                e.Property(user => user.Email).IsRequired().HasMaxLength(100);
                e.HasIndex(user => user.Email).IsUnique();
                e.Property(user => user.Phone).HasMaxLength(16).HasDefaultValue("");
                e.HasIndex(user => user.Phone).IsUnique();
                e.Property(user => user.Address).HasMaxLength(256).HasDefaultValue("");
                e.Property(user => user.Birthday).IsRequired();
                e.Property(user => user.Bio).HasMaxLength(256);

            });

            modelBuilder.Entity<Account>(e =>
            {
                e.ToTable("Account");
                e.HasKey(account => account.AccountId);
                e.Property(account => account.Username).HasMaxLength(100).IsRequired();
                e.HasIndex(account => account.Username).IsUnique();
                e.Property(account => account.Password).IsRequired();
            });

            modelBuilder.Entity<Role>(e =>
            {
                e.ToTable("Role");
                e.HasKey(role => role.RoleId);
                e.Property(role => role.RoleId).HasMaxLength(50).IsRequired();
                e.Property(role => role.Name).HasMaxLength(256).IsRequired();
                e.Property(role => role.Description).HasMaxLength(256);
            });
            modelBuilder.Entity<TypeUserRole>(e =>
            {
                e.ToTable("TypeUserRole");
                e.HasKey(typeUserRole => new { typeUserRole.RoleId, typeUserRole.TypeUserId });
                e.Property(typeuserRole => typeuserRole.RoleId).HasMaxLength(50);
                
                e.HasOne(typeUserRole => typeUserRole.TypeUser)
                .WithMany(role => role.TypeUserRoles)
                .HasForeignKey(typeUserRole => typeUserRole.TypeUserId);

                e.HasOne(typeUserRole => typeUserRole.Role)
               .WithMany(typeUser => typeUser.TypeUserRoles)
               .HasForeignKey(typeUserRole => typeUserRole.RoleId);
            });

            modelBuilder.Entity<Region>(e =>
            {
                e.ToTable("Region");
                e.HasKey(region => region.RegionId);
                e.Property(region => region.RegionName).HasMaxLength(50);
               

            });
            modelBuilder.Entity<Area>(e =>
            {
                e.ToTable("Area");
                e.HasKey(area => area.AreaId);
                e.Property(area => area.AreaName).HasMaxLength(50);

                e.HasOne(area => area.Region)
                .WithMany(region => region.Areas)
                .HasForeignKey(area => area.RegionId);
            });

            modelBuilder.Entity<Ward>(e =>
            {
                e.ToTable("Ward");
                e.HasKey(ward => ward.WardId);
                e.Property(ward => ward.WardName).HasMaxLength(50);

                e.HasOne(ward => ward.Area)
                .WithMany(area => area.Wards)
                .HasForeignKey(ward => ward.AreaId);
            });

            modelBuilder.Entity<RealEstate>(e =>
            {
                e.ToTable("RealEstate");
                e.HasKey(realEstate => realEstate.RealEstateId);
                e.HasOne(realEstate => realEstate.RealEstateType)
                .WithMany(realEstateType => realEstateType.RealEstates)
                .HasForeignKey(realEstate => realEstate.RealEstateTypeId);

                e.HasOne(realEstate => realEstate.User)
                .WithMany(user => user.RealEstates)
                .HasForeignKey(realEstate => realEstate.UserId);

                e.HasOne<Position>(realEstate => realEstate.Position)
                .WithOne(position => position.RealEstate)
                .HasForeignKey<Position>(position => position.RealEstateId);

                e.HasOne<Post>(realEstate => realEstate.Post)
                .WithOne(post => post.RealEstate)
                .HasForeignKey<Post>(post => post.RealEstateId);
            });

            modelBuilder.Entity<RealEstateType>(e =>
            {
                e.ToTable("RealEstateType");
                e.HasKey(realEstateType => realEstateType.Id);
                e.Property(realEstateType => realEstateType.Name).HasMaxLength(50);

            });
            modelBuilder.Entity<Media>(e =>
            {
                e.ToTable("Media");
                e.HasKey(media => media.Id);
                e.Property(media => media.MediaLink).HasMaxLength(256);

                e.HasOne(media => media.RealEstate)
                .WithMany(realEstate => realEstate.Medias)
                .HasForeignKey(media => media.RealEstateId);

            });

            modelBuilder.Entity<Position>(e =>
            {
                e.ToTable("Position");
                e.HasKey(position => position.Id);

            });
            modelBuilder.Entity<PostType>(e =>
            {
                e.ToTable("PostType");
                e.HasKey(postType => postType.Id);

            });

            modelBuilder.Entity<Post>(e =>
            {
                e.ToTable("Post");
                e.HasKey(post => post.Id);

                e.HasOne(post => post.PostTypeOfPost)
                .WithMany(postType => postType.PostsOfPostType)
                .HasForeignKey(post => post.PostTypeId);

            });
            
        }

    }
}
