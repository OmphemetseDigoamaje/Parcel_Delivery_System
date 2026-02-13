using Microsoft.EntityFrameworkCore;

namespace Parcel_Delivery_System.Models
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
			: base(options)
		{
		}

		public DbSet<Parcel> Parcels { get; set; }
	}
}