//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System; 
using System.ComponentModel;
using System.ComponentModel.DataAnnotations; 
using System.Data;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace SO.LocalClub.Manager.Models.ValueObjects
{
    [Table("ClubEvent", Schema = "data" )]
    [Serializable]
    public  class ClubEventVo
    {
        public ClubEventVo()
        {
        }
    
    	[DisplayName("club Event Id")]
    	[Required]
    	[Key]
        public Guid clubEventId { get; set; }
    
    	[DisplayName("club Id")]
    	[Required]
        public Guid clubId { get; set; }
    
    	[DisplayName("name")]
    	[Required]
        public string name { get; set; }
    
    	[DisplayName("description")]
        public string description { get; set; }
    
    	[DisplayName("date")]
        public Nullable<DateTime> date { get; set; }
    
    	[DisplayName("leader Id")]
        public Nullable<Guid> leaderId { get; set; }
    
    	[DisplayName("modified")]
    	[Required]
        public DateTime modified { get; set; }
    
    	[DisplayName("created")]
    	[Required]
        public DateTime created { get; set; }
    
    
        [ForeignKey("clubId")]
        public ClubVo club { get; set; }
       
        [Association("ClubEvent_ClubEventMember", "clubEventId", "clubEventId")]
        public List<ClubEventMemberVo> clubEventMembers { get; set; }
       
        [ForeignKey("memberId")]
        public MemberVo member { get; set; }
       
    }
    
}
