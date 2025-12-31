namespace PortiForce.AssetsAssistant.Core.Assets.Domain.Portfolio.Models;

/// <summary>
/// Estimated Domain Value representation
/// </summary>
/// <param name="Currency"></param>
/// <param name="Amount"></param>
public sealed record EstimatedValue(string Currency, decimal Amount);
