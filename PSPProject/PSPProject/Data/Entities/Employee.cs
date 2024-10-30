using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace PSPProject.Data.Entities
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(60)]
        public string firstName { get; set; }
        [StringLength(80)]
        public string lastName { get; set; }
        [StringLength(200)]
        [DataType(DataType.EmailAddress)]
        public string email { get; set; }
        [StringLength(10)]
        public string phoneNumber { get; set; }
        [StringLength(200)]
        public string adress { get; set; }
        [StringLength(200)]
        public string photo { get; set; }
    }
}
