using UnityEngine;

public class GameDirector : SingletonBehaviour<GameDirector>
{
    [SerializeField] private LoadingSystem.SCENE firstScene;

    public bool niceEnding = true;

    // Lazy public data
    [EditorReadOnly] public int good;
    [EditorReadOnly] public int bad;

    public void UpGoodProgress(int latest) {
        good = Mathf.Max(good, latest);
    }

    public void UpBadProgress(int latest) {
        bad = Mathf.Max(bad, latest);
    }

    protected override void Awake() {
        if (Shared != null) {
            Destroy(gameObject);
            return;
        }
        base.Awake();
        good = 0;
        bad = 0;
        DontDestroyOnLoad(gameObject);
    }

    void Start() {
        Debug.Log("Director is live");
    }
}
