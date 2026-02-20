namespace Content.Shared._Stalker.Weight;

/// <summary>
/// Stub system for entity weight tracking.
/// Used by anomaly weight-based triggers and ZoneAnomaly weight modifiers.
/// </summary>
public sealed class STWeightSystem : EntitySystem
{
    public override void Initialize()
    {
        base.Initialize();
    }

    /// <summary>
    /// Attempts to recalculate the total weight for an entity by raising GetWeightModifiersEvent.
    /// </summary>
    public void TryUpdateWeight(EntityUid uid)
    {
        if (!TryComp<STWeightComponent>(uid, out var weight))
            return;

        var ev = new GetWeightModifiersEvent();
        RaiseLocalEvent(uid, ev);

        weight.Total = ev.Self + ev.Inside;
        Dirty(uid, weight);
    }
}
