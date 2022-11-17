using System;
using System.Collections.Generic;
using System.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

namespace SE1634_Group1_Project.Models
{
    public partial class HappyQuizzContext : DbContext
    {
        public HappyQuizzContext()
        {
        }

        public HappyQuizzContext(DbContextOptions<HappyQuizzContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Accounts { get; set; } = null!;
        public virtual DbSet<Answer> Answers { get; set; } = null!;
        public virtual DbSet<Question> Questions { get; set; } = null!;
        public virtual DbSet<Quizz> Quizzs { get; set; } = null!;
        public virtual DbSet<RecordQuizz> RecordQuizzs { get; set; } = null!;
        public virtual DbSet<ResumeQuestion> ResumeQuestions { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                string dbConnect = new AppSetting().getConnectionString("DbConnection");
                optionsBuilder.UseSqlServer(dbConnect);
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__Account__1788CC4CB225BAB1");

                entity.ToTable("Account");

                entity.Property(e => e.UserName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Answer>(entity =>
            {
                entity.ToTable("Answer");

                entity.Property(e => e.IsCorrect).HasDefaultValueSql("((0))");

                entity.Property(e => e.Text)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.Answers)
                    .HasForeignKey(d => d.QuestionId)
                    .HasConstraintName("FK__Answer__Question__2D27B809");
            });

            modelBuilder.Entity<Question>(entity =>
            {
                entity.ToTable("Question");

                entity.Property(e => e.Text)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.Quizz)
                    .WithMany(p => p.Questions)
                    .HasForeignKey(d => d.QuizzId)
                    .HasConstraintName("FK__Question__QuizzI__29572725");
            });

            modelBuilder.Entity<Quizz>(entity =>
            {
                entity.ToTable("Quizz");

                entity.Property(e => e.Title)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.AuthorNavigation)
                    .WithMany(p => p.Quizzs)
                    .HasForeignKey(d => d.Author)
                    .HasConstraintName("FK__Quizz__Author__267ABA7A");
            });

            modelBuilder.Entity<RecordQuizz>(entity =>
            {
                entity.ToTable("RecordQuizz");

                entity.Property(e => e.LastTime).HasColumnType("datetime");

                entity.Property(e => e.Status).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Quizz)
                    .WithMany(p => p.RecordQuizzs)
                    .HasForeignKey(d => d.QuizzId)
                    .HasConstraintName("FK__RecordQui__Quizz__31EC6D26");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.RecordQuizzs)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__RecordQui__UserI__30F848ED");
            });

            modelBuilder.Entity<ResumeQuestion>(entity =>
            {
                entity.ToTable("ResumeQuestion");

                entity.HasOne(d => d.RecordQuizz)
                    .WithMany(p => p.ResumeQuestions)
                    .HasForeignKey(d => d.RecordQuizzId)
                    .HasConstraintName("FK__ResumeQue__Recor__34C8D9D1");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
