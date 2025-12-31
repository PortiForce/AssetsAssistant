using PortiForce.AssetsAssistant.Core.Assets.Enums;
using PortiForce.AssetsAssistant.Core.Assets.Interfaces;

namespace PortiForce.AssetsAssistant.Core.Assets.Domain.Actor.Models;

/// <summary>
/// Reference to an owner of accounts/assets.
/// </summary>
public sealed class Owner : ICommonEntity<Guid>
{
    public Guid Id { get; set; }

    public required string Alias { get; set; }

    public EntityState State { get; set; }

    public Guid ApplicationUserId { get; set; }

    public string EntityType => "own";
}
