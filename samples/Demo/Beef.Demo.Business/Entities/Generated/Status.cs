/*
 * This file is automatically generated; any changes will be lost. 
 */

#nullable enable
#pragma warning disable

namespace Beef.Demo.Business.Entities
{
    /// <summary>
    /// Represents the Status entity.
    /// </summary>
    public partial class Status : ReferenceDataBaseEx<string?, Status>
    {

        /// <summary>
        /// An implicit cast from a <see cref="IReferenceData.Code"> to <see cref="Status"/>.
        /// </summary>
        /// <param name="code">The <see cref="IReferenceData.Code">.</param>
        /// <returns>The corresponding <see cref="Status"/>.</returns>
        public static implicit operator Status?(string? code) => ConvertFromCode(code);
    }

    /// <summary>
    /// Represents the <see cref="Status"/> collection.
    /// </summary>
    public partial class StatusCollection : ReferenceDataCollectionBase<string?, Status, StatusCollection>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StatusCollection"/> class.
        /// </summary>
        public StatusCollection() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="StatusCollection"/> class with <paramref name="items"/> to add.
        /// </summary>
        /// <param name="items">The items to add.</param>
        public StatusCollection(IEnumerable<Status> items) => AddRange(items);
    }
}

#pragma warning restore
#nullable restore