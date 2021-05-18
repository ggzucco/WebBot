using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using WebBotModule.DBI;
using WebBotModule.DTO;

namespace WebBotModule.DBC.EFCorePostGres
{
    public class BotConfiguration : IBotEntityTypeConfiguration<BotDTO>
    {
        public void Configure(EntityTypeBuilder<BotDTO> botBuilder)
        {
            botBuilder.HasKey(bot => bot.idBot);
            botBuilder.HasIndex(bot => bot.idBot);
            
            botBuilder.HasMany(bot => bot.Commands)
                      .WithOne(command => command.Bot)
                      .HasForeignKey(command => command.numIdBot)
                      .OnDelete(DeleteBehavior.ClientSetNull)
                      .HasConstraintName("FK_Bot_Command");

            botBuilder.Property(bot => bot.idBot).IsRequired().ValueGeneratedOnAdd();
            botBuilder.Property(bot => bot.numIdUser).IsRequired();
            botBuilder.Property(bot => bot.vcharToken).HasMaxLength(100);

        }
    }
}
