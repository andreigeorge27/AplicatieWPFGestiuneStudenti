//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AplicatiePRC
{
    using System;
    using System.Collections.Generic;
    
    public partial class Nota
    {
        public int IdNota { get; set; }
        public int Calificativ { get; set; }
        public int IdCurs { get; set; }
        public int IdStudent { get; set; }
        public System.DateTime DataAdaugare { get; set; }
    
        public virtual Curs Curs { get; set; }
        public virtual Student Student { get; set; }
    }
}
