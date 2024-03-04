namespace proba.Models;

public class AplikacijadbContext : DbContext
{
    public AplikacijadbContext(DbContextOptions options) : base(options)
    {

    }

    public DbSet<User>? User { get; set; }

    public DbSet<MyObject>? Objects { get; set; }

    public DbSet<Feedback>? Feedbacks { get; set; }

    public DbSet<Reservation>? Reservations { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Reservation>().HasKey(e => new { e.UserID, e.ObjectID });

        modelBuilder.Entity<Reservation>().HasOne(e => e.User).WithMany(q => q.Reservations).HasForeignKey(e => e.UserID).HasConstraintName("Reservation_UserCT").IsRequired();
        modelBuilder.Entity<Reservation>().HasOne(e => e.Object).WithMany(u => u.Reservations).HasForeignKey(e => e.ObjectID).HasConstraintName("Reservation_ObjectCT").IsRequired();


        modelBuilder.Entity<Feedback>().HasKey(e => new { e.UserID, e.ObjectID });

        modelBuilder.Entity<Feedback>().HasOne(e => e.User).WithMany(q => q.Feedbacks).HasForeignKey(e => e.UserID).HasConstraintName("Feedback_UserCT").IsRequired();
        modelBuilder.Entity<Feedback>().HasOne(e => e.Object).WithMany(u => u.Feedbacks).HasForeignKey(e => e.ObjectID).HasConstraintName("Feedback_ObjectCT").IsRequired();


    }

}
