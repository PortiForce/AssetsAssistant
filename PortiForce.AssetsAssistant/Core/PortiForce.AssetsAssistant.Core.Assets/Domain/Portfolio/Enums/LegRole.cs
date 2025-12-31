namespace PortiForce.AssetsAssistant.Core.Assets.Domain.Portfolio.Enums;

public enum LegRole
{
    NotDefined = 0,

    /// <summary>
    /// The thing you received (bought asset, income)
    /// </summary>
    Proceeds = 1,

    /// <summary>
    /// the thing you paid (cash/asset given up)
    /// </summary>
    Consideration = 2,

    /// <summary>
    /// trading/commission/network/holding fee leg
    /// </summary>
    Fee = 3,

    /// <summary>
    /// tax leg inside a transfer
    /// </summary>
    Tax = 4,

    /// <summary>
    /// mirror legs for in-place moves (same asset; A→B)
    /// </summary>
    InternalMove = 5 
}
