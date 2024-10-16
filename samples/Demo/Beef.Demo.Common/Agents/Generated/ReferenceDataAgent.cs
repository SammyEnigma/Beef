/*
 * This file is automatically generated; any changes will be lost. 
 */

#nullable enable
#pragma warning disable

namespace Beef.Demo.Common.Agents;

/// <summary>
/// Provides the <b>ReferenceData</b> HTTP agent.
/// </summary>
public partial class ReferenceDataAgent : TypedHttpClientBase<ReferenceDataAgent>, IReferenceDataAgent
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ReferenceDataAgent"/> class.
    /// </summary>
    /// <param name="client">The underlying <see cref="HttpClient"/>.</param>
    /// <param name="jsonSerializer">The optional <see cref="IJsonSerializer"/>.</param>
    /// <param name="executionContext">The optional <see cref="CoreEx.ExecutionContext"/>.</param>
    public ReferenceDataAgent(HttpClient client, IJsonSerializer? jsonSerializer = null, CoreEx.ExecutionContext? executionContext = null) : base(client, jsonSerializer, executionContext) { }

    /// <inheritdoc/>
    public Task<HttpResult<RefDataNamespace.CountryCollection>> CountryGetAllAsync(ReferenceDataFilter? args = null, HttpRequestOptions? requestOptions = null, CancellationToken cancellationToken = default)
        => GetAsync<RefDataNamespace.CountryCollection>("api/v1/demo/ref/countries", requestOptions: requestOptions, args: HttpArgs.Create(new HttpArg<ReferenceDataFilter>("args", args!, HttpArgType.FromUriUseProperties)), cancellationToken);      

    /// <inheritdoc/>
    public Task<HttpResult<RefDataNamespace.USStateCollection>> USStateGetAllAsync(ReferenceDataFilter? args = null, HttpRequestOptions? requestOptions = null, CancellationToken cancellationToken = default)
        => GetAsync<RefDataNamespace.USStateCollection>("api/v1/demo/ref/usStates", requestOptions: requestOptions, args: HttpArgs.Create(new HttpArg<ReferenceDataFilter>("args", args!, HttpArgType.FromUriUseProperties)), cancellationToken);      

    /// <inheritdoc/>
    public Task<HttpResult<RefDataNamespace.GenderCollection>> GenderGetAllAsync(ReferenceDataFilter? args = null, HttpRequestOptions? requestOptions = null, CancellationToken cancellationToken = default)
        => GetAsync<RefDataNamespace.GenderCollection>("api/v1/demo/ref/genders", requestOptions: requestOptions, args: HttpArgs.Create(new HttpArg<ReferenceDataFilter>("args", args!, HttpArgType.FromUriUseProperties)), cancellationToken);      

    /// <inheritdoc/>
    public Task<HttpResult<RefDataNamespace.EyeColorCollection>> EyeColorGetAllAsync(ReferenceDataFilter? args = null, HttpRequestOptions? requestOptions = null, CancellationToken cancellationToken = default)
        => GetAsync<RefDataNamespace.EyeColorCollection>("api/v1/demo/ref/eyeColors", requestOptions: requestOptions, args: HttpArgs.Create(new HttpArg<ReferenceDataFilter>("args", args!, HttpArgType.FromUriUseProperties)), cancellationToken);      

    /// <inheritdoc/>
    public Task<HttpResult<RefDataNamespace.PowerSourceCollection>> PowerSourceGetAllAsync(ReferenceDataFilter? args = null, HttpRequestOptions? requestOptions = null, CancellationToken cancellationToken = default)
        => GetAsync<RefDataNamespace.PowerSourceCollection>("api/v1/demo/ref/powerSources", requestOptions: requestOptions, args: HttpArgs.Create(new HttpArg<ReferenceDataFilter>("args", args!, HttpArgType.FromUriUseProperties)), cancellationToken);      

    /// <inheritdoc/>
    public Task<HttpResult<RefDataNamespace.CompanyCollection>> CompanyGetAllAsync(ReferenceDataFilter? args = null, HttpRequestOptions? requestOptions = null, CancellationToken cancellationToken = default)
        => GetAsync<RefDataNamespace.CompanyCollection>("api/v1/demo/ref/companies", requestOptions: requestOptions, args: HttpArgs.Create(new HttpArg<ReferenceDataFilter>("args", args!, HttpArgType.FromUriUseProperties)), cancellationToken);      

    /// <inheritdoc/>
    public Task<HttpResult<RefDataNamespace.StatusCollection>> StatusGetAllAsync(ReferenceDataFilter? args = null, HttpRequestOptions? requestOptions = null, CancellationToken cancellationToken = default)
        => GetAsync<RefDataNamespace.StatusCollection>("api/v1/demo/ref/statuses", requestOptions: requestOptions, args: HttpArgs.Create(new HttpArg<ReferenceDataFilter>("args", args!, HttpArgType.FromUriUseProperties)), cancellationToken);      

    /// <inheritdoc/>
    public Task<HttpResult<RefDataNamespace.CommunicationTypeCollection>> CommunicationTypeGetAllAsync(ReferenceDataFilter? args = null, HttpRequestOptions? requestOptions = null, CancellationToken cancellationToken = default)
        => GetAsync<RefDataNamespace.CommunicationTypeCollection>("api/v1/demo/ref/communicationTypes", requestOptions: requestOptions, args: HttpArgs.Create(new HttpArg<ReferenceDataFilter>("args", args!, HttpArgType.FromUriUseProperties)), cancellationToken);      

    /// <inheritdoc/>
    public Task<HttpResult> GetNamedAsync(string[] names, HttpRequestOptions? requestOptions = null, CancellationToken cancellationToken = default)
    {
        var ro = requestOptions ?? new HttpRequestOptions();
        if (names != null)
            ro.UrlQueryString += string.Join("&", names);
            
        return GetAsync("api/v1/demo/ref", ro, null, cancellationToken);
    }
}

#pragma warning restore
#nullable restore