using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{

    public AudioSource musica;
    public AudioSource fimdejogo;
    public AudioSource tempoLento;

    public bool musicaTocando = false;

   public void Start()
    {
        DontDestroyOnLoad(gameObject); 
    }

   // essa fun��o � chamada pelo GamerManager
   public void IniciaMusica()
    {
        float timeToFade = 3f;
        float timeElapsed = 0f;
        musica.Play();
        while (timeElapsed < timeToFade)
        {
            musica.volume = Mathf.Lerp(0, 1, timeElapsed / timeToFade);
            timeElapsed += Time.deltaTime;
        }
    }

    public void SlowMoSounds()
    {
        float timeToFade = 0.25f;
        float timeElapsed = 0f;
        if (SlowMo.slowed)
        {
            musica.Play();
            while (timeElapsed < timeToFade)
            {
                musica.volume = Mathf.Lerp(0, 1, timeElapsed / timeToFade);
                tempoLento.volume = Mathf.Lerp(1, 0, timeElapsed / timeToFade);
                timeElapsed += Time.deltaTime;
            }
            tempoLento.Stop();
        }
        else
        {
            tempoLento.Play();
            while (timeElapsed < timeToFade)
            {
                tempoLento.volume = Mathf.Lerp(0, 1, timeElapsed / timeToFade);
                musica.volume = Mathf.Lerp(1, 0, timeElapsed / timeToFade);
                timeElapsed += Time.deltaTime;
            }
            musica.Stop();
        }
    }
        

    public void MusicaFinal()
    {
        float timeToFade = 0.25f;
        float timeElapsed = 0f;
        if (SlowMo.slowed)
        {
            fimdejogo.Play();
            while (timeElapsed < timeToFade)
            {
                fimdejogo.volume = Mathf.Lerp(0, 1, timeElapsed / timeToFade);
                tempoLento.volume = Mathf.Lerp(1, 0, timeElapsed / timeToFade);
                timeElapsed += Time.deltaTime;
            }
            tempoLento.Stop();
        }
        else
        {
            fimdejogo.Play();
            while (timeElapsed < timeToFade)
            {
                fimdejogo.volume = Mathf.Lerp(0, 1, timeElapsed / timeToFade);
                musica.volume = Mathf.Lerp(1, 0, timeElapsed / timeToFade);
                timeElapsed += Time.deltaTime;
            }
            musica.Stop();
        }
    }
}
