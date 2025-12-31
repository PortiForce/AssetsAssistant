namespace PortiForce.AssetsAssistant.Core.Assets.Domain.Portfolio.Enums.NotUsedNow;

/// <summary>
/// Enum to describe fee structure type.
/// </summary>
public enum FeeType
{
    NotDefined = 0,

    /// <summary>
    /// Fee is of same type as an asset that has been obtained.
    /// </summary>
    SameAsGainAsset = 1,

    /// <summary>
    /// Fee is of same type as an asset that has been released.
    /// </summary>
    SameAsReleaseAsset = 2,

    /// <summary>
    /// Fee is of different type, not directly related to gain or release asset.
    /// </summary>
    CustomAsset = 3
}
