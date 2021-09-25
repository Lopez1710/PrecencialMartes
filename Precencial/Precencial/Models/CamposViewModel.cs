using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Precencial.Models
{
    public class CamposViewModel
    {
        [Required(ErrorMessage ="Campo Obligatorio")]
        public string Nombre { get; set; }
        [Required(ErrorMessage ="Campo Obligatorio")]
        [Range(0,100,ErrorMessage ="Edad Erronea")]
        public int Edad { get; set; }
        [Required(ErrorMessage = "Campo Obligatorio")]
        public string Sexo { get; set; }
        [Required(ErrorMessage = "Campo Obligatorio")]
        public string Educacion { get; set; }
    }
}
