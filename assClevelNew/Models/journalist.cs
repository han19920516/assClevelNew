//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace assClevelNew.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class journalist
    {
        public int journalistid { get; set; }
        [Required(ErrorMessage = "Please Enter Name")]
        public string jname { get; set; }
        [Required(ErrorMessage = "Please Enter phone")]
        public Nullable<int> jphone { get; set; }
        public string jemail { get; set; }
        [Required(ErrorMessage = "Please Enter title")]
        public string jtitle { get; set; }
        public Nullable<int> articleid { get; set; }
    
        public virtual article article { get; set; }
    }
}
