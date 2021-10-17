using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using UofLMentorshipProgram.Models.Data.WordPress;

#nullable disable

namespace UofLMentorshipProgram.Data
{
    public partial class WordPressContext : DbContext
    {
        public WordPressContext()
        {
        }

        public WordPressContext(DbContextOptions<WordPressContext> options)
            : base(options)
        {
        }

        public virtual DbSet<WpComment> WpComments { get; set; }
        public virtual DbSet<WpCommentmetum> WpCommentmeta { get; set; }
        public virtual DbSet<WpGiveComment> WpGiveComments { get; set; }
        public virtual DbSet<WpGiveCommentmetum> WpGiveCommentmeta { get; set; }
        public virtual DbSet<WpGiveDonationmetum> WpGiveDonationmeta { get; set; }
        public virtual DbSet<WpGiveDonor> WpGiveDonors { get; set; }
        public virtual DbSet<WpGiveDonormetum> WpGiveDonormeta { get; set; }
        public virtual DbSet<WpGiveFormmetum> WpGiveFormmeta { get; set; }
        public virtual DbSet<WpGiveLog> WpGiveLogs { get; set; }
        public virtual DbSet<WpGiveMigration> WpGiveMigrations { get; set; }
        public virtual DbSet<WpGiveRevenue> WpGiveRevenues { get; set; }
        public virtual DbSet<WpGiveSequentialOrdering> WpGiveSequentialOrderings { get; set; }
        public virtual DbSet<WpGiveSession> WpGiveSessions { get; set; }
        public virtual DbSet<WpLink> WpLinks { get; set; }
        public virtual DbSet<WpOption> WpOptions { get; set; }
        public virtual DbSet<WpPost> WpPosts { get; set; }
        public virtual DbSet<WpPostmetum> WpPostmeta { get; set; }
        public virtual DbSet<WpTerm> WpTerms { get; set; }
        public virtual DbSet<WpTermRelationship> WpTermRelationships { get; set; }
        public virtual DbSet<WpTermTaxonomy> WpTermTaxonomies { get; set; }
        public virtual DbSet<WpTermmetum> WpTermmeta { get; set; }
        public virtual DbSet<WpUser> WpUsers { get; set; }
        public virtual DbSet<WpUsermetum> WpUsermeta { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasCharSet("utf8")
                .UseCollation("utf8_unicode_ci");

            modelBuilder.Entity<WpComment>(entity =>
            {
                entity.HasKey(e => e.CommentId)
                    .HasName("PRIMARY");

                entity.ToTable("wp_comments");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => new { e.CommentApproved, e.CommentDateGmt }, "comment_approved_date_gmt");

                entity.HasIndex(e => e.CommentAuthorEmail, "comment_author_email")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 10 });

                entity.HasIndex(e => e.CommentDateGmt, "comment_date_gmt");

                entity.HasIndex(e => e.CommentParent, "comment_parent");

                entity.HasIndex(e => e.CommentPostId, "comment_post_ID");

                entity.Property(e => e.CommentId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("comment_ID");

                entity.Property(e => e.CommentAgent)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("comment_agent")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CommentApproved)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("comment_approved")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.CommentAuthor)
                    .IsRequired()
                    .HasColumnType("tinytext")
                    .HasColumnName("comment_author");

