using System.Collections;
using UnityEngine;

public class ItemInteractable : Interactable
{
    [SerializeField] private int targetProgress;
    [SerializeField] private string itemKey;
    public override (string, string) GetDialog() {
        if (TrackProgress == targetProgress - 1) {
            return (Items.Shared.all[itemKey], "moveon");
        } else {
            // isTrigger = false;
            // Make sure doesn't disable too soon
        }
        // We should not have gotten here!
        return (Basics.Shared.stuff, "moveon");
    }

    // Items are non-interactable at the start
    void Start() {
        thisCollider.isTrigger = false;
    }

    void Update() {
        if (!thisCollider.isTrigger && TrackProgress == targetProgress - 1) {
            thisCollider.isTrigger = true;
        }
    }

// All items only increase progress along their track by 1, then disappear
    public override void DismissAction() {
        if (goodTrack) {
            GameDirector.Shared.UpGoodProgress(targetProgress);
        } else {
            GameDirector.Shared.UpBadProgress(targetProgress);
        }
        thisCollider.isTrigger = false;
        StartCoroutine(ItemPicked());
    }

    private IEnumerator ItemPicked() {
        float t = 0;
        float speed = 30f;
        float spin = 360f;
        while (t < 3f) {
            transform.position = transform.position + speed * Vector3.up * Time.deltaTime;
            transform.Rotate(Vector3.up, spin * Time.deltaTime);
            t += Time.deltaTime;
            yield return null;
        }
        yield return null;
        gameObject.SetActive(false);
    }
}
