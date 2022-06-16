using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OVRM.Entities
{
    [Table("Admin")]
    public class Admin
    {
        [Key]
        public int Admin_id { get; set; }

        [Required]
        [StringLength(50,MinimumLength =3)]
        public string First_name { get; set; }
        
        [Required]
        public string Last_name { get; set; }
        
        [Required]

        public string Admin_Email { get; set; }

        [Required]
        public string Mobile_No { get; set; }

        [Required]
        [MaxLength(30)]
        public string Admin_Password { get; set; }
    }
}