                entity.Property(e => e.CommentAuthorEmail)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("comment_author_email")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CommentAuthorIp)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("comment_author_IP")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CommentAuthorUrl)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("comment_author_url")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CommentContent)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("comment_content");

                entity.Property(e => e.CommentDate)
                    .HasColumnType("datetime")
                    .HasColumnName("comment_date")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.CommentDateGmt)
                    .HasColumnType("datetime")
                    .HasColumnName("comment_date_gmt")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.CommentKarma)
                    .HasColumnType("int(11)")
                    .HasColumnName("comment_karma");

                entity.Property(e => e.CommentParent)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("comment_parent");

                entity.Property(e => e.CommentPostId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("comment_post_ID");

                entity.Property(e => e.CommentType)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("comment_type")
                    .HasDefaultValueSql("'comment'");

                entity.Property(e => e.UserId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("user_id");
            });

            modelBuilder.Entity<WpCommentmetum>(entity =>
            {
                entity.HasKey(e => e.MetaId)
                    .HasName("PRIMARY");

                entity.ToTable("wp_commentmeta");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.CommentId, "comment_id");

                entity.HasIndex(e => e.MetaKey, "meta_key")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 191 });

                entity.Property(e => e.MetaId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("meta_id");

                entity.Property(e => e.CommentId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("comment_id");

                entity.Property(e => e.MetaKey).HasColumnName("meta_key");

                entity.Property(e => e.MetaValue).HasColumnName("meta_value");
            });

            modelBuilder.Entity<WpGiveComment>(entity =>
            {
                entity.HasKey(e => e.CommentId)
                    .HasName("PRIMARY");

                entity.ToTable("wp_give_comments");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.CommentId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("comment_ID");

                entity.Property(e => e.CommentContent)
                    .IsRequired()
                    .HasColumnName("comment_content");

                entity.Property(e => e.CommentDate)
                    .HasColumnType("datetime")
                    .HasColumnName("comment_date");

                entity.Property(e => e.CommentDateGmt)
                    .HasColumnType("datetime")
                    .HasColumnName("comment_date_gmt");

                entity.Property(e => e.CommentParent)
                    .IsRequired()
                    .HasColumnType("mediumtext")
                    .HasColumnName("comment_parent");

                entity.Property(e => e.CommentType)
                    .IsRequired()
                    .HasColumnType("mediumtext")
                    .HasColumnName("comment_type");

                entity.Property(e => e.UserId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("user_id");
            });

            modelBuilder.Entity<WpGiveCommentmetum>(entity =>
            {
                entity.HasKey(e => e.MetaId)
                    .HasName("PRIMARY");

                entity.ToTable("wp_give_commentmeta");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.GiveCommentId, "give_comment_id");

                entity.HasIndex(e => e.MetaKey, "meta_key")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 191 });

                entity.Property(e => e.MetaId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("meta_id");

                entity.Property(e => e.GiveCommentId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("give_comment_id");

                entity.Property(e => e.MetaKey).HasColumnName("meta_key");

                entity.Property(e => e.MetaValue).HasColumnName("meta_value");
            });

            modelBuilder.Entity<WpGiveDonationmetum>(entity =>
            {
                entity.HasKey(e => e.MetaId)
                    .HasName("PRIMARY");

                entity.ToTable("wp_give_donationmeta");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.DonationId, "donation_id");

                entity.HasIndex(e => e.MetaKey, "meta_key")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 191 });

                entity.Property(e => e.MetaId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("meta_id");

                entity.Property(e => e.DonationId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("donation_id");

                entity.Property(e => e.MetaKey).HasColumnName("meta_key");

                entity.Property(e => e.MetaValue).HasColumnName("meta_value");
            });

            modelBuilder.Entity<WpGiveDonor>(entity =>
            {
                entity.ToTable("wp_give_donors");

                entity.UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.Email, "email")
                    .IsUnique();

                entity.HasIndex(e => e.UserId, "user");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasColumnName("date_created");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("mediumtext")
                    .HasColumnName("name");

                entity.Property(e => e.PaymentIds)
                    .IsRequired()
                    .HasColumnName("payment_ids");

                entity.Property(e => e.PurchaseCount)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("purchase_count");

                entity.Property(e => e.PurchaseValue)
                    .IsRequired()
                    .HasColumnType("mediumtext")
                    .HasColumnName("purchase_value");

                entity.Property(e => e.Token)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("token");

                entity.Property(e => e.UserId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("user_id");

                entity.Property(e => e.VerifyKey)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("verify_key");

                entity.Property(e => e.VerifyThrottle)
                    .HasColumnType("datetime")
                    .HasColumnName("verify_throttle");
            });

            modelBuilder.Entity<WpGiveDonormetum>(entity =>
            {
                entity.HasKey(e => e.MetaId)
                    .HasName("PRIMARY");

                entity.ToTable("wp_give_donormeta");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.DonorId, "donor_id");

                entity.HasIndex(e => e.MetaKey, "meta_key")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 191 });

                entity.Property(e => e.MetaId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("meta_id");

                entity.Property(e => e.DonorId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("donor_id");

                entity.Property(e => e.MetaKey).HasColumnName("meta_key");

                entity.Property(e => e.MetaValue).HasColumnName("meta_value");
            });

            modelBuilder.Entity<WpGiveFormmetum>(entity =>
            {
                entity.HasKey(e => e.MetaId)
                    .HasName("PRIMARY");

                entity.ToTable("wp_give_formmeta");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.FormId, "form_id");

                entity.HasIndex(e => e.MetaKey, "meta_key")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 191 });

                entity.Property(e => e.MetaId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("meta_id");

                entity.Property(e => e.FormId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("form_id");

                entity.Property(e => e.MetaKey).HasColumnName("meta_key");

                entity.Property(e => e.MetaValue).HasColumnName("meta_value");
            });

            modelBuilder.Entity<WpGiveLog>(entity =>
            {
                entity.ToTable("wp_give_log");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.Category, "category");

                entity.HasIndex(e => e.LogType, "log_type");

                entity.HasIndex(e => e.Source, "source");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("category");

                entity.Property(e => e.Data)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("data");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("date");

                entity.Property(e => e.LogType)
                    .IsRequired()
                    .HasMaxLength(16)
                    .HasColumnName("log_type");

                entity.Property(e => e.Source)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("source");
            });

            modelBuilder.Entity<WpGiveMigration>(entity =>
            {
                entity.ToTable("wp_give_migrations");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasMaxLength(180)
                    .HasColumnName("id");

                entity.Property(e => e.Error)
                    .HasColumnType("text")
                    .HasColumnName("error");

                entity.Property(e => e.LastRun)
                    .HasColumnType("datetime")
                    .HasColumnName("last_run");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(16)
                    .HasColumnName("status");
            });

            modelBuilder.Entity<WpGiveRevenue>(entity =>
            {
                entity.ToTable("wp_give_revenue");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Amount)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("amount");

                entity.Property(e => e.DonationId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("donation_id");

                entity.Property(e => e.FormId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("form_id");
            });

            modelBuilder.Entity<WpGiveSequentialOrdering>(entity =>
            {
                entity.ToTable("wp_give_sequential_ordering");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.PaymentId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("payment_id");
            });

            modelBuilder.Entity<WpGiveSession>(entity =>
            {
                entity.HasKey(e => e.SessionKey)
                    .HasName("PRIMARY");

                entity.ToTable("wp_give_sessions");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.SessionId, "session_id")
                    .IsUnique();

                entity.Property(e => e.SessionKey)
                    .HasMaxLength(32)
                    .HasColumnName("session_key")
                    .IsFixedLength(true);

                entity.Property(e => e.SessionExpiry)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("session_expiry");

                entity.Property(e => e.SessionId)
                    .HasColumnType("bigint(20) unsigned")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("session_id");

                entity.Property(e => e.SessionValue)
                    .IsRequired()
                    .HasColumnName("session_value");
            });

            modelBuilder.Entity<WpLink>(entity =>
            {
                entity.HasKey(e => e.LinkId)
                    .HasName("PRIMARY");

                entity.ToTable("wp_links");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.LinkVisible, "link_visible");

                entity.Property(e => e.LinkId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("link_id");

                entity.Property(e => e.LinkDescription)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("link_description")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.LinkImage)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("link_image")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.LinkName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("link_name")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.LinkNotes)
                    .IsRequired()
                    .HasColumnType("mediumtext")
                    .HasColumnName("link_notes");

                entity.Property(e => e.LinkOwner)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("link_owner")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.LinkRating)
                    .HasColumnType("int(11)")
                    .HasColumnName("link_rating");

                entity.Property(e => e.LinkRel)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("link_rel")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.LinkRss)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("link_rss")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.LinkTarget)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasColumnName("link_target")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.LinkUpdated)
                    .HasColumnType("datetime")
                    .HasColumnName("link_updated")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.LinkUrl)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("link_url")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.LinkVisible)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("link_visible")
                    .HasDefaultValueSql("'Y'");
            });

            modelBuilder.Entity<WpOption>(entity =>
            {
                entity.HasKey(e => e.OptionId)
                    .HasName("PRIMARY");

                entity.ToTable("wp_options");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.Autoload, "autoload");

                entity.HasIndex(e => e.OptionName, "option_name")
                    .IsUnique();

                entity.Property(e => e.OptionId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("option_id");

                entity.Property(e => e.Autoload)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("autoload")
                    .HasDefaultValueSql("'yes'");

                entity.Property(e => e.OptionName)
                    .IsRequired()
                    .HasMaxLength(191)
                    .HasColumnName("option_name")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OptionValue)
                    .IsRequired()
                    .HasColumnName("option_value");
            });

            modelBuilder.Entity<WpPost>(entity =>
            {
                entity.ToTable("wp_posts");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.PostAuthor, "post_author");

                entity.HasIndex(e => e.PostName, "post_name")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 191 });

                entity.HasIndex(e => e.PostParent, "post_parent");

                entity.HasIndex(e => new { e.PostType, e.PostStatus, e.PostDate, e.Id }, "type_status_date");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("ID");

                entity.Property(e => e.CommentCount)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("comment_count");

                entity.Property(e => e.CommentStatus)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("comment_status")
                    .HasDefaultValueSql("'open'");

                entity.Property(e => e.Guid)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("guid")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MenuOrder)
                    .HasColumnType("int(11)")
                    .HasColumnName("menu_order");

                entity.Property(e => e.PingStatus)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("ping_status")
                    .HasDefaultValueSql("'open'");

                entity.Property(e => e.Pinged)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("pinged");

                entity.Property(e => e.PostAuthor)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("post_author");

                entity.Property(e => e.PostContent)
                    .IsRequired()
                    .HasColumnName("post_content");

                entity.Property(e => e.PostContentFiltered)
                    .IsRequired()
                    .HasColumnName("post_content_filtered");

                entity.Property(e => e.PostDate)
                    .HasColumnType("datetime")
                    .HasColumnName("post_date")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.PostDateGmt)
                    .HasColumnType("datetime")
                    .HasColumnName("post_date_gmt")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.PostExcerpt)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("post_excerpt");

                entity.Property(e => e.PostMimeType)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("post_mime_type")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PostModified)
                    .HasColumnType("datetime")
                    .HasColumnName("post_modified")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.PostModifiedGmt)
                    .HasColumnType("datetime")
                    .HasColumnName("post_modified_gmt")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.PostName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("post_name")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PostParent)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("post_parent");

                entity.Property(e => e.PostPassword)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("post_password")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PostStatus)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("post_status")
                    .HasDefaultValueSql("'publish'");

                entity.Property(e => e.PostTitle)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("post_title");

                entity.Property(e => e.PostType)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("post_type")
                    .HasDefaultValueSql("'post'");

                entity.Property(e => e.ToPing)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("to_ping");
            });

            modelBuilder.Entity<WpPostmetum>(entity =>
            {
                entity.HasKey(e => e.MetaId)
                    .HasName("PRIMARY");

                entity.ToTable("wp_postmeta");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.MetaKey, "meta_key")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 191 });

                entity.HasIndex(e => e.PostId, "post_id");

                entity.Property(e => e.MetaId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("meta_id");

                entity.Property(e => e.MetaKey).HasColumnName("meta_key");

                entity.Property(e => e.MetaValue).HasColumnName("meta_value");

                entity.Property(e => e.PostId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("post_id");
            });

            modelBuilder.Entity<WpTerm>(entity =>
            {
                entity.HasKey(e => e.TermId)
                    .HasName("PRIMARY");

                entity.ToTable("wp_terms");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.Name, "name")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 191 });

                entity.HasIndex(e => e.Slug, "slug")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 191 });

                entity.Property(e => e.TermId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("term_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("name")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Slug)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("slug")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.TermGroup)
                    .HasColumnType("bigint(10)")
                    .HasColumnName("term_group");
            });

            modelBuilder.Entity<WpTermRelationship>(entity =>
            {
                entity.HasKey(e => new { e.ObjectId, e.TermTaxonomyId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("wp_term_relationships");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.TermTaxonomyId, "term_taxonomy_id");

                entity.Property(e => e.ObjectId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("object_id");

                entity.Property(e => e.TermTaxonomyId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("term_taxonomy_id");

                entity.Property(e => e.TermOrder)
                    .HasColumnType("int(11)")
                    .HasColumnName("term_order");
            });

            modelBuilder.Entity<WpTermTaxonomy>(entity =>
            {
                entity.HasKey(e => e.TermTaxonomyId)
                    .HasName("PRIMARY");

                entity.ToTable("wp_term_taxonomy");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.Taxonomy, "taxonomy");

                entity.HasIndex(e => new { e.TermId, e.Taxonomy }, "term_id_taxonomy")
                    .IsUnique();

                entity.Property(e => e.TermTaxonomyId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("term_taxonomy_id");

                entity.Property(e => e.Count)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("count");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description");

                entity.Property(e => e.Parent)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("parent");

                entity.Property(e => e.Taxonomy)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("taxonomy")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.TermId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("term_id");
            });

            modelBuilder.Entity<WpTermmetum>(entity =>
            {
                entity.HasKey(e => e.MetaId)
                    .HasName("PRIMARY");

                entity.ToTable("wp_termmeta");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.MetaKey, "meta_key")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 191 });

                entity.HasIndex(e => e.TermId, "term_id");

                entity.Property(e => e.MetaId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("meta_id");

                entity.Property(e => e.MetaKey).HasColumnName("meta_key");

                entity.Property(e => e.MetaValue).HasColumnName("meta_value");

                entity.Property(e => e.TermId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("term_id");
            });

            modelBuilder.Entity<WpUser>(entity =>
            {
                entity.ToTable("wp_users");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.UserEmail, "user_email");

                entity.HasIndex(e => e.UserLogin, "user_login_key");

                entity.HasIndex(e => e.UserNicename, "user_nicename");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("ID");

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("display_name")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.UserActivationKey)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("user_activation_key")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.UserEmail)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("user_email")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.UserLogin)
                    .IsRequired()
                    .HasMaxLength(60)
                    .HasColumnName("user_login")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.UserNicename)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("user_nicename")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.UserPass)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("user_pass")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.UserRegistered)
                    .HasColumnType("datetime")
                    .HasColumnName("user_registered")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.UserStatus)
                    .HasColumnType("int(11)")
                    .HasColumnName("user_status");

                entity.Property(e => e.UserUrl)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("user_url")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<WpUsermetum>(entity =>
            {
                entity.HasKey(e => e.UmetaId)
                    .HasName("PRIMARY");

                entity.ToTable("wp_usermeta");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.MetaKey, "meta_key")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 191 });

                entity.HasIndex(e => e.UserId, "user_id");

                entity.Property(e => e.UmetaId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("umeta_id");

                entity.Property(e => e.MetaKey).HasColumnName("meta_key");

                entity.Property(e => e.MetaValue).HasColumnName("meta_value");

                entity.Property(e => e.UserId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("user_id");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
