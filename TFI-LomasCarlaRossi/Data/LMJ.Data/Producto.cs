//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LMJ.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Producto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Producto()
        {
            this.Caja = new HashSet<Caja>();
            this.Caja_Producto = new HashSet<Caja_Producto>();
            this.VentaPagos = new HashSet<VentaPagos>();
        }
    
        public int IdProducto { get; set; }
        public int IdProveedor { get; set; }
        public int IdCaja { get; set; }
        public string Tipo { get; set; }
        public Nullable<decimal> Precio { get; set; }
        public string Color { get; set; }
        public Nullable<int> Cantidad { get; set; }
        public string Descripcion { get; set; }
        public string DVH { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Caja> Caja { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Caja_Producto> Caja_Producto { get; set; }
        public virtual Proveedor Proveedor { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VentaPagos> VentaPagos { get; set; }
    }
}
