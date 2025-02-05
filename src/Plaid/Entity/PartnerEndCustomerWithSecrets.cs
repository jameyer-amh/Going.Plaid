namespace Going.Plaid.Entity;

/// <summary>
/// <para>The details for the newly created end customer, including secrets for non-Production environments.</para>
/// </summary>
public record PartnerEndCustomerWithSecrets
{
	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("client_id")]
	public string? ClientId { get; init; } = default!;

	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("company_name")]
	public string? CompanyName { get; init; } = default!;

	/// <summary>
	/// <para>The status of the given end customer.</para>
	/// </summary>
	[JsonPropertyName("status")]
	public Entity.PartnerEndCustomerStatus? Status { get; init; } = default!;

	/// <summary>
	/// <para>The secrets for the newly created end customer in non-Production environments.</para>
	/// </summary>
	[JsonPropertyName("secrets")]
	public Entity.PartnerEndCustomerSecrets? Secrets { get; init; } = default!;
}