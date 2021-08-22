using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LMJ.Entities.Model
{
    [MetadataType(typeof(AsociadoMetadata))]
    public partial class Asociado
    {
        public class AsociadoMetadata
        {

            [DisplayName("Descripcion")]
            [MaxLength(2000, ErrorMessage = "Longitud  2000 caracteres")]
            public string Descripcion { get; set; }

            [DisplayName("Telefono")]
            [MaxLength(50, ErrorMessage = "Longitud  50 caracteres")]
            public string Telefono { get; set; }


            [DisplayName("NombreContacto")]
            [Required(ErrorMessage = "Requerido")]
            [MaxLength(50, ErrorMessage = "Longitud  50 caracteres")]
            public string NombreContacto { get; set; }

            [DisplayName("Email")]
            [Required(ErrorMessage = "Requerido")]
            [MaxLength(100, ErrorMessage = "Longitud  100 caracteres")]
            public string Email { get; set; }


            [DisplayName("Plazo")]
            [Required(ErrorMessage = "Requerido")]
            [MaxLength(100, ErrorMessage = "Longitud  100 caracteres")]
            public string Plazo { get; set; }

            [DisplayName("Vigencia")]
            [Required(ErrorMessage = "Requerido")]
            public int Vigencia { get; set; }
                       

            [DisplayName("DVH")]
            [Required(ErrorMessage = "Requerido")]
            [MaxLength(100, ErrorMessage = "Longitud  100 caracteres")]
            public string DVH { get; set; }


        }
    }
}
