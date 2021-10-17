﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UofLMentorshipProgram.Data;

namespace UofLMentorshipProgram.Migrations
{
    [DbContext(typeof(MentorshipContext))]
    partial class MentorshipContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.11");

            modelBuilder.Entity("Models.Data.Users.Attributes.UserAttribute", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("Value")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("AttributeType")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("UserId", "Value");

                    b.ToTable("UserAttributes");

                    b.HasDiscriminator<string>("AttributeType").HasValue("UserAttribute");
                });

            modelBuilder.Entity("UofLMentorshipProgram.Models.Data.Users.Business", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<string>("Type")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Businesses");
                });

            modelBuilder.Entity("UofLMentorshipProgram.Models.Data.Users.JobPosting", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("BusinessId")
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("CloseDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Function")
                        .HasColumnType("longtext");

                    b.Property<string>("Industry")
                        .HasColumnType("longtext");

                    b.Property<string>("JobDescription")
                        .HasColumnType("longtext");

                    b.Property<string>("JobTitle")
                        .HasColumnType("longtext");

                    b.Property<string>("JobType")
                        .HasColumnType("longtext");

                    b.Property<bool>("Open")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("OpenDate")
                        .HasColumnType("datetime(6)");

                    b.Property<decimal>("Pay")
                        .HasColumnType("decimal(10,2)");

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("State")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("BusinessId");

                    b.ToTable("JobPostings");
                });

            modelBuilder.Entity("UofLMentorshipProgram.Models.Data.Users.Photo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<byte[]>("Data")
                        .HasColumnType("longblob");

                    b.Property<string>("Url")
                        .HasColumnType("longtext");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Photo");
                });

            modelBuilder.Entity("UofLMentorshipProgram.Models.Data.Users.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("UserType")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("WordPressId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasDiscriminator<string>("UserType").HasValue("User");
                });

            modelBuilder.Entity("Models.Data.Users.Attributes.CISCourseTaken", b =>
                {
                    b.HasBaseType("Models.Data.Users.Attributes.UserAttribute");

                    b.Property<int?>("AlumnusId")
                        .HasColumnType("int")
                        .HasColumnName("CISCourseTaken_AlumnusId");

                    b.Property<int?>("MenteeId")
                        .HasColumnType("int")
                        .HasColumnName("CISCourseTaken_MenteeId");

                    b.HasIndex("AlumnusId");

                    b.HasIndex("MenteeId");

                    b.HasDiscriminator().HasValue("CISCourseTaken");
                });

            modelBuilder.Entity("Models.Data.Users.Attributes.CISCourseTaking", b =>
                {
                    b.HasBaseType("Models.Data.Users.Attributes.UserAttribute");

                    b.Property<int?>("AlumnusId")
                        .HasColumnType("int")
                        .HasColumnName("CISCourseTaking_AlumnusId");

                    b.Property<int?>("MenteeId")
                        .HasColumnType("int")
                        .HasColumnName("CISCourseTaking_MenteeId");

                    b.HasIndex("AlumnusId");

                    b.HasIndex("MenteeId");

                    b.HasDiscriminator().HasValue("CISCourseTaking");
                });

            modelBuilder.Entity("Models.Data.Users.Attributes.CISTrack", b =>
                {
                    b.HasBaseType("Models.Data.Users.Attributes.UserAttribute");

                    b.Property<int?>("AlumnusId")
                        .HasColumnType("int");

                    b.Property<int?>("MenteeId")
                        .HasColumnType("int");

                    b.HasIndex("AlumnusId");

                    b.HasIndex("MenteeId");

                    b.HasDiscriminator().HasValue("CISTrack");
                });

            modelBuilder.Entity("Models.Data.Users.Attributes.Ethnicity", b =>
                {
                    b.HasBaseType("Models.Data.Users.Attributes.UserAttribute");

                    b.Property<int?>("PersonId")
                        .HasColumnType("int")
                        .HasColumnName("Ethnicity_PersonId");

                    b.HasIndex("PersonId");

                    b.HasDiscriminator().HasValue("Ethnicity");
                });

            modelBuilder.Entity("Models.Data.Users.Attributes.NationalOrigin", b =>
                {
                    b.HasBaseType("Models.Data.Users.Attributes.UserAttribute");

                    b.Property<int?>("ParticipantId")
                        .HasColumnType("int");

                    b.HasIndex("ParticipantId");

                    b.HasDiscriminator().HasValue("NationalOrigin");
                });

            modelBuilder.Entity("Models.Data.Users.Attributes.Pronoun", b =>
                {
                    b.HasBaseType("Models.Data.Users.Attributes.UserAttribute");

                    b.Property<int?>("PersonId")
                        .HasColumnType("int");

                    b.HasIndex("PersonId");

                    b.HasDiscriminator().HasValue("Pronoun");
                });

            modelBuilder.Entity("Models.Data.Users.Attributes.Service", b =>
                {
                    b.HasBaseType("Models.Data.Users.Attributes.UserAttribute");

                    b.Property<int?>("BusinessId")
                        .HasColumnType("int");

                    b.HasIndex("BusinessId");

                    b.HasDiscriminator().HasValue("Service");
                });

            modelBuilder.Entity("UofLMentorshipProgram.Models.Data.Users.Person", b =>
                {
                    b.HasBaseType("UofLMentorshipProgram.Models.Data.Users.User");

                    b.Property<string>("EmailAddress")
                        .HasColumnType("longtext");

                    b.Property<string>("FirstName")
                        .HasColumnType("longtext");

                    b.Property<string>("Gender")
                        .HasColumnType("longtext");

                    b.Property<string>("LastName")
                        .HasColumnType("longtext");

                    b.HasDiscriminator().HasValue("Person");
                });

            modelBuilder.Entity("UofLMentorshipProgram.Models.Data.Users.Administrator", b =>
                {
                    b.HasBaseType("UofLMentorshipProgram.Models.Data.Users.Person");

                    b.HasDiscriminator().HasValue("Administrator");
                });

            modelBuilder.Entity("UofLMentorshipProgram.Models.Data.Users.Alumnus", b =>
                {
                    b.HasBaseType("UofLMentorshipProgram.Models.Data.Users.Person");

                    b.HasDiscriminator().HasValue("Alumnus");
                });

            modelBuilder.Entity("UofLMentorshipProgram.Models.Data.Users.BusinessContact", b =>
                {
                    b.HasBaseType("UofLMentorshipProgram.Models.Data.Users.Person");

                    b.Property<int>("BusinessId")
                        .HasColumnType("int");

                    b.Property<string>("JobTitle")
                        .HasColumnType("longtext");

                    b.HasIndex("BusinessId");

                    b.HasDiscriminator().HasValue("BusinessContact");
                });

            modelBuilder.Entity("UofLMentorshipProgram.Models.Data.Users.Participant", b =>
                {
                    b.HasBaseType("UofLMentorshipProgram.Models.Data.Users.Person");

                    b.HasDiscriminator().HasValue("Participant");
                });

            modelBuilder.Entity("UofLMentorshipProgram.Models.Data.Users.Mentee", b =>
                {
                    b.HasBaseType("UofLMentorshipProgram.Models.Data.Users.Participant");

                    b.HasDiscriminator().HasValue("Mentee");
                });

            modelBuilder.Entity("UofLMentorshipProgram.Models.Data.Users.Mentor", b =>
                {
                    b.HasBaseType("UofLMentorshipProgram.Models.Data.Users.Participant");

                    b.HasDiscriminator().HasValue("Mentor");
                });

            modelBuilder.Entity("Models.Data.Users.Attributes.UserAttribute", b =>
                {
                    b.HasOne("UofLMentorshipProgram.Models.Data.Users.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("UofLMentorshipProgram.Models.Data.Users.JobPosting", b =>
                {
                    b.HasOne("UofLMentorshipProgram.Models.Data.Users.Business", "Business")
                        .WithMany("JobPostings")
                        .HasForeignKey("BusinessId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Business");
                });

            modelBuilder.Entity("UofLMentorshipProgram.Models.Data.Users.Photo", b =>
                {
                    b.HasOne("UofLMentorshipProgram.Models.Data.Users.User", "User")
                        .WithOne("Photo")
                        .HasForeignKey("UofLMentorshipProgram.Models.Data.Users.Photo", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Models.Data.Users.Attributes.CISCourseTaken", b =>
                {
                    b.HasOne("UofLMentorshipProgram.Models.Data.Users.Alumnus", null)
                        .WithMany("CISCoursesTaken")
                        .HasForeignKey("AlumnusId");

                    b.HasOne("UofLMentorshipProgram.Models.Data.Users.Mentee", null)
                        .WithMany("CISCoursesTaken")
                        .HasForeignKey("MenteeId");
                });

            modelBuilder.Entity("Models.Data.Users.Attributes.CISCourseTaking", b =>
                {
                    b.HasOne("UofLMentorshipProgram.Models.Data.Users.Alumnus", null)
                        .WithMany("CISCoursesTaking")
                        .HasForeignKey("AlumnusId");

                    b.HasOne("UofLMentorshipProgram.Models.Data.Users.Mentee", null)
                        .WithMany("CISCoursesTaking")
                        .HasForeignKey("MenteeId");
                });

            modelBuilder.Entity("Models.Data.Users.Attributes.CISTrack", b =>
                {
                    b.HasOne("UofLMentorshipProgram.Models.Data.Users.Alumnus", null)
                        .WithMany("CISTracks")
                        .HasForeignKey("AlumnusId");

                    b.HasOne("UofLMentorshipProgram.Models.Data.Users.Mentee", null)
                        .WithMany("CISTracks")
                        .HasForeignKey("MenteeId");
                });

            modelBuilder.Entity("Models.Data.Users.Attributes.Ethnicity", b =>
                {
                    b.HasOne("UofLMentorshipProgram.Models.Data.Users.Person", null)
                        .WithMany("Ethnicity")
                        .HasForeignKey("PersonId");
                });

            modelBuilder.Entity("Models.Data.Users.Attributes.NationalOrigin", b =>
                {
                    b.HasOne("UofLMentorshipProgram.Models.Data.Users.Participant", null)
                        .WithMany("NationalOrigin")
                        .HasForeignKey("ParticipantId");
                });

            modelBuilder.Entity("Models.Data.Users.Attributes.Pronoun", b =>
                {
                    b.HasOne("UofLMentorshipProgram.Models.Data.Users.Person", null)
                        .WithMany("Pronouns")
                        .HasForeignKey("PersonId");
                });

            modelBuilder.Entity("Models.Data.Users.Attributes.Service", b =>
                {
                    b.HasOne("UofLMentorshipProgram.Models.Data.Users.Business", null)
                        .WithMany("Services")
                        .HasForeignKey("BusinessId");
                });

            modelBuilder.Entity("UofLMentorshipProgram.Models.Data.Users.BusinessContact", b =>
                {
                    b.HasOne("UofLMentorshipProgram.Models.Data.Users.Business", "Business")
                        .WithMany("BusinessContacts")
                        .HasForeignKey("BusinessId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Business");
                });

            modelBuilder.Entity("UofLMentorshipProgram.Models.Data.Users.Business", b =>
                {
                    b.Navigation("BusinessContacts");

                    b.Navigation("JobPostings");

                    b.Navigation("Services");
                });

            modelBuilder.Entity("UofLMentorshipProgram.Models.Data.Users.User", b =>
                {
                    b.Navigation("Photo");
                });

            modelBuilder.Entity("UofLMentorshipProgram.Models.Data.Users.Person", b =>
                {
                    b.Navigation("Ethnicity");

                    b.Navigation("Pronouns");
                });

            modelBuilder.Entity("UofLMentorshipProgram.Models.Data.Users.Alumnus", b =>
                {
                    b.Navigation("CISCoursesTaken");

                    b.Navigation("CISCoursesTaking");

                    b.Navigation("CISTracks");
                });

            modelBuilder.Entity("UofLMentorshipProgram.Models.Data.Users.Participant", b =>
                {
                    b.Navigation("NationalOrigin");
                });

            modelBuilder.Entity("UofLMentorshipProgram.Models.Data.Users.Mentee", b =>
                {
                    b.Navigation("CISCoursesTaken");

                    b.Navigation("CISCoursesTaking");

                    b.Navigation("CISTracks");
                });
#pragma warning restore 612, 618
        }
    }
}