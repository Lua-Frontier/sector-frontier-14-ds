using JetBrains.Annotations;
using Robust.Shared.Random;

namespace Content.Server._Lua.Maps.NameGenerators;

[UsedImplicitly]
public sealed partial class ShuttleNameGenerator : StationNameGenerator
{
    [DataField("shipyardPrefix")] public string SuffixCode = "ERC";

    public override string FormatName(string input)
    {
        var random = IoCManager.Resolve<IRobustRandom>();
        var ShuttleNumber = random.Next(100,1000);
        return string.Format("{0} {1}-{2}", input, SuffixCode, ShuttleNumber);
    }
}
