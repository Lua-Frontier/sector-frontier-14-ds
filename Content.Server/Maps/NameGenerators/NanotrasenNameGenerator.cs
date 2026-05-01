using JetBrains.Annotations;
using Robust.Shared.Random;

namespace Content.Server.Maps.NameGenerators;

[UsedImplicitly]
public sealed partial class NanotrasenNameGenerator : StationNameGenerator
{
    /// <summary>
    ///     Where the map comes from. Should be a two or three letter code, for example "VG" for Packedstation.
    /// </summary>
    [DataField("prefixCreator")] public string PrefixCreator = default!;
    [DataField("shipyardPrefix")] public string SuffixCode = "ERC";

    //private string Prefix => "NT";
    private string Prefix => "";
    private string[] SuffixCodes => new []{ "LV", "NX", "EV", "QT", "PR" };

    public override string FormatName(string input)
    {
        var random = IoCManager.Resolve<IRobustRandom>();
        var ShuttleNumber = random.Next(100,1000); // Lua: Выбор случайного числа от 100 до 999 включительно в качестве номера
        //return string.Format(input, $"{Prefix}{PrefixCreator}", $"{random.Pick(SuffixCodes)}-{random.Next(0, 1000):D3}");
        return string.Format("{0} {1}-{2}", input, SuffixCode, ShuttleNumber); // Lua: сборка названия шаттла из: названия, префикса верфи, сгенерированного номера
    }
}
