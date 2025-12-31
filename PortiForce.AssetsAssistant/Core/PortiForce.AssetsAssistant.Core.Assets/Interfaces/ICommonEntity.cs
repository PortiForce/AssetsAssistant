using PortiForce.AssetsAssistant.Core.Assets.Enums;

namespace PortiForce.AssetsAssistant.Core.Assets.Interfaces;

public interface ICommonEntity<T>
{
    T Id { get; set; }

    EntityState State { get; set; }

    /// <summary>
    /// Unique prefix of the entity to be able to find it in logs if necessary.
    /// </summary>
    string EntityType { get; }
}
