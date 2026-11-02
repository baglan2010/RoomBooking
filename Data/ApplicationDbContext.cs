using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace RoomBooking.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
{
    public DbSet<Room> Rooms => Set<Room>();
    public DbSet<Booking> Bookings => Set<Booking>();

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<Room>().HasData(
            new Room { Id = 1, Name = "Переговорка A", Capacity = 6, Description = "Проектор и доска" },
            new Room { Id = 2, Name = "Переговорка B", Capacity = 10, Description = "Большой стол, ТВ" },
            new Room { Id = 3, Name = "Тихая комната", Capacity = 2, Description = "Для звонков и работы вдвоём" }
        );
    }
}