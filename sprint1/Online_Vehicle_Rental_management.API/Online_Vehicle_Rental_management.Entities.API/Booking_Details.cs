using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Online_Vehicle_Rental_management.Entities.API
{
    [Table("Booking_Details")]
    public class Booking_Details
    {
        [Column("Booking_id")]
        [Key]    
        public int Booking_id { get; set; }

        [Column("payment_details")]
        [Required]
        [MaxLength(50)]
        public string payment_details { get; set; }

        [Column("Booking_Date")]
        [Required]
        [DataType(DataType.Time)]
        public DateTime Booking_Date { get; set; }


        public int VechicleVechicle_number { get; set; }

        public List<Payment> payments { get; }
    }
}
