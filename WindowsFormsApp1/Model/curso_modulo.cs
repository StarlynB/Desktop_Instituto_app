//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp1.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class curso_modulo
    {
        public int Id_curso_modulo { get; set; }
        public Nullable<int> curso_id { get; set; }
        public Nullable<int> modulo_id { get; set; }
    
        public virtual curso curso { get; set; }
        public virtual modulo modulo { get; set; }
    }
}