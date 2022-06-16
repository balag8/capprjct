using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Online_Vehicle_Rental_management.Entities.API
{
    [Table("payment_details")]
    public class Payment
    {
        [Column("Payment_no")]
        [Key]
        [Required]
        [MaxLength(20)]
        public int Payment_no { get; set; }


        [Column("payment_mode")]
        [Required]
        [MaxLength(30)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string payment_mode { get; set; }

        [Column("payment_details")]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string payment_details { get; set; }


        public int Booking_DetailsBooking_id { get; set; }

        public List<Active_Booking> Active_Bookings { get; }
    }
}
