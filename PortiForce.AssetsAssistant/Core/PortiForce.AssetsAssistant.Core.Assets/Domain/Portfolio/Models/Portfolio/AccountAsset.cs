using PortiForce.AssetsAssistant.Core.Assets.Domain.Actor.Models;
using PortiForce.AssetsAssistant.Core.Assets.Domain.Portfolio.Models.Assets;
using PortiForce.AssetsAssistant.Core.Assets.Enums;

namespace PortiForce.AssetsAssistant.Core.Assets.Domain.Portfolio.Models.Portfolio;

public sealed class AccountAsset
{
    public Guid AccountId { get; set; }

    public Account? Account { get; set; } = default!;

    public int AssetId { get; set; }

    public Asset? Asset { get; set; } = default!;

    public EntityState State { get; set; } = EntityState.Draft;

    public Quantity Quantity { get; set; }

    public required PriceQuote AssetQuote { get; set; }
}
