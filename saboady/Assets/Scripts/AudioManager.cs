using System;
using UnityEditor.Rendering.Universal;
using System.Collections;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioClip menuBackgroundMusic;
    public AudioClip museumBackgroundMusic;
    public AudioClip parkBackgroundMusic;
    public AudioClip cultistBackgroundMusic;

    public AudioClip goodEndingMusic;
    public AudioClip badEndingMusic;


    public AudioSource musicSource;
    public AudioSource footstepsSource;
    public AudioSource transitionSource;

    public AudioSource dialogueSource;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //FOR TESTING ONLY, REMOVE IN PRODUCTION
        // musicSource.clip = cultistBackgroundMusic;
        // musicSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AssignBackgroundMusic(LoadingSystem.SCENE scene)
    {
        if(scene == LoadingSystem.SCENE.SPLASH)
        {
            musicSource.clip = menuBackgroundMusic;
        }
        else if(scene == LoadingSystem.SCENE.LEVEL_PARK)
        {
            musicSource.clip = parkBackgroundMusic;
        }
        else if(scene == LoadingSystem.SCENE.LEVEL_MUSEUM)
        {
            musicSource.clip = museumBackgroundMusic;
        }
        else if(scene == LoadingSystem.SCENE.LEVEL_CATHEDRAL)
        {
            musicSource.clip = cultistBackgroundMusic;
        }
        else if(scene == LoadingSystem.SCENE.PLAYER_TEST)
        {
            musicSource.clip = parkBackgroundMusic;
        } 
        else if(scene == LoadingSystem.SCENE.END_SCENE)
        {
            if(GameDirector.Shared.niceEnding)
            {
                musicSource.clip = goodEndingMusic;
            } else 
            {
                musicSource.clip = badEndingMusic;
            }
        }

        if(musicSource.clip != null) 
        {
            musicSource.Play();
        }
    }

    public enum SFX_TYPE {
        FOOTSTEP,
        TRANSITION,
        DIALOGUE,
    }
    public void PlaySFX(SFX_TYPE sfxName)
    {
        if(sfxName == SFX_TYPE.FOOTSTEP && !footstepsSource.isPlaying)
        {
            footstepsSource.Play();
        } 
        else if (sfxName == SFX_TYPE.TRANSITION && !transitionSource.isPlaying)
        {
            transitionSource.Play();
        } else if (sfxName == SFX_TYPE.DIALOGUE)
        {
            dialogueSource.Play();
        }
    }

    const float FADE_TIME_SECONDS = 1.5f;
    public void FadeOutMusic()
    {
        StartCoroutine(FadeOut(musicSource, 0));
    }

    IEnumerator FadeOut(AudioSource audioSource, float delay) 
    {
        yield return new WaitForSeconds(delay);
        float timeElapsed = 0;
        while (audioSource.volume > 0) 
        {
            audioSource.volume = Mathf.Lerp(1, 0, timeElapsed / FADE_TIME_SECONDS);
            timeElapsed += Time.deltaTime;
            yield return null;
        }

    }

    IEnumerator FadeIn(AudioSource audioSource) 
    {
        float timeElapsed = 0;

        while (audioSource.volume < 1) 
        {
            audioSource.volume = Mathf.Lerp(0, 1, timeElapsed / FADE_TIME_SECONDS);
            timeElapsed += Time.deltaTime;
            yield return null;
        }


    }       

}
