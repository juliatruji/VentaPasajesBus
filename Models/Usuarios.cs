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
    
    public partial class Usuarios
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Usuarios()
        {
            this.Pasajes = new HashSet<Pasajes>();
        }
    
        public int id_usuario { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Dni { get; set; }
        public string Sexo { get; set; }
        public string EstadoCivil { get; set; }
        public string Telefono { get; set; }
        public string EmailAddress { get; set; }
        public string Nacionalidad { get; set; }
        public string LugarNacimiento { get; set; }
        public System.DateTime FechaNacimiento { get; set; }
        public string Login { get; set; }
        public string Contrasena { get; set; }
        public string Direccion { get; set; }
        public int id_ubicacion { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pasajes> Pasajes { get; set; }
        public virtual Ubicacion Ubicacion { get; set; }
    }
}
