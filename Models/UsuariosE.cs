using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ViajesUTP.Models
{
    public class UsuariosE
    {
        [Required]
        [Display(Name ="ingrese nombre")]
        public string Nombre { get; set; }
        [Display(Name = "ingrese Apellidos")]
        public string Apellidos { get; set; }
        [Display(Name = "ingrese Dni")]
        public string Dni { get; set; }
        [Display(Name = "ingrese Sexo")]
        public string Sexo { get; set; }
        [Display(Name = "ingrese Esatado civil")]
        public string EstadoCivil { get; set; }
        [Display(Name = "ingrese Telefono")]
        public string Telefono { get; set; }
        [Display(Name = "ingrese Correo")]
        public string EmailAddress { get; set; }
        [Display(Name = "ingrese Nacionalidad")]
        public string Nacionalidad { get; set; }
        [Display(Name = "ingrese Lugar Nacimiento")]
        public string LugarNacimiento { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:yyy-MM-dd}", ApplyFormatInEditMode =true)]
        public DateTime FechaNacimiento { get; set; }
        [Display(Name = "ingrese usuario")]
        public string Login { get; set; }
        [Display(Name = "ingrese Contraseña")]
        public string Contrasena { get; set; }
        [Display(Name = "ingrese Direccion")]
        public string Direccion { get; set; }
        [Display(Name = "ingrese Departamento")]
        public int id_ubicacion { get; set; }

    }
    [MetadataType(typeof(UsuariosE))]
    public partial class Usuarios {

    }
}