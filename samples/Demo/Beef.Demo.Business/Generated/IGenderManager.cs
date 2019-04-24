/*
 * This file is automatically generated; any changes will be lost. 
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Beef;
using Beef.Entities;
using Beef.Demo.Common.Entities;
using RefDataNamespace = Beef.Demo.Common.Entities;

namespace Beef.Demo.Business
{
    /// <summary>
    /// Defines the Gender business functionality.
    /// </summary>
    public partial interface IGenderManager
    {
        /// <summary>
        /// Gets the <see cref="Gender"/> object that matches the selection criteria.
        /// </summary>
        /// <param name="id">The <see cref="Gender"/> identifier.</param>
        /// <returns>The selected <see cref="Gender"/> object where found; otherwise, <c>null</c>.</returns>
        Task<Gender> GetAsync(Guid id);

        /// <summary>
        /// Creates the <see cref="Gender"/> object.
        /// </summary>
        /// <param name="value">The <see cref="Gender"/> object.</param>
        /// <returns>A refreshed <see cref="Gender"/> object.</returns>
        Task<Gender> CreateAsync(Gender value);

        /// <summary>
        /// Updates the <see cref="Gender"/> object.
        /// </summary>
        /// <param name="value">The <see cref="Gender"/> object.</param>
        /// <param name="id">The <see cref="Gender"/> identifier.</param>
        /// <returns>A refreshed <see cref="Gender"/> object.</returns>
        Task<Gender> UpdateAsync(Gender value, Guid id);
    }
}
