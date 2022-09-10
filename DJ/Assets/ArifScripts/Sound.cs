using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

[System.Serializable]
public class Sound 
{
    public AudioClip clip;
    public AudioSource source;
    public float volume;
    public bool loop;
    public float pitch;
    public string name;


}
