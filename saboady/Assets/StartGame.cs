using UnityEngine;

public class StartGame : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        LoadingSystem.Shared.LoadSceneAndThen(LoadingSystem.SCENE.SPLASH, () => {
            LoadingSystem.Shared.MakeCurrentSceneActive();
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
