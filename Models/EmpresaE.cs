using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ViajesUTP.Models
{
    public class EmpresaE
    {
        [Required]
        [Display(Name = "Ingrese Empresa")]
        public string Empresa { get; set; }
        [Required]
        [Display(Name = "Ingrese Direccion")]
        public string Direccion { get; set; }
        [Required]
        [Display(Name = "Ingrese Ruc")]
        public string Ruc { get; set; }
        [Required]
        [Display(Name = "Ingrese Cantidad de Buses")]
        public int CantidadBuses { get; set; }

    }
    [MetadataType(typeof(EmpresaE))]
    public partial class Empresas {

    }
}