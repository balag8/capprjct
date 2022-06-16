using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Online_Vehicle_Rental_management.Entities.API
{
    [Table("Vehicle_Details")]
    public class Vehicle
    {
        [Column("Vehicle_Number")]
        [Key]
        [MaxLength(20)]
        public int vehicle_number { get; set; }

        [Column("Vehicle_Type")]
        [Required]
        [MaxLength(40)]
        public string vehicle_type { get; set; }

        [Column("Vehicle_price")]
        [Required]
        [MaxLength(40)]
        public int price { get; set; }


        public int CustomerCustomer_id { get; set; }

        public List<Booking_Details> Booking_Details { get;}
    }
}
