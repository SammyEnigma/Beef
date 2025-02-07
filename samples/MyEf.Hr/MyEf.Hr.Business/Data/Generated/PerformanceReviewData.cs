/*
 * This file is automatically generated; any changes will be lost. 
 */

namespace MyEf.Hr.Business.Data;

/// <summary>
/// Provides the <see cref="PerformanceReview"/> data access.
/// </summary>
public partial class PerformanceReviewData : IPerformanceReviewData
{
    private readonly HrEfDb _ef;
    private Func<IQueryable<EfModel.PerformanceReview>, Guid, IQueryable<EfModel.PerformanceReview>>? _getByEmployeeIdOnQuery;

    /// <summary>
    /// Initializes a new instance of the <see cref="PerformanceReviewData"/> class.
    /// </summary>
    /// <param name="ef">The <see cref="HrEfDb"/>.</param>
    public PerformanceReviewData(HrEfDb ef)
        { _ef = ef.ThrowIfNull(); PerformanceReviewDataCtor(); }

    partial void PerformanceReviewDataCtor(); // Enables additional functionality to be added to the constructor.

    /// <inheritdoc/>
    public Task<Result<PerformanceReview?>> GetAsync(Guid id)
        => _ef.GetWithResultAsync<PerformanceReview, EfModel.PerformanceReview>(id);

    /// <inheritdoc/>
    public Task<Result<PerformanceReview>> UpdateAsync(PerformanceReview value)
        => _ef.UpdateWithResultAsync<PerformanceReview, EfModel.PerformanceReview>(value);

    /// <inheritdoc/>
    public Task<Result> DeleteAsync(Guid id)
        => _ef.DeleteWithResultAsync<PerformanceReview, EfModel.PerformanceReview>(id);

    /// <inheritdoc/>
    public Task<Result<PerformanceReviewCollectionResult>> GetByEmployeeIdAsync(Guid employeeId, PagingArgs? paging)
        => _ef.Query<PerformanceReview, EfModel.PerformanceReview>(q => _getByEmployeeIdOnQuery?.Invoke(q, employeeId) ?? q).WithPaging(paging).SelectResultWithResultAsync<PerformanceReviewCollectionResult, PerformanceReviewCollection>();

    /// <inheritdoc/>
    public Task<Result<PerformanceReview>> CreateAsync(PerformanceReview value)
        => _ef.CreateWithResultAsync<PerformanceReview, EfModel.PerformanceReview>(value);

    /// <summary>
    /// Provides the <see cref="PerformanceReview"/> to Entity Framework <see cref="EfModel.PerformanceReview"/> mapping.
    /// </summary>
    public partial class EntityToModelEfMapper : Mapper<PerformanceReview, EfModel.PerformanceReview>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EntityToModelEfMapper"/> class.
        /// </summary>
        public EntityToModelEfMapper()
        {
            Map((s, d) => d.PerformanceReviewId = s.Id, OperationTypes.Any, s => s.Id == default, d => d.PerformanceReviewId = default);
            Map((s, d) => d.EmployeeId = s.EmployeeId, OperationTypes.AnyExceptUpdate, s => s.EmployeeId == default, d => d.EmployeeId = default);
            Map((s, d) => d.Date = s.Date, OperationTypes.Any, s => s.Date == default, d => d.Date = default);
            Map((s, d) => d.PerformanceOutcomeCode = s.OutcomeSid, OperationTypes.Any, s => s.OutcomeSid == default, d => d.PerformanceOutcomeCode = default);
            Map((s, d) => d.Reviewer = s.Reviewer, OperationTypes.Any, s => s.Reviewer == default, d => d.Reviewer = default);
            Map((s, d) => d.Notes = s.Notes, OperationTypes.Any, s => s.Notes == default, d => d.Notes = default);
            Map((s, d) => d.RowVersion = StringToBase64Converter.Default.ConvertToDestination(s.ETag), OperationTypes.Any, s => s.ETag == default, d => d.RowVersion = default);
            Flatten(s => s.ChangeLog, OperationTypes.Any, s => s.ChangeLog == default);
            EntityToModelEfMapperCtor();
        }

        partial void EntityToModelEfMapperCtor(); // Enables the constructor to be extended.

        /// <inheritdoc/>
        protected override void OnRegister(Mapper<PerformanceReview, EfModel.PerformanceReview> mapper) => mapper.Owner.Register(new Mapper<ChangeLogEx, EfModel.PerformanceReview>()
            .Map((s, d) => d.CreatedBy = s.CreatedBy, OperationTypes.AnyExceptUpdate)
            .Map((s, d) => d.CreatedDate = s.CreatedDate, OperationTypes.AnyExceptUpdate)
            .Map((s, d) => d.UpdatedBy = s.UpdatedBy, OperationTypes.AnyExceptCreate)
            .Map((s, d) => d.UpdatedDate = s.UpdatedDate, OperationTypes.AnyExceptCreate));
    }

    /// <summary>
    /// Provides the Entity Framework <see cref="EfModel.PerformanceReview"/> to <see cref="PerformanceReview"/> mapping.
    /// </summary>
    public partial class ModelToEntityEfMapper : Mapper<EfModel.PerformanceReview, PerformanceReview>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ModelToEntityEfMapper"/> class.
        /// </summary>
        public ModelToEntityEfMapper()
        {
            Map((s, d) => d.Id = (Guid)s.PerformanceReviewId!, OperationTypes.Any, s => s.PerformanceReviewId == default, d => d.Id = default);
            Map((s, d) => d.EmployeeId = (Guid)s.EmployeeId!, OperationTypes.AnyExceptUpdate, s => s.EmployeeId == default, d => d.EmployeeId = default);
            Map((s, d) => d.Date = (DateTime)s.Date!, OperationTypes.Any, s => s.Date == default, d => d.Date = default);
            Map((s, d) => d.OutcomeSid = (string?)s.PerformanceOutcomeCode!, OperationTypes.Any, s => s.PerformanceOutcomeCode == default, d => d.OutcomeSid = default);
            Map((s, d) => d.Reviewer = (string?)s.Reviewer!, OperationTypes.Any, s => s.Reviewer == default, d => d.Reviewer = default);
            Map((s, d) => d.Notes = (string?)s.Notes!, OperationTypes.Any, s => s.Notes == default, d => d.Notes = default);
            Map((s, d) => d.ETag = (string?)StringToBase64Converter.Default.ConvertToSource(s.RowVersion!), OperationTypes.Any, s => s.RowVersion == default, d => d.ETag = default);
            Expand<ChangeLogEx>((d, v) => d.ChangeLog = v, OperationTypes.Any, d => d.ChangeLog = default);
            ModelToEntityEfMapperCtor();
        }

        partial void ModelToEntityEfMapperCtor(); // Enables the constructor to be extended.

        /// <inheritdoc/>
        protected override void OnRegister(Mapper<EfModel.PerformanceReview, PerformanceReview> mapper) => mapper.Owner.Register(new Mapper<EfModel.PerformanceReview, ChangeLogEx>()
            .Map((s, d) => d.CreatedBy = s.CreatedBy, OperationTypes.AnyExceptUpdate)
            .Map((s, d) => d.CreatedDate = s.CreatedDate, OperationTypes.AnyExceptUpdate)
            .Map((s, d) => d.UpdatedBy = s.UpdatedBy, OperationTypes.AnyExceptCreate)
            .Map((s, d) => d.UpdatedDate = s.UpdatedDate, OperationTypes.AnyExceptCreate));
    }
}