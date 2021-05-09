using System;
using System.Collections.Generic;
using System.Text;

namespace WebBotModule.DTO
{
    /// <summary>
    /// Data Transfer Object o entity GroupUSer
    /// This entity registry the relational table between Users and Groups
    /// </summary>
    public class GroupUserDTO
    {
        //[Key]
        //[Column(Order = 1)]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int64 idUserGroup { get; set; }
        //[ForeignKey("User")]
        public Int64 numIdUser { get; set; }
        //[ForeignKey("Group")]
        public Int64 numIdGroup { get; set; }
        public DateTime dateEntryDate { get; set; }
        public DateTime dateLastUpdate { get; set; }
        public Boolean boolActive { get; set; }
        public Boolean boolBanned { get; set; }
        public Boolean boolMutted { get; set; }
        public Boolean boolIsAdmin { get; set; }
        //public virtual ICollection<CaptchaModel> Captchas { get; set; }
        //public UseDTO User { get; set; }
        //public GroupDTO Group { get; set; }
    }
}
