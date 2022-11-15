/*
 * This file is automatically generated; any changes will be lost. 
 */

#nullable enable
#pragma warning disable

using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace My.Hr.Business.Data.EfModel
{
    /// <summary>
    /// Represents the Entity Framework (EF) model for database object 'Hr.USState'.
    /// </summary>
    public partial class USState
    {
        /// <summary>
        /// Gets or sets the 'USStateId' column value.
        /// </summary>
        public Guid USStateId { get; set; }

        /// <summary>
        /// Gets or sets the 'Code' column value.
        /// </summary>
        public string? Code { get; set; }

        /// <summary>
        /// Gets or sets the 'Text' column value.
        /// </summary>
        public string? Text { get; set; }

        /// <summary>
        /// Gets or sets the 'IsActive' column value.
        /// </summary>
        public bool? IsActive { get; set; }

        /// <summary>
        /// Gets or sets the 'SortOrder' column value.
        /// </summary>
        public int? SortOrder { get; set; }

        /// <summary>
        /// Gets or sets the 'RowVersion' column value.
        /// </summary>
        public byte[]? RowVersion { get; set; }

        /// <summary>
        /// Gets or sets the 'CreatedBy' column value.
        /// </summary>
        public string? CreatedBy { get; set; }

        /// <summary>
        /// Gets or sets the 'CreatedDate' column value.
        /// </summary>
        public DateTime? CreatedDate { get; set; }

        /// <summary>
        /// Gets or sets the 'UpdatedBy' column value.
        /// </summary>
        public string? UpdatedBy { get; set; }

        /// <summary>
        /// Gets or sets the 'UpdatedDate' column value.
        /// </summary>
        public DateTime? UpdatedDate { get; set; }

        /// <summary>
        /// Adds the table/model configuration to the <see cref="ModelBuilder"/>.
        /// </summary>
        /// <param name="modelBuilder">The <see cref="ModelBuilder"/>.</param>
        public static void AddToModel(ModelBuilder modelBuilder)
        {
            if (modelBuilder == null)
                throw new ArgumentNullException(nameof(modelBuilder));

            modelBuilder.Entity<USState>(entity =>
            {
                entity.ToTable("USState", "Hr");
                entity.HasKey(nameof(USStateId));
                entity.Property(p => p.USStateId).HasColumnName("USStateId").HasColumnType("UNIQUEIDENTIFIER");
                entity.Property(p => p.Code).HasColumnName("Code").HasColumnType("NVARCHAR(50)");
                entity.Property(p => p.Text).HasColumnName("Text").HasColumnType("NVARCHAR(250)");
                entity.Property(p => p.IsActive).HasColumnName("IsActive").HasColumnType("BIT");
                entity.Property(p => p.SortOrder).HasColumnName("SortOrder").HasColumnType("INT");
                entity.Property(p => p.RowVersion).HasColumnName("RowVersion").HasColumnType("TIMESTAMP").IsRowVersion();
                entity.Property(p => p.CreatedBy).HasColumnName("CreatedBy").HasColumnType("NVARCHAR(250)").ValueGeneratedOnUpdate();
                entity.Property(p => p.CreatedDate).HasColumnName("CreatedDate").HasColumnType("DATETIME2").ValueGeneratedOnUpdate();
                entity.Property(p => p.UpdatedBy).HasColumnName("UpdatedBy").HasColumnType("NVARCHAR(250)").ValueGeneratedOnAdd();
                entity.Property(p => p.UpdatedDate).HasColumnName("UpdatedDate").HasColumnType("DATETIME2").ValueGeneratedOnAdd();
                AddToModel(entity);
            });
        }
        
        /// <summary>
        /// Enables further configuration of the underlying <see cref="EntityTypeBuilder"/> when configuring the <see cref="ModelBuilder"/>.
        /// </summary>
        static partial void AddToModel(EntityTypeBuilder<USState> entity);
    }
}

#pragma warning restore
#nullable restore