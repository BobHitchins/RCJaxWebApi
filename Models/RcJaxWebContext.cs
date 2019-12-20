using Microsoft.EntityFrameworkCore;

namespace RCJaxWebApi.Models
{
    public class RcJaxWebContext : DbContext
    {
        public RcJaxWebContext(DbContextOptions<RcJaxWebContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<AfireMember>()
                .HasKey(x => new { x.AfireId, x.MemberId });

            modelBuilder.Entity<AfireMember>()
                .HasOne(a => a.Afire)
                .WithMany(am => am.MemberLink)
                .HasForeignKey(a => a.AfireId);

            modelBuilder.Entity<AfireMember>()
                .HasOne(m => m.Member)
                .WithMany(am => am.AfireLink)
                .HasForeignKey(m => m.MemberId);

            modelBuilder.Entity<Member>()
                .HasMany(p => p.Phones)
                .WithOne(m => m.Member)
                .IsRequired();

            modelBuilder.Entity<Member>()
                .HasMany(a => a.Addresses)
                .WithOne(m => m.Member)
                .IsRequired();

            modelBuilder.Entity<ContentType>()
                .HasMany(c => c.Contents)
                .WithOne(ct => ct.ContentType)
                .IsRequired();
        }
    }
}