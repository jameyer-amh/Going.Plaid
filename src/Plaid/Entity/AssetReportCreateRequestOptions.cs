namespace Going.Plaid.Entity;

/// <summary>
/// <para>An optional object to filter <c>/asset_report/create</c> results. If provided, must be non-<c>null</c>. The optional <c>user</c> object is required for the report to be eligible for Fannie Mae's Day 1 Certainty program.</para>
/// </summary>
public class AssetReportCreateRequestOptions
{
	/// <summary>
	/// <para>Client-generated identifier, which can be used by lenders to track loan applications.</para>
	/// </summary>
	[JsonPropertyName("client_report_id")]
	public string? ClientReportId { get; set; } = default!;

	/// <summary>
	/// <para>URL to which Plaid will send Assets webhooks, for example when the requested Asset Report is ready.</para>
	/// </summary>
	[JsonPropertyName("webhook")]
	public string? Webhook { get; set; } = default!;

	/// <summary>
	/// <para>true to return balance and identity earlier as a fast report. Defaults to false if omitted.</para>
	/// </summary>
	[JsonPropertyName("include_fast_report")]
	public bool? IncludeFastReport { get; set; } = default!;

	/// <summary>
	/// <para>Additional information that can be included in the asset report. Possible values: <c>"investments"</c></para>
	/// </summary>
	[JsonPropertyName("products")]
	public IReadOnlyList<string>? Products { get; set; } = default!;

	/// <summary>
	/// <para>Use this field to request a <c>fast_asset</c> report. When Fast Assets is requested, Plaid will create two versions of the Asset Report: first, the Fast Asset Report, which will contain only current identity and balance information, and later, the Full Asset Report, which will also contain historical balance information and transaction data. A <c>PRODUCT_READY</c> webhook will be fired for each Asset Report when it is ready, and the <c>report_type</c> field will indicate whether the webhook is firing for the <c>full</c> or <c>fast</c> Asset Report. To retrieve the Fast Asset Report, call <c>/asset_report/get</c> with <c>fast_report</c> set to <c>true</c>. There is no additional charge for using Fast Assets.</para>
	/// </summary>
	[JsonPropertyName("add_ons")]
	public IReadOnlyList<Entity.AssetReportAddOns>? AddOns { get; set; } = default!;

	/// <summary>
	/// <para>The user object allows you to provide additional information about the user to be appended to the Asset Report. All fields are optional. The <c>first_name</c>, <c>last_name</c>, and <c>ssn</c> fields are required if you would like the Report to be eligible for Fannie Mae’s Day 1 Certainty™ program.</para>
	/// </summary>
	[JsonPropertyName("user")]
	public Entity.AssetReportUser? User { get; set; } = default!;
}