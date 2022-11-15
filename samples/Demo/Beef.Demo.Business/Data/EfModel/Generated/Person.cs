/*
 * This file is automatically generated; any changes will be lost. 
 */

#nullable enable
#pragma warning disable

using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Beef.Demo.Business.Data.EfModel
{
    /// <summary>
    /// Represents the Entity Framework (EF) model for database object 'Demo.Person'.
    /// </summary>
    public partial class Person
    {
        /// <summary>
        /// Gets or sets the 'PersonId' column value.
        /// </summary>
        public Guid PersonId { get; set; }

        /// <summary>
        /// Gets or sets the 'FirstName' column value.
        /// </summary>
        public string? FirstName { get; set; }

        /// <summary>
        /// Gets or sets the 'LastName' column value.
        /// </summary>
        public string? LastName { get; set; }

        /// <summary>
        /// Gets or sets the 'Birthday' column value.
        /// </summary>
        public DateTime? Birthday { get; set; }

        /// <summary>
        /// Gets or sets the 'GenderId' column value.
        /// </summary>
        public Guid? GenderId { get; set; }

        /// <summary>
        /// Gets or sets the 'Street' column value.
        /// </summary>
        public string? Street { get; set; }

        /// <summary>
        /// Gets or sets the 'City' column value.
        /// </summary>
        public string? City { get; set; }

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
        /// Gets or sets the 'UniqueCode' column value.
        /// </summary>
        public string? UniqueCode { get; set; }

        /// <summary>
        /// Gets or sets the 'EyeColorCode' column value.
        /// </summary>
        public string? EyeColorCode { get; set; }

        /// <summary>
        /// Gets or sets the 'MetadataJson' column value.
        /// </summary>
        public string? MetadataJson { get; set; }

        /// <summary>
        /// Adds the table/model configuration to the <see cref="ModelBuilder"/>.
        /// </summary>
        /// <param name="modelBuilder">The <see cref="ModelBuilder"/>.</param>
        public static void AddToModel(ModelBuilder modelBuilder)
        {
            if (modelBuilder == null)
                throw new ArgumentNullException(nameof(modelBuilder));

            modelBuilder.Entity<Person>(entity =>
            {
                entity.ToTable("Person", "Demo");
                entity.HasKey(nameof(PersonId));
                entity.Property(p => p.PersonId).HasColumnName("PersonId").HasColumnType("UNIQUEIDENTIFIER");
                entity.Property(p => p.FirstName).HasColumnName("FirstName").HasColumnType("NVARCHAR(50)");
                entity.Property(p => p.LastName).HasColumnName("LastName").HasColumnType("NVARCHAR(50)");
                entity.Property(p => p.Birthday).HasColumnName("Birthday").HasColumnType("DATE");
                entity.Property(p => p.GenderId).HasColumnName("GenderId").HasColumnType("UNIQUEIDENTIFIER");
                entity.Property(p => p.Street).HasColumnName("Street").HasColumnType("NVARCHAR(100)");
                entity.Property(p => p.City).HasColumnName("City").HasColumnType("NVARCHAR(100)");
                entity.Property(p => p.RowVersion).HasColumnName("RowVersion").HasColumnType("TIMESTAMP").IsRowVersion();
                entity.Property(p => p.CreatedBy).HasColumnName("CreatedBy").HasColumnType("NVARCHAR(250)").ValueGeneratedOnUpdate();
                entity.Property(p => p.CreatedDate).HasColumnName("CreatedDate").HasColumnType("DATETIME2").ValueGeneratedOnUpdate();
                entity.Property(p => p.UpdatedBy).HasColumnName("UpdatedBy").HasColumnType("NVARCHAR(250)").ValueGeneratedOnAdd();
                entity.Property(p => p.UpdatedDate).HasColumnName("UpdatedDate").HasColumnType("DATETIME2").ValueGeneratedOnAdd();
                entity.Property(p => p.UniqueCode).HasColumnName("UniqueCode").HasColumnType("NVARCHAR(20)");
                entity.Property(p => p.EyeColorCode).HasColumnName("EyeColorCode").HasColumnType("NVARCHAR(50)");
                entity.Property(p => p.MetadataJson).HasColumnName("MetadataJson").HasColumnType("NVARCHAR(2048)");
                AddToModel(entity);
            });
        }
        
        /// <summary>
        /// Enables further configuration of the underlying <see cref="EntityTypeBuilder"/> when configuring the <see cref="ModelBuilder"/>.
        /// </summary>
        static partial void AddToModel(EntityTypeBuilder<Person> entity);
    }
}

#pragma warning restore
#nullable restore