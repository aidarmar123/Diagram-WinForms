//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace winForm.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Player
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Player()
        {
            this.MatchupLog = new HashSet<MatchupLog>();
            this.PlayerStatistics = new HashSet<PlayerStatistics>();
            this.PlayerInTeam = new HashSet<PlayerInTeam>();
        }
    
        public int PlayerId { get; set; }
        public string Name { get; set; }
        public int PositionId { get; set; }
        public System.DateTime JoinYear { get; set; }
        public decimal Height { get; set; }
        public decimal Weight { get; set; }
        public System.DateTime DateOfBirth { get; set; }
        public string College { get; set; }
        public string CountryCode { get; set; }
        public byte[] Img { get; set; }
        public bool IsRetirment { get; set; }
        public Nullable<System.DateTime> RetirmentTime { get; set; }
    
        public virtual Country Country { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MatchupLog> MatchupLog { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PlayerStatistics> PlayerStatistics { get; set; }
        public virtual Position Position { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PlayerInTeam> PlayerInTeam { get; set; }
    }
}