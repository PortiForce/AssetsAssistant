namespace PortiForce.AssetsAssistant.Core.Assets.Domain.Portfolio.Models;

public sealed record QuoteWithTimestamp
{
    public int QuoteAssetId { get; set; }

    public decimal PricePerUnit { get; set; }

    public DateTimeOffset TimeSnaphot { get; set; }
}
