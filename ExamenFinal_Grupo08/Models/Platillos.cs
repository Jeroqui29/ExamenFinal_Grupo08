//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ExamenFinal_Grupo08.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    public partial class Platillos
    {
        
        public Platillos()
        {
            this.OrdenDetalle = new HashSet<OrdenDetalle>();
        }
        [Display(Name = "#")]
        public int ID_Platillo { get; set; }
        [Display(Name = "Nombre de platillo")]
        public string Nombre { get; set; }
        [Display(Name = "Ingredientes del platillo")]
        public string Ingredientes { get; set; }
        [Display(Name = "Precio del Platillo")]
        public decimal Precio { get; set; }
        [Display(Name = "Imagen del platillo")]
        public string ImagenURL { get; set; }

        [Display(Name = "#")]
        public virtual ICollection<OrdenDetalle> OrdenDetalle { get; set; }
    }
}
