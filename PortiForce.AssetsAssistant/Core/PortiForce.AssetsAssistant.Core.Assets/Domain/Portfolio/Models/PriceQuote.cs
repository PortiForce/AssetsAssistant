using PortiForce.AssetsAssistant.Core.Assets.Domain.Portfolio.Models.Assets;

namespace PortiForce.AssetsAssistant.Core.Assets.Domain.Portfolio.Models;

public sealed record PriceQuote
{
    public int QuoteAssetId { get; init; }

    public decimal PricePerUnit { get; init; }
}