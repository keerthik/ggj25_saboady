using UnityEngine;

public class OldNPCInteractable : Interactable
{
    public override (string, string) GetDialog() {
        if (TrackProgress == 2) {
            return (Constructors.Shared.old["contact_0"], "ok");
        } else if (TrackProgress == 1) {
            return (Constructors.Shared.old["midquest_1"], "ok");
        } else {
            // isTrigger = false;
        }
        // We should not have gotten here!
        return (null, null);
    }
    public override void DismissAction() {
        
    }
}
