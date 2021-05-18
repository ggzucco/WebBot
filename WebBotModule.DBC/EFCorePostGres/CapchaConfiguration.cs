using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using WebBotModule.DBI;
using WebBotModule.DTO;

namespace WebBotModule.DBC.EFCorePostGres
{
    public class CapchaConfiguration : IBotEntityTypeConfiguration<CaptchaDTO>
    {
        public void Configure(EntityTypeBuilder<CaptchaDTO> captchaBuilder)
        {
            captchaBuilder.HasKey(bot => bot.idCaptcha);
            captchaBuilder.HasIndex(bot => bot.idCaptcha);
            
            captchaBuilder.Property(bot => bot.idCaptcha).IsRequired().ValueGeneratedOnAdd();
            captchaBuilder.Property(bot => bot.numIdUserGroup).IsRequired();
            captchaBuilder.Property(bot => bot.numAction).IsRequired();
            captchaBuilder.Property(bot => bot.vcharCaptchaValue).IsRequired();
            captchaBuilder.Property(bot => bot.dateGeneration).IsRequired().ValueGeneratedOnAdd();
        }
    }
}
