namespace PortiForce.AssetsAssistant.Core.Assets.Interfaces;

public interface ICommonMonitoredEntity
{
    /// <summary>
    /// field to handle update/concurrency issues
    /// </summary>
    byte[]? RowVersion { get; set; }
}
