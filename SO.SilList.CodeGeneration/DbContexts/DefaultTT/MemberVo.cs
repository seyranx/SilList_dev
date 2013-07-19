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
    [Table("Member", Schema = "data" )]
    [Serializable]
    public  class MemberVo
    {
        public MemberVo()
        {
        }
    
    	[DisplayName("member Id")]
    	[Required]
    	[Key]
        public Guid memberId { get; set; }
    
    	[DisplayName("first Name")]
    	[StringLength(50)]
        public string firstName { get; set; }
    
    	[DisplayName("last Name")]
    	[StringLength(50)]
        public string lastName { get; set; }
    
    	[DisplayName("username")]
    	[StringLength(50)]
        public string username { get; set; }
    
    	[DisplayName("email")]
    	[Required]
    	[StringLength(50)]
        public string email { get; set; }
    
    	[DisplayName("password")]
    	[Required]
    	[StringLength(100)]
        public string password { get; set; }
    
    	[DisplayName("zip")]
    	[Required]
        public int zip { get; set; }
    
    	[DisplayName("city Id")]
        public Nullable<int> cityId { get; set; }
    
    	[DisplayName("is Email Confirmed")]
    	[Required]
        public bool isEmailConfirmed { get; set; }
    
    	[DisplayName("is Active")]
    	[Required]
        public bool isActive { get; set; }
    
    	[DisplayName("modified")]
    	[Required]
        public DateTime modified { get; set; }
    
    	[DisplayName("created")]
    	[Required]
        public DateTime created { get; set; }
    
    
        [Association("Member_ClubEventMember", "memberId", "memberId")]
        public List<ClubEventMemberVo> clubEventMembers { get; set; }
       
        [Association("Member_ClubEvent", "memberId", "memberId")]
        public List<ClubEventVo> clubEvents { get; set; }
       
        [Association("Member_ClubMember", "memberId", "memberId")]
        public List<ClubMemberVo> clubMembers { get; set; }
       
        [Association("Member_MemberFileLink", "memberId", "memberId")]
        public List<MemberFileLinkVo> memberFileLinks { get; set; }
       
    }
    
}
