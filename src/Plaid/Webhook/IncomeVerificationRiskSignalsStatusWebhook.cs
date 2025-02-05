namespace Going.Plaid.Webhook;

/// <summary>
/// <para>Fired when a risk signal is available for documents uploaded via Document Income. It will typically take a minute or two for this webhook to fire after the end user has uploaded their documents in the Document Income flow. Once this webhook has fired, <c>/credit/payroll_income/risk_signals/get</c> may then be called to retrieve risk data.</para>
/// </summary>
public record IncomeVerificationRiskSignalsStatusWebhook : WebhookBase
{
	/// <inheritdoc />
	[JsonPropertyName("webhook_type")]
	public override WebhookType WebhookType => WebhookType.Income;

	/// <inheritdoc />
	[JsonPropertyName("webhook_code")]
	public override WebhookCode WebhookCode => WebhookCode.IncomeVerificationRiskSignals;

	/// <summary>
	/// <para>The Item ID associated with the verification.</para>
	/// </summary>
	[JsonPropertyName("item_id")]
	public string ItemId { get; init; } = default!;

	/// <summary>
	/// <para>The Plaid <c>user_id</c> of the User associated with this webhook, warning, or error.</para>
	/// </summary>
	[JsonPropertyName("user_id")]
	public string? UserId { get; init; } = default!;

	/// <summary>
	/// <para><c>RISK_SIGNALS_PROCESSING_COMPLETE</c>: The income verification fraud detection processing has completed. If the user uploaded multiple documents, this webhook will fire when all documents have finished processing. Call the <c>/credit/payroll_income/risk_signals/get</c> endpoint to get all risk signal data.</para>
	/// </summary>
	[JsonPropertyName("risk_signals_status")]
	public string? RiskSignalsStatus { get; init; } = default!;
}