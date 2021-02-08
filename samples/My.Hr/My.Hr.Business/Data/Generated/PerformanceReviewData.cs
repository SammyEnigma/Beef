/*
 * This file is automatically generated; any changes will be lost. 
 */

#nullable enable
#pragma warning disable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Beef;
using Beef.Business;
using Beef.Data.EntityFrameworkCore;
using Beef.Entities;
using Beef.Mapper;
using Beef.Mapper.Converters;
using My.Hr.Common.Entities;
using RefDataNamespace = My.Hr.Common.Entities;

namespace My.Hr.Business.Data
{
    /// <summary>
    /// Provides the <see cref="PerformanceReview"/> data access.
    /// </summary>
    public partial class PerformanceReviewData : IPerformanceReviewData
    {
        private readonly IEfDb _ef;

        private Func<IQueryable<EfModel.PerformanceReview>, Guid, IEfDbArgs, IQueryable<EfModel.PerformanceReview>>? _getByEmployeeIdOnQuery;

        /// <summary>
        /// Initializes a new instance of the <see cref="PerformanceReviewData"/> class.
        /// </summary>
        /// <param name="ef">The <see cref="IEfDb"/>.</param>
        public PerformanceReviewData(IEfDb ef)
            { _ef = Check.NotNull(ef, nameof(ef)); PerformanceReviewDataCtor(); }

        partial void PerformanceReviewDataCtor(); // Enables additional functionality to be added to the constructor.

        /// <summary>
        /// Gets the specified <see cref="PerformanceReview"/>.
        /// </summary>
        /// <param name="id">The <see cref="Employee"/> identifier.</param>
        /// <returns>The selected <see cref="PerformanceReview"/> where found.</returns>
        public Task<PerformanceReview?> GetAsync(Guid id)
        {
            return DataInvoker.Current.InvokeAsync(this, async () =>
            {
                var __dataArgs = EfMapper.Default.CreateArgs();
                return await _ef.GetAsync(__dataArgs, id).ConfigureAwait(false);
            });
        }

        /// <summary>
        /// Gets the <see cref="PerformanceReviewCollectionResult"/> that contains the items that match the selection criteria.
        /// </summary>
        /// <param name="employeeId">The <see cref="Employee.Id"/>.</param>
        /// <param name="paging">The <see cref="PagingArgs"/>.</param>
        /// <returns>The <see cref="PerformanceReviewCollectionResult"/>.</returns>
        public Task<PerformanceReviewCollectionResult> GetByEmployeeIdAsync(Guid employeeId, PagingArgs? paging)
        {
            return DataInvoker.Current.InvokeAsync(this, async () =>
            {
                PerformanceReviewCollectionResult __result = new PerformanceReviewCollectionResult(paging);
                var __dataArgs = EfMapper.Default.CreateArgs(__result.Paging!);
                __result.Result = _ef.Query(__dataArgs, q => _getByEmployeeIdOnQuery?.Invoke(q, employeeId, __dataArgs) ?? q).SelectQuery<PerformanceReviewCollection>();
                return await Task.FromResult(__result).ConfigureAwait(false);
            });
        }

        /// <summary>
        /// Creates a new <see cref="PerformanceReview"/>.
        /// </summary>
        /// <param name="value">The <see cref="PerformanceReview"/>.</param>
        /// <returns>The created <see cref="PerformanceReview"/>.</returns>
        public Task<PerformanceReview> CreateAsync(PerformanceReview value)
        {
            return DataInvoker.Current.InvokeAsync(this, async () =>
            {
                var __dataArgs = EfMapper.Default.CreateArgs();
                return await _ef.CreateAsync(__dataArgs, Check.NotNull(value, nameof(value))).ConfigureAwait(false);
            });
        }

        /// <summary>
        /// Updates an existing <see cref="PerformanceReview"/>.
        /// </summary>
        /// <param name="value">The <see cref="PerformanceReview"/>.</param>
        /// <returns>The updated <see cref="PerformanceReview"/>.</returns>
        public Task<PerformanceReview> UpdateAsync(PerformanceReview value)
        {
            return DataInvoker.Current.InvokeAsync(this, async () =>
            {
                var __dataArgs = EfMapper.Default.CreateArgs();
                return await _ef.UpdateAsync(__dataArgs, Check.NotNull(value, nameof(value))).ConfigureAwait(false);
            });
        }

        /// <summary>
        /// Deletes the specified <see cref="PerformanceReview"/>.
        /// </summary>
        /// <param name="id">The <see cref="Employee"/> identifier.</param>
        public Task DeleteAsync(Guid id)
        {
            return DataInvoker.Current.InvokeAsync(this, async () =>
            {
                var __dataArgs = EfMapper.Default.CreateArgs();
                await _ef.DeleteAsync(__dataArgs, id).ConfigureAwait(false);
            });
        }

        /// <summary>
        /// Provides the <see cref="PerformanceReview"/> and Entity Framework <see cref="EfModel.PerformanceReview"/> property mapping.
        /// </summary>
        public partial class EfMapper : EfDbMapper<PerformanceReview, EfModel.PerformanceReview, EfMapper>
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="EfMapper"/> class.
            /// </summary>
            public EfMapper()
            {
                Property(s => s.Id, d => d.PerformanceReviewId).SetUniqueKey(true);
                Property(s => s.EmployeeId, d => d.EmployeeId).SetOperationTypes(OperationTypes.AnyExceptUpdate);
                Property(s => s.Date, d => d.Date);
                Property(s => s.OutcomeSid, d => d.PerformanceOutcomeCode);
                Property(s => s.Reviewer, d => d.Reviewer);
                Property(s => s.Notes, d => d.Notes);
                AddStandardProperties();
                EfMapperCtor();
            }
            
            partial void EfMapperCtor(); // Enables the EfMapper constructor to be extended.
        }
    }
}

#pragma warning restore
#nullable restore