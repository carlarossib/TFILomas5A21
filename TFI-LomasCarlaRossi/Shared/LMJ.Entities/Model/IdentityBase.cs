using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LMJ.Entities.Model
{
    public class IdentityBase
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Requerido")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public System.DateTime CreatedOn { get; set; }

        [MaxLength(256, ErrorMessage = "Created By Longitud  256 caracteres")]
        public string CreatedBy { get; set; }

        [Required(ErrorMessage = "Requerido")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public System.DateTime ChangedOn { get; set; }

        [MaxLength(256, ErrorMessage = "Changed By Longitud  256 caracteres")]
        public string ChangedBy { get; set; }
        public override string ToString()
        {
            return this.GetType().Name + ": " +
                string.Join(",", this.GetType().GetProperties()
                .Where(p => !p.PropertyType.IsGenericType && !p.PropertyType.IsArray)
                .Select(p => string.Format("{0}={1}", p.Name, p.GetValue(this, null))));
        }
    }
}
