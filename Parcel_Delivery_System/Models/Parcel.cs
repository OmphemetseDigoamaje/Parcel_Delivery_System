using System.ComponentModel.DataAnnotations;

namespace Parcel_Delivery_System.Models
{
	public class Parcel
	{
		public int Id { get; set; }

		[Required]
		public string? TrackingNumber { get; set; }

		[Required]
		public string? SenderName { get; set; }

		[Required]
		public string? ReceiverName { get; set; }

		public string? Status { get; set; }
	}
}