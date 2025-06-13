using Content.Shared.Roles;
using Robust.Shared.Prototypes;

namespace Content.Server._Aurora.StationPay;

[Prototype]
public sealed class StationPayPrototype : IPrototype
{
    /// <inheritdoc/>
    [IdDataField]
    public string ID { get; private set; } = default!;

    /// <summary>
    /// Spesos paid per hour to players with this job.
    /// </summary>
    [DataField("payPerHour", required: true, serverOnly: true)]
    public int PayPerHour;

    /// <summary>
    /// Job player must have to receive automated payments.
    /// </summary>
    [DataField("job", required: true, serverOnly: true)]
    public ProtoId<JobPrototype> JobProto;
}

