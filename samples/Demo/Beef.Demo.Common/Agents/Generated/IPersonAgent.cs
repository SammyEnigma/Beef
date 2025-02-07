/*
 * This file is automatically generated; any changes will be lost.
 */

#nullable enable
#pragma warning disable

namespace Beef.Demo.Common.Agents;

/// <summary>
/// Defines the <see cref="Person"/> HTTP agent.
/// </summary>
public partial interface IPersonAgent
{
    /// <summary>
    /// Creates a new <see cref="Person"/>.
    /// </summary>
    /// <param name="value">The <see cref="Person"/>.</param>
    /// <param name="requestOptions">The optional <see cref="HttpRequestOptions"/>.</param>
    /// <param name="cancellationToken">The <see cref="CancellationToken"/>.</param>
    /// <returns>A <see cref="HttpResult"/>.</returns>
    Task<HttpResult<Person>> CreateAsync(Person value, HttpRequestOptions? requestOptions = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Deletes the specified <see cref="Person"/>.
    /// </summary>
    /// <param name="id">The <see cref="Person"/> identifier.</param>
    /// <param name="requestOptions">The optional <see cref="HttpRequestOptions"/>.</param>
    /// <param name="cancellationToken">The <see cref="CancellationToken"/>.</param>
    /// <returns>A <see cref="HttpResult"/>.</returns>
    Task<HttpResult> DeleteAsync(Guid id, HttpRequestOptions? requestOptions = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Gets the specified <see cref="Person"/>.
    /// </summary>
    /// <param name="id">The <see cref="Person"/> identifier.</param>
    /// <param name="requestOptions">The optional <see cref="HttpRequestOptions"/>.</param>
    /// <param name="cancellationToken">The <see cref="CancellationToken"/>.</param>
    /// <returns>A <see cref="HttpResult"/>.</returns>
    Task<HttpResult<Person?>> GetAsync(Guid id, HttpRequestOptions? requestOptions = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Gets the specified <see cref="Person"/>.
    /// </summary>
    /// <param name="id">The <see cref="Person"/> identifier.</param>
    /// <param name="requestOptions">The optional <see cref="HttpRequestOptions"/>.</param>
    /// <param name="cancellationToken">The <see cref="CancellationToken"/>.</param>
    /// <returns>A <see cref="HttpResult"/>.</returns>
    Task<HttpResult<Person?>> GetExAsync(Guid id, HttpRequestOptions? requestOptions = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Updates an existing <see cref="Person"/>.
    /// </summary>
    /// <param name="value">The <see cref="Person"/>.</param>
    /// <param name="id">The <see cref="Person"/> identifier.</param>
    /// <param name="requestOptions">The optional <see cref="HttpRequestOptions"/>.</param>
    /// <param name="cancellationToken">The <see cref="CancellationToken"/>.</param>
    /// <returns>A <see cref="HttpResult"/>.</returns>
    Task<HttpResult<Person>> UpdateAsync(Person value, Guid id, HttpRequestOptions? requestOptions = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Updates an existing <see cref="Person"/>.
    /// </summary>
    /// <param name="value">The <see cref="Person"/>.</param>
    /// <param name="id">The <see cref="Person"/> identifier.</param>
    /// <param name="requestOptions">The optional <see cref="HttpRequestOptions"/>.</param>
    /// <param name="cancellationToken">The <see cref="CancellationToken"/>.</param>
    /// <returns>A <see cref="HttpResult"/>.</returns>
    Task<HttpResult<Person>> UpdateWithRollbackAsync(Person value, Guid id, HttpRequestOptions? requestOptions = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Patches an existing <see cref="Person"/>.
    /// </summary>
    /// <param name="patchOption">The <see cref="HttpPatchOption"/>.</param>
    /// <param name="value">The <see cref="string"/> that contains the patch content for the <see cref="Person"/>.</param>
    /// <param name="id">The <see cref="Person"/> identifier.</param>
    /// <param name="requestOptions">The optional <see cref="HttpRequestOptions"/>.</param>
    /// <param name="cancellationToken">The <see cref="CancellationToken"/>.</param>
    /// <returns>A <see cref="HttpResult"/>.</returns>
    Task<HttpResult<Person>> PatchAsync(HttpPatchOption patchOption, string value, Guid id, HttpRequestOptions? requestOptions = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Gets the <see cref="PersonCollectionResult"/> that contains the items that match the selection criteria.
    /// </summary>
    /// <param name="paging">The <see cref="PagingArgs"/>.</param>
    /// <param name="requestOptions">The optional <see cref="HttpRequestOptions"/>.</param>
    /// <param name="cancellationToken">The <see cref="CancellationToken"/>.</param>
    /// <returns>A <see cref="HttpResult"/>.</returns>
    Task<HttpResult<PersonCollectionResult>> GetAllAsync(PagingArgs? paging = null, HttpRequestOptions? requestOptions = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Gets the <see cref="PersonCollectionResult"/> that contains the items that match the selection criteria.
    /// </summary>
    /// <param name="requestOptions">The optional <see cref="HttpRequestOptions"/>.</param>
    /// <param name="cancellationToken">The <see cref="CancellationToken"/>.</param>
    /// <returns>A <see cref="HttpResult"/>.</returns>
    Task<HttpResult<PersonCollectionResult>> GetAll2Async(HttpRequestOptions? requestOptions = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Gets the <see cref="PersonCollectionResult"/> that contains the items that match the selection criteria.
    /// </summary>
    /// <param name="args">The Args (see <see cref="PersonArgs"/>).</param>
    /// <param name="paging">The <see cref="PagingArgs"/>.</param>
    /// <param name="requestOptions">The optional <see cref="HttpRequestOptions"/>.</param>
    /// <param name="cancellationToken">The <see cref="CancellationToken"/>.</param>
    /// <returns>A <see cref="HttpResult"/>.</returns>
    Task<HttpResult<PersonCollectionResult>> GetByArgsAsync(PersonArgs? args, PagingArgs? paging = null, HttpRequestOptions? requestOptions = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Gets the <see cref="PersonDetailCollectionResult"/> that contains the items that match the selection criteria.
    /// </summary>
    /// <param name="args">The Args (see <see cref="PersonArgs"/>).</param>
    /// <param name="paging">The <see cref="PagingArgs"/>.</param>
    /// <param name="requestOptions">The optional <see cref="HttpRequestOptions"/>.</param>
    /// <param name="cancellationToken">The <see cref="CancellationToken"/>.</param>
    /// <returns>A <see cref="HttpResult"/>.</returns>
    Task<HttpResult<PersonDetailCollectionResult>> GetDetailByArgsAsync(PersonArgs? args, PagingArgs? paging = null, HttpRequestOptions? requestOptions = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Merge first <see cref="Person"/> into second.
    /// </summary>
    /// <param name="fromId">The from <see cref="Person"/> identifier.</param>
    /// <param name="toId">The to <see cref="Person"/> identifier.</param>
    /// <param name="requestOptions">The optional <see cref="HttpRequestOptions"/>.</param>
    /// <param name="cancellationToken">The <see cref="CancellationToken"/>.</param>
    /// <returns>A <see cref="HttpResult"/>.</returns>
    Task<HttpResult<Person>> MergeAsync(Guid fromId, Guid toId, HttpRequestOptions? requestOptions = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Mark <see cref="Person"/>.
    /// </summary>
    /// <param name="requestOptions">The optional <see cref="HttpRequestOptions"/>.</param>
    /// <param name="cancellationToken">The <see cref="CancellationToken"/>.</param>
    /// <returns>A <see cref="HttpResult"/>.</returns>
    Task<HttpResult> MarkAsync(HttpRequestOptions? requestOptions = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get <see cref="Person"/> at specified <see cref="MapCoordinates"/>.
    /// </summary>
    /// <param name="args">The Args (see <see cref="MapArgs"/>).</param>
    /// <param name="requestOptions">The optional <see cref="HttpRequestOptions"/>.</param>
    /// <param name="cancellationToken">The <see cref="CancellationToken"/>.</param>
    /// <returns>A <see cref="HttpResult"/>.</returns>
    Task<HttpResult<MapCoordinates>> MapAsync(MapArgs? args, HttpRequestOptions? requestOptions = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get no arguments.
    /// </summary>
    /// <param name="requestOptions">The optional <see cref="HttpRequestOptions"/>.</param>
    /// <param name="cancellationToken">The <see cref="CancellationToken"/>.</param>
    /// <returns>A <see cref="HttpResult"/>.</returns>
    Task<HttpResult<Person?>> GetNoArgsAsync(HttpRequestOptions? requestOptions = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Gets the specified <see cref="PersonDetail"/>.
    /// </summary>
    /// <param name="id">The <see cref="Person"/> identifier.</param>
    /// <param name="requestOptions">The optional <see cref="HttpRequestOptions"/>.</param>
    /// <param name="cancellationToken">The <see cref="CancellationToken"/>.</param>
    /// <returns>A <see cref="HttpResult"/>.</returns>
    Task<HttpResult<PersonDetail?>> GetDetailAsync(Guid id, HttpRequestOptions? requestOptions = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Updates an existing <see cref="PersonDetail"/>.
    /// </summary>
    /// <param name="value">The <see cref="PersonDetail"/>.</param>
    /// <param name="id">The <see cref="Person"/> identifier.</param>
    /// <param name="requestOptions">The optional <see cref="HttpRequestOptions"/>.</param>
    /// <param name="cancellationToken">The <see cref="CancellationToken"/>.</param>
    /// <returns>A <see cref="HttpResult"/>.</returns>
    Task<HttpResult<PersonDetail>> UpdateDetailAsync(PersonDetail value, Guid id, HttpRequestOptions? requestOptions = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Patches an existing <see cref="PersonDetail"/>.
    /// </summary>
    /// <param name="patchOption">The <see cref="HttpPatchOption"/>.</param>
    /// <param name="value">The <see cref="string"/> that contains the patch content for the <see cref="PersonDetail"/>.</param>
    /// <param name="id">The <see cref="Person"/> identifier.</param>
    /// <param name="requestOptions">The optional <see cref="HttpRequestOptions"/>.</param>
    /// <param name="cancellationToken">The <see cref="CancellationToken"/>.</param>
    /// <returns>A <see cref="HttpResult"/>.</returns>
    Task<HttpResult<PersonDetail>> PatchDetailAsync(HttpPatchOption patchOption, string value, Guid id, HttpRequestOptions? requestOptions = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Actually validating the FromBody parameter generation.
    /// </summary>
    /// <param name="person">The Person (see <see cref="Person"/>).</param>
    /// <param name="requestOptions">The optional <see cref="HttpRequestOptions"/>.</param>
    /// <param name="cancellationToken">The <see cref="CancellationToken"/>.</param>
    /// <returns>A <see cref="HttpResult"/>.</returns>
    Task<HttpResult> AddAsync(Person person, HttpRequestOptions? requestOptions = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Actually validating the AcceptBody parameter generation.
    /// </summary>
    /// <param name="person">The Person (see <see cref="Person"/>).</param>
    /// <param name="requestOptions">The optional <see cref="HttpRequestOptions"/>.</param>
    /// <param name="cancellationToken">The <see cref="CancellationToken"/>.</param>
    /// <returns>A <see cref="HttpResult"/>.</returns>
    Task<HttpResult> Add2Async(Person person, HttpRequestOptions? requestOptions = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Actually validating the Custom with Value parameter generation.
    /// </summary>
    /// <param name="value">The <see cref="Person"/>.</param>
    /// <param name="requestOptions">The optional <see cref="HttpRequestOptions"/>.</param>
    /// <param name="cancellationToken">The <see cref="CancellationToken"/>.</param>
    /// <returns>A <see cref="HttpResult"/>.</returns>
    Task<HttpResult> Add3Async(Person value, HttpRequestOptions? requestOptions = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Validate CustomManagerOnly.
    /// </summary>
    /// <param name="requestOptions">The optional <see cref="HttpRequestOptions"/>.</param>
    /// <param name="cancellationToken">The <see cref="CancellationToken"/>.</param>
    /// <returns>A <see cref="HttpResult"/>.</returns>
    Task<HttpResult> CustomManagerOnlyAsync(HttpRequestOptions? requestOptions = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get Null.
    /// </summary>
    /// <param name="name">The Name.</param>
    /// <param name="names">The Names.</param>
    /// <param name="requestOptions">The optional <see cref="HttpRequestOptions"/>.</param>
    /// <param name="cancellationToken">The <see cref="CancellationToken"/>.</param>
    /// <returns>A <see cref="HttpResult"/>.</returns>
    Task<HttpResult<Person?>> GetNullAsync(string? name, List<string>? names, HttpRequestOptions? requestOptions = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Validate when an Event is published but not sent.
    /// </summary>
    /// <param name="value">The <see cref="Person"/>.</param>
    /// <param name="requestOptions">The optional <see cref="HttpRequestOptions"/>.</param>
    /// <param name="cancellationToken">The <see cref="CancellationToken"/>.</param>
    /// <returns>A <see cref="HttpResult"/>.</returns>
    Task<HttpResult<Person>> EventPublishNoSendAsync(Person value, HttpRequestOptions? requestOptions = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Gets the <see cref="PersonCollectionResult"/> that contains the items that match the selection criteria.
    /// </summary>
    /// <param name="args">The Args (see <see cref="PersonArgs"/>).</param>
    /// <param name="paging">The <see cref="PagingArgs"/>.</param>
    /// <param name="requestOptions">The optional <see cref="HttpRequestOptions"/>.</param>
    /// <param name="cancellationToken">The <see cref="CancellationToken"/>.</param>
    /// <returns>A <see cref="HttpResult"/>.</returns>
    Task<HttpResult<PersonCollectionResult>> GetByArgsWithEfAsync(PersonArgs? args, PagingArgs? paging = null, HttpRequestOptions? requestOptions = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Throw Error.
    /// </summary>
    /// <param name="requestOptions">The optional <see cref="HttpRequestOptions"/>.</param>
    /// <param name="cancellationToken">The <see cref="CancellationToken"/>.</param>
    /// <returns>A <see cref="HttpResult"/>.</returns>
    Task<HttpResult> ThrowErrorAsync(HttpRequestOptions? requestOptions = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Invoke Api Via Agent.
    /// </summary>
    /// <param name="id">The <see cref="Person"/> identifier.</param>
    /// <param name="requestOptions">The optional <see cref="HttpRequestOptions"/>.</param>
    /// <param name="cancellationToken">The <see cref="CancellationToken"/>.</param>
    /// <returns>A <see cref="HttpResult"/>.</returns>
    Task<HttpResult<string>> InvokeApiViaAgentAsync(Guid id, HttpRequestOptions? requestOptions = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Param Coll.
    /// </summary>
    /// <param name="addresses">The Addresses.</param>
    /// <param name="requestOptions">The optional <see cref="HttpRequestOptions"/>.</param>
    /// <param name="cancellationToken">The <see cref="CancellationToken"/>.</param>
    /// <returns>A <see cref="HttpResult"/>.</returns>
    Task<HttpResult> ParamCollAsync(AddressCollection? addresses, HttpRequestOptions? requestOptions = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Gets the specified <see cref="Person"/>.
    /// </summary>
    /// <param name="id">The <see cref="Person"/> identifier.</param>
    /// <param name="requestOptions">The optional <see cref="HttpRequestOptions"/>.</param>
    /// <param name="cancellationToken">The <see cref="CancellationToken"/>.</param>
    /// <returns>A <see cref="HttpResult"/>.</returns>
    Task<HttpResult<Person?>> GetWithEfAsync(Guid id, HttpRequestOptions? requestOptions = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Creates a new <see cref="Person"/>.
    /// </summary>
    /// <param name="value">The <see cref="Person"/>.</param>
    /// <param name="requestOptions">The optional <see cref="HttpRequestOptions"/>.</param>
    /// <param name="cancellationToken">The <see cref="CancellationToken"/>.</param>
    /// <returns>A <see cref="HttpResult"/>.</returns>
    Task<HttpResult<Person>> CreateWithEfAsync(Person value, HttpRequestOptions? requestOptions = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Updates an existing <see cref="Person"/>.
    /// </summary>
    /// <param name="value">The <see cref="Person"/>.</param>
    /// <param name="id">The <see cref="Person"/> identifier.</param>
    /// <param name="requestOptions">The optional <see cref="HttpRequestOptions"/>.</param>
    /// <param name="cancellationToken">The <see cref="CancellationToken"/>.</param>
    /// <returns>A <see cref="HttpResult"/>.</returns>
    Task<HttpResult<Person>> UpdateWithEfAsync(Person value, Guid id, HttpRequestOptions? requestOptions = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Deletes the specified <see cref="Person"/>.
    /// </summary>
    /// <param name="id">The <see cref="Person"/> identifier.</param>
    /// <param name="requestOptions">The optional <see cref="HttpRequestOptions"/>.</param>
    /// <param name="cancellationToken">The <see cref="CancellationToken"/>.</param>
    /// <returns>A <see cref="HttpResult"/>.</returns>
    Task<HttpResult> DeleteWithEfAsync(Guid id, HttpRequestOptions? requestOptions = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Patches an existing <see cref="Person"/>.
    /// </summary>
    /// <param name="patchOption">The <see cref="HttpPatchOption"/>.</param>
    /// <param name="value">The <see cref="string"/> that contains the patch content for the <see cref="Person"/>.</param>
    /// <param name="id">The <see cref="Person"/> identifier.</param>
    /// <param name="requestOptions">The optional <see cref="HttpRequestOptions"/>.</param>
    /// <param name="cancellationToken">The <see cref="CancellationToken"/>.</param>
    /// <returns>A <see cref="HttpResult"/>.</returns>
    Task<HttpResult<Person>> PatchWithEfAsync(HttpPatchOption patchOption, string value, Guid id, HttpRequestOptions? requestOptions = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get Documentation.
    /// </summary>
    /// <param name="id">The <see cref="Person"/> identifier.</param>
    /// <param name="requestOptions">The optional <see cref="HttpRequestOptions"/>.</param>
    /// <param name="cancellationToken">The <see cref="CancellationToken"/>.</param>
    /// <returns>A <see cref="HttpResult"/>.</returns>
    Task<HttpResult> GetDocumentationAsync(Guid id, HttpRequestOptions? requestOptions = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Simulate Work.
    /// </summary>
    /// <param name="id">The <see cref="Person"/> identifier.</param>
    /// <param name="requestOptions">The optional <see cref="HttpRequestOptions"/>.</param>
    /// <param name="cancellationToken">The <see cref="CancellationToken"/>.</param>
    /// <returns>A <see cref="HttpResult"/>.</returns>
    Task<HttpResult<string?>> SimulateWorkAsync(Guid id, HttpRequestOptions? requestOptions = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Extend Response.
    /// </summary>
    /// <param name="name">The Name.</param>
    /// <param name="requestOptions">The optional <see cref="HttpRequestOptions"/>.</param>
    /// <param name="cancellationToken">The <see cref="CancellationToken"/>.</param>
    /// <returns>A <see cref="HttpResult"/>.</returns>
    Task<HttpResult<string?>> ExtendResponseAsync(string? name, HttpRequestOptions? requestOptions = null, CancellationToken cancellationToken = default);
}

#pragma warning restore
#nullable restore