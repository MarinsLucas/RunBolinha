/*
Eu não utilizei esse script no final das contas! Ele possuí limitações que eu não pude corrigir e acabou que eu preferi trabalhar cada efeito sonoro separadamente
Esse script foi feito de acordo com tutorial sobre áudio do Brackeys
*/
using UnityEngine.Audio;
using UnityEngine;
using System; 


public class AudioManager : MonoBehaviour
{
    //public AudioMixerGroup Output;
    public Sounds[] sound;
    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    void Awake()
    {
        foreach(Sounds s in sound)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop; 
        }
    }
    public void Play(string name)
    {
        Sounds s = Array.Find(sound, Sounds => Sounds.name == name);
        if (name == "ImpactoBola")
        {
            //s.volume = Movimento.volquicada;
            s.source.volume = Movimento.volquicada;
        }
        s.source.volume = s.volume;
        s.source.pitch = s.pitch;
        s.source.Play();
        if (s == null)
        {
            Debug.Log("Sound: " + name + " not found!");
            return;
        }
   
    }

    public void Stop(string name)
    {
        Sounds s = Array.Find(sound, Sounds => Sounds.name == name);
        if (s == null)
        {
            Debug.LogWarning("Sound: " + name + " not found!");
            return;
        }

        s.source.volume = s.volume;
        s.source.pitch = s.pitch;
        s.source.Stop();
    }
}

