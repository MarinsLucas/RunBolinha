using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowMo : MonoBehaviour
{
    public static bool slowed = false;
    public AudioSource tempoAcelerando;
    public AudioSource tempoDesacelerando; 

    void Start()
    {
        Time.timeScale = 1f;
        EndTrigger.musicaTocando = true;

    }

    void OnTriggerEnter()
    {
        if (slowed)
        {
            Time.timeScale = 1f;

            tempoAcelerando.Play();
            FindObjectOfType<MusicManager>().SlowMoSounds();
            EndTrigger.musicaTocando = true; 
        }
        else
        {
            Time.timeScale = 0.5f;

            tempoDesacelerando.Play();
            FindObjectOfType<MusicManager>().SlowMoSounds();
            EndTrigger.musicaTocando = false;
        }

        slowed = !slowed;
    }
}
