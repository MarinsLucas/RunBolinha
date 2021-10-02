/*
Utilizado para criar transições entre as músicas do joog
*/
using UnityEngine;
using UnityEngine.Audio;
using System.Collections;
using System.Collections.Generic; 

public class Fade : MonoBehaviour
{
    public AudioClip defaultAmbience;
    public static AudioMixerGroup output; 
    private AudioSource track1 , track2;
    private bool isPlayingTrack1;
    public static Fade instance;

    private void Awake()
    {
        if (instance == null)
            instance = this;

        Start();
    }
    private void Start()
    {
        track1 = gameObject.AddComponent<AudioSource>();
        track2 = gameObject.AddComponent<AudioSource>();
        isPlayingTrack1 = true;
        DontDestroyOnLoad(gameObject);
        ReturnToDefault();
        
    }

    public void SwapTrack(AudioClip newClip)
    {
        StopAllCoroutines();
        StartCoroutine(FadeTrack(newClip));
        isPlayingTrack1 = !isPlayingTrack1; 
    }

    public void ReturnToDefault()
    {
        SwapTrack(defaultAmbience);
    }
    private IEnumerator FadeTrack(AudioClip newClip)
    {
        float timeToFade = 0.25f;
        float timeElapsed = 0; 
        if(isPlayingTrack1)
        {
            track2.clip = newClip;
            track2.Play();
            while(timeElapsed < timeToFade)
            {
                track2.volume = Mathf.Lerp(0, 1, timeElapsed / timeToFade);
                track1.volume = Mathf.Lerp(1, 0, timeElapsed / timeToFade);
                timeElapsed += Time.deltaTime;
                yield return null; 
            }
            track1.Stop();
            track2.loop = true;
        }
        else
        {
            track1.clip = newClip;
            track1.Play();
            while (timeElapsed < timeToFade)
            {
                track1.volume = Mathf.Lerp(0, 1, timeElapsed / timeToFade);
                track2.volume = Mathf.Lerp(1, 0, timeElapsed / timeToFade);
                timeElapsed += Time.deltaTime;
                yield return null;
            }
            track2.Stop();
            track1.loop = true;
        }
    }
}
