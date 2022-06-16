using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace OVRM.Entities
{

    [Table("vehicle")]
    public class Vehicle
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Vehicle_number { get; set; }
 
        [Required]
        [MaxLength(50)]
        public string Vehicle_Type { get; set; }
       
        [Required]
        public int Vehicle_price { get; set; }

        public List<Booking_Detail> Booking_Details { get; set; }
    }
}
