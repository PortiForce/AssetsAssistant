using PortiForce.AssetsAssistant.Core.Assets.Domain.Portfolio.Enums;

namespace PortiForce.AssetsAssistant.Core.Assets.Domain.Portfolio.Models.AssetOperations.Guards;

public static class TransferLegGuard
{
    public static void Validate(TransferLeg transferLeg)
    {
        if (transferLeg.Role is LegRole.Fee or LegRole.Tax && transferLeg.Amount > 0)
        {
            throw new InvalidOperationException("Fee/Tax legs must be non-positive.");
        }

        if (transferLeg.Role is LegRole.Proceeds && transferLeg.Amount <= 0)
        {
            throw new InvalidOperationException("Proceeds must be positive.");
        }

        if (transferLeg.Role is LegRole.Consideration && transferLeg.Amount >= 0)
        {
            throw new InvalidOperationException("Consideration must be negative.");
        }
    }
}
