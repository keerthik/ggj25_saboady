using System;
using UnityEngine;

public class SplashScreen : MonoBehaviour
{

    [SerializeField] private LoadingSystem.SCENE sceneToLoad;
    AudioManager audioManager;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // get the audio manager
        audioManager = GameObject.Find("AudioManager").GetComponent<AudioManager>();
        // start splash screen music
        audioManager.AssignBackgroundMusic(LoadingSystem.SCENE.SPLASH);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonUp(0))
        {
            Debug.Log("Loading Scene: " + sceneToLoad);
            LoadScene();
        }
    }

    public void LoadScene()
    {
        LoadingSystem.Shared.LoadSceneAndThen(sceneToLoad, () => {
            // Do a camera fade or something if you want
            LoadingSystem.Shared.MakeCurrentSceneActive();

            //Trigger Transition Sound from Train in other levels
            //audioManager.PlaySFX(AudioManager.SFX_TYPE.TRANSITION);

            // Fade out music
            // audioManager.FadeOutMusic();
            // Assign new background music 
            audioManager.AssignBackgroundMusic(sceneToLoad);

        });
        
    }
}
