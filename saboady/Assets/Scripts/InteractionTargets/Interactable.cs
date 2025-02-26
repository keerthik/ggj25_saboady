using System;
using UnityEngine;

public abstract class Interactable : MonoBehaviour
{
    // Override this for each interactable in the game
    protected Collider thisCollider;
    [SerializeField] protected bool goodTrack;
    [SerializeField] public Texture2D portrait;

    protected int TrackProgress => goodTrack? GameDirector.Shared.good : GameDirector.Shared.bad;
    public virtual (string, string) GetDialog() {
        return (Basics.Shared.nothing, "moveon");
    }

    public abstract void DismissAction();

    protected virtual void Awake() {
        thisCollider = GetComponent<Collider>();
        thisCollider.isTrigger = true;
    }
}
