using UnityEngine;

public class PondNPCInteractable : Interactable
{
    public override (string, string) GetDialog() {
        if (TrackProgress < 1) {
            return (Constructors.Shared.pond["contact_0"], "unsure");
        } else if (TrackProgress == 1) {
            return (Constructors.Shared.pond["midquest_1"], "illlook");
        }
        // We have nothing to do with this guy
        return base.GetDialog();
    }
    public override void DismissAction() {
        if (TrackProgress < 2) {
            GameDirector.Shared.UpGoodProgress(1);
        } else {
            // midquest
            GameDirector.Shared.UpGoodProgress(2);
        }
    }
}
