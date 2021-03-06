//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ViajesUTP.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Viajes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Viajes()
        {
            this.Pasajes = new HashSet<Pasajes>();
        }
    
        public int id_viaje { get; set; }
        public int id_empres { get; set; }
        public int id_bus { get; set; }
        public int id_origen { get; set; }
        public int id_destino { get; set; }
        public System.DateTime fecha { get; set; }
        public System.DateTime hora { get; set; }
        public int precio { get; set; }
        public string asientos { get; set; }
    
        public virtual Buses Buses { get; set; }
        public virtual Empresas Empresas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pasajes> Pasajes { get; set; }
        public virtual Ubicacion Ubicacion { get; set; }
        public virtual Ubicacion Ubicacion1 { get; set; }
    }
}
