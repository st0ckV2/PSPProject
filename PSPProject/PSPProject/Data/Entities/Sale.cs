using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSPProject.Data.Entities
{
    public class Sale
    {
        /*
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "ID del cliente")]
        public int customerID { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "ID del empleado que realiza la venta")]
        public int employeeID { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Fecha de la venta en DD/MM/AAAA")]
        [MaxLength(10, ErrorMessage = "El campo {0} no puede tener más de {1} caracteres")]
        public string date { get; set; } = null!;

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Monto total")]
        public int totalAmount { get; set; }
        
        public Customer Customer { get; set; } = null!;
        public ICollection<SalesDetail>? SalesDetails { get; set; }
        //public Customer Customer { get; set; } = null!;
        */
        public int Id { get; set; }
        public int customerId { get; set; }
        public int employeeId { get; set; }
        public string date { get; set; }
        public int totalAmount { get; set; }
    }
}