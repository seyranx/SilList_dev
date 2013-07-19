
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace SO.SilList.CodeGeneration.DbContexts.SilList
{
     
    [Table("BusinessCategoryType", Schema = "dbo" )]
    [Serializable]
    public partial class BusinessCategoryTypeVo
    {
    		
    	[DisplayName("business Category Type Id")]
    	[Required]
        public int businessCategoryTypeId { get; set; }
    		
    	[DisplayName("name")]
    	[Required]
    	[StringLength(200)]
        public string name { get; set; }
    		
    	[DisplayName("description")]
        public string description { get; set; }
    		
    	[DisplayName("created By")]
        public Nullable<int> createdBy { get; set; }
    		
    	[DisplayName("modified By")]
        public Nullable<int> modifiedBy { get; set; }
    		
    	[DisplayName("modified")]
    	[Required]
        public System.DateTime modified { get; set; }
    		
    	[DisplayName("created")]
    	[Required]
        public System.DateTime created { get; set; }
    		
    	[DisplayName("is Active")]
    	[Required]
        public bool isActive { get; set; }
    }
}
