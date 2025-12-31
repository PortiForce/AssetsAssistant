using PortiForce.AssetsAssistant.Core.Assets.Domain.Actor.Models;
using PortiForce.AssetsAssistant.Core.Assets.Domain.Portfolio.Enums;
using PortiForce.AssetsAssistant.Core.Assets.Enums;
using PortiForce.AssetsAssistant.Core.Assets.Interfaces;

namespace PortiForce.AssetsAssistant.Core.Assets.Domain.Portfolio.Models.AssetOperations;

/// <summary>
/// Represents a trasaction of an asset from one entity to another.
/// </summary>
public sealed class AssetTransfer : ICommonEntity<Guid>, ICommonMonitoredEntity
{
    public Guid Id { get; set; }
    public DateTimeOffset StartTimeStamp { get; set; }

    public DateTimeOffset? CompleteTimeStamp { get; set; }

    public TransferType TransferType { get; set; }

    public MarketType MarketType { get; set; }

    public OperationType OperationType { get; set; }

    public TransferState TransferState { get; set; }

    /// <summary>
    /// Price basis or quote used for the transfer (if applicable)
    /// </summary>
    public QuoteWithTimestamp? QuoteWithTimeStamp { get; set; }

    /// <summary>
    /// Computed or persisted total valuation of the transfer (if applicable)
    /// </summary>
    public EstimatedValue? TotalValuation { get; set; }

    public List<TransferLeg>? TransferLegs { get; set; } = [];

    /// <summary>
    /// Reference identifier for external system correlation (if defined)
    /// </summary>
    public string? ExternalReferenceId { get; set; }

    public Guid AccountId { get; set; }

    /// <summary>
    /// Reference to the Account involved in the transfer.
    /// </summary>
    public Account? Account { get; set; }

    public string? Note { get; set; }

	public EntityState State { get; set; }

    public byte[]? RowVersion { get; set; }

    public string EntityType => "ast";
}
