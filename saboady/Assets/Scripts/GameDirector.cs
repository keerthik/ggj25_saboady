using UnityEngine;

public class GameDirector : SingletonBehaviour<GameDirector>
{
    [SerializeField] private LoadingSystem.SCENE firstScene;

    protected override void Awake() {
        base.Awake();
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
