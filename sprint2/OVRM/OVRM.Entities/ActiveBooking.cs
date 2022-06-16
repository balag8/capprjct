using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace OVRM.Entities
{
    [Table("ActiveBooking")]
    public class ActiveBooking
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Booking_id { get; set; }

        [Required]
        [MaxLength(30)]
        public string vehicle_status { get; set; }


        [Required]
        [MaxLength(30)]
        public string cancel_booking { get; set; }
    }
}