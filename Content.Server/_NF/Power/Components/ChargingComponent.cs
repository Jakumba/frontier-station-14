using Content.Server.Power.Components;

namespace Content.Server._NF.Power.Components;

[RegisterComponent]
public sealed partial class ChargingComponent : Component // Frontier: Upstream - #28984
{
    ///<summary>
    ///References the entity of the charger that is currently powering this battery
    ///</summary>
    public EntityUid ChargerUid;

    ///<summary>
    ///References the component of the charger that is currently powering this battery
    ///</summary>
    public ChargerComponent ChargerComponent;
}
