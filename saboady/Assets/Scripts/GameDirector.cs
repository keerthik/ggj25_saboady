using UnityEngine;

public class GameDirector : SingletonBehaviour<GameDirector>
{
    [SerializeField] private LoadingSystem.SCENE firstScene;

    public bool niceEnding = true;

    private PlayerProgression progress;

    public static PlayerProgression Progress {
        get => Shared.progress;
    }

    protected override void Awake() {
        if (Shared != null) {
            Destroy(gameObject);
            return;
        }
        base.Awake();
        progress = new();
        DontDestroyOnLoad(gameObject);
    }

    void Start() {
        // Let's load the main menu and show it when it's ready.
        LoadingSystem.Shared.LoadSceneAndThen(firstScene, () => {
            // Do a camera fade or something if you want
            LoadingSystem.Shared.MakeCurrentSceneActive();
        });
    }
}
