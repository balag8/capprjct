using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Online_Vehicle_Rental_management.Entities.API
{
    [Table("Active_Booking_Details")]
    public class Active_Booking
    {
        [Column("Booking_id")]
        [Key]
        [MaxLength(20)]
        public int Booking_id { get; set; }
        
        [Column("vehicle_status")]
        [Required]
        [MaxLength(30)]
        public string vehicle_status { get; set; }

        [Column("cancel_booking")]
        [Required]
        [MaxLength(30)]
        public string cancel_booking { get; set; }

        public int PaymentPayment_no { get; set; }

        public Payment Payment { get; }
    }
}
