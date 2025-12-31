using PortiForce.AssetsAssistant.Core.Assets.Enums;
using PortiForce.AssetsAssistant.Core.Assets.Interfaces;

namespace PortiForce.AssetsAssistant.Core.Assets.Domain.Actor.Models;

public sealed class Account : ICommonEntity<Guid>
{
    public Guid Id { get; set; }

    public Guid OwnerId { get; set; }

    public Owner? Owner { get; set; }

    public required string Platform { get; set; } = default!;

    public string? AccountName { get; set; }  

    public EntityState State { get; set; }

    public Dictionary<string, string>? Metadata { get; set; }

    public string EntityType => "acc";
}
