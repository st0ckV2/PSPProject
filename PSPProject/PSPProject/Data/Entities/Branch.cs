﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSPProject.Data.Entities
{
    public class Branch
    {
        /*
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Nombre de la sucursal")]
        [MaxLength(100, ErrorMessage = "El campo {0} no puede tener más de {1} caracteres")]
        public string Name { get; set; } = null!;

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Ubicación de la sucursal")]
        [MaxLength(300, ErrorMessage = "El campo {0} no puede tener más de {1} caracteres")]
        public string Location { get; set; } = null!;

        public ICollection<Assignment>? Assignments { get; set; }
        */
        public int Id { get; set; }
        public string name { get; set; }
        public string location { get; set; }
    }
}
