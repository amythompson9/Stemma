//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Stemma.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserProfile
    {
        public int UserProfileID { get; set; }
        public System.DateTime Birthdate { get; set; }
        public int RegisterUserID { get; set; }
        public int RelationshipsID { get; set; }
        public int CareerID { get; set; }
        public int CelebrationID { get; set; }
        public int HobbyID { get; set; }
        public int MemoryID { get; set; }
        public int WorldEventID { get; set; }
        public int EventID { get; set; }
    
        public virtual Career Career { get; set; }
        public virtual Celebration Celebration { get; set; }
        public virtual HobbyTable HobbyTable { get; set; }
        public virtual Memory Memory { get; set; }
        public virtual RegisterUser RegisterUser { get; set; }
        public virtual Relationship Relationship { get; set; }
        public virtual WorldEvent WorldEvent { get; set; }
        public virtual EventTable EventTable { get; set; }
    }
}
