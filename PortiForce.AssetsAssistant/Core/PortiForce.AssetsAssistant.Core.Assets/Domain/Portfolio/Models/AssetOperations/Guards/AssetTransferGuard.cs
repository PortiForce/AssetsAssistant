using PortiForce.AssetsAssistant.Core.Assets.Domain.Portfolio.Enums;

namespace PortiForce.AssetsAssistant.Core.Assets.Domain.Portfolio.Models.AssetOperations.Guards;

public static class AssetTransferGuard
{
    public static void Validate(AssetTransfer assetTransfer) 
    {
        if (assetTransfer.TransferState == TransferState.Completed && assetTransfer.CompleteTimeStamp is null)
        {
            throw new InvalidOperationException("CompleteTimeStamp must be set for Completed transfers.");
        }


        if (assetTransfer.CompleteTimeStamp is not null && assetTransfer.CompleteTimeStamp < assetTransfer.StartTimeStamp)
        {
            throw new InvalidOperationException("CompleteTimeStamp must be >= StartTimeStamp.");
        }           

        ValidateRequiredLegs(assetTransfer);
        ValidateInternalMoves(assetTransfer);
    }

    static void ValidateRequiredLegs(AssetTransfer assetTransfer)
    {
		List<TransferLeg> legs = assetTransfer.TransferLegs ?? [];
        if (assetTransfer.TransferType == TransferType.Trade || assetTransfer.TransferType == TransferType.Conversion)
        {
            if (!legs.Any(x => x.Role == LegRole.Proceeds) ||
                !legs.Any(x => x.Role == LegRole.Consideration))
            {
                throw new InvalidOperationException("Trade/Conversion must have Proceeds and Consideration.");
            }
        }
        if (assetTransfer.TransferType == TransferType.Income &&
           !legs.Any(x => x.Role == LegRole.Proceeds))
        {
            throw new InvalidOperationException("Income requires at least one Proceeds leg.");
        }
    }

    static void ValidateInternalMoves(AssetTransfer assetTransfer)
    {
		IEnumerable<IGrouping<int, TransferLeg>> groups = (assetTransfer.TransferLegs ?? [])
            .Where(x => x.Role == LegRole.InternalMove)
            .GroupBy(x => x.AssetId);

        foreach (var group in groups)
        {
            var sum = group.Sum(x => x.Amount);
            if (sum != 0)
            {
                throw new InvalidOperationException("InternalMove legs must sum to 0 per asset.");
            }
        }
    }
}
