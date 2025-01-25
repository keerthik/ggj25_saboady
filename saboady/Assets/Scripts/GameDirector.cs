using UnityEngine;

public class GameDirector : MonoBehaviour
{
    void Awake() {
        DontDestroyOnLoad(gameObject);
    }

    void Start() {
        // Let's load the main menu and show it when it's ready.
        LoadingSystem.Shared.LoadSceneAndThen(LoadingSystem.SCENE.MAINMENU, () => {
            // Do a camera fade or something if you want
            LoadingSystem.Shared.MakeCurrentSceneActive();
        });
    }
}
