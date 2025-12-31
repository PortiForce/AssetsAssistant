namespace PortiForce.AssetsAssistant.Core.Assets.Enums;

public enum EntityState
{
    Draft = 0,

    Active = 1,

    Readonly = 2,

    Inactive = 3,

    /// <summary>
    /// Archived entity that is kept for historical/audit purposes.
    /// </summary>
    Archived = 4,

    Deleted = 5
}
