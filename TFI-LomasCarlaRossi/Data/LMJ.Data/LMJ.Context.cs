﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class LMJEntities1 : DbContext
    {
        public LMJEntities1()
            : base("name=LMJEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Asociado> Asociado { get; set; }
        public virtual DbSet<Bitacora> Bitacora { get; set; }
        public virtual DbSet<Caja> Caja { get; set; }
        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<Compra> Compra { get; set; }
        public virtual DbSet<DVV> DVV { get; set; }
        public virtual DbSet<Envio> Envio { get; set; }
        public virtual DbSet<Formulario> Formulario { get; set; }
        public virtual DbSet<Idioma> Idioma { get; set; }
        public virtual DbSet<Permiso> Permiso { get; set; }
        public virtual DbSet<Producto> Producto { get; set; }
        public virtual DbSet<Promocion> Promocion { get; set; }
        public virtual DbSet<Proveedor> Proveedor { get; set; }
        public virtual DbSet<Rol> Rol { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Traduccion> Traduccion { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }
        public virtual DbSet<VentaPagos> VentaPagos { get; set; }
        public virtual DbSet<Caja_Producto> Caja_Producto { get; set; }
        public virtual DbSet<DetalleVentaPagos> DetalleVentaPagos { get; set; }
        public virtual DbSet<Rol_Permiso> Rol_Permiso { get; set; }
        public virtual DbSet<Rol_Usuario> Rol_Usuario { get; set; }
    }
}
