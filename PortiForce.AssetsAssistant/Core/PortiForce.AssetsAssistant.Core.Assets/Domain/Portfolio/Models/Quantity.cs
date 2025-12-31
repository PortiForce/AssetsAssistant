namespace PortiForce.AssetsAssistant.Core.Assets.Domain.Portfolio.Models;

/// <summary>
/// Domain Unit amount representation
/// </summary>
public readonly record struct Quantity
{
    public static Quantity Zero => new(0m);

    public decimal Value { get; init; }

    public Quantity(decimal value)
    {
        ArgumentOutOfRangeException.ThrowIfNegative(value, nameof(Value));
        Value = value;
    }
}

