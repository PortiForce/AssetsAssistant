namespace PortiForce.AssetsAssistant.Core.Assets.Domain.Portfolio.Enums;

public enum AssetType
{
    Other = 0,

    /// <summary>
    /// Fiat currencies
    /// </summary>
    Cash = 1,

    /// <summary>
    /// Common/Preferred shares
    /// </summary>
    Stock = 2,

    /// <summary>
    /// ETFs, Mutual Funds, and Index Funds
    /// </summary>
    Fund = 3,

    ///<summary>
    ///Gold, Silver, Oil
    ///</summary>
    Commodity = 4,      

    /// <summary>
    /// Digital assets (BTC, ETH)
    /// </summary>
    Cryptocurrency = 5,

    /// <summary>
    /// Pegged digital assets (USDC, USDT)
    /// </summary>
    Stablecoin = 6,

    /// <summary>
    /// Bonds, T-Bills, CDs
    /// </summary>
    FixedIncome = 7,

    /// <summary>
    /// Physical property or REITs
    /// </summary>
    RealEstate = 8 
}
