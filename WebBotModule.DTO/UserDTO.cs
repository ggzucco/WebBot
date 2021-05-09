﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WebBotModule.DTO
{
    /// <summary>
    /// Data Transfer Object o entity User
    /// This entity registry the users
    /// </summary>
    public class UserDTO
    {
        //[Key]
        //[Column(Order = 1)]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int64 idUser { get; set; }
        //[Key]
        //[Column(Order = 2)]
        public Int64 idTelegramUser { get; set; }
        public String vcharFirstName { get; set; }
        public String vcharLastName { get; set; }
        public String vcharUser { get; set; }
        public Boolean boolIsBot { get; set; }


    }
}
