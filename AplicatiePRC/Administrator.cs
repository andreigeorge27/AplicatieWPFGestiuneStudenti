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
    
    public partial class Administrator
    {
        public Administrator()
        {
            this.Cont = new HashSet<Cont>();
        }
    
        public int IdAdministrator { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string CNP { get; set; }
    
        public virtual ICollection<Cont> Cont { get; set; }
    }
}
