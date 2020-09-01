using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DataService.Models
{
    public partial class FDRYFRUITSMANAGEMENTDATASERVICEDRYFRUITMANAGEMENTDBMDFContext : DbContext
    {
        public FDRYFRUITSMANAGEMENTDATASERVICEDRYFRUITMANAGEMENTDBMDFContext()
        {
        }

        public FDRYFRUITSMANAGEMENTDATASERVICEDRYFRUITMANAGEMENTDBMDFContext(DbContextOptions<FDRYFRUITSMANAGEMENTDATASERVICEDRYFRUITMANAGEMENTDBMDFContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblAdmin> TblAdmin { get; set; }
        public virtual DbSet<TblComments> TblComments { get; set; }
        public virtual DbSet<TblLike> TblLike { get; set; }
        public virtual DbSet<TblNotifications> TblNotifications { get; set; }
        public virtual DbSet<TblPost> TblPost { get; set; }
        public virtual DbSet<TblProducts> TblProducts { get; set; }
        public virtual DbSet<TblUser> TblUser { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=F:\\DryFruitsManagement\\DataService\\DryFruitManagementDB.mdf;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblAdmin>(entity =>
            {
                entity.HasKey(e => e.AdminId)
                    .HasName("PK__tbl_Admi__4A3006F7F139D342");

                entity.ToTable("tbl_Admin");

                entity.HasIndex(e => e.AdminEmail)
                    .HasName("UQ__tbl_Admi__6066AA650ECC0908")
                    .IsUnique();

                entity.HasIndex(e => e.AdminMobileNumber)
                    .HasName("UQ__tbl_Admi__77F2C3A5D674D297")
                    .IsUnique();

                entity.Property(e => e.AdminId).HasColumnName("Admin_Id");

                entity.Property(e => e.AdminCreated)
                    .HasColumnName("Admin_Created")
                    .HasColumnType("datetime");

                entity.Property(e => e.AdminEmail)
                    .IsRequired()
                    .HasColumnName("Admin_Email")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.AdminIsActive).HasColumnName("Admin_IsActive");

                entity.Property(e => e.AdminMobileNumber)
                    .IsRequired()
                    .HasColumnName("Admin_MobileNumber")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AdminPassword)
                    .IsRequired()
                    .HasColumnName("Admin_Password")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AdminUpdated)
                    .HasColumnName("Admin_Updated")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TblComments>(entity =>
            {
                entity.HasKey(e => e.CommentId)
                    .HasName("PK__tbl_Comm__99FC14DBFC212DFF");

                entity.ToTable("tbl_Comments");

                entity.Property(e => e.CommentId)
                    .HasColumnName("Comment_Id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CommentCommentBy).HasColumnName("Comment_CommentBy");

                entity.Property(e => e.CommentCreated)
                    .HasColumnName("Comment_Created")
                    .HasColumnType("datetime");

                entity.Property(e => e.CommentPostId).HasColumnName("Comment_POstId");

                entity.Property(e => e.CommentText)
                    .HasColumnName("Comment_Text")
                    .IsUnicode(false);

                entity.Property(e => e.CommentUpdated)
                    .HasColumnName("Comment_Updated")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.CommentPost)
                    .WithMany(p => p.TblComments)
                    .HasForeignKey(d => d.CommentPostId)
                    .HasConstraintName("FK__tbl_Comme__Comme__34C8D9D1");
            });

            modelBuilder.Entity<TblLike>(entity =>
            {
                entity.HasKey(e => e.LikeId)
                    .HasName("PK__tbl_Like__A40EE687E16CD6BF");

                entity.ToTable("tbl_Like");

                entity.Property(e => e.LikeId)
                    .HasColumnName("Like_Id")
                    .ValueGeneratedNever();

                entity.Property(e => e.LikeDate)
                    .HasColumnName("Like_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.LikeLikedBy)
                    .HasColumnName("Like_LikedBy")
                    .IsUnicode(false);

                entity.Property(e => e.LikePostId).HasColumnName("Like_PostId");

                entity.HasOne(d => d.LikePost)
                    .WithMany(p => p.TblLike)
                    .HasForeignKey(d => d.LikePostId)
                    .HasConstraintName("FK__tbl_Like__Like_P__31EC6D26");
            });

            modelBuilder.Entity<TblNotifications>(entity =>
            {
                entity.HasKey(e => e.NotificationsId)
                    .HasName("PK__tbl_Noti__9688F63C1A8BDB58");

                entity.ToTable("tbl_Notifications");

                entity.HasIndex(e => e.NotificationsName)
                    .HasName("UQ__tbl_Noti__03A7F1EBA7AE8793")
                    .IsUnique();

                entity.Property(e => e.NotificationsId).HasColumnName("Notifications_Id");

                entity.Property(e => e.NotificationAddedBy).HasColumnName("Notification_Added_By");

                entity.Property(e => e.NotificationsAgeLimit).HasColumnName("Notifications_AgeLimit");

                entity.Property(e => e.NotificationsCreated)
                    .HasColumnName("Notifications_Created")
                    .HasColumnType("datetime");

                entity.Property(e => e.NotificationsLastDate)
                    .HasColumnName("Notifications_LastDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.NotificationsName)
                    .HasColumnName("Notifications_Name")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.NotificationsQualification)
                    .HasColumnName("Notifications_Qualification")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NotificationsSalary)
                    .HasColumnName("Notifications_Salary")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NotificationsSite)
                    .HasColumnName("Notifications_Site")
                    .IsUnicode(false);

                entity.Property(e => e.NotificationsStartDate)
                    .HasColumnName("Notifications_StartDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.NotificationsUpdated)
                    .HasColumnName("Notifications_Updated")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.NotificationAddedByNavigation)
                    .WithMany(p => p.TblNotifications)
                    .HasForeignKey(d => d.NotificationAddedBy)
                    .HasConstraintName("FK__tbl_Notif__Notif__2C3393D0");
            });

            modelBuilder.Entity<TblPost>(entity =>
            {
                entity.HasKey(e => e.PostId)
                    .HasName("PK__tbl_Post__5875F7AD79A23D90");

                entity.ToTable("tbl_Post");

                entity.Property(e => e.PostId).HasColumnName("Post_Id");

                entity.Property(e => e.PostCreatedBy).HasColumnName("Post_createdBy");

                entity.Property(e => e.PostCreatedOn)
                    .HasColumnName("Post_CreatedOn")
                    .HasColumnType("datetime");

                entity.Property(e => e.PostImage).HasColumnName("Post_Image");

                entity.Property(e => e.PostText)
                    .HasColumnName("Post_Text")
                    .IsUnicode(false);

                entity.Property(e => e.PostUpdatedOn)
                    .HasColumnName("Post_UpdatedOn")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.PostCreatedByNavigation)
                    .WithMany(p => p.TblPost)
                    .HasForeignKey(d => d.PostCreatedBy)
                    .HasConstraintName("FK__tbl_Post__Post_c__2F10007B");
            });

            modelBuilder.Entity<TblProducts>(entity =>
            {
                entity.HasKey(e => e.ProductId)
                    .HasName("PK__TblProdu__B40CC6CD3DE24E05");

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ProductName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblUser>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__tbl_User__206D9170A9A49602");

                entity.ToTable("tbl_User");

                entity.HasIndex(e => e.UserEmail)
                    .HasName("UQ__tbl_User__4C70A05C10025833")
                    .IsUnique();

                entity.HasIndex(e => e.UserMobileNumber)
                    .HasName("UQ__tbl_User__46AEB3EB0D769ED9")
                    .IsUnique();

                entity.Property(e => e.UserId).HasColumnName("User_Id");

                entity.Property(e => e.UserCreated)
                    .HasColumnName("User_Created")
                    .HasColumnType("datetime");

                entity.Property(e => e.UserEmail)
                    .IsRequired()
                    .HasColumnName("User_Email")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UserIsActive).HasColumnName("User_IsActive");

                entity.Property(e => e.UserMobileNumber)
                    .IsRequired()
                    .HasColumnName("User_MobileNumber")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserPassword)
                    .IsRequired()
                    .HasColumnName("User_Password")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UserUpdated)
                    .HasColumnName("User_Updated")
                    .HasColumnType("datetime");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
