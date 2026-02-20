namespace Content.Shared._Stalker.Weight;

/// <summary>
/// Raised on an entity to collect weight modifiers from all contributing components.
/// </summary>
public sealed class GetWeightModifiersEvent : EntityEventArgs
{
    /// <summary>
    /// The entity's own weight contribution.
    /// </summary>
    public float Self;

    /// <summary>
    /// Weight from items inside the entity (inventory, storage, etc).
    /// </summary>
    public float Inside;
}
