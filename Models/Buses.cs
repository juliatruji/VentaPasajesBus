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
    
    public partial class Buses
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Buses()
        {
            this.Pasajes = new HashSet<Pasajes>();
            this.Viajes = new HashSet<Viajes>();
        }
    
        public int id_bus { get; set; }
        public string modelo_bus { get; set; }
        public string placa_bus { get; set; }
        public int capacidad_bus { get; set; }
        public int id_empres { get; set; }
        public Nullable<int> pisos { get; set; }
        public string url { get; set; }
        public string tipo_servicio { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pasajes> Pasajes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Viajes> Viajes { get; set; }
        public virtual Empresas Empresas { get; set; }
    }
}
