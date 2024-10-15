/*
 * This file is automatically generated; any changes will be lost. 
 */

namespace Cdr.Banking.Business.Entities;

/// <summary>
/// Represents the Account entity.
/// </summary>
public partial class Account : EntityBase, IIdentifier<string>
{
    private string? _id;
    private DateTime _creationDate;
    private string? _displayName;
    private string? _nickname;
    private string? _openStatusSid;
    private bool _isOwned;
    private string? _maskedNumber;
    private string? _productCategorySid;
    private string? _productName;

    /// <summary>
    /// Gets or sets the <see cref="Account"/> identifier.
    /// </summary>
    [JsonPropertyName("accountId")]
    public string? Id { get => _id; set => SetValue(ref _id, value); }

    /// <summary>
    /// Gets or sets the Creation Date.
    /// </summary>
    public DateTime CreationDate { get => _creationDate; set => SetValue(ref _creationDate, value, transform: DateTimeTransform.DateOnly); }

    /// <summary>
    /// Gets or sets the Display Name.
    /// </summary>
    public string? DisplayName { get => _displayName; set => SetValue(ref _displayName, value); }

    /// <summary>
    /// Gets or sets the Nickname.
    /// </summary>
    public string? Nickname { get => _nickname; set => SetValue(ref _nickname, value); }

    /// <summary>
    /// Gets or sets the <see cref="OpenStatus"/> using the underlying Serialization Identifier (SID).
    /// </summary>
    [JsonPropertyName("openStatus")]
    public string? OpenStatusSid { get => _openStatusSid; set => SetValue(ref _openStatusSid, value, propertyName: nameof(OpenStatus)); }

    /// <summary>
    /// Gets or sets the Open Status (see <see cref="RefDataNamespace.OpenStatus"/>).
    /// </summary>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [JsonIgnore]
    public RefDataNamespace.OpenStatus? OpenStatus { get => _openStatusSid; set => SetValue(ref _openStatusSid, value); }

    /// <summary>
    /// Indicates whether Is Owned.
    /// </summary>
    public bool IsOwned { get => _isOwned; set => SetValue(ref _isOwned, value); }

    /// <summary>
    /// Gets or sets the Masked Number.
    /// </summary>
    public string? MaskedNumber { get => _maskedNumber; set => SetValue(ref _maskedNumber, value); }

    /// <summary>
    /// Gets or sets the <see cref="ProductCategory"/> using the underlying Serialization Identifier (SID).
    /// </summary>
    [JsonPropertyName("productCategory")]
    public string? ProductCategorySid { get => _productCategorySid; set => SetValue(ref _productCategorySid, value, propertyName: nameof(ProductCategory)); }

    /// <summary>
    /// Gets or sets the Product Category (see <see cref="RefDataNamespace.ProductCategory"/>).
    /// </summary>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [JsonIgnore]
    public RefDataNamespace.ProductCategory? ProductCategory { get => _productCategorySid; set => SetValue(ref _productCategorySid, value); }

    /// <summary>
    /// Gets or sets the Product Name.
    /// </summary>
    public string? ProductName { get => _productName; set => SetValue(ref _productName, value); }

    /// <inheritdoc/>
    protected override IEnumerable<IPropertyValue> GetPropertyValues()
    {
        yield return CreateProperty(nameof(Id), Id, v => Id = v);
        yield return CreateProperty(nameof(CreationDate), CreationDate, v => CreationDate = v);
        yield return CreateProperty(nameof(DisplayName), DisplayName, v => DisplayName = v);
        yield return CreateProperty(nameof(Nickname), Nickname, v => Nickname = v);
        yield return CreateProperty(nameof(OpenStatus), OpenStatusSid, v => OpenStatusSid = v);
        yield return CreateProperty(nameof(IsOwned), IsOwned, v => IsOwned = v);
        yield return CreateProperty(nameof(MaskedNumber), MaskedNumber, v => MaskedNumber = v);
        yield return CreateProperty(nameof(ProductCategory), ProductCategorySid, v => ProductCategorySid = v);
        yield return CreateProperty(nameof(ProductName), ProductName, v => ProductName = v);
    }
}

/// <summary>
/// Represents the <see cref="Account"/> collection.
/// </summary>
public partial class AccountCollection : EntityBaseCollection<Account, AccountCollection>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AccountCollection"/> class.
    /// </summary>
    public AccountCollection() { }

    /// <summary>
    /// Initializes a new instance of the <see cref="AccountCollection"/> class with <paramref name="items"/> to add.
    /// </summary>
    /// <param name="items">The items to add.</param>
    public AccountCollection(IEnumerable<Account> items) => AddRange(items);
}

/// <summary>
/// Represents the <see cref="Account"/> collection result.
/// </summary>
public class AccountCollectionResult : EntityCollectionResult<AccountCollection, Account, AccountCollectionResult>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AccountCollectionResult"/> class.
    /// </summary>
    public AccountCollectionResult() { }
        
    /// <summary>
    /// Initializes a new instance of the <see cref="AccountCollectionResult"/> class with <paramref name="paging"/>.
    /// </summary>
    /// <param name="paging">The <see cref="PagingArgs"/>.</param>
    public AccountCollectionResult(PagingArgs? paging) : base(paging) { }
        
    /// <summary>
    /// Initializes a new instance of the <see cref="AccountCollectionResult"/> class with <paramref name="items"/> to add.
    /// </summary>
    /// <param name="items">The items to add.</param>
    /// <param name="paging">The optional <see cref="PagingArgs"/>.</param>
    public AccountCollectionResult(IEnumerable<Account> items, PagingArgs? paging = null) : base(paging) => Items.AddRange(items);
}