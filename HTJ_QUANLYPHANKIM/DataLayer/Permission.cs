//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class Permission
    {
        public string PermissionId { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Parent { get; set; }
        public string ButtonName { get; set; }
        public string KeyCodes { get; set; }
        public byte[] Image { get; set; }
        public Nullable<bool> View { get; set; }
        public Nullable<bool> Add { get; set; }
        public Nullable<bool> Edit { get; set; }
        public Nullable<bool> Delete { get; set; }
        public Nullable<bool> Print { get; set; }
        public Nullable<bool> Extract { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
    }
}
