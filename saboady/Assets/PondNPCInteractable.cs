using UnityEngine;

public class PondNPCInteractable : Interactable
{
    public override (string, string) GetDialog() {
        if (TrackProgress < 1) {
            return (Constructors.Shared.pond["contact_0"], "unsure");
        } else if (TrackProgress == 1) {
            return (Constructors.Shared.pond["midquest"], "illlook");
        }
        // We have nothing to do with this guy
        return (Basics.Shared.nothing, "moveon");
    }
    public override void DismissAction() {
        if (TrackProgress < 2) {
            GameDirector.Shared.UpGoodProgress(1);
        } else {
            GameDirector.Shared.UpGoodProgress(2);
        }
    }
}
