/*
 * This file is automatically generated; any changes will be lost. 
 */

#nullable enable
#pragma warning disable

namespace Beef.Demo.Business.Entities;

/// <summary>
/// Represents the <see cref="Person"/> arguments entity.
/// </summary>
public partial class PersonArgs : EntityBase, ICacheKey
{
    private string? _firstName;
    private string? _lastName;
    private List<string?>? _gendersSids;
    private Common.Entities.OrderBy? _orderBy;

    /// <summary>
    /// Gets or sets the First Name.
    /// </summary>
    public string? FirstName { get => _firstName; set => SetValue(ref _firstName, value); }

    /// <summary>
    /// Gets or sets the Last Name.
    /// </summary>
    public string? LastName { get => _lastName; set => SetValue(ref _lastName, value); }

    /// <summary>
    /// Gets or sets the <see cref="Genders"/> list using the underlying Serialization Identifier (SID).
    /// </summary>
    [JsonPropertyName("genders")]
    public List<string?>? GendersSids { get => _gendersSids; set => SetValue(ref _gendersSids, value, propertyName: nameof(Genders)); }

    /// <summary>
    /// Gets or sets the Genders (see <see cref="RefDataNamespace.Gender"/>).
    /// </summary>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [JsonIgnore]
    public ReferenceDataCodeList<RefDataNamespace.Gender>? Genders { get => new(ref _gendersSids); set => SetValue(ref _gendersSids, value?.ToCodeList(), propertyName: nameof(Genders)); }

    /// <summary>
    /// Gets or sets the Order By.
    /// </summary>
    public Common.Entities.OrderBy? OrderBy { get => _orderBy; set => SetValue(ref _orderBy, value); }

    /// <summary>
    /// Creates the <see cref="ICacheKey.CacheKey"/>.
    /// </summary>
    /// <param name="firstName">The <see cref="FirstName"/>.</param>
    /// <param name="lastName">The <see cref="LastName"/>.</param>
    /// <returns>The Cache Key.</returns>
    public static CompositeKey CreateCacheKey(string? firstName, string? lastName) => CompositeKey.Create(firstName, lastName);

    /// <summary>
    /// Gets the Cache Key (consists of the following property(s): <see cref="FirstName"/>, <see cref="LastName"/>).
    /// </summary>
    [JsonIgnore]
    public CompositeKey CacheKey => CreateCacheKey(FirstName, LastName);

    /// <inheritdoc/>
    protected override IEnumerable<IPropertyValue> GetPropertyValues()
    {
        yield return CreateProperty(nameof(FirstName), FirstName, v => FirstName = v);
        yield return CreateProperty(nameof(LastName), LastName, v => LastName = v);
        yield return CreateProperty(nameof(Genders), GendersSids, v => GendersSids = v);
        yield return CreateProperty(nameof(OrderBy), OrderBy, v => OrderBy = v);
    }
}

#pragma warning restore
#nullable restore