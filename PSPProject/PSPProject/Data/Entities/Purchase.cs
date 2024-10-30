using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSPProject.Data.Entities
{
    public class Purchase
    {
        /*
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "ID del proveedor")]
        public int suplierID { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Fecha de la compra en DD/MM/AAAA")]
        public string date { get; set; } = null!;

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Monto total")]
        public int totalAmount { get; set; }
        
        //public Suplier? Suplier { get; set; }
        public ICollection<PurchaseDetail>? PurchaseDetails { get; set; }
        */
        public int Id { get; set; }
        public int suplierId { get; set; }
        public string date { get; set; }
        public int totalAmount { get; set; }
    }
}