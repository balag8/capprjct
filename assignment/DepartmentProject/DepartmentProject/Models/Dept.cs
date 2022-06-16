using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DepartmentProject.Models
{
    [Table("Depts")]k
    public class Dept
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DeptNo { get; set; }

        [Required]
        [MaxLength(50)]
        public string DName { get; set; }

        [Required]
        [MaxLength(50)]
        public string Location { get; set; }

    }
}
