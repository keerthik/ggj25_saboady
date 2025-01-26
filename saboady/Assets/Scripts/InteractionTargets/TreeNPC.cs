using UnityEngine;

public class TreeNPC : Interactable
{
    public override (string, string) GetDialog() {
        if (TrackProgress == 5) {
            return (Constructors.Shared.tree["contact_5"], "ok");
        } else if (TrackProgress == 3) {
            return (Constructors.Shared.tree["midquest_6"], "ok");
        } else {
            // isTrigger = false;
        }
        return base.GetDialog();
    }
    public override void DismissAction() {
        if (TrackProgress < 5) {
            // Only the first quest in a region updates this!
            // GameDirector.Shared.UpGoodProgress(2);
        } else if (TrackProgress == 5) {
            GameDirector.Shared.UpGoodProgress(6);
        } else {
            // midquest
            GameDirector.Shared.UpGoodProgress(6);
        }
    }
}
