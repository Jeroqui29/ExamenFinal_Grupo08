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
    public partial class OrdenDetalle
    {
        public int ID_Detalle { get; set; }
        public Nullable<int> ID_Orden { get; set; }
        public Nullable<int> ID_Platillo { get; set; }
        public int Cantidad { get; set; }
    
        public virtual Ordenes Ordenes { get; set; }
        public virtual Platillos Platillos { get; set; }
    }
}
