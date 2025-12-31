using PortiForce.AssetsAssistant.Core.Assets.Domain.Portfolio.Enums;
using PortiForce.AssetsAssistant.Core.Assets.Domain.Portfolio.Models.Assets;
using PortiForce.AssetsAssistant.Core.Assets.Enums;
using PortiForce.AssetsAssistant.Core.Assets.Interfaces;

namespace PortiForce.AssetsAssistant.Core.Assets.Domain.Portfolio.Models.AssetOperations;

public sealed class TransferLeg : ICommonEntity<Guid>
{
    public Guid Id { get; set; }

    public Guid AssetTransferId { get; set; }

    /// <summary>
    /// Reference to the parent asset transfer operation
    /// </summary>
    public AssetTransfer? AssetTransfer { get; set; }

    public int AssetId { get; set; }

    public Asset? Asset { get; set; }

    /// <summary>
    /// Amount of the asset involved in atomic operation (Positive for income, negative for outcome)
    /// </summary>
    public decimal Amount { get; set; }

    public LegRole Role { get; set; }

    /// <summary>
    /// If defined, rate per unit of asset involved in the operation
    /// </summary>
    public decimal? RatePerUnit { get; set; }

    /// <summary>
    /// If defined, overall value for the operation
    /// </summary>
    public decimal? RateOverall { get; set; }

    public DateTimeOffset Timestamp { get; set; }

    /// <summary>
    /// Hook/Grouping reference identifier for correlation (if defined) - to combine several legs together 
    /// </summary>
    public required Guid GroupId { get; set; }

    /// <summary>
    /// platform or system involved in the operation
    /// </summary>
    public string? Platform { get; set; }

    public string? Note { get; set; }

    public EntityState State { get; set; }

    public string EntityType => "trl"; 
}