﻿// <auto-generated />
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Surveyapp.Models;

#nullable disable

namespace Surveyapp.Migrations
{
    [DbContext(typeof(SurveyContext))]
    [Migration("20211201182751_description")]
    partial class description
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("text");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .HasColumnType("text");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Surveyapp.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Surveyapp.Models.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<bool?>("AnswerRequired")
                        .HasColumnType("boolean");

                    b.Property<int?>("QuestionGroupId")
                        .HasColumnType("integer");

                    b.Property<int>("ResponseTypeId")
                        .HasColumnType("integer");

                    b.Property<int>("SubjectId")
                        .HasColumnType("integer");

                    b.Property<string>("question")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("QuestionGroupId");

                    b.HasIndex("ResponseTypeId");

                    b.HasIndex("SubjectId");

                    b.ToTable("Question");
                });

            modelBuilder.Entity("Surveyapp.Models.QuestionGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int>("SubjectId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("SubjectId");

                    b.ToTable("QuestionGroups");
                });

            modelBuilder.Entity("Surveyapp.Models.ResponseType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("CreatorId")
                        .HasColumnType("text");

                    b.Property<int?>("DisplayOptionType")
                        .HasColumnType("integer");

                    b.Property<List<ResponseDictionary>>("ResponseDictionary")
                        .HasColumnType("jsonb");

                    b.Property<string>("ResponseName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("CreatorId");

                    b.ToTable("ResponseType");
                });

            modelBuilder.Entity("Surveyapp.Models.Survey", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ApplicationUserId")
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("Startdate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("approvalStatus")
                        .HasColumnType("text");

                    b.Property<string>("status")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.ToTable("Survey");
                });

            modelBuilder.Entity("Surveyapp.Models.SurveyCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("SurveyId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("SurveyId");

                    b.ToTable("SurveyCategory");
                });

            modelBuilder.Entity("Surveyapp.Models.Surveyors", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<bool>("ActiveStatus")
                        .HasColumnType("boolean");

                    b.Property<int>("Permission")
                        .HasColumnType("integer");

                    b.Property<int>("SurveyId")
                        .HasColumnType("integer");

                    b.Property<string>("SurveyorId")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("SurveyId");

                    b.HasIndex("SurveyorId");

                    b.ToTable("Surveyors");
                });

            modelBuilder.Entity("Surveyapp.Models.SurveyResponse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("QuestionId")
                        .HasColumnType("integer");

                    b.Property<string>("RespondantId")
                        .HasColumnType("text");

                    b.Property<int>("Response")
                        .HasColumnType("integer");

                    b.Property<string>("ResponseText")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("QuestionId");

                    b.HasIndex("RespondantId");

                    b.ToTable("SurveyResponse");
                });

            modelBuilder.Entity("Surveyapp.Models.SurveySubject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("CategoryId")
                        .HasColumnType("integer");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<List<OtherProperties>>("OtherProperties")
                        .HasColumnType("jsonb");

                    b.Property<int?>("ResponseTypeId")
                        .HasColumnType("integer");

                    b.Property<int>("SurveyId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("ResponseTypeId");

                    b.HasIndex("SurveyId");

                    b.ToTable("SurveySubject");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Surveyapp.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Surveyapp.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Surveyapp.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Surveyapp.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Surveyapp.Models.Question", b =>
                {
                    b.HasOne("Surveyapp.Models.QuestionGroup", "QuestionGroup")
                        .WithMany("Questions")
                        .HasForeignKey("QuestionGroupId");

                    b.HasOne("Surveyapp.Models.ResponseType", "ResponseType")
                        .WithMany()
                        .HasForeignKey("ResponseTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Surveyapp.Models.SurveySubject", "Subject")
                        .WithMany("Questions")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("QuestionGroup");

                    b.Navigation("ResponseType");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("Surveyapp.Models.QuestionGroup", b =>
                {
                    b.HasOne("Surveyapp.Models.SurveySubject", "SurveySubject")
                        .WithMany()
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SurveySubject");
                });

            modelBuilder.Entity("Surveyapp.Models.ResponseType", b =>
                {
                    b.HasOne("Surveyapp.Models.ApplicationUser", "Creator")
                        .WithMany()
                        .HasForeignKey("CreatorId");

                    b.Navigation("Creator");
                });

            modelBuilder.Entity("Surveyapp.Models.Survey", b =>
                {
                    b.HasOne("Surveyapp.Models.ApplicationUser", null)
                        .WithMany("Surveys")
                        .HasForeignKey("ApplicationUserId");
                });

            modelBuilder.Entity("Surveyapp.Models.SurveyCategory", b =>
                {
                    b.HasOne("Surveyapp.Models.Survey", "Survey")
                        .WithMany("SurveyCategorys")
                        .HasForeignKey("SurveyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Survey");
                });

            modelBuilder.Entity("Surveyapp.Models.Surveyors", b =>
                {
                    b.HasOne("Surveyapp.Models.Survey", "Survey")
                        .WithMany("Surveyors")
                        .HasForeignKey("SurveyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Surveyapp.Models.ApplicationUser", "Surveyor")
                        .WithMany()
                        .HasForeignKey("SurveyorId");

                    b.Navigation("Survey");

                    b.Navigation("Surveyor");
                });

            modelBuilder.Entity("Surveyapp.Models.SurveyResponse", b =>
                {
                    b.HasOne("Surveyapp.Models.Question", "question")
                        .WithMany("SurveyResponses")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Surveyapp.Models.ApplicationUser", "Respondant")
                        .WithMany("SurveyResponses")
                        .HasForeignKey("RespondantId");

                    b.Navigation("Respondant");

                    b.Navigation("question");
                });

            modelBuilder.Entity("Surveyapp.Models.SurveySubject", b =>
                {
                    b.HasOne("Surveyapp.Models.SurveyCategory", "Category")
                        .WithMany("SurveySubjects")
                        .HasForeignKey("CategoryId");

                    b.HasOne("Surveyapp.Models.ResponseType", "ResponseType")
                        .WithMany()
                        .HasForeignKey("ResponseTypeId");

                    b.HasOne("Surveyapp.Models.Survey", "Survey")
                        .WithMany()
                        .HasForeignKey("SurveyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("ResponseType");

                    b.Navigation("Survey");
                });

            modelBuilder.Entity("Surveyapp.Models.ApplicationUser", b =>
                {
                    b.Navigation("SurveyResponses");

                    b.Navigation("Surveys");
                });

            modelBuilder.Entity("Surveyapp.Models.Question", b =>
                {
                    b.Navigation("SurveyResponses");
                });

            modelBuilder.Entity("Surveyapp.Models.QuestionGroup", b =>
                {
                    b.Navigation("Questions");
                });

            modelBuilder.Entity("Surveyapp.Models.Survey", b =>
                {
                    b.Navigation("SurveyCategorys");

                    b.Navigation("Surveyors");
                });

            modelBuilder.Entity("Surveyapp.Models.SurveyCategory", b =>
                {
                    b.Navigation("SurveySubjects");
                });

            modelBuilder.Entity("Surveyapp.Models.SurveySubject", b =>
                {
                    b.Navigation("Questions");
                });
#pragma warning restore 612, 618
        }
    }
}
