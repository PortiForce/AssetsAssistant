using PortiForce.AssetsAssistant.Core.Assets.Domain.Portfolio.Enums;
using PortiForce.AssetsAssistant.Core.Assets.Domain.Portfolio.Models.AssetOperations;
using PortiForce.AssetsAssistant.Core.Assets.Domain.Portfolio.Models.AssetOperations.Guards;
using PortiForce.AssetsAssistant.Core.Assets.Enums;

namespace PortiForce.AssetsAssistant.Core.Assets.Tests.Domain.Portfolio.Models.AssetOperations;

public class TransferLegTests
{
    [Theory]
    [InlineData(LegRole.Fee, -0.0001)]
    [InlineData(LegRole.Tax, -5)]
    public void Fee_and_tax_must_be_non_positive(LegRole role, decimal amount)
    {
        var leg = new TransferLeg
        {
            Id = Guid.NewGuid(),
            AssetTransferId = Guid.NewGuid(),
            AssetId = 1,
            Role = role,
            Amount = amount,
            Timestamp = DateTimeOffset.UtcNow,
            GroupId = Guid.NewGuid(),
            State = EntityState.Active
        };

        TransferLegGuard.Validate(leg); 
    }
}
