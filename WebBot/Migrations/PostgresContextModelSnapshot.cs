﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using WebBotModule.DBC.EFCorePostGres;

namespace WebBot.Migrations
{
    [DbContext(typeof(PostgresContext))]
    partial class PostgresContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("WebBotModule.DTO.BotDTO", b =>
                {
                    b.Property<long>("idBot")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<long>("numIdUser")
                        .HasColumnType("bigint");

                    b.Property<string>("vcharToken")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.HasKey("idBot");

                    b.HasIndex("idBot");

                    b.HasIndex("numIdUser")
                        .IsUnique();

                    b.ToTable("Bot");
                });

            modelBuilder.Entity("WebBotModule.DTO.CaptchaDTO", b =>
                {
                    b.Property<long>("idCaptcha")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("dateGeneration")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp without time zone");

                    b.Property<long>("numAction")
                        .HasColumnType("bigint");

                    b.Property<long>("numIdUserGroup")
                        .HasColumnType("bigint");

                    b.Property<string>("vcharCaptchaValue")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("idCaptcha");

                    b.HasIndex("idCaptcha");

                    b.HasIndex("numIdUserGroup");

                    b.ToTable("Captcha");
                });

            modelBuilder.Entity("WebBotModule.DTO.CommandDTO", b =>
                {
                    b.Property<long>("idCommand")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<bool>("boolActive")
                        .HasColumnType("boolean");

                    b.Property<bool>("boolOnlyAdmin")
                        .HasColumnType("boolean");

                    b.Property<long>("numIdBot")
                        .HasColumnType("bigint");

                    b.Property<string>("vcharDescription")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("vcharHelpCommand")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("idCommand");

                    b.HasIndex("idCommand");

                    b.HasIndex("numIdBot");

                    b.ToTable("HelpCommand");
                });

