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
    
    public partial class Curs
    {
        public Curs()
        {
            this.Nota = new HashSet<Nota>();
        }
    
        public int IdCurs { get; set; }
        public string DenumireCurs { get; set; }
        public int IdSpecializare { get; set; }
        public int An { get; set; }
        public int Semestru { get; set; }
        public int NumarCredite { get; set; }
    
        public virtual Specializare Specializare { get; set; }
        public virtual ICollection<Nota> Nota { get; set; }
    }
}