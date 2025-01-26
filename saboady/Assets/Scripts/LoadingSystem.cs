using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingSystem : SingletonBehaviour<LoadingSystem>
{

    // Align this enum with the indexing of scenes in Build Profiles/Scene List
    public enum SCENE {
        START_SCENE      = 0,
        SPLASH           = 1,
        FIRST_LEVEL      = 2,
        END_SCENE        = 3,
        UNKNOWN     = -1,
    }

    [EditorReadOnly][SerializeField] private SCENE currentScene = SCENE.SPLASH;

    private Action onLoadComplete = null;

    void Update() {
        if (onLoadComplete == null) return;
        onLoadComplete.Invoke();
        onLoadComplete = null;
    }

    // Show a spinny wheel in the corner
    private void ShowLoadingAnimation(bool show) {
        if (show) {

        } else {
            // Hide the spinny wheel
        }
    }

    public void MakeCurrentSceneActive() {
        Scene newScene = SceneManager.GetSceneByBuildIndex((int)currentScene);
        SceneManager.SetActiveScene(newScene);
    }

    public void LoadSceneAndThen(SCENE scene, Action action) {
        AsyncOperation loadOperation = SceneManager.LoadSceneAsync((int)scene);
        ShowLoadingAnimation(true);
        loadOperation.completed += (AsyncOperation op) => {
            ShowLoadingAnimation(false);
            currentScene = scene;
            onLoadComplete = action;
        };
        
    }
}
