using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Online_Vehicle_Rental_management.Entities.API
{
    [Table("admin")]
    public class Admin
    {
        [Column("A_id")]
        [Key]
        public int Admin_id { get; set; }

        [Column("A_Name")]
        [Required]
        [MaxLength(50)]
        public string First_name { get; set; }

        [Column("L_Name")]
        [Required]
        [MaxLength(30)]
        public string Last_name { get; set; }

        [Column("Emailid")]
        [Required]
        [MaxLength(50)]
        public string Admin_Email { get; set; }

        [Column("p_No")]
        [Required]
        [MaxLength(10)]
        public string Mobile_No { get; set; }

        [Column("password")]
        [Required]
        [MaxLength(50)]
        public string Admin_Password { get; set; }

        public List<Customer> Customers { get; }
    }
}
