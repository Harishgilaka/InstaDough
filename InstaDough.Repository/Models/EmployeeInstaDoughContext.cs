using Microsoft.EntityFrameworkCore;

namespace InstaDough.Repository.Models;

public partial class EmployeeInstaDoughContext : DbContext
{
    public EmployeeInstaDoughContext()
    {
    }

    public EmployeeInstaDoughContext(DbContextOptions<EmployeeInstaDoughContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Employee> Employees { get; set; }

    //    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
    //        => optionsBuilder.UseSqlServer("Server=DESKTOP-U7O0436\\SQLEXPRESS01;Database=EmployeeInstaDough;Trusted_Connection=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Employee__3214EC07787396AD");

            entity.ToTable("Employee");

            entity.Property(e => e.EmailId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("EmailID");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
