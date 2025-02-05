namespace Going.Plaid.Transfer;

/// <summary>
/// <para>Defines the request schema for <c>/transfer/refund/get</c></para>
/// </summary>
public partial class TransferRefundGetRequest : RequestBase
{
	/// <summary>
	/// <para>Plaid’s unique identifier for a refund.</para>
	/// </summary>
	[JsonPropertyName("refund_id")]
	public string RefundId { get; set; } = default!;
}