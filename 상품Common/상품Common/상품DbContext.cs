using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace 상품Common
{
    public class 상품DbContext : DbContext
    {
        public DbSet<상품> 상품 { get; set; }

        public 상품DbContext(DbContextOptions<상품DbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new 상품Configuration());
        }
    }
    public class 상품Configuration : IEntityTypeConfiguration<상품>
    {
        public void Configure(EntityTypeBuilder<상품> builder)
        {
            builder.HasKey(x => x.품목코드);
            builder.Property(x => x.품목명).IsRequired().HasMaxLength(100);
            builder.Property(x => x.그룹명).HasMaxLength(50);
            builder.Property(x => x.규격명).HasMaxLength(50);
            builder.Property(x => x.바코드).HasMaxLength(20);
            builder.Property(x => x.품목구분).IsRequired();  // Enum 처리
            builder.Property(x => x.이미지).HasMaxLength(255);  // 이미지 파일 경로 또는 URL
        }
    }
}
