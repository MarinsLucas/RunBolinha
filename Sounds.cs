/*
Cria um vetor de sonds
*/
using UnityEngine.Audio; 
using UnityEngine;


[System.Serializable]
public class Sounds 
{


    public string name; 
    // Start is called before the first frame update
    public AudioClip clip;

    [Range(0f, 1f)]
    public float volume;
    [Range(1f, 3f)]
    public float pitch;

    public bool loop;
    public AudioMixerGroup output; 

    [HideInInspector]
    public AudioSource source; 
}
