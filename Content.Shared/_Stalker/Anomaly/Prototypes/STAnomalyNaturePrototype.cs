using Robust.Shared.Prototypes;

namespace Content.Shared._Stalker.Anomaly.Prototypes;

[Prototype("stAnomalyNature")]
public sealed partial class STAnomalyNaturePrototype : IPrototype
{
    [IdDataField]
    public string ID { get; private set; } = string.Empty;
}
