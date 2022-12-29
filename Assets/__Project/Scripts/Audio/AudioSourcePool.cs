using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NaughtyAttributes;

public class AudioSourcePool : MonoBehaviour
{
    public struct Request {
        public GameObject requester;
        public float requestTime;
    }
    
    public static AudioSourcePool Instance;
    [NonSerializedAttribute]
    private int defaultSourceCount = 10;
    List<AudioSource> inactiveSources = new List<AudioSource>();
    Queue<AudioSource> activeSources = new Queue<AudioSource>(); 
    

    void Awake() {
        if(Instance!=null) {
            Destroy(gameObject);
            return;
        }

        Instance=this;
        DontDestroyOnLoad(gameObject);
        
        AudioSource source = Instantiate(new GameObject(),Vector3.zero,Quaternion.identity,transform).AddComponent<AudioSource>();

        for(int i = 0; i < defaultSourceCount; i++) inactiveSources.Add(source);
    }
    
    public AudioSource RequestAudioSource(GameObject requester) {
        throw new NotImplementedException();
        if(inactiveSources.Count==0) {
            RequestBumpUser();
            //return;
        }

    }

    private void RequestBumpUser()
    {
        throw new NotImplementedException();
    }

    IEnumerator PlaySoundRoutine(AudioSource source, AudioClip clip) {
        yield break;
    }
}
