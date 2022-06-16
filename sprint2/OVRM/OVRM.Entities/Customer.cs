using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace OVRM.Entities
{
    [Table("Customer")]
    public class Customer
    {  
        [Key]
        public int Customer_id { get; set; }

        [Required]
        [MaxLength(30)]
        public string Cust_FstName { get; set; }

        [Required]
        [MaxLength(30)]
        public string Cust_LstName { get; set; }

        [Required]
        [MaxLength(50)]
        public string Cust_Emailid { get; set; }

        [Required]
        [MaxLength(50)]
        public string Cust_MobileNo { get; set; }

        [Required]
        [MaxLength(50)]
        public string Cust_Password { get; set; }


        [Required]
        [MaxLength(50)]
        public string Cust_drivinglicence { get; set; }

        public Admin Admin { get; set; }
        public List<Vehicle> Vehicles { get; set; }

    }
    }
