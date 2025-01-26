using UnityEngine;

public class OldNPCInteractable : Interactable
{
    public override (string, string) GetDialog() {
        if (GameDirector.Shared.good == 2) {
            return (Constructors.Shared.npc0_contact_0, "ok");
        } else if (GameDirector.Shared.good == 1) {
            return (Constructors.Shared.npc0_midquest_1, "ok");
        } else {
            // isTrigger = false;
        }
        // We should not have gotten here!
        return (null, null);
    }
    public virtual void DismissAction(PlayerProgression progress) {
        
    }
}
