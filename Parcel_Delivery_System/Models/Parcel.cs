using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Parcel_Delivery_System.Models
{

	[Index(nameof(TrackingNumber), IsUnique = true)]
	public class Parcel
	{
		public int Id { get; set; }

		[Required]
		public string TrackingNumber { get; set; } = string.Empty;

		[Required]
		public string? SenderName { get; set; } = string.Empty;

		[Required]
		public string? ReceiverName { get; set; } = string.Empty;

		[Required]
		public string? Status { get; set; } = "Not Available";
	}
}