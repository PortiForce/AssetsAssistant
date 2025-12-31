using PortiForce.AssetsAssistant.Core.Assets.Domain.Portfolio.Enums;
using PortiForce.AssetsAssistant.Core.Assets.Domain.Portfolio.Models.AssetOperations;
using PortiForce.AssetsAssistant.Core.Assets.Domain.Portfolio.Models.AssetOperations.Guards;
using FluentAssertions;

namespace PortiForce.AssetsAssistant.Core.Assets.Tests.Domain.Portfolio.Models.AssetOperations;

public class AssetTransferTests
{
    [Fact]
    public void Completed_transfer_requires_complete_timestamp()
    {
        var assetTransfer = new AssetTransfer
        {
            Id = Guid.NewGuid(),
            AccountId = Guid.NewGuid(),
            TransferType = TransferType.Trade,
            MarketType = MarketType.Spot,
            OperationType = OperationType.Market,
            TransferState = TransferState.Completed,
            StartTimeStamp = DateTimeOffset.UtcNow.AddMinutes(-1),
            CompleteTimeStamp = null
        };

        Action action = () => AssetTransferGuard.Validate(assetTransfer);

        action.Should().Throw<InvalidOperationException>()
           .WithMessage("*CompleteTimestamp*");
    }
}
