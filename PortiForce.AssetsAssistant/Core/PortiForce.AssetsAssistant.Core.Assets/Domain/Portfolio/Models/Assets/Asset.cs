using PortiForce.AssetsAssistant.Core.Assets.Domain.Portfolio.Enums;
using PortiForce.AssetsAssistant.Core.Assets.Enums;
using PortiForce.AssetsAssistant.Core.Assets.Interfaces;

namespace PortiForce.AssetsAssistant.Core.Assets.Domain.Portfolio.Models.Assets;

/// <summary>
/// Unit of tradeable/measureable asset.
/// </summary>
public sealed class Asset : ICommonEntity<int>
{
    public int Id { get; set; }

    public required string Symbol { get; set; }   

    public required string Name { get; set; }

    public AssetType AssetType { get; set; }

    /// <summary>
    /// Om-chain precision for this asset (if applicable).
    /// </summary>
    public byte? NativeDecimals { get; set; }

    public EntityState State { get; set; }

	public string EntityType => "ast";
}
