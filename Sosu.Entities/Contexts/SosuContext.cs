using Microsoft.EntityFrameworkCore;
using Entities.Sosu;
using Task = Entities.Sosu.Task;

namespace Entities.Contexts;

public partial class SosuContext : DbContext
{
    public SosuContext()
    {
    }

    public SosuContext(DbContextOptions<SosuContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<Note> Notes { get; set; }

    public virtual DbSet<Resident> Residents { get; set; }

    public virtual DbSet<Task> Tasks { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=Sosu;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.EmployeeId).HasName("PK__Employee__7AD04F1114DCC6FD");

            entity.Property(e => e.Initials).HasMaxLength(10);
        });

        modelBuilder.Entity<Note>(entity =>
        {
            entity.HasKey(e => new { e.EmployeeId, e.TaskId }).HasName("PK__Notes__7D16DB8A47BD1974");

            entity.Property(e => e.Text).HasColumnName("Note");

            entity.HasOne(d => d.Employee).WithMany(p => p.Notes)
                .HasForeignKey(d => d.EmployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Notes__EmployeeI__2D27B809");

            entity.HasOne(d => d.Task).WithMany(p => p.Notes)
                .HasForeignKey(d => d.TaskId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Notes__TaskId__2E1BDC42");
        });

        modelBuilder.Entity<Resident>(entity =>
        {
            entity.HasKey(e => e.ResidentId).HasName("PK__Resident__07FB00DCC923CED6");

            entity.Property(e => e.RoomId).HasMaxLength(10);
        });

        modelBuilder.Entity<Task>(entity =>
        {
            entity.HasKey(e => e.TaskId).HasName("PK__Tasks__7C6949B1F540309F");

            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.Title).HasMaxLength(100);

            entity.HasOne(d => d.CompletedByNavigation).WithMany(p => p.Tasks)
                .HasForeignKey(d => d.CompletedBy)
                .HasConstraintName("FK__Tasks__Completed__29572725");

            entity.HasOne(d => d.Resident).WithMany(p => p.Tasks)
                .HasForeignKey(d => d.ResidentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Tasks__ResidentI__2A4B4B5E");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
