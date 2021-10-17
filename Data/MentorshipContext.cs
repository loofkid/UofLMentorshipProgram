using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Models.Data.Users.Attributes;
using UofLMentorshipProgram.Models.Data.Users;

namespace UofLMentorshipProgram.Data
{
    public class MentorshipContext : DbContext
    {
        public MentorshipContext(DbContextOptions<MentorshipContext> options)
        : base(options)
        {
        }

        public DbSet<Administrator> Administrators { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<Participant> Participants { get; set; }
        public DbSet<Mentee> Mentees { get; set; }
        public DbSet<Mentor> Mentors { get; set; }
        public DbSet<Alumnus> Alumni { get; set; }
        public DbSet<Business> Businesses { get; set; }
        public DbSet<BusinessContact> BusinessContacts { get; set; }
        public DbSet<JobPosting> JobPostings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(entity => {
                entity.HasDiscriminator<string>("UserType");
                entity.HasKey(e => e.Id);
            });

            modelBuilder.Entity<Administrator>();
            modelBuilder.Entity<Person>();
            modelBuilder.Entity<Participant>();
            modelBuilder.Entity<Mentee>();
            modelBuilder.Entity<Mentor>();
            modelBuilder.Entity<Alumnus>();
            modelBuilder.Entity<BusinessContact>();


            modelBuilder.Entity<Business>(entity => {
                entity.ToTable("Businesses");
            });

            modelBuilder.Entity<JobPosting>(entity => {
                entity.ToTable("JobPostings");
                entity.Property(e => e.Pay).HasColumnType("decimal(10,2)");
            });

            modelBuilder.Entity<UserAttribute>(entity => {
                entity.ToTable("UserAttributes");
                entity.HasDiscriminator<string>("AttributeType");
                entity.HasKey(e => new {e.UserId, e.Value});
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}