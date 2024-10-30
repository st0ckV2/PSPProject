using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSPProject.Data.Entities
{
    public class Suplier
    {
        /*
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Nombre del proveedor")]
        [MaxLength(100, ErrorMessage = "El campo {0} no puede tener más de {1} caracteres")]
        public string name { get; set; } = null!;

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Información de contacto")]
        [MaxLength(300, ErrorMessage = "El campo {0} no puede tener más de {1} caracteres")]
        public string contactInfo { get; set; } = null!;
        
        public ICollection<Purchase>? Purchases { get; set; }*/
        public int Id { get; set; }
        public string name { get; set; }
        public string contactInfo { get; set; }
    }
}
