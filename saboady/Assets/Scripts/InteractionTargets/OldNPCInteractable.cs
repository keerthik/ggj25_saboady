using UnityEngine;

public class OldNPCInteractable : Interactable
{
    public override (string, string) GetDialog() {
        HudEntities.Shared.SetPortrait(portrait);
        if (TrackProgress == 2) {
            return (Constructors.Shared.old["contact_2"], "ok");
        } else if (TrackProgress == 3) {
            return (Constructors.Shared.old["midquest_3"], "ok");
        } else if (TrackProgress == 4) {
            return (Constructors.Shared.old["questdone_4"], "ok");
        } else {
            // isTrigger = false;
        }
        return base.GetDialog();
    }
    public override void DismissAction() {
        if (TrackProgress < 2) {
            // Only the first quest in a region updates this!
            // GameDirector.Shared.UpGoodProgress(2);
        } else if (TrackProgress == 2) {
            GameDirector.Shared.UpGoodProgress(3);
        } else if (TrackProgress == 4) {
            GameDirector.Shared.UpGoodProgress(5);
        } else {
            // midquest
            GameDirector.Shared.UpGoodProgress(3);
        }
    }
}
