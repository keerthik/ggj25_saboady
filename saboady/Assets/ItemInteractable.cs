using UnityEngine;

public class ItemInteractable : Interactable
{
    public override (string, string) GetDialog() {
        if (GameDirector.Shared.good == 1) {
            return (Constructors.Shared.water_questdone_1, "");
        } else {
            // isTrigger = false;
            // Make sure doesn't disable too soon
        }
        // We should not have gotten here!
        return (null, null);
    }
}
