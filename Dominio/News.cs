//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dominio
{
    using System;
    using System.Collections.Generic;
    
    public partial class News
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> LastSent { get; set; }
        public int IdFamily { get; set; }
    
        public virtual Family Family { get; set; }
    }
}