using UnityEngine;

public class ItemInteractable : Interactable
{
    [SerializeField] private int targetProgress;
    [SerializeField] private string itemKey;

    public override (string, string) GetDialog() {
        int trackProgress = goodTrack? GameDirector.Shared.good : GameDirector.Shared.bad;
        if (GameDirector.Shared.good == 1) {
            return (Items.Shared.all[itemKey], "");
        } else {
            // isTrigger = false;
            // Make sure doesn't disable too soon
        }
        // We should not have gotten here!
        return (null, null);
    }

    // Items are non-interactable at the start
    protected override void Awake() {
        GetComponent<Collider>().isTrigger = false;
    }

    void Update() {

    }
    public override void DismissAction() {
        if (goodTrack) {
            GameDirector.Shared.UpGoodProgress(targetProgress);
        } else {
            GameDirector.Shared.UpBadProgress(targetProgress);
        }
        gameObject.SetActive(false);
    }
}