            modelBuilder.Entity("WebBotModule.DTO.GroupDTO", b =>
                {
                    b.Property<long>("idGroup")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<bool>("boolActive")
                        .HasColumnType("boolean");

                    b.Property<long>("idTelegramGroup")
                        .HasColumnType("bigint");

                    b.Property<long>("numIdLanguage")
                        .HasColumnType("bigint");

                    b.Property<string>("vcharCountryName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("vcharGroupAdress")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("vcharGroupName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("idGroup");

                    b.HasIndex("numIdLanguage");

                    b.HasIndex("idGroup", "idTelegramGroup");

                    b.ToTable("Group");
                });

            modelBuilder.Entity("WebBotModule.DTO.GroupUserDTO", b =>
                {
                    b.Property<long>("idUserGroup")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<bool>("boolActive")
                        .HasColumnType("boolean");

                    b.Property<bool>("boolBanned")
                        .HasColumnType("boolean");

                    b.Property<bool>("boolIsAdmin")
                        .HasColumnType("boolean");

                    b.Property<bool>("boolMutted")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("dateEntryDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("dateLastUpdate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<long>("numIdGroup")
                        .HasColumnType("bigint");

                    b.Property<long>("numIdUser")
                        .HasColumnType("bigint");

                    b.HasKey("idUserGroup");

                    b.HasIndex("numIdGroup");

                    b.HasIndex("numIdUser");

                    b.HasIndex("idUserGroup", "numIdGroup", "numIdUser");

                    b.ToTable("GroupUserDTO");
                });

            modelBuilder.Entity("WebBotModule.DTO.LanguageDTO", b =>
                {
                    b.Property<long>("idLanguage")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("vcharAbreveation")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("character varying(8)");

                    b.Property<string>("vcharLanguage")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)");

                    b.HasKey("idLanguage");

                    b.HasIndex("idLanguage");

                    b.ToTable("Language");
                });

            modelBuilder.Entity("WebBotModule.DTO.MessageDTO", b =>
                {
                    b.Property<long>("idMessage")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<long>("numIdLanguage")
                        .HasColumnType("bigint");

                    b.Property<long>("numType")
                        .HasColumnType("bigint");

                    b.Property<string>("vcharMessageText")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("idMessage");

                    b.HasIndex("idMessage");

                    b.HasIndex("numIdLanguage");

                    b.ToTable("Message");
                });

            modelBuilder.Entity("WebBotModule.DTO.UserDTO", b =>
                {
                    b.Property<long>("idUser")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<long>("idTelegramUser")
                        .HasColumnType("bigint");

                    b.Property<string>("vcharFirstName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("vcharLastName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("vcharUser")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("idUser");

                    b.HasIndex("idUser", "idTelegramUser");

                    b.ToTable("User");
                });

            modelBuilder.Entity("WebBotModule.DTO.BotDTO", b =>
                {
                    b.HasOne("WebBotModule.DTO.UserDTO", "User")
                        .WithOne("Bot")
                        .HasForeignKey("WebBotModule.DTO.BotDTO", "numIdUser")
                        .HasConstraintName("FK_User_Bot")
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("WebBotModule.DTO.CaptchaDTO", b =>
                {
                    b.HasOne("WebBotModule.DTO.GroupUserDTO", "GroupUser")
                        .WithMany("Captchas")
                        .HasForeignKey("numIdUserGroup")
                        .HasConstraintName("FK_GroupUser_Captcha")
                        .IsRequired();

                    b.Navigation("GroupUser");
                });

            modelBuilder.Entity("WebBotModule.DTO.CommandDTO", b =>
                {
                    b.HasOne("WebBotModule.DTO.BotDTO", "Bot")
                        .WithMany("Commands")
                        .HasForeignKey("numIdBot")
                        .HasConstraintName("FK_Bot_Command")
                        .IsRequired();

                    b.Navigation("Bot");
                });

            modelBuilder.Entity("WebBotModule.DTO.GroupDTO", b =>
                {
                    b.HasOne("WebBotModule.DTO.LanguageDTO", "Language")
                        .WithMany("Group")
                        .HasForeignKey("numIdLanguage")
                        .HasConstraintName("FK_Language_Group")
                        .IsRequired();

                    b.Navigation("Language");
                });

            modelBuilder.Entity("WebBotModule.DTO.GroupUserDTO", b =>
                {
                    b.HasOne("WebBotModule.DTO.GroupDTO", "Group")
                        .WithMany("GroupUsers")
                        .HasForeignKey("numIdGroup")
                        .HasConstraintName("FK_Group_GroupUser")
                        .IsRequired();

                    b.HasOne("WebBotModule.DTO.UserDTO", "User")
                        .WithMany("GroupUsers")
                        .HasForeignKey("numIdUser")
                        .HasConstraintName("FK_User_GroupUser")
                        .IsRequired();

                    b.Navigation("Group");

                    b.Navigation("User");
                });

            modelBuilder.Entity("WebBotModule.DTO.MessageDTO", b =>
                {
                    b.HasOne("WebBotModule.DTO.LanguageDTO", "Language")
                        .WithMany("Message")
                        .HasForeignKey("numIdLanguage")
                        .HasConstraintName("FK_Language_Message")
                        .IsRequired();

                    b.Navigation("Language");
                });

            modelBuilder.Entity("WebBotModule.DTO.BotDTO", b =>
                {
                    b.Navigation("Commands");
                });

            modelBuilder.Entity("WebBotModule.DTO.GroupDTO", b =>
                {
                    b.Navigation("GroupUsers");
                });

            modelBuilder.Entity("WebBotModule.DTO.GroupUserDTO", b =>
                {
                    b.Navigation("Captchas");
                });

            modelBuilder.Entity("WebBotModule.DTO.LanguageDTO", b =>
                {
                    b.Navigation("Group");

                    b.Navigation("Message");
                });

            modelBuilder.Entity("WebBotModule.DTO.UserDTO", b =>
                {
                    b.Navigation("Bot");

                    b.Navigation("GroupUsers");
                });
#pragma warning restore 612, 618
        }
    }
}
