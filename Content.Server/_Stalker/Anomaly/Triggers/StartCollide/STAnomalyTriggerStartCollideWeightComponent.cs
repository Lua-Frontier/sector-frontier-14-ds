namespace Content.Server._Stalker.Anomaly.Triggers.StartCollide;

[RegisterComponent]
public sealed partial class STAnomalyTriggerStartCollideWeightComponent : Component
{
    [DataField]
    public Dictionary<float, string> WeightTriggerGroup = new()
    {
        { 10, "WeightSmall" },
        { 20, "WeightNormal" },
    };
}
