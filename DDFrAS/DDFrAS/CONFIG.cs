//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DDFrAS
{
    using System;
    using System.Collections.Generic;
    
    public partial class CONFIG
    {
        public int Config_ID { get; set; }
        public Nullable<int> Port_ID { get; set; }
        public Nullable<int> Config_var_ID { get; set; }
        public Nullable<int> Product_ID { get; set; }
        public Nullable<int> Command_ID { get; set; }
        public Nullable<int> Line_ID { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<System.DateTime> ExDate { get; set; }
        public string Script { get; set; }
    
        public virtual CONFIG_VAR CONFIG_VAR { get; set; }
        public virtual PORT PORT { get; set; }
        public virtual PRODUCT PRODUCT { get; set; }
        public virtual SSH_COMMANDS SSH_COMMANDS { get; set; }
    }
}
