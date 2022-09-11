using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public Sound[] sounds;
    public static AudioManager instance;

    void Start()
    {
        if (instance) { Destroy(this.gameObject); }
        else { instance = this; }
        foreach(Sound s in sounds)
        {
            AudioSource source = gameObject.AddComponent<AudioSource>();
            s.source = source;
            source.clip = s.clip;
            source.volume = s.volume;
            source.loop = s.loop;
            source.pitch = s.pitch;
        }
    }

    public void Play(string name)
    {
        foreach(Sound s in sounds)
        {
            if(s.name == name)
            {
                Debug.Log(name);
                s.source.Play();
                break;
            }
        }
    }
}
