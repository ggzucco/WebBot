using System;
using System.Collections.Generic;
using System.Text;

namespace WebBotModule.DTO
{
    /// <summary>
    /// Data Transfer Object o entity BOT
    /// This entity only goes to the Bot that controls that system
    /// </summary>
    public class BotDTO
    {
        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int64 idBot { get; set; }
        //[ForeignKey("User")]
        public Int64 numidUser { get; set; }
        public String vcharToken { get; set; }
        //public ICollection<CommandDTO> commandDTOs { get; set; }
        //public UseDTO User { get; set; }
    }
}
