using UnityEngine;

public class ItemInteractable : Interactable
{
    public override (string, string) GetDialog(PlayerProgression progress) {
        if (progress.constructorProgress == 1) {
            return (ConstructorStrings.Shared.water_questdone_1, PlayerStrings.Shared.ok);
        } else {
            // isTrigger = false;
            // Make sure doesn't disable too soon
        }
        // We should not have gotten here!
        return (null, null);
    }
}
