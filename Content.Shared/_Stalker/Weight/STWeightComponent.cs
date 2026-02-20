namespace Content.Shared._Stalker.Weight;

/// <summary>
/// Stub component for entity weight tracking.
/// Used by anomaly weight-based triggers to assign trigger groups.
/// </summary>
[RegisterComponent]
public sealed partial class STWeightComponent : Component
{
    [DataField, ViewVariables(VVAccess.ReadWrite)]
    public float Total;
}
