using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using WebBotModule.DBI;
using WebBotModule.DTO;

namespace WebBotModule.DBC.EFCorePostGres
{
    public class LanguageConfiguration : IBotEntityTypeConfiguration<LanguageDTO>
    {
        public void Configure(EntityTypeBuilder<LanguageDTO> languageBuilder)
        {
            languageBuilder.HasKey(language => language.idLanguage);
            languageBuilder.HasIndex(language => language.idLanguage);
            
            languageBuilder.HasMany(language => language.Group)
                      .WithOne(group => group.Language)
                      .HasForeignKey(group => group.numIdLanguage)
                      .OnDelete(DeleteBehavior.ClientSetNull)
                      .HasConstraintName("FK_Language_Group");
            
            languageBuilder.HasMany(language => language.Message)
                      .WithOne(message => message.Language)
                      .HasForeignKey(message => message.numIdLanguage)
                      .OnDelete(DeleteBehavior.ClientSetNull)
                      .HasConstraintName("FK_Language_Message");


            languageBuilder.Property(language => language.idLanguage).IsRequired().ValueGeneratedOnAdd();
            languageBuilder.Property(language => language.vcharLanguage).IsRequired().HasMaxLength(30);
            languageBuilder.Property(language => language.vcharAbreveation).IsRequired().HasMaxLength(8);

        }
    }
}
