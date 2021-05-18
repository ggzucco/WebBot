using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using WebBotModule.DBI;
using WebBotModule.DTO;

namespace WebBotModule.DBC.EFCorePostGres
{
    public class UserConfiguration : IBotEntityTypeConfiguration<UserDTO>
    {
        public void Configure(EntityTypeBuilder<UserDTO> userBuilder)
        {
            userBuilder.HasKey(user => user.idUser);
            userBuilder.HasIndex(user => new { user.idUser, user.idTelegramUser });

            userBuilder.HasMany(user => user.GroupUsers)
                        .WithOne(groupUser => groupUser.User)
                        .HasForeignKey(groupUser => groupUser.numIdUser)
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_User_GroupUser");

            userBuilder.HasOne(user => user.Bot)
                       .WithOne(bot => bot.User)
                       .HasForeignKey<BotDTO>(bot => bot.numIdUser)
                       .OnDelete(DeleteBehavior.ClientSetNull)
                       .HasConstraintName("FK_User_Bot");

            userBuilder.Property(user => user.idUser).IsRequired().ValueGeneratedOnAdd();
            userBuilder.Property(user => user.idTelegramUser).IsRequired();
            userBuilder.Property(user => user.vcharFirstName).HasMaxLength(256);
            userBuilder.Property(user => user.vcharLastName).HasMaxLength(256);
            userBuilder.Property(user => user.vcharUser).HasMaxLength(256);
        }
    }
}
