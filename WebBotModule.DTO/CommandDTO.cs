using System;
using System.Collections.Generic;
using System.Text;

namespace WebBotModule.DTO
{
    /// <summary>
    /// Data Transfer Object o entity Command
    /// This entity registry the command of the bots
    /// </summary>
    public class CommandDTO
    {
        public Boolean boolActive { get; set; }
        public Boolean boolOnlyAdmin { get; set; }
                
        public Int64 idCommand { get; set; }
        public Int64 numIdBot { get; set; }

        public String vcharDescription { get; set; }
        public String vcharHelpCommand { get; set; }
        
        public BotDTO Bot { get; set; }
    }
}
