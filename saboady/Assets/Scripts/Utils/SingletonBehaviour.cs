using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 Subclass this for globally active and accessed singleton behaviours.
 eg: TourDownloadManager: SingletonBehaviour<TourDownloadManager>
 NOTE: Use <WorkoutAssistant> for singletons meant to be used exclusively within a workout
*/
public class SingletonBehaviour : MonoBehaviour
{
}

public abstract class SingletonBehaviour<SingletonAssistant> : SingletonBehaviour
    where SingletonAssistant : SingletonBehaviour<SingletonAssistant> {
    private static SingletonAssistant instance = null;
    public static SingletonAssistant Shared {
        private set { instance = value; }
        get { return instance; }
    }

    // Because we want assignments to be done first, call this at the end of overriding 'new' Awake
    protected virtual void Awake() {
        instance = (SingletonAssistant)this;
    }
}
