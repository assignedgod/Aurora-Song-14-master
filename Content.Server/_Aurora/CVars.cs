using Robust.Shared.Configuration;

namespace Content.Server._Aurora;

[CVarDefs]
public sealed class AuroraCVars
{
    /// <summary>
    /// How often station staff wages are paid.
    /// </summary>
    public static readonly CVarDef<int> StationPayDelay =
        CVarDef.Create(
            "station_pay.delay",
            3600,
            CVar.SERVERONLY,
            "how often station staff wages are paid"
        );
}
