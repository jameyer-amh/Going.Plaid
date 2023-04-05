namespace Going.Plaid.Entity;

/// <summary>
/// <para>The amount and currency of a payment</para>
/// </summary>
public record PaymentAmountRefunded
{
	/// <summary>
	/// <para>The ISO-4217 currency code of the payment. For standing orders and payment consents, <c>"GBP"</c> must be used.</para>
	/// </summary>
	[JsonPropertyName("currency")]
	public Entity.PaymentAmountCurrency? Currency { get; init; } = default!;

	/// <summary>
	/// <para>The amount of the payment. Must contain at most two digits of precision e.g. <c>1.23</c>.</para>
	/// </summary>
	[JsonPropertyName("value")]
	public decimal? Value { get; init; } = default!;
}