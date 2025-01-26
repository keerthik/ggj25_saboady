using UnityEngine;

public class PondNPCInteractable : Interactable
{
    public override (string, string) GetDialog() {
        if (GameDirector.Shared.good < 1) {
            return (Constructors.Shared.pond["contact_0"], "unsure");
        } else if (GameDirector.Shared.good == 1) {
            return (Constructors.Shared.pond["midquest"], "illlook");
        } else {
            // isTrigger = false;
        }
        // We should not have gotten here!
        return (Basics.Shared.nothing, "moveon");
    }
    public override void DismissAction() {
        if (GameDirector.Shared.good < 2) {
            GameDirector.Shared.UpGoodProgress(1);
        } else {
            GameDirector.Shared.UpGoodProgress(2);
        }
    }

}
