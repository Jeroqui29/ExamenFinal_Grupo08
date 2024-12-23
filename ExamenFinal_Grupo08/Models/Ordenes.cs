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
    public partial class Ordenes
    {
        public Ordenes()
        {
            this.OrdenDetalle = new HashSet<OrdenDetalle>();
        }
        [Display(Name = "#")]
        public int ID_Orden { get; set; }
        [Display(Name = "Numero de mesa")]
        public int ID_Mesa { get; set; }
        [Display(Name = "Estado de la Orden")]
        public string Estado { get; set; }

        [Display(Name = "Fecha de orden")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString ="{0:MM/dd/yyyy}")]
        [DataType(DataType.DateTime)]
        public Nullable<System.DateTime> Fecha { get; set; }
        [Display(Name = "#")]
        public virtual ICollection<OrdenDetalle> OrdenDetalle { get; set; }
    }
}
