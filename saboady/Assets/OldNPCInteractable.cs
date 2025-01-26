using UnityEngine;

public class OldNPCInteractable : Interactable
{
    public override (string, string) GetDialog(PlayerProgression progress) {
        if (progress.constructorProgress == 2) {
            return (Constructors.Shared.npc0_contact_0, Basics.Shared.ok);
        } else if (progress.constructorProgress == 1) {
            return (Constructors.Shared.npc0_midquest_1, Basics.Shared.illlook);
        } else {
            // isTrigger = false;
        }
        // We should not have gotten here!
        return (null, null);
    }
    public virtual void DismissAction(PlayerProgression progress) {
        
    }
}
