namespace PortiForce.AssetsAssistant.Core.Assets.Domain.Portfolio.Enums;

/// <summary>
/// Generic description of the overall operation
/// </summary>
public enum TransferType
{
    // Market actions (priced by venue)
    /// <summary>
    /// Buy/Sell on an exchange (spot/market/limit). Legs: asset in/out + fees.
    /// </summary>
    Trade = 1,

    // Non-market asset-to-asset conversions (fixed/implicit ratio; broker FX; chain swaps/migrations)
    /// <summary>
    ///  Asset A -> Asset B not via order book (incl. broker auto-FX, token migrations)
    /// </summary>
    Conversion = 10,

    // Movement of assets between boundaries
    /// <summary>
    /// External -> Your account (fiat/crypto/securities incoming)
    /// </summary>
    Deposit = 20,

    /// <summary>
    /// Your account -> External (incl. on-chain withdrawals)
    /// </summary>
    Withdrawal = 21,

    /// <summary>
    /// Your account A -> Your account B (same owner; may include network fee legs)
    /// </summary>
    InternalTransfer = 22,

    // Positive inflows not caused by selling something
    /// <summary>
    /// Airdrop, staking reward, interest, referral bonus, dividend, gift, etc.
    /// </summary>
    Income = 30,

    // Outflows not tied to a sale
    /// <summary>
    /// Standalone fee (custody/holding/service/network) not attached to another transfer
    /// </summary>
    FeeOnly = 40,

    /// <summary>
    /// Withholding/capital-gains/VAT stamp, etc., when recorded as a separate payment
    /// </summary>
    Tax = 41,

    /// <summary>
    /// Negative fee / maker rebate / broker cashback 
    /// </summary>
    RebateOrCashback = 42,

    // Book maintenance
    /// <summary>
    /// Manual correction, rounding fix, broker reconciliation, symbol migration tails 
    /// </summary>
    Adjustment = 50,

    /// <summary>
    /// Irretrievable send/burn (protocol burn, dust burn, fee-on-transfer burn)
    /// </summary>
    Burn = 51,  

    /// <summary>
    /// Catch-all for future extensions (reserved)
    /// </summary>
    Other = 99
}