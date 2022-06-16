using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Online_Vehicle_Rental_management.Entities.API
{
    [Table("Cust")]
    public class Customer
    {
        [Column("Cust_id")]
        [Key]
        public int Customer_id { get; set; }
        
        [Column("Cust_FName")]
        [Required]
        [MaxLength(30)]
        public string Cust_FstName { get; set; }

        [Column("Cust_LName")]
        [Required]
        [MaxLength(30)]
        public string Cust_LstName { get; set; }

        [Column("Cust_email")]
        [Required]
        [MaxLength(30)]
        public string Cust_Emailid { get; set; }

        [Column("cust_phno")]
        [Required]
        [MaxLength(20)]
        public string Mobile_no { get; set; }

        [Column("password")]
        [Required]
        [MaxLength(20)]
        public string Cust_Password { get; set; }

        [Column("Driving_licence")]
        [Required]
        [MaxLength(50)]
        public string Cust_drivingLicence { get; set; }


        public int AdminAdmin_id  { get; set; }

        public Admin admin { get;  }


        public List<Vehicle> vehicle { get; }
    }
}
