using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OVRM.Entities
{
    [Table("Booking_Details")]
    public class Booking_Detail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Booking_id { get; set; }


        [Required]
        public DateTime Booking_Date { get; set; }

        [Required]
        public int Booking_hours { get; set; }
        
        public List<Payment> Payments { get; set; }
    }
}
